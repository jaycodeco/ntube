using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_tube
{
    public partial class Main : Form
    {
        public Home home_panel;
        public Links links_panel;
        public Downloads downloads_panel;
        public About about_panel;
        public Form active_pan;
        private Button active_btn;
        public bridge back;


        //initialising data for dragable window
        int mouseX = 0, mouseY = 0, Xdis, Ydis;
        Boolean mousedown, blocked=true;
        //end of initialisation



        public Main()
        {
            back = new bridge();
            back.Main();

            InitializeComponent();

            home_panel =  new Home(back);
            links_panel = new Links(back);
            downloads_panel = new Downloads(back);
            about_panel = new About();


        }



        #region formAction

        private void getSubForm(Form Child)
        {    
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            main_sec.Controls.Add(Child);
            main_sec.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }

        private void togleToActive(Button btn, Form frm)
        {
            if (active_btn != btn)
            {
                home_btn.BackColor = Color.FromArgb(30, 30, 30);
                links_btn.BackColor = Color.FromArgb(30, 30, 30);
                downloads_btn.BackColor = Color.FromArgb(30, 30, 30);
                about_btn.BackColor = Color.FromArgb(30, 30, 30);


                home_panel.Hide();
                links_panel.Hide();
                downloads_panel.Hide();
                about_panel.Hide();

                active_btn= btn;
                getSubForm(frm);

                btn.BackColor = Color.FromArgb(35, 35, 35);
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            togleToActive(home_btn, home_panel);
        }

        private void links_btn_Click(object sender, EventArgs e)
        {
            togleToActive(links_btn,links_panel);
        }

        private void downloads_btn_Click(object sender, EventArgs e)
        {
            togleToActive(downloads_btn,downloads_panel);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            togleToActive(about_btn, about_panel);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            home_panel.refreshPath();
            links_panel.refreshPath();
        }

        #endregion

        #region movable topbar

        private void size()
        {
            if (blocked) 
            { 
                Xdis = this.DesktopLocation.X - MousePosition.X;
                Ydis = this.DesktopLocation.Y - MousePosition.Y;

                blocked = false;
            }
        }
        private void top_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                
                mouseX = MousePosition.X + Xdis;
                mouseY = MousePosition.Y + Ydis;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void top_bar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
            blocked = true;
        }

        private void top_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            size();
        }

        #endregion
    }
}
