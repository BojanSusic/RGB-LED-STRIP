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
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    
    public partial class Main : Form
    {
      
        private Image image = Image.FromFile("SLike/slider.png");
        private static SerialPort Arduino;
        private static string indata="0";
        private static bool connected = false;
        Color pixel;
        /// <summary>
        /// Main screen of application.
        /// </summary>
        public Main()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
            SetButtonsNames();
            Arduino = new SerialPort();
            Init(); //opens Arduino port
        }
       
        /// <summary>
        /// Sets the position and background color of "save" form and disables this form.
        /// After save form is closed, enable this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbSaveProf_Click(object sender, EventArgs e)
        {
            Save sav = new Save();
            sav.ShowInTaskbar = false;
            this.Enabled = false;
            sav.StartPosition=FormStartPosition.Manual;
            sav.SetDesktopLocation(this.Left+190, this.Top+180);
            sav.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value,tbBlue.Value);
                sav.Show();
            if (sav.Created == false)
                this.Enabled = true;
            sav.FormClosed += (o, args) => { SetButtonsNames(); this.Enabled = true; };         
            
        }

        /// <summary>
        /// Set BG color to parameter.
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        private void ChangeColor(int R,int G, int B)
        {
            this.BackColor = Color.FromArgb(R, G, B);
            cInfoButton1.BorderColor = Color.FromArgb(R, G, B);
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
        /// Get color of selected pixel and set sliders at those values.
        /// </summary>
        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Bitmap imp = new Bitmap(colorPicker.Image);
                if (e.X > 0 && e.Y > 0 && e.X<colorPicker.Width && e.Y<colorPicker.Height)
                {
                    Color pixel = imp.GetPixel(e.X, e.Y);
                  /*  tbRed.Value = pixel.R;
                    tbGreen.Value = pixel.G;
                    tbBlue.Value= pixel.B;*/
                    ChangeColor(pixel.R, pixel.G, pixel.B);
                
                }
            }
        }
        /// <summary>
        /// Set sliders to inserted text.
        /// </summary>
        private void tbColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbColorCode.Text.Length == 7)
                {
                    try
                    {
                        tbRed.Value = Convert.ToInt32(Convert.ToString(tbColorCode.Text[1]) + Convert.ToString(tbColorCode.Text[2]), 16);
                        tbGreen.Value= Convert.ToInt32(Convert.ToString(tbColorCode.Text[3]) + Convert.ToString(tbColorCode.Text[4]), 16);
                        tbBlue.Value = Convert.ToInt32(Convert.ToString(tbColorCode.Text[5]) + Convert.ToString(tbColorCode.Text[6]), 16);
                        ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
                        if (Arduino.IsOpen)
                            SendToArduino();
                        else
                            MessageBox.Show("PORT IS NOT OPEN PLEASE CHECK SETED PORT!!!");
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

       
        /// <summary>
        /// Reads buttons.xml and sets button labels to node "ime".
        /// If not possible, shows warning.
        /// </summary>
        private void SetButtonsNames() { 
            try
            {
                List<Button> btnsProfiles = new List<Button>();
                btnsProfiles.Clear();
                for (int i = 0; i < 20; i++) {
                    btnsProfiles.Add(pnlProfiles.Controls[19 - i] as Button);
                }
                btnsProfiles = SortList(btnsProfiles);
                DataSet dsProfiles = new DataSet();
                dsProfiles.ReadXml("buttons.xml");
                for (int i = 0; i < 20; i++)
                {
                    btnsProfiles[i].Text=dsProfiles.Tables[0].Rows[i].ItemArray[0].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file! Wrong name or the file does not exist.");
            }
        }
        private List<Button> SortList(List<Button> buttons)
        {
            Button temp = new Button();
            for(int i=0;i<20;i++)
            {
                int x = int.Parse(Regex.Match(buttons[i].Name, @"\d+").Value);
                for (int j =i; j < 20; j++)
                {
                    int y = int.Parse(Regex.Match(buttons[j].Name, @"\d+").Value);
                    if (y < x)
                    {
                        x = y;
                        temp = buttons[i];
                        buttons[i] = buttons[j];
                        buttons[j] = temp;
                    }
                }
                
            }
            return buttons;
        }

        /// <summary>
        /// Sets Red Green and Blue to "set" node from "buttons.xml".
        /// </summary>
        /// <param name="btnnumber">Number of button pressed in "profiles" tab.</param>
        private void get_Buttons_sets(int btnnumber) {
            DataSet dsProfiles = new DataSet();
            dsProfiles.ReadXml("buttons.xml");
            int set = int.Parse(dsProfiles.Tables[0].Rows[btnnumber-1].ItemArray[1].ToString());
            tbBlue.Value = set % 1000;
            tbGreen.Value= (set / 1000) % 1000;
            tbRed.Value = set / 1000000;
            ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        /// <summary>
        /// set RGB sliders and change text.
        /// </summary>
        private void button00_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            get_Buttons_sets(int.Parse(Regex.Match(btn.Name, @"\d+").Value));
            tbColorCode.Text = "#" + tbRed.Value.ToString("X2") + tbGreen.Value.ToString("X2") + tbBlue.Value.ToString("X2");
        }

        /// <summary>
        /// When port is open, send message to arduino.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Arduino.IsOpen)
                SendToArduino();
            else
                MessageBox.Show("PORT IS NOT OPEN PLEASE CHECK SETED PORT!!!");
        }
        /// <summary>
        /// If selected item in comboBox1 is "NONE" send RGB set to arduino
        /// or send name of effect
        /// </summary>
        private void SendToArduino() {

            if (cbEffects.SelectedItem.ToString() == "NONE" )
            {
                Arduino.WriteLine(tbRed.Value.ToString("D3") + tbGreen.Value.ToString("D3") + tbBlue.Value.ToString("D3"));
            }
            else if(cbEffects.SelectedItem.ToString()=="FADE") {
                Arduino.WriteLine("FADE00000");
            }
            else if (cbEffects.SelectedItem.ToString() == "RAINBOW")
            {
                Arduino.WriteLine("RAINBOW00");
            }
            else if (cbEffects.SelectedItem.ToString() == "BLINK")
            {
                Arduino.WriteLine("BLINK0000");
            }
        }

        private static void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadExisting()+"5";
            if (indata[0] == '1')
            {
                connected = true;
            }
        }
        /// <summary>
        /// Opens serial port to arduino.
        /// </summary>
        private void Init() {
            Arduino.BaudRate = 9600; 
            try
                {
                string[] serialPorts = SerialPort.GetPortNames();
                int sPlenght=0;
                while (!connected && sPlenght < serialPorts.Length)
                {
                    Arduino.Close();
                    Arduino.PortName = serialPorts[sPlenght];
                    sPlenght++;
                   Arduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    try
                    {
                        Arduino.Open();
                        Arduino.Write("COMPING00");
                    }
                    catch { }
                }
                }
                catch {
                MessageBox.Show("IT IS NOT POSSIBLE TO OPEN THIS PORT");
            }         
        }

        /// <summary>
        /// When text is changed, sends message to arduino if port is open.
        /// </summary>
        private void tbColorCode_TextChanged(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                SendToArduino();
                cbEffects.SelectedItem = "NONE";
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
            this.ShowInTaskbar = true;
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
        private void colorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            tbColorCode.Text = "#" + tbRed.Value.ToString("X2") + tbGreen.Value.ToString("X2") + tbBlue.Value.ToString("X2");
            tbRed.Value = pixel.R;
            tbGreen.Value = pixel.G;
            tbBlue.Value = pixel.B;
        }

        /// <summary>
        /// Set position of the sliders
        /// </summary>
        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Bitmap imp = new Bitmap(colorPicker.Image);
                if (e.X > 0 && e.Y > 0 && e.X < colorPicker.Width && e.Y < colorPicker.Height)
                {
                    pixel = imp.GetPixel(e.X, e.Y);
                    tbRed.Value = pixel.R;
                    tbGreen.Value = pixel.G;
                    tbBlue.Value = pixel.B;
                    ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Icon = SystemIcons.Application;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            tbColorCode.Text = "#" + tbRed.Value.ToString("X2") + tbGreen.Value.ToString("X2") + tbBlue.Value.ToString("X2");
            ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            tbColorCode.Text = "#" + tbRed.Value.ToString("X2") + tbGreen.Value.ToString("X2") + tbBlue.Value.ToString("X2");
            ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);

        }
        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            tbColorCode.Text = "#" + tbRed.Value.ToString("X2") + tbGreen.Value.ToString("X2") + tbBlue.Value.ToString("X2");
            ChangeColor(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void cInfoButton1_Click(object sender, EventArgs e)
        {
            //MEMORY!!!
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
}
