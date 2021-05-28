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

namespace file_organization_project
{
    public partial class Insert : Form
    {
        private string file;
        private Form main;
        private static int rec_size = 60;
        public Insert()
        {
            InitializeComponent();
        }
        public Insert(string filename, Form main)
        {
            file = filename;
            this.main = main;
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            this.filename.Text = file;
            BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            records.Text = (length / rec_size).ToString();
            filesize.Text = length.ToString();
            bw.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.Write));
            try
            {
                int length = (int)bw.BaseStream.Length;
                if (length != 0)
                {
                    bw.BaseStream.Seek(length, SeekOrigin.Begin);
                }
                bw.Write(int.Parse(id.Text));
                name.Text = name.Text.PadRight(11);
                bw.Write(name.Text.Substring(0, 11));
                author.Text = author.Text.PadRight(9);
                bw.Write(author.Text.Substring(0, 9));
                description.Text = description.Text.PadRight(19);
                bw.Write(description.Text.Substring(0, 19));
                bw.Write(int.Parse(year.Text));
                edition.Text = edition.Text.PadRight(5);
                bw.Write(edition.Text.Substring(0, 5));
                bw.Write(float.Parse(rate.Text));

                length += rec_size;
                id.Text = name.Text = author.Text = description.Text = year.Text = edition.Text = rate.Text = "";
                records.Text = (length/rec_size).ToString();
                filesize.Text = length.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            bw.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }
    }
}
