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

        /// <summary>
        /// Getter.
        /// </summary>
        /// <returns>1 if text is provided, 0 otherwise</returns>
        public int is_Text_In() {
            return text_in;
        }
        
        /// <summary>
        /// Getter.
        /// </summary>
        /// <returns>Text from text box.</returns>
        public string get_Text() {
            return textBox1.Text;
        
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Sets text_in at 1 and closes form.
        /// </summary>
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
