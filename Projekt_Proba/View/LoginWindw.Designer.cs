namespace Projekt_Proba.View
{
    partial class LoginWindw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindw));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.BackgroundImage = global::Projekt_Proba.Properties.Resources.rsz_flower_03;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.bunifuThinButton1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuTextbox2);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuTextbox1);
            this.splitContainer1.Size = new System.Drawing.Size(915, 512);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(85, 234);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(241, 35);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "Password";
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(85, 153);
            this.bunifuTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(241, 35);
            this.bunifuTextbox2.TabIndex = 2;
            this.bunifuTextbox2.text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wedding Planner";
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Login";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(81, 318);
            this.bunifuThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(245, 44);
            this.bunifuThinButton1.TabIndex = 5;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // LoginWindw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoginWindw";
            this.Text = "Wedding Planner";
            this.Load += new System.EventHandler(this.LoginWindw_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
    }
}