using System;
using System.Drawing;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.MemoryItems;

namespace FPaint
{
    enum PageStatus { NoChanges, ChangesWereMade }

    // form some tools like Fill Tool is needed to have acces to 'pixel representation' of workspace
    class MyPictureBox : PictureBox
    {
        public Bitmap Image { get; set; }
    }

    class Page
    {
        private Status status;
        private Memory memory;
        private string fileName;
        private bool isMouseDown;
        private PageStatus pageStatus;
        private Size workSpaceDefSize;
        private MyPictureBox workSpace;

        public Size Size
        {
            get
            {
                return new Size(workSpace.Width, workSpace.Height);
            }
        }

        public PageStatus Status
        {
            get
            {
                return pageStatus;
            }
        }

        public Page(Status status)
        {
            this.status = status;
            this.pageStatus = PageStatus.NoChanges;
            this.isMouseDown = false;
            this.fileName = string.Empty;
            this.memory = new Memory();
            this.workSpaceDefSize = new Size(300, 400);

            this.workSpace = new MyPictureBox();
            this.workSpace.BackColor = System.Drawing.Color.White;
            this.workSpace.Location = new System.Drawing.Point(2, 1);
            this.workSpace.Margin = new System.Windows.Forms.Padding(1);
            this.workSpace.Name = "WorkSpace";
            this.workSpace.Size = workSpaceDefSize;
            this.workSpace.TabIndex = 0;
            this.workSpace.TabStop = false;
            this.workSpace.Cursor = System.Windows.Forms.Cursors.Cross;

            // events
            this.workSpace.MouseDown += new MouseEventHandler(this.Page_MouseDown);
            this.workSpace.MouseMove += new MouseEventHandler(this.Page_MouseMove);
            this.workSpace.MouseUp += new MouseEventHandler(this.Page_MouseUp);
            this.workSpace.Paint += new PaintEventHandler(this.Page_Paint);
        }

        private void Page_Paint(object sender, PaintEventArgs e)
        {
            Redraw(e.Graphics);
            workSpace.Image = CrateWorkSpaceBitmap();
        }

        private void Redraw(Graphics g)
        {
            g.Clear(workSpace.BackColor);

            foreach (IMemorable memoryItem in memory)
            {
                 memoryItem.Redraw(g);
            }
        }

        private void Page_MouseDown(object sender, MouseEventArgs e)
        {
            pageStatus = PageStatus.ChangesWereMade;

            IDrawUsable tool = status.ActiveTool as IDrawUsable;
            if (tool != null)
            {
                memory.Add(tool.StartDrawing(sender, e));
                isMouseDown = true;
                workSpace.Invalidate();
            }
        }

        private void Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                IDrawUsable tool = status.ActiveTool as IDrawUsable;
                if (tool != null)
                {
                    memory.Undo();
                    memory.Add(tool.Drawing(workSpace, e));
                    workSpace.Invalidate();
                }
            }
        }

        private void Page_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                IDrawUsable tool = status.ActiveTool as IDrawUsable;
                if (tool != null)
                {
                    memory.Undo();
                    memory.Add(tool.EndDrawing(workSpace, e));
                    isMouseDown = false;
                    workSpace.Invalidate();
                }
            }
        }

        public void New()
        {
            memory.Clear();
            workSpace.CreateGraphics().Clear(workSpace.BackColor);

            pageStatus = PageStatus.NoChanges;
        }

        public bool Save(string path)
        {
            if (path == string.Empty)
                if (fileName == string.Empty)
                    return false;
                else
                    path = fileName;

            CrateWorkSpaceBitmap().Save(path);

            fileName = path;
            pageStatus = PageStatus.NoChanges;

            return true;
        }

        public void Open(string path)
        {
            memory.Clear();

            // openign file
            fileName = path;
            Bitmap bm;

            try
            {
                bm = (Bitmap)System.Drawing.Image.FromFile(path, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            workSpace.Size = new Size(bm.Width, bm.Height);
            workSpace.Refresh();

            Graphics grPhoto = workSpace.CreateGraphics();
            grPhoto.DrawImage(bm, new Rectangle(0, 0, bm.Width, bm.Height), 0, 0, bm.Width, bm.Height,
                GraphicsUnit.Pixel);
            grPhoto.Dispose();

            memory.Add(new ImageMemoryItem(bm, new Point(0, 0)));
            pageStatus = PageStatus.NoChanges;
        }

        public void Undo()
        {
            memory.Undo();
            Redraw(workSpace.CreateGraphics());
        }

        public void Repeat()
        {
            memory.Repeat();
            Redraw(workSpace.CreateGraphics());
        }

        public void Clear()
        {
            memory.Add(new RectMemoryItem(new Rectangle(Point.Empty,
                new Size(workSpace.Width, workSpace.Height)),
                workSpace.BackColor, workSpace.BackColor, BorderAndFillType.BorderAndFill, 1));
            workSpace.Invalidate();
        }

        public PictureBox GetWorkSpace()
        {
            return workSpace;
        }

        private Bitmap CrateWorkSpaceBitmap()
        {
            Bitmap tmp = new Bitmap(workSpace.Size.Width, workSpace.Size.Height);
            Graphics grPhoto = Graphics.FromImage(tmp);
            grPhoto.FillRectangle(new SolidBrush(workSpace.BackColor), 0, 0,
                workSpace.Width, workSpace.Height);
            Redraw(grPhoto);
            grPhoto.Dispose();

            return tmp;
        }

        public void Transform(Transformations transformation)
        {
            TransformationMemoryItem mem = transformation.Transform(CrateWorkSpaceBitmap());
            memory.Add(mem);
            workSpace.Size = mem.Size;
            workSpace.Invalidate();
        }

        public void Resize(Transformations transformation)
        {
            ResizeMemoryItem mem = transformation.Resize();
            workSpace.Size = mem.Size;
            workSpace.Invalidate();
        }
    }
}
