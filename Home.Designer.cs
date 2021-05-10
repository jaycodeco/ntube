
namespace n_tube
{
    partial class Home
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
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.settings_panel_sv_text = new System.Windows.Forms.Label();
            this.settings_panel_as_txt = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.settings_panel_close = new System.Windows.Forms.Button();
            this.format_box = new System.Windows.Forms.ComboBox();
            this.settings_panel_set_path = new System.Windows.Forms.Button();
            this.sv_path = new System.Windows.Forms.Label();
            this.settings_panel_at_txt = new System.Windows.Forms.Label();
            this.save_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.searchin_txt = new System.Windows.Forms.Label();
            this.settings_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Source Sans Pro Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(12, 31);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(295, 24);
            this.search_box.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.search_btn.Location = new System.Drawing.Point(313, 31);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(25, 25);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Q";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.BackgroundImage = global::n_tube.Properties.Resources.settings_100px;
            this.settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.Location = new System.Drawing.Point(583, 12);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(35, 35);
            this.settings_btn.TabIndex = 2;
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // settings_panel_sv_text
            // 
            this.settings_panel_sv_text.AutoSize = true;
            this.settings_panel_sv_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_panel_sv_text.ForeColor = System.Drawing.SystemColors.Control;
            this.settings_panel_sv_text.Location = new System.Drawing.Point(12, 13);
            this.settings_panel_sv_text.Name = "settings_panel_sv_text";
            this.settings_panel_sv_text.Size = new System.Drawing.Size(67, 29);
            this.settings_panel_sv_text.TabIndex = 0;
            this.settings_panel_sv_text.Text = "Save";
            // 
            // settings_panel_as_txt
            // 
            this.settings_panel_as_txt.AutoSize = true;
            this.settings_panel_as_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_panel_as_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.settings_panel_as_txt.Location = new System.Drawing.Point(34, 180);
            this.settings_panel_as_txt.Name = "settings_panel_as_txt";
            this.settings_panel_as_txt.Size = new System.Drawing.Size(23, 16);
            this.settings_panel_as_txt.TabIndex = 1;
            this.settings_panel_as_txt.Text = "as";
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.settings_panel.Controls.Add(this.settings_panel_close);
            this.settings_panel.Controls.Add(this.format_box);
            this.settings_panel.Controls.Add(this.settings_panel_set_path);
            this.settings_panel.Controls.Add(this.settings_panel_as_txt);
            this.settings_panel.Controls.Add(this.sv_path);
            this.settings_panel.Controls.Add(this.settings_panel_at_txt);
            this.settings_panel.Controls.Add(this.settings_panel_sv_text);
            this.settings_panel.Location = new System.Drawing.Point(205, 107);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(224, 288);
            this.settings_panel.TabIndex = 3;
            this.settings_panel.Visible = false;
            // 
            // settings_panel_close
            // 
            this.settings_panel_close.BackgroundImage = global::n_tube.Properties.Resources.multiply_32px;
            this.settings_panel_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_panel_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_panel_close.Location = new System.Drawing.Point(196, 3);
            this.settings_panel_close.Name = "settings_panel_close";
            this.settings_panel_close.Size = new System.Drawing.Size(25, 25);
            this.settings_panel_close.TabIndex = 4;
            this.settings_panel_close.UseVisualStyleBackColor = true;
            this.settings_panel_close.Click += new System.EventHandler(this.settings_panel_close_Click);
            // 
            // format_box
            // 
            this.format_box.FormattingEnabled = true;
            this.format_box.Location = new System.Drawing.Point(37, 218);
            this.format_box.Name = "format_box";
            this.format_box.Size = new System.Drawing.Size(159, 21);
            this.format_box.TabIndex = 3;
            this.format_box.SelectionChangeCommitted += new System.EventHandler(this.format_box_SelectionChangeCommitted);
            // 
            // settings_panel_set_path
            // 
            this.settings_panel_set_path.BackColor = System.Drawing.Color.Indigo;
            this.settings_panel_set_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_panel_set_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_panel_set_path.Location = new System.Drawing.Point(140, 57);
            this.settings_panel_set_path.Name = "settings_panel_set_path";
            this.settings_panel_set_path.Size = new System.Drawing.Size(56, 24);
            this.settings_panel_set_path.TabIndex = 2;
            this.settings_panel_set_path.Text = "edit";
            this.settings_panel_set_path.UseVisualStyleBackColor = false;
            this.settings_panel_set_path.Click += new System.EventHandler(this.settings_panel_set_path_Click);
            // 
            // sv_path
            // 
            this.sv_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sv_path.ForeColor = System.Drawing.SystemColors.Control;
            this.sv_path.Location = new System.Drawing.Point(34, 90);
            this.sv_path.Name = "sv_path";
            this.sv_path.Size = new System.Drawing.Size(162, 78);
            this.sv_path.TabIndex = 1;
            this.sv_path.Text = "C:\\Users\\ACER\\Documents\\project\\pySharp\\bin\\Debug\\netcoreapp3.1";
            // 
            // settings_panel_at_txt
            // 
            this.settings_panel_at_txt.AutoSize = true;
            this.settings_panel_at_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_panel_at_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.settings_panel_at_txt.Location = new System.Drawing.Point(34, 65);
            this.settings_panel_at_txt.Name = "settings_panel_at_txt";
            this.settings_panel_at_txt.Size = new System.Drawing.Size(19, 16);
            this.settings_panel_at_txt.TabIndex = 1;
            this.settings_panel_at_txt.Text = "at";
            // 
            // searchin_txt
            // 
            this.searchin_txt.AutoSize = true;
            this.searchin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchin_txt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchin_txt.Location = new System.Drawing.Point(373, 31);
            this.searchin_txt.Name = "searchin_txt";
            this.searchin_txt.Size = new System.Drawing.Size(156, 31);
            this.searchin_txt.TabIndex = 0;
            this.searchin_txt.Text = "searching...";
            this.searchin_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchin_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::n_tube.Properties.Resources.Asset_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.searchin_txt);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Label settings_panel_sv_text;
        private System.Windows.Forms.Label settings_panel_as_txt;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.ComboBox format_box;
        private System.Windows.Forms.Button settings_panel_set_path;
        private System.Windows.Forms.Label sv_path;
        private System.Windows.Forms.Label settings_panel_at_txt;
        private System.Windows.Forms.Button settings_panel_close;
        private System.Windows.Forms.FolderBrowserDialog save_dir;
        private System.Windows.Forms.Label searchin_txt;
    }
}