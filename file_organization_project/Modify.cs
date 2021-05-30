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
    public partial class Modify : Form
    {
        private string file;
        private Form main;
        int key;
        private static int rec_size = 60;
        private int count = 0;
        private int toChange = -1;
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(string filename, Form main, int key)
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

        private void Modify_Load(object sender, EventArgs e)
        {
            this.filename.Text = file;
            bool isFound = false;
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
                    while (!((count / rec_size) >= (length / rec_size - 1)))
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
                            isFound = true;
                            toChange = count;
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
        }

        private void save_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.Write));
            try
            {
                if (toChange == -1)
                {
                    MessageBox.Show("Coulnd't find ID!");
                }
                else
                {
                    bw.BaseStream.Seek(toChange, SeekOrigin.Begin);

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
                    MessageBox.Show("Saved Successfully");
                }
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
