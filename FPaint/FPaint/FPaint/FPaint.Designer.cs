using System.Windows.Forms;
namespace FPaint
{
    partial class FPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPaint));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBoxViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.flipRotateImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFPaintHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkSpacePanel = new System.Windows.Forms.Panel();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.MoreColorsPictureBox = new System.Windows.Forms.PictureBox();
            this.MoreColors = new System.Windows.Forms.Button();
            this.BlueColor = new System.Windows.Forms.PictureBox();
            this.GreenColor = new System.Windows.Forms.PictureBox();
            this.YellowColor = new System.Windows.Forms.PictureBox();
            this.RedColor = new System.Windows.Forms.PictureBox();
            this.GrayColor = new System.Windows.Forms.PictureBox();
            this.WhiteColor = new System.Windows.Forms.PictureBox();
            this.BlackColor = new System.Windows.Forms.PictureBox();
            this.ColorsViewPanel = new System.Windows.Forms.Panel();
            this.FrontColor = new System.Windows.Forms.PictureBox();
            this.BackColor = new System.Windows.Forms.PictureBox();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.ContainerForBorderAndFillQuestionPanel = new System.Windows.Forms.Panel();
            this.BorderAndFillQuestionPanel = new System.Windows.Forms.Panel();
            this.FillOnly = new System.Windows.Forms.Button();
            this.BorderAndFill = new System.Windows.Forms.Button();
            this.BorderOnly = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenu.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreColorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackColor)).BeginInit();
            this.ColorsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColor)).BeginInit();
            this.ToolPanel.SuspendLayout();
            this.ContainerForBorderAndFillQuestionPanel.SuspendLayout();
            this.BorderAndFillQuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.imageMenu,
            this.helpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(461, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.toolStripSeparator1,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.Image = global::FPaint.Properties.Resources._new;
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenu.Size = new System.Drawing.Size(152, 22);
            this.newFileMenu.Text = "New";
            this.newFileMenu.Click += new System.EventHandler(this.newFileMenu_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Image = global::FPaint.Properties.Resources.open;
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(152, 22);
            this.openFileMenu.Text = "Open..";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Image = global::FPaint.Properties.Resources.save;
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(152, 22);
            this.saveFileMenu.Text = "Save";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(152, 22);
            this.saveAsFileMenu.Text = "Save as...";
            this.saveAsFileMenu.Click += new System.EventHandler(this.saveAsFileMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Image = global::FPaint.Properties.Resources.exit;
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitFileMenu.Size = new System.Drawing.Size(152, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenu,
            this.redoEditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // undoEditMenu
            // 
            this.undoEditMenu.Name = "undoEditMenu";
            this.undoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoEditMenu.Size = new System.Drawing.Size(151, 22);
            this.undoEditMenu.Text = "Undo";
            this.undoEditMenu.Click += new System.EventHandler(this.undoEditMenu_Click);
            // 
            // redoEditMenu
            // 
            this.redoEditMenu.Name = "redoEditMenu";
            this.redoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoEditMenu.Size = new System.Drawing.Size(151, 22);
            this.redoEditMenu.Text = "Repeat";
            this.redoEditMenu.Click += new System.EventHandler(this.redoEditMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBoxViewMenu,
            this.colorBoxViewMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "View";
            // 
            // toolBoxViewMenu
            // 
            this.toolBoxViewMenu.Checked = true;
            this.toolBoxViewMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBoxViewMenu.Image = global::FPaint.Properties.Resources._checked;
            this.toolBoxViewMenu.Name = "toolBoxViewMenu";
            this.toolBoxViewMenu.Size = new System.Drawing.Size(125, 22);
            this.toolBoxViewMenu.Text = "Tool Box";
            this.toolBoxViewMenu.Click += new System.EventHandler(this.toolBoxViewMenu_Click);
            // 
            // colorBoxViewMenu
            // 
            this.colorBoxViewMenu.Checked = true;
            this.colorBoxViewMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorBoxViewMenu.Image = global::FPaint.Properties.Resources._checked;
            this.colorBoxViewMenu.Name = "colorBoxViewMenu";
            this.colorBoxViewMenu.Size = new System.Drawing.Size(125, 22);
            this.colorBoxViewMenu.Text = "Color Box";
            this.colorBoxViewMenu.Click += new System.EventHandler(this.colorBoxViewMenu_Click);
            // 
            // imageMenu
            // 
            this.imageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipRotateImageMenu,
            this.attributesImageMenu,
            this.clearImageMenu});
            this.imageMenu.Name = "imageMenu";
            this.imageMenu.Size = new System.Drawing.Size(52, 20);
            this.imageMenu.Text = "Image";
            // 
            // flipRotateImageMenu
            // 
            this.flipRotateImageMenu.Name = "flipRotateImageMenu";
            this.flipRotateImageMenu.Size = new System.Drawing.Size(179, 22);
            this.flipRotateImageMenu.Text = "Flip/Rotate";
            this.flipRotateImageMenu.Click += new System.EventHandler(this.flipRotateImageMenu_Click);
            // 
            // attributesImageMenu
            // 
            this.attributesImageMenu.Name = "attributesImageMenu";
            this.attributesImageMenu.Size = new System.Drawing.Size(179, 22);
            this.attributesImageMenu.Text = "Resize";
            this.attributesImageMenu.Click += new System.EventHandler(this.attributesImageMenu_Click);
            // 
            // clearImageMenu
            // 
            this.clearImageMenu.Name = "clearImageMenu";
            this.clearImageMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearImageMenu.Size = new System.Drawing.Size(179, 22);
            this.clearImageMenu.Text = "Clear Image";
            this.clearImageMenu.Click += new System.EventHandler(this.clearImageMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFPaintHelp});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutFPaintHelp
            // 
            this.aboutFPaintHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutFPaintHelp.Name = "aboutFPaintHelp";
            this.aboutFPaintHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.aboutFPaintHelp.Size = new System.Drawing.Size(186, 22);
            this.aboutFPaintHelp.Text = "About FPaint";
            this.aboutFPaintHelp.Click += new System.EventHandler(this.aboutFPaintHelp_Click);
            // 
            // WorkSpacePanel
            // 
            this.WorkSpacePanel.AutoScroll = true;
            this.WorkSpacePanel.BackColor = System.Drawing.Color.Gray;
            this.WorkSpacePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkSpacePanel.Location = new System.Drawing.Point(78, 24);
            this.WorkSpacePanel.Name = "WorkSpacePanel";
            this.WorkSpacePanel.Size = new System.Drawing.Size(383, 349);
            this.WorkSpacePanel.TabIndex = 1;
            this.WorkSpacePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkSpacePanel_Paint);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Controls.Add(this.MoreColorsPictureBox);
            this.ColorPanel.Controls.Add(this.MoreColors);
            this.ColorPanel.Controls.Add(this.BlueColor);
            this.ColorPanel.Controls.Add(this.GreenColor);
            this.ColorPanel.Controls.Add(this.YellowColor);
            this.ColorPanel.Controls.Add(this.RedColor);
            this.ColorPanel.Controls.Add(this.GrayColor);
            this.ColorPanel.Controls.Add(this.WhiteColor);
            this.ColorPanel.Controls.Add(this.BlackColor);
            this.ColorPanel.Controls.Add(this.ColorsViewPanel);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorPanel.Location = new System.Drawing.Point(0, 373);
            this.ColorPanel.MaximumSize = new System.Drawing.Size(90000004, 50);
            this.ColorPanel.MinimumSize = new System.Drawing.Size(400, 50);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(461, 50);
            this.ColorPanel.TabIndex = 2;
            // 
            // MoreColorsPictureBox
            // 
            this.MoreColorsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoreColorsPictureBox.BackColor = System.Drawing.Color.Lavender;
            this.MoreColorsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoreColorsPictureBox.Location = new System.Drawing.Point(350, 10);
            this.MoreColorsPictureBox.MaximumSize = new System.Drawing.Size(20, 20);
            this.MoreColorsPictureBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.MoreColorsPictureBox.Name = "MoreColorsPictureBox";
            this.MoreColorsPictureBox.Size = new System.Drawing.Size(20, 20);
            this.MoreColorsPictureBox.TabIndex = 9;
            this.MoreColorsPictureBox.TabStop = false;
            this.MoreColorsPictureBox.Click += new System.EventHandler(this.Color_Click);
            // 
            // MoreColors
            // 
            this.MoreColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoreColors.FlatAppearance.BorderSize = 0;
            this.MoreColors.Location = new System.Drawing.Point(264, 10);
            this.MoreColors.MaximumSize = new System.Drawing.Size(80, 20);
            this.MoreColors.MinimumSize = new System.Drawing.Size(80, 20);
            this.MoreColors.Name = "MoreColors";
            this.MoreColors.Size = new System.Drawing.Size(80, 20);
            this.MoreColors.TabIndex = 8;
            this.MoreColors.Text = "More Colors";
            this.MoreColors.UseVisualStyleBackColor = true;
            this.MoreColors.Click += new System.EventHandler(this.MoreColors_Click);
            // 
            // BlueColor
            // 
            this.BlueColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BlueColor.BackColor = System.Drawing.Color.Blue;
            this.BlueColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BlueColor.Location = new System.Drawing.Point(238, 11);
            this.BlueColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.BlueColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.BlueColor.Name = "BlueColor";
            this.BlueColor.Size = new System.Drawing.Size(20, 20);
            this.BlueColor.TabIndex = 7;
            this.BlueColor.TabStop = false;
            this.BlueColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // GreenColor
            // 
            this.GreenColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenColor.BackColor = System.Drawing.Color.Green;
            this.GreenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GreenColor.Location = new System.Drawing.Point(207, 11);
            this.GreenColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.GreenColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.GreenColor.Name = "GreenColor";
            this.GreenColor.Size = new System.Drawing.Size(20, 20);
            this.GreenColor.TabIndex = 6;
            this.GreenColor.TabStop = false;
            this.GreenColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // YellowColor
            // 
            this.YellowColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.YellowColor.BackColor = System.Drawing.Color.Yellow;
            this.YellowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YellowColor.Location = new System.Drawing.Point(176, 11);
            this.YellowColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.YellowColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.YellowColor.Name = "YellowColor";
            this.YellowColor.Size = new System.Drawing.Size(20, 20);
            this.YellowColor.TabIndex = 5;
            this.YellowColor.TabStop = false;
            this.YellowColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // RedColor
            // 
            this.RedColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RedColor.BackColor = System.Drawing.Color.Red;
            this.RedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RedColor.Location = new System.Drawing.Point(145, 11);
            this.RedColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.RedColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.RedColor.Name = "RedColor";
            this.RedColor.Size = new System.Drawing.Size(20, 20);
            this.RedColor.TabIndex = 4;
            this.RedColor.TabStop = false;
            this.RedColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // GrayColor
            // 
            this.GrayColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrayColor.BackColor = System.Drawing.Color.Gray;
            this.GrayColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrayColor.Location = new System.Drawing.Point(114, 11);
            this.GrayColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.GrayColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.GrayColor.Name = "GrayColor";
            this.GrayColor.Size = new System.Drawing.Size(20, 20);
            this.GrayColor.TabIndex = 3;
            this.GrayColor.TabStop = false;
            this.GrayColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // WhiteColor
            // 
            this.WhiteColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WhiteColor.BackColor = System.Drawing.Color.White;
            this.WhiteColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WhiteColor.Location = new System.Drawing.Point(83, 11);
            this.WhiteColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.WhiteColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.WhiteColor.Name = "WhiteColor";
            this.WhiteColor.Size = new System.Drawing.Size(20, 20);
            this.WhiteColor.TabIndex = 2;
            this.WhiteColor.TabStop = false;
            this.WhiteColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // BlackColor
            // 
            this.BlackColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BlackColor.BackColor = System.Drawing.Color.Black;
            this.BlackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BlackColor.Location = new System.Drawing.Point(52, 11);
            this.BlackColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.BlackColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.BlackColor.Name = "BlackColor";
            this.BlackColor.Size = new System.Drawing.Size(20, 20);
            this.BlackColor.TabIndex = 1;
            this.BlackColor.TabStop = false;
            this.BlackColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // ColorsViewPanel
            // 
            this.ColorsViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColorsViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorsViewPanel.Controls.Add(this.FrontColor);
            this.ColorsViewPanel.Controls.Add(this.BackColor);
            this.ColorsViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorsViewPanel.Name = "ColorsViewPanel";
            this.ColorsViewPanel.Size = new System.Drawing.Size(46, 46);
            this.ColorsViewPanel.TabIndex = 0;
            // 
            // FrontColor
            // 
            this.FrontColor.BackColor = System.Drawing.Color.Black;
            this.FrontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FrontColor.Location = new System.Drawing.Point(3, 3);
            this.FrontColor.Name = "FrontColor";
            this.FrontColor.Size = new System.Drawing.Size(24, 23);
            this.FrontColor.TabIndex = 1;
            this.FrontColor.TabStop = false;
            // 
            // BackColor
            // 
            this.BackColor.BackColor = System.Drawing.Color.White;
            this.BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackColor.Location = new System.Drawing.Point(17, 14);
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(22, 20);
            this.BackColor.TabIndex = 0;
            this.BackColor.TabStop = false;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ToolPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToolPanel.Controls.Add(this.SizeLabel);
            this.ToolPanel.Controls.Add(this.SizeTextBox);
            this.ToolPanel.Controls.Add(this.ContainerForBorderAndFillQuestionPanel);
            this.ToolPanel.Controls.Add(this.ButtonsPanel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 24);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(78, 9000000);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(78, 200);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Padding = new System.Windows.Forms.Padding(2);
            this.ToolPanel.Size = new System.Drawing.Size(78, 349);
            this.ToolPanel.TabIndex = 3;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SizeLabel.Location = new System.Drawing.Point(2, 108);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.SizeLabel.Size = new System.Drawing.Size(36, 19);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Size:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SizeTextBox.Location = new System.Drawing.Point(41, 108);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(31, 20);
            this.SizeTextBox.TabIndex = 8;
            this.SizeTextBox.Text = "2";
            this.SizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SizeTextBox.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // ContainerForBorderAndFillQuestionPanel
            // 
            this.ContainerForBorderAndFillQuestionPanel.Controls.Add(this.BorderAndFillQuestionPanel);
            this.ContainerForBorderAndFillQuestionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerForBorderAndFillQuestionPanel.Location = new System.Drawing.Point(2, 10);
            this.ContainerForBorderAndFillQuestionPanel.Name = "ContainerForBorderAndFillQuestionPanel";
            this.ContainerForBorderAndFillQuestionPanel.Padding = new System.Windows.Forms.Padding(12);
            this.ContainerForBorderAndFillQuestionPanel.Size = new System.Drawing.Size(70, 98);
            this.ContainerForBorderAndFillQuestionPanel.TabIndex = 1;
            // 
            // BorderAndFillQuestionPanel
            // 
            this.BorderAndFillQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BorderAndFillQuestionPanel.Controls.Add(this.FillOnly);
            this.BorderAndFillQuestionPanel.Controls.Add(this.BorderAndFill);
            this.BorderAndFillQuestionPanel.Controls.Add(this.BorderOnly);
            this.BorderAndFillQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderAndFillQuestionPanel.Location = new System.Drawing.Point(12, 12);
            this.BorderAndFillQuestionPanel.Name = "BorderAndFillQuestionPanel";
            this.BorderAndFillQuestionPanel.Size = new System.Drawing.Size(46, 74);
            this.BorderAndFillQuestionPanel.TabIndex = 0;
            // 
            // FillOnly
            // 
            this.FillOnly.BackgroundImage = global::FPaint.Properties.Resources.BrushFillOnly;
            this.FillOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillOnly.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillOnly.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.FillOnly.FlatAppearance.BorderSize = 2;
            this.FillOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FillOnly.ImageIndex = 2;
            this.FillOnly.Location = new System.Drawing.Point(0, 46);
            this.FillOnly.Margin = new System.Windows.Forms.Padding(0);
            this.FillOnly.Name = "FillOnly";
            this.FillOnly.Size = new System.Drawing.Size(42, 23);
            this.FillOnly.TabIndex = 2;
            this.FillOnly.UseVisualStyleBackColor = true;
            this.FillOnly.Click += new System.EventHandler(this.BorderFillButton_Click);
            // 
            // BorderAndFill
            // 
            this.BorderAndFill.BackgroundImage = global::FPaint.Properties.Resources.BrushBorderAndFill;
            this.BorderAndFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderAndFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderAndFill.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BorderAndFill.FlatAppearance.BorderSize = 2;
            this.BorderAndFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorderAndFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorderAndFill.ImageIndex = 1;
            this.BorderAndFill.Location = new System.Drawing.Point(0, 23);
            this.BorderAndFill.Margin = new System.Windows.Forms.Padding(0);
            this.BorderAndFill.Name = "BorderAndFill";
            this.BorderAndFill.Size = new System.Drawing.Size(42, 23);
            this.BorderAndFill.TabIndex = 1;
            this.BorderAndFill.UseVisualStyleBackColor = true;
            this.BorderAndFill.Click += new System.EventHandler(this.BorderFillButton_Click);
            // 
            // BorderOnly
            // 
            this.BorderOnly.BackColor = System.Drawing.SystemColors.Control;
            this.BorderOnly.BackgroundImage = global::FPaint.Properties.Resources.BrushBorderOnly;
            this.BorderOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderOnly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderOnly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderOnly.FlatAppearance.BorderSize = 2;
            this.BorderOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorderOnly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BorderOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorderOnly.ImageIndex = 0;
            this.BorderOnly.Location = new System.Drawing.Point(0, 0);
            this.BorderOnly.Margin = new System.Windows.Forms.Padding(0);
            this.BorderOnly.Name = "BorderOnly";
            this.BorderOnly.Size = new System.Drawing.Size(42, 23);
            this.BorderOnly.TabIndex = 0;
            this.BorderOnly.UseVisualStyleBackColor = false;
            this.BorderOnly.Click += new System.EventHandler(this.BorderFillButton_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(2, 2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.ButtonsPanel.Size = new System.Drawing.Size(70, 8);
            this.ButtonsPanel.TabIndex = 7;
            // 
            // FPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 423);
            this.Controls.Add(this.WorkSpacePanel);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(395, 315);
            this.Name = "FPaint";
            this.Text = "FPaint";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoreColorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackColor)).EndInit();
            this.ColorsViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColor)).EndInit();
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.ContainerForBorderAndFillQuestionPanel.ResumeLayout(false);
            this.BorderAndFillQuestionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem imageMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem undoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem redoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem flipRotateImageMenu;
        private System.Windows.Forms.ToolStripMenuItem attributesImageMenu;
        private System.Windows.Forms.ToolStripMenuItem clearImageMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutFPaintHelp;
        private System.Windows.Forms.Panel WorkSpacePanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBoxViewMenu;
        private System.Windows.Forms.ToolStripMenuItem colorBoxViewMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Panel ColorsViewPanel;
        private System.Windows.Forms.PictureBox FrontColor;
        private System.Windows.Forms.PictureBox BackColor;
        private System.Windows.Forms.PictureBox BlueColor;
        private System.Windows.Forms.PictureBox GreenColor;
        private System.Windows.Forms.PictureBox YellowColor;
        private System.Windows.Forms.PictureBox RedColor;
        private System.Windows.Forms.PictureBox GrayColor;
        private System.Windows.Forms.PictureBox WhiteColor;
        private System.Windows.Forms.PictureBox BlackColor;
        private System.Windows.Forms.Button MoreColors;
        private System.Windows.Forms.PictureBox MoreColorsPictureBox;
        private System.Windows.Forms.Panel ContainerForBorderAndFillQuestionPanel;
        private Panel BorderAndFillQuestionPanel;
        private Button BorderAndFill;
        private Button BorderOnly;
        private Button FillOnly;
        private TextBox SizeTextBox;
        private Label SizeLabel;
    }
}

