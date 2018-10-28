namespace QLHSGV
{
    partial class Form1
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_GV = new System.Windows.Forms.Button();
            this.b_HS = new System.Windows.Forms.Button();
            this.b_LH = new System.Windows.Forms.Button();
            this.b_TT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Location = new System.Drawing.Point(151, 49);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(664, 380);
            this.panel_main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.b_TT);
            this.panel2.Controls.Add(this.b_LH);
            this.panel2.Controls.Add(this.b_HS);
            this.panel2.Controls.Add(this.b_GV);
            this.panel2.Location = new System.Drawing.Point(2, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 380);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileToolStripMenuItem.Text = "Tài khoản";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // b_GV
            // 
            this.b_GV.Location = new System.Drawing.Point(10, 42);
            this.b_GV.Name = "b_GV";
            this.b_GV.Size = new System.Drawing.Size(123, 27);
            this.b_GV.TabIndex = 0;
            this.b_GV.Text = "Quản lý giảng viên";
            this.b_GV.UseVisualStyleBackColor = true;
            this.b_GV.Click += new System.EventHandler(this.b_GV_Click);
            // 
            // b_HS
            // 
            this.b_HS.Location = new System.Drawing.Point(10, 84);
            this.b_HS.Name = "b_HS";
            this.b_HS.Size = new System.Drawing.Size(123, 24);
            this.b_HS.TabIndex = 1;
            this.b_HS.Text = "Quản lý học sinh";
            this.b_HS.UseVisualStyleBackColor = true;
            this.b_HS.Click += new System.EventHandler(this.b_HS_Click);
            // 
            // b_LH
            // 
            this.b_LH.Location = new System.Drawing.Point(10, 124);
            this.b_LH.Name = "b_LH";
            this.b_LH.Size = new System.Drawing.Size(123, 23);
            this.b_LH.TabIndex = 2;
            this.b_LH.Text = "Lớp học";
            this.b_LH.UseVisualStyleBackColor = true;
            this.b_LH.Click += new System.EventHandler(this.b_LH_Click);
            // 
            // b_TT
            // 
            this.b_TT.Location = new System.Drawing.Point(10, 164);
            this.b_TT.Name = "b_TT";
            this.b_TT.Size = new System.Drawing.Size(123, 23);
            this.b_TT.TabIndex = 3;
            this.b_TT.Text = "Thông tin giảng dạy";
            this.b_TT.UseVisualStyleBackColor = true;
            this.b_TT.Click += new System.EventHandler(this.b_TT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PHẦN MỀM QUẢN LÝ HỌC SINH - GIÁO VIÊN THPT";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Button b_TT;
        private System.Windows.Forms.Button b_LH;
        private System.Windows.Forms.Button b_HS;
        private System.Windows.Forms.Button b_GV;
        private System.Windows.Forms.Label label1;
    }
}

