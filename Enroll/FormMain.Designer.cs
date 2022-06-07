namespace Enroll
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMain = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEnrolled = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourses = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmrHidden = new System.Windows.Forms.Timer(this.components);
            this.tmrVisible = new System.Windows.Forms.Timer(this.components);
            this.panelDashBoard.SuspendLayout();
            this.panelForms.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMain)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDashBoard.Controls.Add(this.panelForms);
            this.panelDashBoard.Controls.Add(this.panelMenu);
            this.panelDashBoard.Controls.Add(this.panelTopBar);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(650, 450);
            this.panelDashBoard.TabIndex = 0;
            this.panelDashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashBoard_Paint);
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.SystemColors.Control;
            this.panelForms.Controls.Add(this.panel3);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(160, 30);
            this.panelForms.MinimumSize = new System.Drawing.Size(400, 300);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(490, 420);
            this.panelForms.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(400, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 420);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.MinimumSize = new System.Drawing.Size(400, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 420);
            this.panel5.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.MinimumSize = new System.Drawing.Size(400, 300);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(490, 420);
            this.panel7.TabIndex = 5;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.iconMain);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.btnEnrolled);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.btnStudent);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnTeacher);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnCourses);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(160, 420);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconMain
            // 
            this.iconMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconMain.Image = ((System.Drawing.Image)(resources.GetObject("iconMain.Image")));
            this.iconMain.Location = new System.Drawing.Point(12, 6);
            this.iconMain.Name = "iconMain";
            this.iconMain.Size = new System.Drawing.Size(60, 50);
            this.iconMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMain.TabIndex = 0;
            this.iconMain.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.panel6.Location = new System.Drawing.Point(0, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 30);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnEnrolled
            // 
            this.btnEnrolled.FlatAppearance.BorderSize = 0;
            this.btnEnrolled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.btnEnrolled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrolled.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnrolled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnrolled.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrolled.Image")));
            this.btnEnrolled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrolled.Location = new System.Drawing.Point(3, 237);
            this.btnEnrolled.Name = "btnEnrolled";
            this.btnEnrolled.Size = new System.Drawing.Size(160, 30);
            this.btnEnrolled.TabIndex = 4;
            this.btnEnrolled.Text = "     Enrolled";
            this.btnEnrolled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnrolled.UseVisualStyleBackColor = true;
            this.btnEnrolled.Click += new System.EventHandler(this.btnEnrolled_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.panel4.Location = new System.Drawing.Point(0, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 30);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(3, 188);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(160, 30);
            this.btnStudent.TabIndex = 4;
            this.btnStudent.Text = "     Students";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(3, 140);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(160, 30);
            this.btnTeacher.TabIndex = 4;
            this.btnTeacher.Text = "     Teachers";
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnCourses
            // 
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCourses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(3, 94);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(160, 30);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "     Courses";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(95)))));
            this.panelTopBar.Controls.Add(this.btnRestore);
            this.panelTopBar.Controls.Add(this.btnMinimize);
            this.panelTopBar.Controls.Add(this.btnMaximize);
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(650, 30);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(587, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(20, 20);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(548, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(587, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(627, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrHidden
            // 
            this.tmrHidden.Tick += new System.EventHandler(this.tmrHidden_Tick);
            // 
            // tmrVisible
            // 
            this.tmrVisible.Tick += new System.EventHandler(this.tmrVisible_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.panelDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDashBoard.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMain)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDashBoard;
        private Panel panelForms;
        private Panel panelMenu;
        private Panel panelTopBar;
        private Button btnRestore;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel panel1;
        private Button btnCourses;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Button btnEnrolled;
        private Panel panel4;
        private Button btnStudent;
        private Panel panel2;
        private Button btnTeacher;
        private PictureBox pictureBox1;
        private PictureBox iconMain;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrHidden;
        private System.Windows.Forms.Timer tmrVisible;
    }
}