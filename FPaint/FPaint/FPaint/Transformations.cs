using System;
using System.Drawing;
using System.Windows.Forms;
using FPaint.MemoryItems;

namespace FPaint
{
    class Transformations
    {
        private Size bitmapSize;
        private RotateFlipType type;

        // controls
        private TextBox width;
        private TextBox height;
        private RadioButton activeAngle;
        private RadioButton activeButton;
        private FlowLayoutPanel rotatePanel;

        public Transformations()
        {
            type = RotateFlipType.RotateNoneFlipNone;
            activeAngle = activeButton = null;
            rotatePanel = null;
        }

        public DialogResult ShowTransformationDialog(Form parent)
        {
            Form dialog = new Form();
            dialog.Text = "Flip / Rotate";
            dialog.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            dialog.Size = new Size(310, 248);

            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Flip or rotate";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(180, 180);

            int radioButtonsPadding = 3;
            RadioButton flipHorizontal = new RadioButton();
            flipHorizontal.Name = "RotateNoneFlipY";
            flipHorizontal.Text = "Flip horizontal";
            flipHorizontal.Dock = DockStyle.Top;
            flipHorizontal.Padding = new Padding(radioButtonsPadding);
            flipHorizontal.Checked = true;
            flipHorizontal.CheckedChanged += CheckedChange;
            activeButton = flipHorizontal;
            RadioButton flipVertical = new RadioButton();
            flipVertical.Name = "RotateNoneFlipX";
            flipVertical.Text = "Flip vertical";
            flipVertical.Dock = DockStyle.Top;
            flipVertical.Padding = new Padding(radioButtonsPadding);
            flipVertical.CheckedChanged += CheckedChange;
            RadioButton rotateByAngle = new RadioButton();
            rotateByAngle.Name = "Angle";
            rotateByAngle.Text = "Rotate by angle";
            rotateByAngle.Dock = DockStyle.Top;
            rotateByAngle.Padding = new Padding(radioButtonsPadding);
            rotateByAngle.CheckedChanged += CheckedChange;

            rotatePanel = new FlowLayoutPanel();
            rotatePanel.Text = string.Empty;
            rotatePanel.Dock = DockStyle.Top;
            rotatePanel.FlowDirection = FlowDirection.TopDown;
            rotatePanel.Padding = new Padding(20, 0, 0, 0);
            rotatePanel.Enabled = false;

            RadioButton rightBy90 = new RadioButton();
            rightBy90.Name = "Rotate90FlipNone";
            rightBy90.Text = "90 right";
            rightBy90.Margin = new Padding(0);
            rightBy90.Checked = true;
            rightBy90.CheckedChanged += CheckedChangeAngle;
            activeAngle = rightBy90;
            RadioButton leftBy90 = new RadioButton();
            leftBy90.Name = "Rotate270FlipNone";
            leftBy90.Text = "90 left";
            leftBy90.Margin = new Padding(0);
            leftBy90.CheckedChanged += CheckedChangeAngle;
            RadioButton by180 = new RadioButton();
            by180.Name = "Rotate180FlipNone";
            by180.Text = "180";
            by180.Margin = new Padding(0);
            by180.CheckedChanged += CheckedChangeAngle;

            rotatePanel.Controls.Add(rightBy90);
            rotatePanel.Controls.Add(leftBy90);
            rotatePanel.Controls.Add(by180);

            groupBox.Controls.Add(rotatePanel);
            groupBox.Controls.Add(rotateByAngle);
            groupBox.Controls.Add(flipVertical);
            groupBox.Controls.Add(flipHorizontal);

            Button ok = new Button();
            ok.Text = "OK";
            ok.Location = new Point(200, 10);
            ok.DialogResult = DialogResult.OK;
            ok.Click += ok_Click;
            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.Location = new Point(200, 40);
            cancel.DialogResult = DialogResult.Cancel;

            dialog.Controls.Add(ok);
            dialog.Controls.Add(cancel);
            dialog.Controls.Add(groupBox);
            return dialog.ShowDialog(parent);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (activeButton.Name == "Angle")
                type = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), activeAngle.Name);
            else
                type = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), activeButton.Name);
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                activeButton = rb;
                if (rb.Text == "Rotate by angle")
                    rotatePanel.Enabled = true;
                else
                    rotatePanel.Enabled = false;
            }
        }

        private void CheckedChangeAngle(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                activeAngle = rb;
            }
        }

        public TransformationMemoryItem Transform(Bitmap bm)
        {
            Bitmap image = new Bitmap(bm);
            image.RotateFlip(type);
            return new TransformationMemoryItem(image, image.Size);
        }

        public DialogResult ShowSizeDialog(Form parent, Size size)
        {
            Form dialog = new Form();
            dialog.Text = "Resize";
            dialog.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            dialog.Size = new Size(250, 120);

            Label widthLabel = new Label();
            widthLabel.Text = "Width: ";
            widthLabel.Location = new Point(10, 15);
            widthLabel.Size = new Size(50, 20);
            Label heightLabel = new Label();
            heightLabel.Text = "Height: ";
            heightLabel.Location = new Point(10, 45);
            heightLabel.Size = new Size(50, 20);

            width = new TextBox();
            width.Name = "width";
            width.Text = size.Width.ToString();
            width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            width.Location = new Point(60, 13);
            width.Size = new Size(60, 20);
            width.TextChanged += TextChanged;

            height = new TextBox();
            height.Name = "height";
            height.Text = size.Height.ToString();
            height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            height.Location = new Point(60, 43);
            height.Size = new Size(60, 20);
            width.TextChanged += TextChanged;


            Button ok = new Button();
            ok.Text = "OK";
            ok.Location = new Point(150, 12);
            ok.DialogResult = DialogResult.OK;
            ok.Click += okSize_Click;
            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.Location = new Point(150, 42);
            cancel.DialogResult = DialogResult.Cancel;

            dialog.Controls.Add(ok);
            dialog.Controls.Add(cancel);
            dialog.Controls.Add(widthLabel);
            dialog.Controls.Add(heightLabel);
            dialog.Controls.Add(width);
            dialog.Controls.Add(height);

            return dialog.ShowDialog(parent);
        }

        void TextChanged(object sender, EventArgs e)
        {
            int size = new int();
            int value;
            TextBox tb = sender as TextBox;

            if (tb.Name == "width")
                value = bitmapSize.Width;
            else
                value = bitmapSize.Height;

            if (tb != null)
            {
                try
                {
                    size = Convert.ToInt32(tb.Text);
                }
                catch (Exception)
                {
                    tb.Text = value.ToString();
                    return;
                }

                if (size < 1)
                    tb.Text = value.ToString();
                value = size;

                if (tb.Name == "width")
                    bitmapSize.Width = value;
                else
                    bitmapSize.Height = value;
            }
        }

        private void okSize_Click(object sender, EventArgs e)
        {
            TextChanged(width, e);
            TextChanged(height, e);
        }

        public ResizeMemoryItem Resize()
        {
            return new ResizeMemoryItem(new Size(bitmapSize.Width, bitmapSize.Height));
        }
    }
}
