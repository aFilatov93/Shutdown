using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shutdown cmd1 = new Shutdown();   

        private void button1_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            
            try
            {
                int hours = int.Parse(textBox1.Text);

                cmd1.shutdown(hours);
                string msg1 = "System will shut down at " + ((time.Hour + hours) + ":" + time.Minute);
                MessageBox.Show(msg1);
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Type time in hours. 5 hours max and not 0.");
                textBox1.Text = "";
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }
    }
}
