using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO.Ports;
namespace WindowsFormsApp2
{
    
    public partial class main : Form
    {
      
        private Image image = Image.FromFile("SLike/slider.png");
        public static string[] nazivi = new string[20];
        //Start position of the sliders.
        public Point tackaR=new Point(100,0);
        public Point tackaG = new Point(100, 0);
        public Point tackaB = new Point(100, 0);
        private SerialPort Arduino;
        private XmlDocument xmldoc = new XmlDocument();
        private int x;

        /// <summary>
        /// Main screen of application.
        /// </summary>
        public main()
        {
            InitializeComponent();
            set_Buttons_names();
            Arduino = new SerialPort();
            init();
        }
        
        /// <summary>
        /// Sets the position and background color of "save" form and disables this form.
        /// After save form is closed, enable this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            save sav = new save();
            sav.ShowInTaskbar = false;
            this.Enabled = false;
            sav.StartPosition=FormStartPosition.Manual;
            sav.SetDesktopLocation(this.Left+190, this.Top+180);
            sav.BackColor = Color.FromArgb(tackaR.X, tackaG.X, tackaB.X);
                sav.Show();
            if (sav.Created == false)
                this.Enabled = true;
            sav.FormClosed += (o, args) => { set_Buttons_names(); this.Enabled = true; };         
            
        }

        bool dozvolaR = false;
        bool dozvolaG = false;
        bool dozvolaB = false;

