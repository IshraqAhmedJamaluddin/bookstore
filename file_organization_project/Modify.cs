using System;
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
    public partial class Modify : Form
    {
        private string file;
        private Form main;
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(string filename, Form main)
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
    }
}
