using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace n_tube
{
    public class Video
    {
        private Panel r1;

        private WebBrowser img_scr;
        private Panel r2;
        private Button dwn_btn;
        private Label name;
        public ProgressBar lvl;
        private static int x = 0;
        private static int y = 0;
        private string[] props;
        public bridge back;
        private int prog_val;


        public Video(Panel Cont, string data, bridge back_ref)
        {
            back = back_ref;


            props = data.Split('^');



            r1 = new Panel();
            
            img_scr = new WebBrowser();
            dwn_btn = new Button();
            name = new Label();
            r2 = new Panel();
            lvl = new ProgressBar();



            lvl.Height = 10;
            lvl.BringToFront();
            lvl.Value = 0;
            lvl.Dock = DockStyle.Bottom;
            lvl.Hide();

            r1.BackColor = Color.FromArgb(50,50,50);


            r1.Left = 20 + (x * 20) + (x++ * 280);
            r1.Top  = 20 + (y * 20) + (y * 200);
            r1.Width = 280;
            r1.Height = 200;
            r2.Height = 50;
            dwn_btn.Width = 45;
            dwn_btn.Image = n_tube.Properties.Resources.download_32px;
            dwn_btn.ImageAlign = ContentAlignment.MiddleCenter;
            dwn_btn.FlatStyle = FlatStyle.Flat;
            dwn_btn.BackColor = Color.Black;


            name.Text = props[1];
            name.ForeColor = Color.White;
            name.Width = 230;
            name.Padding = new Padding(5);
            name.Dock = DockStyle.Left;


            img_scr.Height = 150;
            img_scr.ScrollBarsEnabled = false;
            img_scr.Dock = DockStyle.Top;
            r2.Dock = DockStyle.Bottom;
            dwn_btn.Dock = DockStyle.Right;

            //img_scr.Url = new Uri(props[2]);

            img_scr.DocumentText = "<style> " +
                                 "body { " +
                                    "margin: 0; " +
                                    "padding: 0; " +
                                  "} " +
                                  "img {"+
                                    "width: 20px"+
                                    "height: 10px"+
                                  "}" +
                            "</style> " +
                            $"<img src='{props[2]}' />";

            Cont.Controls.Add(r1);
            r1.BringToFront();
            r1.Controls.Add(img_scr);
            r1.Controls.Add(r2);
            r2.Controls.Add(dwn_btn);
            r2.Controls.Add(name);
            r2.Controls.Add(lvl);

            if (x == 2)
            {
                x = 0;
                y++;
            }

            dwn_btn.Click += new EventHandler(dwn_btn_Click);
        }
        
        public void remove()
        {
            r1.Dispose();
            x = 0;
            y = 0;
        }
        private void download()
        {

            back.download("--chc", back.getQlty(), props[0]);

        }

       

        private void dwn_btn_Click(object sender, EventArgs e)
        {

            lvl.Show();
            Thread dwn = new Thread(download);
            dwn.Start();

            

        }


        public void refresh()
        {
            try { 
            prog_val = int.Parse(File.ReadAllText($"./nBack/{props[0]}.txt").Split('.')[0]);
            }
            catch(Exception)
            {
                string t = "ehbd";
            }

            lvl.Value = prog_val;
        }

    }
}
