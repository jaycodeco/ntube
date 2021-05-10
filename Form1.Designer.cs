
namespace n_tube
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.top_bar = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_sec = new System.Windows.Forms.Panel();
            this.main_pic = new System.Windows.Forms.PictureBox();
            this.side_bar = new System.Windows.Forms.Panel();
            this.about_btn = new System.Windows.Forms.Button();
            this.downloads_btn = new System.Windows.Forms.Button();
            this.links_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.side_pic = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.top_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pic)).BeginInit();
            this.side_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.side_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.Black;
            this.top_bar.Controls.Add(this.minimize_btn);
            this.top_bar.Controls.Add(this.close_btn);
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Margin = new System.Windows.Forms.Padding(0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(800, 40);
            this.top_bar.TabIndex = 0;
            this.top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseDown);
            this.top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseMove);
            this.top_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Image = global::n_tube.Properties.Resources.minus_32px;
            this.minimize_btn.Location = new System.Drawing.Point(712, 3);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = global::n_tube.Properties.Resources.cancel_32px;
            this.close_btn.Location = new System.Drawing.Point(757, 2);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(34, 34);
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.main_sec);
            this.panel2.Controls.Add(this.side_bar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 479);
            this.panel2.TabIndex = 1;
            // 
            // main_sec
            // 
            this.main_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.main_sec.Controls.Add(this.main_pic);
            this.main_sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_sec.Location = new System.Drawing.Point(170, 0);
            this.main_sec.Margin = new System.Windows.Forms.Padding(0);
            this.main_sec.Name = "main_sec";
            this.main_sec.Size = new System.Drawing.Size(630, 479);
            this.main_sec.TabIndex = 1;
            // 
            // main_pic
            // 
            this.main_pic.Image = global::n_tube.Properties.Resources.Asset_14;
            this.main_pic.Location = new System.Drawing.Point(99, 73);
            this.main_pic.Name = "main_pic";
            this.main_pic.Size = new System.Drawing.Size(432, 333);
            this.main_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_pic.TabIndex = 0;
            this.main_pic.TabStop = false;
            // 
            // side_bar
            // 
            this.side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.side_bar.Controls.Add(this.about_btn);
            this.side_bar.Controls.Add(this.downloads_btn);
            this.side_bar.Controls.Add(this.links_btn);
            this.side_bar.Controls.Add(this.home_btn);
            this.side_bar.Controls.Add(this.side_pic);
            this.side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar.Location = new System.Drawing.Point(0, 0);
            this.side_bar.Name = "side_bar";
            this.side_bar.Size = new System.Drawing.Size(170, 479);
            this.side_bar.TabIndex = 0;
            // 
            // about_btn
            // 
            this.about_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.about_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_btn.ForeColor = System.Drawing.Color.White;
            this.about_btn.Image = global::n_tube.Properties.Resources.help_32px;
            this.about_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_btn.Location = new System.Drawing.Point(0, 302);
            this.about_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.about_btn.Name = "about_btn";
            this.about_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.about_btn.Size = new System.Drawing.Size(170, 44);
            this.about_btn.TabIndex = 4;
            this.about_btn.Text = "   About";
            this.about_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // downloads_btn
            // 
            this.downloads_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.downloads_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.downloads_btn.FlatAppearance.BorderSize = 0;
            this.downloads_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloads_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloads_btn.ForeColor = System.Drawing.Color.White;
            this.downloads_btn.Image = global::n_tube.Properties.Resources.downloads_32px;
            this.downloads_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloads_btn.Location = new System.Drawing.Point(0, 258);
            this.downloads_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.downloads_btn.Name = "downloads_btn";
            this.downloads_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.downloads_btn.Size = new System.Drawing.Size(170, 44);
            this.downloads_btn.TabIndex = 4;
            this.downloads_btn.Text = "   History";
            this.downloads_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloads_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.downloads_btn.UseVisualStyleBackColor = false;
            this.downloads_btn.Click += new System.EventHandler(this.downloads_btn_Click);
            // 
            // links_btn
            // 
            this.links_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.links_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.links_btn.FlatAppearance.BorderSize = 0;
            this.links_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.links_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.links_btn.ForeColor = System.Drawing.Color.White;
            this.links_btn.Image = global::n_tube.Properties.Resources.below_32px;
            this.links_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.links_btn.Location = new System.Drawing.Point(0, 214);
            this.links_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.links_btn.Name = "links_btn";
            this.links_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.links_btn.Size = new System.Drawing.Size(170, 44);
            this.links_btn.TabIndex = 3;
            this.links_btn.Text = "   Download";
            this.links_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.links_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.links_btn.UseVisualStyleBackColor = false;
            this.links_btn.Click += new System.EventHandler(this.links_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = global::n_tube.Properties.Resources.home_32px;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(0, 170);
            this.home_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.home_btn.Size = new System.Drawing.Size(170, 44);
            this.home_btn.TabIndex = 2;
            this.home_btn.Text = "   Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // side_pic
            // 
            this.side_pic.BackColor = System.Drawing.Color.Black;
            this.side_pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.side_pic.Image = global::n_tube.Properties.Resources.Asset_14;
            this.side_pic.Location = new System.Drawing.Point(0, 0);
            this.side_pic.Margin = new System.Windows.Forms.Padding(0);
            this.side_pic.Name = "side_pic";
            this.side_pic.Size = new System.Drawing.Size(170, 170);
            this.side_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side_pic.TabIndex = 1;
            this.side_pic.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.top_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.top_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.main_sec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_pic)).EndInit();
            this.side_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.side_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel main_sec;
        private System.Windows.Forms.Panel side_bar;
        private System.Windows.Forms.PictureBox main_pic;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Button downloads_btn;
        private System.Windows.Forms.Button links_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox side_pic;
        private System.Windows.Forms.Timer timer;
    }
}

