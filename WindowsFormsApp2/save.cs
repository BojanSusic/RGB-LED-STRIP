using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class save : Form
    {
        
        public int otvorena=1;
        
        /// <summary>
        /// Class used for saving a preset profile.
        /// </summary>
        public save()
        {
            InitializeComponent();
            Set_lbImena_Items();
        }

        /// <summary>
        /// Opens xml file "buttons.xml" and all nodes with name "ime" adds them to "listBox2".
        /// If it is not possible to open xml file MessageBox will show a message.
        /// </summary>
        private void Set_lbImena_Items() {
            XmlTextReader xmlR = new XmlTextReader("buttons.xml");
            try
            {
                DataSet dsProfiles = new DataSet();
                dsProfiles.ReadXml("buttons.xml");
                for (int i = 0; i < 20; i++)
                {
                   lbImena.Items.Add(dsProfiles.Tables[0].Rows[i].ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file\nWrong name or the file does not exist");
            }
        }

        /// <summary>
        /// When "Enter" key pressed it calls the button3_Click method
        /// </summary>
        /// <see cref="button3_Click(object, EventArgs)"/>
        /// <param name="e">Key got from keyboard</param>
        private void tbNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        /// <summary>
        /// Method changes xml node selected in listBox2.
        /// node "ime" is set as textBox1 text
        /// node "set" is set as a string returned by method "napravi_Set"
        /// </summary>
        private void Promijeni_Polje() {
            DataSet dsProfiles = new DataSet();
            dsProfiles.ReadXml("buttons.xml");
            dsProfiles.Tables[0].Rows[lbImena.SelectedIndex]["ime"] = tbNaziv.Text.ToString();
            dsProfiles.Tables[0].Rows[lbImena.SelectedIndex]["set"] = Napravi_Set();
            dsProfiles.WriteXml("buttons.xml");
        }
        /// <summary>
        /// This method creates a 9 character string (3 characters for each color).
        /// Gets background color and makes strings setR, setG and setB. 
        /// <see cref="main.button1_Click_1(object, EventArgs)"/> for background color explanation.
        /// </summary>
        /// <returns>Returns a 9 character string, RedGreenBlue respectively</returns>
        public string Napravi_Set() {
            string setR;
            string setG;
            string setB;
            setR = this.BackColor.R.ToString("D3");
            setG = this.BackColor.G.ToString("D3");
            setB = this.BackColor.B.ToString("D3");
            return setR + setG + setB;
        }

        /// <summary>
        /// Gets color.
        /// </summary>
        public string Boja(string ulazna_boja) {
            return ulazna_boja;
        }

        /// <summary>
        /// Closes form without saving profile.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// If listbox2 item is selected and textbox1 text is not empty call promijeni_polje() and close form
        /// or show appropriate message.
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text.Length > 0 && lbImena.SelectedItem != null)
            {
                Promijeni_Polje();
                Close();
            }
            else if (tbNaziv.Text.Length < 1)
            {
                MessageBox.Show("Profile name not specified!");
            }
            else if (lbImena.SelectedItem == null)
            {
                MessageBox.Show("Profile slot not selected!");
            }
            else
                MessageBox.Show("Unexpected error!");
        }
    }
}
