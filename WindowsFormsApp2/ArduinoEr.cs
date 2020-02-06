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
    public partial class ArduinoEr : Form
    {
        int text_in=0;
        public ArduinoEr()
        {
            InitializeComponent();
            label1.Text = "PLEASE ENTER ARDUINO PORT NAME";
        }
        public int is_text_in() {
            return text_in;
        }
        public string get_text() {
            return textBox1.Text;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_in = 1;
                Close();
                
            }
        }
    }
}
