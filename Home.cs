using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_tube
{
    public partial class Home : Form
    {
        public bool menu_open;
        public bridge back;
        public List<Video> vids;
        private Panel search_res;
        private Panel padd;

        public Home(bridge back_ref)
        {
            back = back_ref;
            

            InitializeComponent();

            search_res = new Panel();
            search_res.Dock = DockStyle.Bottom;
            search_res.Height = 405;
            search_res.BringToFront();
            search_res.BackgroundImage = n_tube.Properties.Resources.Asset_14;
            search_res.BackgroundImageLayout = ImageLayout.Zoom;
            search_res.AutoScroll = true;
            search_res.Show();
            this.Controls.Add(search_res);
            
            searchin_txt.Hide();

            padd = new Panel();
            padd.Dock = DockStyle.Bottom;
            padd.Height = 20;
            padd.BringToFront();
            padd.Show();
            search_res.Controls.Add(padd);

            settings_panel.Hide();
            menu_open = false;

            vids = new List<Video>();

            List<Obj> formats = new List<Obj>();
            formats.Add(new Obj { flag = "m4h", name = "mp4(720p)" });
            formats.Add(new Obj { flag = "m4l", name = "mp4(320p)" });
            formats.Add(new Obj { flag = "m3", name = "mp3" });
            format_box.DataSource = formats;
            format_box.DisplayMember = "name";
            format_box.ValueMember = "flag";

            sv_path.Text = back.getPath();


            populate();

        }

        private void deRender()
        {
            foreach (var vid in vids)
            {
                vid.remove();
            }

            vids.Clear();
        }

        private void populate()
        {
            string[] videos = File.ReadAllText("./nBack/search_results.txt").Split('=');

            foreach (var vid in videos)
            {
                vids.Add(new Video(search_res, vid, back));
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            if (!menu_open)
                settings_panel.Show();
            else
                settings_panel.Hide();

            settings_panel.BringToFront();
            menu_open = !menu_open;
        }

        private void settings_panel_close_Click(object sender, EventArgs e)
        {
            settings_panel.Hide();
        }

        private void settings_panel_set_path_Click(object sender, EventArgs e)
        {
            save_dir.ShowNewFolderButton = true;
            save_dir.ShowDialog();
            back.setPath(save_dir.SelectedPath);
        }

        private void search()
        {

            deRender();
            searchin_txt.BringToFront();
            searchin_txt.Show();

            back.search(search_box.Text);
            
            searchin_txt.Hide();
            populate();
            

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search();
        }

        public void refreshPath()
        {
            sv_path.Text = back.getPath();

            foreach (var vid in vids)
            {
                vid.refresh();
            }
        }


        private void format_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Obj choice = format_box.SelectedItem as Obj;
            back.setQlty(choice.flag);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
