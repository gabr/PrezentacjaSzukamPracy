using System;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.Tools;

namespace FPaint
{
    public partial class FPaint : Form
    {
        private Page page;
        private Status status;

        public FPaint()
        {
            InitializeComponent();

            // creating status object
            status = new Status();
            status.FrontColor = FrontColor.BackColor;
            status.BackColor = BackColor.BackColor;
            status.Size = Convert.ToInt32(SizeTextBox.Text);
            status.BorderAndFillType = BorderAndFillType.BorderOnly;

            // creating work space
            page = new Page(status);
            WorkSpacePanel.Controls.Add(page.GetWorkSpace());

            // creating tools
            IButtonable[] tools = {new Rubber(status),
                                      new Fill(status),
                                      new Pencil(status),
                                      new Line(status),
                                      new Circle(status),
                                      new Rect(status)};

            // adding tools to toolpanel
            foreach (IButtonable toolButton in tools)
            {
                ButtonsPanel.Controls.Add(toolButton.GetButton());
            }

            status.ActiveTool = tools[0];
        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolBoxViewMenu_Click(object sender, EventArgs e)
        {
            toolBoxViewMenu.Checked = !toolBoxViewMenu.Checked;
            ToolPanel.Visible = toolBoxViewMenu.Checked;

            if(toolBoxViewMenu.Checked)
                this.toolBoxViewMenu.Image = global::FPaint.Properties.Resources._checked;
            else
                this.toolBoxViewMenu.Image = global::FPaint.Properties.Resources._unchecked;
        }

        private void colorBoxViewMenu_Click(object sender, EventArgs e)
        {
            colorBoxViewMenu.Checked = !colorBoxViewMenu.Checked;
            ColorPanel.Visible = colorBoxViewMenu.Checked;

            if (colorBoxViewMenu.Checked)
                this.colorBoxViewMenu.Image = global::FPaint.Properties.Resources._checked;
            else
                this.colorBoxViewMenu.Image = global::FPaint.Properties.Resources._unchecked;
        }

        private void aboutFPaintHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FPaint\njob recruitment task\n25-27.09.2013\nArkadiusz Gabryś",
                "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newFileMenu_Click(object sender, EventArgs e)
        {
            // checking status
            if (page.Status == PageStatus.ChangesWereMade)
                if (UnsavedChangesConfirm() == false)
                    return;

            page.New();
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            if (UnsavedChangesConfirm() == false)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    page.Open(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    throw;
                }
            }
        }

        private void saveAsFileMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    page.Save(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    throw;
                }
            }
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            if (page.Save(string.Empty) == false)
                saveAsFileMenu_Click(sender, e);
        }

        private void MoreColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = MoreColorsPictureBox.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                MoreColorsPictureBox.BackColor = colorDialog.Color;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            PictureBox pb = (PictureBox)sender;

            switch (me.Button)
            {
                case MouseButtons.Left:
                    status.FrontColor = FrontColor.BackColor = pb.BackColor;
                    break;
                case MouseButtons.Right:
                    status.BackColor = BackColor.BackColor = pb.BackColor;
                    break;
            }
        }

        private void BorderFillButton_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            switch (status.BorderAndFillType)
            {
                case BorderAndFillType.BorderOnly:
                    BorderOnly.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
                    break;
                case BorderAndFillType.FillOnly:
                    FillOnly.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
                    break;
                case BorderAndFillType.BorderAndFill:
                    BorderAndFill.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
                    break;
                default:
                    break;
            }

            status.BorderAndFillType = (BorderAndFillType)Enum.Parse(typeof(BorderAndFillType), bt.Name);
            bt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void undoEditMenu_Click(object sender, EventArgs e)
        {
            page.Undo();
        }

        private void redoEditMenu_Click(object sender, EventArgs e)
        {
            page.Repeat();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            if(page.Status == PageStatus.ChangesWereMade)
                if (UnsavedChangesConfirm() == false)
                    e.Cancel = true;

        }

        private void WorkSpacePanel_Paint(object sender, PaintEventArgs e)
        {
            int pictureBoxIndex = WorkSpacePanel.Controls.IndexOf(page.GetWorkSpace());
            PictureBox pb = (PictureBox)WorkSpacePanel.Controls[pictureBoxIndex];
            pb.Invalidate();
        }

        private bool UnsavedChangesConfirm()
        {
            // checking status
            if (page.Status == PageStatus.ChangesWereMade)
            {
                switch (MessageBox.Show("Do you want to save unsaved changes?", "Save", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.Yes:
                        this.saveAsFileMenu_Click(this, new EventArgs());
                        break;
                }
            }
            return true;
        }

        private void clearImageMenu_Click(object sender, EventArgs e)
        {
            if (UnsavedChangesConfirm() == false)
                return;
            page.Clear();
        }

        private void SizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int size = new int();

            try
            {
                size = Convert.ToInt32(SizeTextBox.Text);
            }
            catch (Exception)
            {
                SizeTextBox.Text = status.Size.ToString();
                return;
            }
            
            if (size < 1)
                SizeTextBox.Text = status.Size.ToString();
            status.Size = size;
        }

        private void flipRotateImageMenu_Click(object sender, EventArgs e)
        {
            Transformations transformation = new Transformations();
            if (transformation.ShowTransformationDialog(this) == System.Windows.Forms.DialogResult.OK)
                page.Transform(transformation);
        }

        private void attributesImageMenu_Click(object sender, EventArgs e)
        {
            Transformations transformation = new Transformations();
            if (transformation.ShowSizeDialog(this, page.Size) == System.Windows.Forms.DialogResult.OK)
                page.Resize(transformation);
        }
    }
}
