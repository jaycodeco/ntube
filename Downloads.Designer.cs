
namespace n_tube
{
    partial class Downloads
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
            this.title = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.history_pannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.title.Location = new System.Drawing.Point(19, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(187, 29);
            this.title.TabIndex = 1;
            this.title.Text = "Downloded files";
            // 
            // clear_btn
            // 
            this.clear_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear_btn.Location = new System.Drawing.Point(532, 12);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 33);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // history_pannel
            // 
            this.history_pannel.AutoScroll = true;
            this.history_pannel.BackgroundImage = global::n_tube.Properties.Resources.Asset_14;
            this.history_pannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.history_pannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.history_pannel.Location = new System.Drawing.Point(0, 51);
            this.history_pannel.Name = "history_pannel";
            this.history_pannel.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.history_pannel.Size = new System.Drawing.Size(630, 428);
            this.history_pannel.TabIndex = 3;
            // 
            // Downloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::n_tube.Properties.Resources.Asset_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.history_pannel);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Downloads";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Downloads";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Panel history_pannel;
    }
}