using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppGit
{

    public partial class Form1 : Form
    {

        // zmena martin
        public int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Ahoj!";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((i % 2) != 0)
            {
                button1.BackColor = Color.Red;
                i++;
            }
            else
            {
                button1.BackColor = Color.Empty;
                i++;
            }
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Empty;
        }
    }
}
