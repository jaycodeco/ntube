using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace n_tube
{
    public class Downloaded
    {
        private Panel pan;
        private Label name;
        private Label formate;
        private Label path;
        private Label date;
        private Button close_btn;
        private Panel gap;

        private static int y = 0;

        public Downloaded(Panel container, string data)
        {
            pan       = new Panel();
            name      = new Label();
            formate   = new Label();
            path      = new Label();
            date      = new Label();
            close_btn = new Button();
            gap    = new Panel();

            familiarise(container);

            stucturise();

            populate(data);

            stylize();
        }

        private void familiarise(Panel container)
        {
            container.Controls.Add(pan);
            pan.Controls.Add(name);
            pan.Controls.Add(formate);
            pan.Controls.Add(path);
            pan.Controls.Add(date);
            pan.Controls.Add(close_btn);
            container.Controls.Add(gap);
        }

        private void stucturise()
        {
            pan.Width = 500;
            pan.Height = 76;

            close_btn.Width  = 30;
            close_btn.Height = 30;

            name.Left = 20;
            name.Top = 12;

            formate.Left = 390;
            formate.Top = 12;

            path.Left = 20;
            path.Top = 47;

            date.Left = 390;
            date.Top = 45;

            close_btn.Left = 465;
            close_btn.Top = 0;

            gap.Width = 500;
            gap.Height = 5;


            //pan.Top = (y++ * 96) + 20;
            //pan.Left = 24;


            pan.Dock = DockStyle.Top;
            gap.Dock = DockStyle.Top;


        }

        private void populate(string data)
        {
            string[] data_pack = data.Split('^');

            name.Text    = data_pack[0].Remove('\n');
            formate.Text = data_pack[1];
            path.Text    = data_pack[2];
            date.Text    = data_pack[3]; 
        }

        private void stylize()
        {
            pan.BackColor = Color.Black;

            name.ForeColor = Color.White;
            formate.ForeColor = Color.White;
            path.ForeColor = Color.White;
            date.ForeColor = Color.White;

            close_btn.BackColor = Color.Black;
            close_btn.Text = "";
            close_btn.Name = "close_btn";
            close_btn.Click += new EventHandler(close_btn_Click);
            close_btn.Image = n_tube.Properties.Resources.multiply_32px;
            close_btn.ImageAlign = ContentAlignment.MiddleCenter;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.BringToFront();

        }

        public void remove()
        {
            pan.Dispose();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            pan.Dispose();
            gap.Dispose();
        }
    }
}