        /// <summary>
        /// Enables slider movement.
        /// </summary>
        /// <see cref="pictureBox1_MouseMove(object, MouseEventArgs)"/>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaR = true;
        }

        /// <summary>
        /// Sets slider(picturebox1) position according to mouse position.
        /// </summary>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaR) {
                x = tackaR.X;
                if(e.X>=0 && e.X<=255)
                tackaR.X = e.X;
                pictureBox1.Refresh();
            
            }
        }

        /// <summary>
        /// Disables slider movement.
        /// Sets textbox text to hexadecimal.
        /// </summary>
        /// <see cref="pictureBox1_MouseMove(object, MouseEventArgs)"/>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaR = false;
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// Sets slider(pictureBox1) to received position, and changes BG color.
        /// </summary>
        /// <see cref="promjenaBoje(int, int, int)"/>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image,tackaR.X,tackaR.Y,7,15);
            promjenaBoje(tackaR.X,tackaG.X,tackaB.X);
        }
        

        private void main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sets slider(pictureBox2) to received position, and changes BG color.
        /// </summary>
        /// <see cref="promjenaBoje(int, int, int)"/>
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, tackaG.X, tackaG.Y, 7, 15);
            promjenaBoje(tackaR.X, tackaG.X, tackaB.X);
        }

        /// <summary>
        /// Enables slider movement.
        /// </summary>
        /// <see cref="pictureBox2_MouseMove(object, MouseEventArgs)"/>
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaG = true;
        }

        /// <summary>
        /// Disables slider movement.
        /// Sets textbox text to hexadecimal.
        /// </summary>
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaG = false;
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");

        }

        /// <summary>
        /// Sets slider(picturebox2) position according to mouse position.
        /// </summary>
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaG)
            {
                x = tackaG.X;
                if (e.X >= 0 && e.X <= 255)
                    tackaG.X = e.X;
                //    tacka.Y = e.Y;
                pictureBox2.Refresh();

            }
        }

        /// <summary>
        /// Enables slider movement.
        /// </summary>
        /// <see cref="pictureBox2_MouseMove(object, MouseEventArgs)"/>
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaB = true;
        }

        /// <summary>
        /// Disables slider movement.
        /// Sets textbox text to hexadecimal.
        /// </summary>
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaB = false;
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// Sets slider(picturebox3) position according to mouse position.
        /// </summary>
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaB)
            {
                x = tackaB.X;
                if (e.X >= 0 && e.X <= 255)
                    tackaB.X = e.X;
               
                pictureBox3.Refresh();

            }
        }

        /// <summary>
        /// Sets slider(pictureBox3) to received position, and changes BG color.
        /// </summary>
        /// <see cref="promjenaBoje(int, int, int)"/>
        private void pictureBox3_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, tackaB.X, tackaB.Y, 7, 15);
            promjenaBoje(tackaR.X, tackaG.X, tackaB.X); 
        }

        /// <summary>
        /// Set BG color to parameter.
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        private void promjenaBoje(int R,int G, int B)
        {
            this.BackColor = Color.FromArgb(R, G, B);
        }
        
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Send panel1 to back and hide picturebox4
        /// or bring panel1 to front and show picturebox4
        /// </summary>
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap imp = new Bitmap(pictureBox5.Image);
            Color pixel = imp.GetPixel(e.X, e.Y);
            if (pixel.B == 23 || pixel.G == 254)
            {
                panel1.SendToBack();
                pictureBox4.Hide();
            }
            else if (pixel.B == 21 || pixel.G == 255)
            {
                panel1.BringToFront();
                pictureBox4.Show();
            }
        }

        /// <summary>
        /// Minimize to taskbar or minimize to tray.
        /// </summary>
        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap imp = new Bitmap(pictureBox6.Image);
            Color pixel = imp.GetPixel(e.X, e.Y);
            if (pixel.R == 21 || pixel.B == 255)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (pixel.R == 20 || pixel.R == 255) {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Icon = SystemIcons.Application;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
            }
        }

        /// <summary>
        /// When icon in tray is double clicked, show the form.
        /// </summary>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal) {
                Show();
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false; 
           }
        }

        /// <summary>
        /// Move form position on desktop.
        /// </summary>
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) { 
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                //????
            }          
        }
     
        /// <summary>
        /// Show Save form and disable this form.
        /// When save form is closed enable this form.
        /// </summary>
        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            //MEMORY!!!
            Bitmap imp = new Bitmap(pictureBox7.Image);
            Color pixel = imp.GetPixel(e.X, e.Y);
            if (pixel.B == 53 || pixel.G == 255)
            {
                Info info = new Info();
                info.ShowInTaskbar = false;
                this.Enabled = false;
                info.StartPosition = FormStartPosition.Manual;
                info.SetDesktopLocation(this.Left + 140, this.Top);
                info.Show();
                if (info.Created == false)
                    this.Enabled = true;
                info.FormClosed += (o, args) => { this.Enabled = true; };
            }          
        }

        /// <summary>
        /// Get color of selected pixel and set sliders at those values.
        /// </summary>
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Bitmap imp = new Bitmap(pictureBox8.Image);
                if (e.X > 0 && e.Y > 0 && e.X<pictureBox8.Width && e.Y<pictureBox8.Height)
                {
                    Color pixel = imp.GetPixel(e.X, e.Y);
                    tackaR.X = pixel.R;
                    tackaG.X = pixel.G;
                    tackaB.X = pixel.B;
                    pictureBox1.Refresh();
                    pictureBox2.Refresh();
                    pictureBox3.Refresh();
                }
            }
        }
        /// <summary>
        /// Set sliders to inserted text.
        /// </summary>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length == 7)
                {
                    try
                    {
                        tackaR.X = Convert.ToInt32(Convert.ToString(textBox1.Text[1]) + Convert.ToString(textBox1.Text[2]), 16);
                        tackaG.X = Convert.ToInt32(Convert.ToString(textBox1.Text[3]) + Convert.ToString(textBox1.Text[4]), 16);
                        tackaB.X = Convert.ToInt32(Convert.ToString(textBox1.Text[5]) + Convert.ToString(textBox1.Text[6]), 16);
                        if(Arduino.IsOpen)
                            send_To_Arduino();
                        else
                            MessageBox.Show("PORT IS NOT OPEN PLEASE CHECK SETED PORT!!!");
                        pictureBox1.Refresh();
                        pictureBox2.Refresh();
                        pictureBox3.Refresh();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid input please check it!");
                    }
                }
                else
                    MessageBox.Show("Invalid input! Please check it!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        /// <summary>
        /// Reads buttons.xml and sets button labels to node "ime".
        /// If not possible, shows warning.
        /// </summary>
        private void set_Buttons_names() { 
            try
            {
                xmldoc.Load("buttons.xml");
                XmlNode root = xmldoc.DocumentElement;
                button00.Text =root.ChildNodes[0].InnerText;
                button02.Text = root.ChildNodes[2].InnerText;
                button04.Text = root.ChildNodes[4].InnerText;
                button06.Text = root.ChildNodes[6].InnerText;
                button08.Text = root.ChildNodes[8].InnerText;
                button010.Text = root.ChildNodes[10].InnerText;
                button012.Text = root.ChildNodes[12].InnerText;
                button014.Text = root.ChildNodes[14].InnerText;
                button016.Text = root.ChildNodes[16].InnerText;
                button018.Text = root.ChildNodes[18].InnerText;
                button020.Text = root.ChildNodes[20].InnerText;
                button022.Text = root.ChildNodes[22].InnerText;
                button024.Text = root.ChildNodes[24].InnerText;
                button26.Text = root.ChildNodes[26].InnerText;
                button028.Text = root.ChildNodes[28].InnerText;
                button030.Text = root.ChildNodes[30].InnerText;
                button032.Text = root.ChildNodes[32].InnerText;
                button034.Text = root.ChildNodes[34].InnerText;
                button036.Text = root.ChildNodes[36].InnerText;
                button038.Text = root.ChildNodes[38].InnerText;
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file! Wrong name or the file does not exist.");
            }
        }

        /// <summary>
        /// Sets Red Green and Blue to "set" node from "buttons.xml".
        /// </summary>
        /// <param name="btnnumber">Number of button pressed in "profiles" tab.</param>
        private void get_Buttons_sets(int btnnumber) {
            xmldoc.Load("buttons.xml");
            XmlNode root = xmldoc.DocumentElement;
            tackaR.X=Convert.ToInt32(Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[0]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[1]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[2]));
            tackaG.X = Convert.ToInt32(Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[3]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[4]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[5]));
            tackaB.X = Convert.ToInt32(Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[6]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[7]) + Convert.ToString(root.ChildNodes[btnnumber + 1].InnerText[8]));
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            promjenaBoje(tackaR.X, tackaG.X, tackaB.X);
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button00_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(0);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button02_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(2);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button04_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(4);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button06_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(6);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button08_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(8);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button010_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(10);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button012_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(12);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button014_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(14);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button016_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(16);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button018_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(18);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button020_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(20);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button022_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(22);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button024_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(24);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button26_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(26);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button028_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(28);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button030_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(30);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button032_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(32);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button034_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(34);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button036_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(36);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button038_Click(object sender, EventArgs e)
        {
            get_Buttons_sets(38);
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// When port is open, send message to arduino.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Arduino.IsOpen)
                send_To_Arduino();
            else
                MessageBox.Show("PORT IS NOT OPEN PLEASE CHECK SETED PORT!!!");
        }
        /// <summary>
        /// If selected item in comboBox1 is "NONE" send RGB set to arduino
        /// or send name of effect
        /// </summary>
        private void send_To_Arduino() {

            if (comboBox1.SelectedItem == "NONE" )
            {
                Arduino.WriteLine(tackaR.X.ToString("D3") + tackaG.X.ToString("D3") + tackaB.X.ToString("D3"));
            }
            else if(comboBox1.SelectedItem=="FADE") {
                Arduino.WriteLine("FADE00000");
            }
            else if (comboBox1.SelectedItem == "RAINBOW")
            {
                Arduino.WriteLine("RAINBOW00");
            }
            else if (comboBox1.SelectedItem == "BLINK")
            {
                Arduino.WriteLine("BLINK0000");
            }
        }
      
        /// <summary>
        /// Opens serial port to arduino.
        /// </summary>
        private void init() {
            Arduino.BaudRate = 9600; 
            try
                {
                    Arduino.Open();
                }
                catch {
                MessageBox.Show("IT IS NOT POSSIBLE TO OPEN THIS PORT");
            }         
        }

        /// <summary>
        /// Sets position and opens ArduinoEr form to manually set COM port.
        /// </summary>
        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            ArduinoEr com = new ArduinoEr();
            com.ShowInTaskbar = false;
            this.Enabled = false;
            com.StartPosition = FormStartPosition.Manual;
            com.SetDesktopLocation(this.Left + 190, this.Top + 180);
            com.Show();
            if (com.Created == false)
                this.Enabled = true;
            com.FormClosed += (o, args) => { if (com.get_Text().Length > 0) { Arduino.Close(); Arduino.PortName = com.get_Text(); init(); } this.Enabled = true; };
        }

        /// <summary>
        /// When text is changed, sends message to arduino if port is open.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                send_To_Arduino();
                comboBox1.SelectedItem = "NONE";
            }
            else
                MessageBox.Show("PORT IS NOT OPEN PLEASE CHECK SETED PORT!!!");
        }

       
        /// <summary>
        /// Closes form.
        /// </summary>
        private void Item1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Restore form from windows tray.
        /// </summary>
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Change text in textbox1.
        /// </summary>
        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = "#" + tackaR.X.ToString("X2") + tackaG.X.ToString("X2") + tackaB.X.ToString("X2");
        }

        /// <summary>
        /// Set position of the sliders
        /// </summary>
        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Bitmap imp = new Bitmap(pictureBox8.Image);
                if (e.X > 0 && e.Y > 0 && e.X < pictureBox8.Width && e.Y < pictureBox8.Height)
                {
                    Color pixel = imp.GetPixel(e.X, e.Y);
                    tackaR.X = pixel.R;
                    tackaG.X = pixel.G;
                    tackaB.X = pixel.B;
                    pictureBox1.Refresh();
                    pictureBox2.Refresh();
                    pictureBox3.Refresh();
                }
            }
        }
    }
}
