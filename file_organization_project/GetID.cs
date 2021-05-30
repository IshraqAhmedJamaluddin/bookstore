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
    public partial class GetID : Form
    {
        private string change, file;
        private Form main;
        public GetID()
        {
            InitializeComponent();
        }

        public GetID(string target, string filename, Form main)
        {
            try
            {
                change = target;
                file = filename;
                this.main = main;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void get_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Int32.Parse(id.Text);
                bool isFound = false;
                int count = 0;
                int rec_size = 60;
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
                        while (!((count / rec_size) >= (length / rec_size)))
                        {
                            br.BaseStream.Seek(count, SeekOrigin.Begin);
                            int currentId = br.ReadInt32();
                            if (currentId == key)
                            {
                                isFound = true;
                                break;
                            }
                            count += rec_size;
                        }
                        
                        if (!isFound)
                        {
                            MessageBox.Show("ID not found!");
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                br.Close();
                if (isFound)
                {
                    if (change == "modify")
                    {
                        new Modify(file, main, key).Show();
                    }
                    else // search
                    {
                        new Search(file, main, key).Show();
                    }
                    Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }
    }
}
