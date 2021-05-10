
namespace n_tube
{
    partial class Links
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
            this.url_entry = new System.Windows.Forms.TextBox();
            this.parameters = new System.Windows.Forms.Panel();
            this.format_box = new System.Windows.Forms.ComboBox();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.frmt_lbl = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.web_preview = new System.Windows.Forms.WebBrowser();
            this.download_btn = new System.Windows.Forms.Button();
            this.save_path = new System.Windows.Forms.Button();
            this.sv_p_lbl = new System.Windows.Forms.Label();
            this.save_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.parameters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // url_entry
            // 
            this.url_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.url_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_entry.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.url_entry.Location = new System.Drawing.Point(57, 85);
            this.url_entry.Margin = new System.Windows.Forms.Padding(7);
            this.url_entry.Name = "url_entry";
            this.url_entry.Size = new System.Drawing.Size(479, 22);
            this.url_entry.TabIndex = 0;
            this.url_entry.TextChanged += new System.EventHandler(this.url_entry_TextChanged);
            // 
            // parameters
            // 
            this.parameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parameters.Controls.Add(this.format_box);
            this.parameters.Controls.Add(this.type_box);
            this.parameters.Controls.Add(this.frmt_lbl);
            this.parameters.Controls.Add(this.type_lbl);
            this.parameters.Location = new System.Drawing.Point(377, 128);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(225, 178);
            this.parameters.TabIndex = 2;
            // 
            // format_box
            // 
            this.format_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.format_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.format_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.format_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.format_box.FormattingEnabled = true;
            this.format_box.ItemHeight = 16;
            this.format_box.Location = new System.Drawing.Point(91, 107);
            this.format_box.Margin = new System.Windows.Forms.Padding(0);
            this.format_box.Name = "format_box";
            this.format_box.Size = new System.Drawing.Size(121, 24);
            this.format_box.TabIndex = 1;
            // 
            // type_box
            // 
            this.type_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.type_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.type_box.FormattingEnabled = true;
            this.type_box.ItemHeight = 16;
            this.type_box.Location = new System.Drawing.Point(91, 39);
            this.type_box.Margin = new System.Windows.Forms.Padding(0);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(121, 24);
            this.type_box.TabIndex = 1;
            // 
            // frmt_lbl
            // 
            this.frmt_lbl.AutoSize = true;
            this.frmt_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmt_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.frmt_lbl.Location = new System.Drawing.Point(16, 107);
            this.frmt_lbl.Name = "frmt_lbl";
            this.frmt_lbl.Size = new System.Drawing.Size(68, 17);
            this.frmt_lbl.TabIndex = 0;
            this.frmt_lbl.Text = "Format :";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.type_lbl.Location = new System.Drawing.Point(16, 39);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(69, 17);
            this.type_lbl.TabIndex = 0;
            this.type_lbl.Text = "Type    :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.title.Location = new System.Drawing.Point(34, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(306, 51);
            this.title.TabIndex = 3;
            this.title.Text = "Enter the URL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.web_preview);
            this.panel2.Location = new System.Drawing.Point(80, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 178);
            this.panel2.TabIndex = 4;
            // 
            // web_preview
            // 
            this.web_preview.AllowWebBrowserDrop = false;
            this.web_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_preview.IsWebBrowserContextMenuEnabled = false;
            this.web_preview.Location = new System.Drawing.Point(0, 0);
            this.web_preview.Margin = new System.Windows.Forms.Padding(0);
            this.web_preview.Name = "web_preview";
            this.web_preview.ScrollBarsEnabled = false;
            this.web_preview.Size = new System.Drawing.Size(278, 178);
            this.web_preview.TabIndex = 0;
            this.web_preview.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // download_btn
            // 
            this.download_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.download_btn.FlatAppearance.BorderSize = 0;
            this.download_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.download_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_btn.Image = global::n_tube.Properties.Resources.download_32px;
            this.download_btn.Location = new System.Drawing.Point(525, 408);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(77, 43);
            this.download_btn.TabIndex = 1;
            this.download_btn.UseVisualStyleBackColor = false;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // save_path
            // 
            this.save_path.BackColor = System.Drawing.Color.Black;
            this.save_path.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save_path.FlatAppearance.BorderSize = 2;
            this.save_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_path.ForeColor = System.Drawing.SystemColors.Control;
            this.save_path.Location = new System.Drawing.Point(23, 440);
            this.save_path.Name = "save_path";
            this.save_path.Size = new System.Drawing.Size(65, 31);
            this.save_path.TabIndex = 5;
            this.save_path.Text = "save at";
            this.save_path.UseVisualStyleBackColor = false;
            this.save_path.Click += new System.EventHandler(this.save_path_Click);
            // 
            // sv_p_lbl
            // 
            this.sv_p_lbl.AutoSize = true;
            this.sv_p_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sv_p_lbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.sv_p_lbl.Location = new System.Drawing.Point(94, 447);
            this.sv_p_lbl.Name = "sv_p_lbl";
            this.sv_p_lbl.Size = new System.Drawing.Size(100, 17);
            this.sv_p_lbl.TabIndex = 6;
            this.sv_p_lbl.Text = ":->default path";
            // 
            // Links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::n_tube.Properties.Resources.Asset_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.sv_p_lbl);
            this.Controls.Add(this.save_path);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.url_entry);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.parameters);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Links";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Links";
            this.parameters.ResumeLayout(false);
            this.parameters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_entry;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Panel parameters;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label frmt_lbl;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser web_preview;
        private System.Windows.Forms.ComboBox format_box;
        private System.Windows.Forms.Button save_path;
        private System.Windows.Forms.Label sv_p_lbl;
        private System.Windows.Forms.FolderBrowserDialog save_dir;
    }
}