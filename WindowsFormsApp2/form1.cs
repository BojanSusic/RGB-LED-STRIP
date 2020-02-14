using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets Form border to none.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;  
        }

        /// <summary>
        /// Starts timer, waits and then closes form.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();

        }
    }
}
