using System;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class save : Form
    {

        public int otvorena=1;
       // public XmlTextReader xmlR = new XmlTextReader("buttons.xml");
        public save()
        {
            InitializeComponent();
            
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
            catch (Exception) {
                MessageBox.Show("DOSLO JE DO GRESKE PRILIKOM OTVARANJA FAJLA.\n MOGUCE DA FAJL NE POSTOJI ILI IMA POGRESNO IME!");
            }
        }

        private void save_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }

        }


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
        public string napravi_Set() {
            string setR;
            string setG;
            string setB;
            string set;
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
                setG = Convert.ToString(this.BackColor.B);
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


            set = setR + setG + setB;
            return set;
        }
        public string boja(string ulazna_boja) {

            return ulazna_boja;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CANCEL BUTTON
            Close();
           
            
        }

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
                MessageBox.Show("NISTE UPISALI NAZIV PROFILA");
            }
            else if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("NISTE ODABRALI DUGME NA KOJE ZELITE DA SACUVATE PROFIL");
            }
            else
                MessageBox.Show("DOSLO JE DO NEKE NEPREDVIDJENE GRESKE!");
        }
    }
}
