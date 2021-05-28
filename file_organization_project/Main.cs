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
    public partial class bookstore : Form
    {
        public bookstore()
        {
            InitializeComponent();
        }

        private string file;

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                file = filename.Text + ".txt";
                if (!File.Exists(file))
                {
                    File.Create(file).Close();
                    MessageBox.Show("File is created");
                }
                else
                {
                    MessageBox.Show("File already exists");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                file = filename.Text + ".txt";
                if (File.Exists(file))
                {
                    File.Delete(file);
                    MessageBox.Show("File is deleted");
                }
                else
                {
                    MessageBox.Show("File doesn't exist");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            file = filename.Text + ".txt";
            if (File.Exists(file))
            {
                new Insert(file, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            file = filename.Text + ".txt";
            if (File.Exists(file))
            {
                new Display(file, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            file = filename.Text + ".txt";
            if (File.Exists(file))
            {
                new GetID("search", file, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            file = filename.Text + ".txt";
            if (File.Exists(file))
            {
                new GetID("modify", file, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
