using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_tube
{
    public partial class Links : Form
    {
        public bridge back;
        

        public Links(bridge back_ref)
        {
            back = back_ref;
            
            

            InitializeComponent();
            

            List<Obj> formats = new List<Obj>();
            formats.Add(new Obj { flag="m4h", name = "mp4(720p)"});
            formats.Add(new Obj { flag="m4l", name= "mp4(320p)" });
            formats.Add(new Obj { flag="m3", name="mp3"});
            format_box.DataSource = formats;
            format_box.DisplayMember = "name";
            format_box.ValueMember = "flag";


            List<Obj> types = new List<Obj>();
            types.Add(new Obj { flag = "--url", name = "url" });
            types.Add(new Obj { flag = "--file", name = "file" });
            types.Add(new Obj { flag = "--list", name = "playlist" });
            type_box.DataSource = types;
            type_box.DisplayMember = "name";
            type_box.ValueMember = "flag";


            back.setDQlty("m4h");
            back.setDFmt("--url");

            web_preview.Margin =new Padding(0);
            

            sv_p_lbl.Text = back.getPath();
            //int x = int(100.2);
        }

        private void download_vid()
        {
            back.download(back.getDFmt(), back.getDQlty(), url_entry.Text);
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            
            Thread dwn = new Thread(download_vid);
            dwn.Start();

        }


        public void refreshPath()
        {
            sv_p_lbl.Text = back.getPath();
            
        }

        private void save_path_Click(object sender, EventArgs e)
        {
            save_dir.ShowNewFolderButton = true;
            save_dir.ShowDialog();
            back.setPath(save_dir.SelectedPath);
        }

        private void url_entry_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string vid_id = url_entry.Text.Split('=')[1];
                string vid_img = $"https://i.ytimg.com/vi/{vid_id}/mqdefault.jpg";
                //web_preview.Url = new Uri(vid_img);
                web_preview.DocumentText = "<style> " +
                                 "body { " +
                                    "margin: 0; " +
                                    "padding: 0; " +
                                  "} " +
                            "</style> "+
                            $"<img src='{vid_img}' />";

            }
            catch(Exception)
            {
                string vid_img = "https://i.ytimg.com/vi/null/mqdefault.jpg";
                web_preview.Url = null;
            }
        }
    }
}
