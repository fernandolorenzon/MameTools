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

namespace MameTools
{
    public partial class FormTools : Form
    {
        public FormTools()
        {
            InitializeComponent();
        }

        private void buttonMoveFound_Click(object sender, EventArgs e)
        {
            Move(true);
        }

        private void buttonMoveNotFound_Click(object sender, EventArgs e)
        {
            Move(false);
        }

        private void Move(bool movefound)
        {
            labelCount.Text = "0";
            if (textBoxSource.Text == "")
            {
                MessageBox.Show("Select source folder");
                return;
            }

            if (textBoxDestination.Text == "")
            {
                MessageBox.Show("Select destination folder");
                return;
            }

            if (richTextBox.Text == "")
            {
                MessageBox.Show("Insert list");
                return;
            }

            if (!Directory.Exists(textBoxSource.Text)) return;
            if (!Directory.Exists(textBoxDestination.Text)) return;

            string separator = richTextBox.Text.IndexOf("\r\n") > -1 ? "\r\n" : "\n";

            var files = Directory.GetFiles(textBoxSource.Text, "*.*", SearchOption.TopDirectoryOnly).ToList();
            var list = richTextBox.Text.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string file = "";

            int count = 0;

            foreach (var path in files)
            {
                if (radioButtonFullName.Checked)
                {
                    file = GetFileName(path);
                }
                else
                {
                    file = GetFileNameNoExtension(path);
                }

                if (movefound)
                {
                    if (list.Any(x => x == file))
                    {
                        if (radioButtonFullName.Checked)
                        {
                            File.Move(path, textBoxDestination.Text + "\\" + file);
                        }
                        else
                        {
                            File.Move(path, textBoxDestination.Text + "\\" + file + GetFileExtension(path));
                        }

                        count++;
                    }
                }
                else
                {
                    if (!list.Any(x => x == file))
                    {
                        if (radioButtonFullName.Checked)
                        {
                            File.Move(path, textBoxDestination.Text + "\\" + file);
                        }
                        else
                        {
                            File.Move(path, textBoxDestination.Text + "\\" + file + GetFileExtension(path));
                        }

                        count++;
                    }
                }

                labelCount.Text = count.ToString();
                labelCount.Refresh();
            }

            MessageBox.Show("Success!");
        }

        public static string GetFileExtension(string file)
        {
            if (string.IsNullOrEmpty(file)) return "";
            return file.Substring(file.LastIndexOf("."));
        }

        public static string GetFileName(string file)
        {
            if (string.IsNullOrEmpty(file)) return "";
            return file.Substring(file.LastIndexOf("\\") + 1);
        }

        public static string GetFileNameNoExtension(string file)
        {
            if (string.IsNullOrEmpty(file)) return "";
            var fileName = file.Substring(file.LastIndexOf("\\") + 1);
            var indexExtension = fileName.LastIndexOf(".");

            if (indexExtension == -1)
            {
                return fileName;
            }
            else
            {
                return fileName.Substring(0, fileName.LastIndexOf("."));
            }
        }

        private void buttonListFolder_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            var files = Directory.GetFiles(dialog.SelectedPath);

            foreach (var file in files)
            {
                richTextBox.Text += GetFileNameNoExtension(file) + "\r\n";
            }
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            textBoxSource.Text = dialog.SelectedPath;
        }

        private void buttonDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            textBoxDestination.Text = dialog.SelectedPath;
        }
    }
}
