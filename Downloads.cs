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
    public partial class Downloads : Form
    {
        public bridge back;
        public List<Downloaded> history;

        public Downloads(bridge back_ref)
        {
            InitializeComponent();

            back = back_ref;

            string[] data = File.ReadAllText("./nBack/download_history.txt").Split('|');



            history = new List<Downloaded>();

            foreach(var be in data)
                history.Add(new Downloaded(history_pannel, be));
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

            foreach(var data in history)
            {
                data.remove();
            }
                
            history.Clear();
        }
    }
}
