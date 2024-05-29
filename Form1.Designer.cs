namespace DuckHunt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            startPictureBox = new PictureBox();
            lbl_kill = new Label();
            duck2 = new PictureBox();
            duck1 = new PictureBox();
            ammo3 = new PictureBox();
            ammo0 = new PictureBox();
            ammo1 = new PictureBox();
            ammo2 = new PictureBox();
            duck3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)startPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duck2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duck1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammo0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duck3).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // startPictureBox
            // 
            resources.ApplyResources(startPictureBox, "startPictureBox");
            startPictureBox.Name = "startPictureBox";
            startPictureBox.TabStop = false;
            startPictureBox.UseWaitCursor = true;
            // 
            // lbl_kill
            // 
            lbl_kill.BackColor = Color.Transparent;
            resources.ApplyResources(lbl_kill, "lbl_kill");
            lbl_kill.ForeColor = Color.Transparent;
            lbl_kill.Name = "lbl_kill";
            lbl_kill.UseWaitCursor = true;
            // 
            // duck2
            // 
            duck2.BackColor = Color.Transparent;
            duck2.Image = Properties.Resources._2;
            resources.ApplyResources(duck2, "duck2");
            duck2.Name = "duck2";
            duck2.TabStop = false;
            duck2.UseWaitCursor = true;
            duck2.Click += duck2_Click;
            // 
            // duck1
            // 
            duck1.BackColor = Color.Transparent;
            resources.ApplyResources(duck1, "duck1");
            duck1.Name = "duck1";
            duck1.TabStop = false;
            duck1.UseWaitCursor = true;
            duck1.Click += duck1_Click;
            // 
            // ammo3
            // 
            ammo3.BackColor = Color.Transparent;
            ammo3.Image = Properties.Resources.Ammo3;
            resources.ApplyResources(ammo3, "ammo3");
            ammo3.Name = "ammo3";
            ammo3.TabStop = false;
            ammo3.UseWaitCursor = true;
            // 
            // ammo0
            // 
            ammo0.BackColor = Color.Transparent;
            ammo0.Image = Properties.Resources.Ammo0;
            resources.ApplyResources(ammo0, "ammo0");
            ammo0.Name = "ammo0";
            ammo0.TabStop = false;
            ammo0.UseWaitCursor = true;
            // 
            // ammo1
            // 
            ammo1.BackColor = Color.Transparent;
            ammo1.Image = Properties.Resources.Ammo1;
            resources.ApplyResources(ammo1, "ammo1");
            ammo1.Name = "ammo1";
            ammo1.TabStop = false;
            ammo1.UseWaitCursor = true;
            // 
            // ammo2
            // 
            ammo2.BackColor = Color.Transparent;
            ammo2.Image = Properties.Resources.Ammo2;
            resources.ApplyResources(ammo2, "ammo2");
            ammo2.Name = "ammo2";
            ammo2.TabStop = false;
            ammo2.UseWaitCursor = true;
            // 
            // duck3
            // 
            duck3.BackColor = Color.Transparent;
            duck3.Image = Properties.Resources._3;
            resources.ApplyResources(duck3, "duck3");
            duck3.Name = "duck3";
            duck3.TabStop = false;
            duck3.UseWaitCursor = true;
            duck3.Click += duck3_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(startPictureBox);
            Controls.Add(ammo3);
            Controls.Add(ammo2);
            Controls.Add(ammo1);
            Controls.Add(ammo0);
            Controls.Add(lbl_kill);
            Controls.Add(duck2);
            Controls.Add(duck1);
            Controls.Add(duck3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            UseWaitCursor = true;
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)startPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duck2).EndInit();
            ((System.ComponentModel.ISupportInitialize)duck1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammo0).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)duck3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox startPictureBox;
        private Label lbl_kill;
        private PictureBox duck2;
        private PictureBox duck1;
        private PictureBox ammo3;
        private PictureBox ammo0;
        private PictureBox ammo1;
        private PictureBox ammo2;
        private PictureBox duck3;
    }
}
