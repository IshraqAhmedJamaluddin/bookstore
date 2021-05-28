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
    public partial class Display : Form
    {
        private string file;
        private Form main;
        private static int rec_size = 60;
        private int count = 0;
        public Display()
        {
            InitializeComponent();
        }
        public Display(string filename, Form main)
        {
            try
            {
                file = filename;
                this.main = main;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            this.filename.Text = file;
            BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read));
            int length = (int)br.BaseStream.Length;
            records.Text = (length / rec_size).ToString();
            filesize.Text = length.ToString();
            br.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read));
            try
            {
                int length = (int)br.BaseStream.Length;
                if (length == 0)
                {
                    MessageBox.Show("Empty File");
                }
                else
                {
                    show.Text = "Next";
                    br.BaseStream.Seek(count, SeekOrigin.Begin);
                    id.Text = br.ReadInt32().ToString();
                    name.Text = br.ReadString();
                    author.Text = br.ReadString();
                    description.Text = br.ReadString();
                    year.Text = br.ReadInt32().ToString();
                    edition.Text = br.ReadString();
                    rate.Text = br.ReadSingle().ToString();

                    records.Text = (length / rec_size).ToString();
                    filesize.Text = length.ToString();

                    if ((count/rec_size) >= (length/rec_size-1))
                    {
                        count = 0;
                    }
                    else
                    {
                        count += rec_size;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            br.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }
    }
}
