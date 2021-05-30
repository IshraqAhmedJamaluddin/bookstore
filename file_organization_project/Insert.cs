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
        private static int count = 0;
        public Insert()
        {
            InitializeComponent();
        }
        public Insert(string filename, Form main)
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
            try
            {
                int checkID = (int.Parse(id.Text));
                bool isFound = false;
                if (checkID <= 0)
                {
                    MessageBox.Show("Enter a positive number for ID.");
                }
                BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read));
                try
                {
                    int length = (int)br.BaseStream.Length;
                    if (length != 0)
                    {
                        while (!((count / rec_size) >= (length / rec_size)))
                        {
                            br.BaseStream.Seek(count, SeekOrigin.Begin);
                            int currentId = br.ReadInt32();
                            if (currentId == checkID)
                            {
                                MessageBox.Show("ID already exists!");
                                isFound = true;
                                break;
                            }

                            count += rec_size;
                        }
                        count = 0;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                br.Close();

                if ((!isFound) && checkID > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.Write));
                    try
                    {
                        int length = (int)bw.BaseStream.Length;
                        if (length != 0)
                        {
                            bw.BaseStream.Seek(length, SeekOrigin.Begin);
                        }
                        bw.Write(checkID);
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
                        records.Text = (length / rec_size).ToString();
                        filesize.Text = length.ToString();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    bw.Close();
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
