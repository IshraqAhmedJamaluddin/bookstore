﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (change == "modify")
            {
                new Modify(file, main).Show();
            }
            else // search
            {
                new Search(file, main).Show();
            }
            Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }
    }
}
