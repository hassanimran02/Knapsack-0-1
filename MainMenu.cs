using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class MainMenu : Form
    {
        
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Warehouse wh = new Warehouse();
            wh.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gallery glr = new Gallery();
            glr.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
