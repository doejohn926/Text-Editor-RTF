using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Текстовый_редактор_RTF
{
    class Menu
    {
        private string nameRtf = ".rtf";
        private string nameTxt = ".txt";
        private string lastPath = "";
        private RichTextBox rtb;

        public Menu(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        public void SaveDocument(string path)
        {
            lastPath = path;

            if (path.EndsWith(nameRtf))
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.WriteLine(rtb.Rtf);
                    sw.Close();
                }
            }
            else if (path.EndsWith(nameTxt))
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.WriteLine(rtb.Text);
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Программа не поддерживает данное расширение выбранного вами файла");
            }
        }

        public void OpenFile(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(nameRtf))
                {
                    rtb.Rtf = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                    lastPath = ofd.FileName;
                }
                else if (ofd.FileName.EndsWith(nameTxt))
                {
                    rtb.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                    lastPath = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Программа не поддерживает данное расширение выбранного вами файла");
                }
            }
        }

        public void GlobalOpenFile()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2)
            {
                StreamReader sr = new StreamReader(args[1], Encoding.UTF8);

                if (args[1].ToString().EndsWith(nameRtf))
                {
                    rtb.Rtf = sr.ReadToEnd();
                    lastPath = args[1].ToString();
                }
                else if (args[1].ToString().EndsWith(nameTxt))
                {
                    rtb.Text = sr.ReadToEnd();
                    lastPath = args[1].ToString();
                }
                else
                {
                    MessageBox.Show("Программа не поддерживает данное расширение выбранного вами файла");
                }
            }
        }

        public void SaveFile(SaveFileDialog sfd)
        {
            if (lastPath != "")
            {
                SaveDocument(lastPath);
            }
            else
            {
                SaveAsFile(sfd);
            }
        }

        public void SaveAsFile(SaveFileDialog sfd)
        {
            sfd.DefaultExt = "* .rtf |* .txt";
            sfd.Filter = "RTF Files |* .rtf |TXT Files |* .txt";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                lastPath = sfd.FileName;
                SaveDocument(lastPath);
            }
        }

        public void ExitingTheApplication()
        {
            Application.Exit();
        }

        public void ClearAll()
        {
            rtb.Text = "";
        }

        public void SelectAll()
        {
            int count = rtb.TextLength;
            rtb.Select(0, count);
        }
    }
}
