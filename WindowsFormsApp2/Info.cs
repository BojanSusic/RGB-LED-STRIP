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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            label4.Hide();
        }
        /// <summary>
        /// Close the form.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// A click on image opens source code in browser.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BojanSusic/RGB-LED-STRIP");
        }
        /// <summary>
        /// Copy email to clipboard when clicked.
        /// Shows label14 hides it afterwards.
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("bojansusic8@gmail.com");
            label4.Show();
            //?
            Task.Delay(8000).Wait();
            label4.Hide();
        }
    }
}
