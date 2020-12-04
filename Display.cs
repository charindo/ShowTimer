using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            setDisplayTime();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setDisplayTime();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            setDisplayTime();
        }

        private void setDisplayTime()
        {
            timeNow.Text = DateTime.Now.ToString("HH時mm分 ss秒");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
