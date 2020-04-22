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
        /// <summary>
        /// About application.
        /// </summary>
        public Info()
        {
            InitializeComponent();
            lblNotif.Hide();
        }
        /// <summary>
        /// Close the form.
        /// </summary>
        private void btnClick_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// A click on image opens source code in browser.
        /// </summary>
        private void pbGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BojanSusic/RGB-LED-STRIP");
        }
        /// <summary>
        /// Copy email to clipboard when clicked.
        /// Shows label14 hides it afterwards.
        /// </summary>
        private void llMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("bojansusic8@gmail.com");
            lblNotif.Show();
            //?
            Task.Delay(6000).Wait();
            lblNotif.Hide();
        }
    }
}
