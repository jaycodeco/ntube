using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_tube
{
    public class bridge
    {
        private static dynamic psi;
        private static string s_path;
        private static string v_tty;
        private static string d_v_tty;
        private static string d_v_fmt;

        public void Main()
        {
            psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\ACER\AppData\Local\Programs\Python\Python39\python.exe";

            s_path = File.ReadAllText("./nBack/path.txt");
            v_tty = "m4h";
        }



        static string execute(string prms)
        {
            //var script1 = @"../../script.py";
            string script = @"./nBack/script.py";
            psi.Arguments = $"./{script} {prms}";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errs = "";
            var res = "";

            using (dynamic process = Process.Start(psi))
            {
                errs = process.StandardError.ReadToEnd();
                res = process.StandardOutput.ReadToEnd();
            }

            return res;
        }


        public string getPath()
        {
            return s_path;
        }

        public void setPath(string term)
        {
            s_path = term;
            File.WriteAllText("./nBack/path.txt", term);
        }


        public string getQlty()
        {
            return v_tty;
        }

        public void setQlty(string term)
        {
            v_tty = term;
        }



        public string getDQlty()
        {
            return d_v_tty;
        }

        public void setDQlty(string term)
        {
            d_v_tty = term;
        }



        public string getDFmt()
        {
            return d_v_fmt;
        }

        public void setDFmt(string term)
        {
            d_v_fmt = term;
        }


        public string search(string term)
        {

            string args = $"-s \"{term}\"";
            string data = execute(args);

            return data;
        }


        public string download(string a1, string a2, string a3)
        {

            string args = $"-d {a1} {a2} \"{a3}\"";
            string data = execute(args);

            return data;
        }

    }

}
