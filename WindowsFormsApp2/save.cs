using System;
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
            set_Listbox_Items();
            
        }

        /// <summary>
        /// Opens xml file "buttons.xml" and all nodes with name "ime" adds them to "listBox2".
        /// If it is not possible to open xml file MessageBox will show a message.
        /// </summary>
        private void set_Listbox_Items() {
            XmlTextReader xmlR = new XmlTextReader("buttons.xml");
            try
            {
                do
                {
                    if (xmlR.NodeType == XmlNodeType.Element && xmlR.Name == "ime")
                    {
                        listBox2.Items.Add(xmlR.ReadElementContentAsString());
                    }
                } while (xmlR.Read());
                xmlR.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file\nWrong name or the file does not exist");
            }

        }

        private void save_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When "Enter" key pressed it calls the button3_Click method
        /// </summary>
        /// <see cref="button3_Click(object, EventArgs)"/>
        /// <param name="e">Key got from keyboard</param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }

        }

        /// <summary>
        /// Method changes xml node selected in listBox2.
        /// node "ime" is set as textBox1 text
        /// node "set" is set as a string returned by method "napravi_Set"
        /// </summary>
        private void promijeni_polje() {
            string naziv;
            string naziv_xml;
            int broj = 0; 
            XmlTextReader xmlR = new XmlTextReader("buttons.xml");
            naziv = listBox2.SelectedItem.ToString();
            do
            {
                if (xmlR.NodeType == XmlNodeType.Element && xmlR.Name=="ime")
                {
                    naziv_xml=  xmlR.ReadElementContentAsString();
                    if(naziv_xml == naziv)
                        broj = xmlR.LineNumber; 
                }
            } while (xmlR.Read());
            xmlR.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("buttons.xml");
            XmlNode root = xmldoc.DocumentElement;
            XmlElement ime = xmldoc.CreateElement("ime");
            ime.InnerText = textBox1.Text;
            XmlElement set = xmldoc.CreateElement("set");
            set.InnerText = napravi_Set();
            xmldoc.SelectSingleNode("buttons").ReplaceChild(ime, root.ChildNodes[broj - 3]);
            xmldoc.SelectSingleNode("buttons").ReplaceChild(set, root.ChildNodes[broj - 2]);
            xmldoc.Save("buttons.xml");
        }
        /// <summary>
        /// This method creates a 9 character string (3 characters for each color).
        /// Gets background color and makes strings setR, setG and setB. 
        /// <see cref="main.button1_Click_1(object, EventArgs)"/> for background color explanation.
        /// </summary>
        /// <returns>Returns a 9 character string, RedGreenBlue respectively</returns>
        public string napravi_Set() {
            string setR;
            string setG;
            string setB;
            if (Convert.ToString(this.BackColor.R).Length == 1) {
                setR = "00" + Convert.ToString(this.BackColor.R);
            }
            else if (Convert.ToString(this.BackColor.R).Length == 2)
            {
                setR = "0" + Convert.ToString(this.BackColor.R);
            }
            else
                setR = Convert.ToString(this.BackColor.R);

            if (Convert.ToString(this.BackColor.G).Length == 1)
            {
                setG = "00" + Convert.ToString(this.BackColor.G);
            }
            else if (Convert.ToString(this.BackColor.G).Length == 2)
            {
                setG = "0" + Convert.ToString(this.BackColor.G);
            }
            else
                setG = Convert.ToString(this.BackColor.G);

            if (Convert.ToString(this.BackColor.B).Length == 1)
            {
                setB = "00" + Convert.ToString(this.BackColor.B);
            }
            else if (Convert.ToString(this.BackColor.B).Length == 2)
            {
                setB = "0" + Convert.ToString(this.BackColor.B);
            }
            else
                setB = Convert.ToString(this.BackColor.B);
            
            return setR + setG + setB;
        }

        /// <summary>
        /// Gets color.
        /// </summary>
        public string boja(string ulazna_boja) {
            return ulazna_boja;
        }

        /// <summary>
        /// Closes form without saving profile.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            //CANCEL BUTTON
            Close();
        }

        /// <summary>
        /// If listbox2 item is selected and textbox1 text is not empty call promijeni_polje() and close form
        /// or show appropriate message.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            //OK
            if (textBox1.Text.Length > 0 && listBox2.SelectedItem != null)
            {
                promijeni_polje();
                Close();
            }
            else if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Profile name not specified!");
            }
            else if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Profile slot not selected!");
            }
            else
                MessageBox.Show("Unexpected error!");
        }
    }
}
