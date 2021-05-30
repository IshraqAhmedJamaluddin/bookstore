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
    public partial class Search : Form
    {
        private string file;
        private Form main;
        private int key;
        private static int rec_size = 60;
        private int count = 0;
        public Search()
        {
            InitializeComponent();
        }
        public Search(string filename, Form main, int key)
        {
            try
            {
                this.key = key;
                file = filename;
                this.main = main;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.filename.Text = file;
            BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read));
            try
            {
                int length = (int)br.BaseStream.Length;

                while (!((count / rec_size) >= (length / rec_size)))
                {
                    br.BaseStream.Seek(count, SeekOrigin.Begin);
                    int currentId = br.ReadInt32();
                    if (currentId == key)
                    {
                        id.Text = currentId.ToString();
                        name.Text = br.ReadString();
                        author.Text = br.ReadString();
                        description.Text = br.ReadString();
                        year.Text = br.ReadInt32().ToString();
                        edition.Text = br.ReadString();
                        rate.Text = br.ReadSingle().ToString();
                        break;
                    }
                    count += rec_size;
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
