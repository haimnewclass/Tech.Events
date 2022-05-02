using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech.Events.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "123";

            Task.Factory.StartNew(() => {
                while (true)
                {
                    Random random = new Random();

                    if (textBox1.InvokeRequired)
                    {
                        textBox1.Invoke(new Action(() => { textBox1.Text = random.Next(1, 10000).ToString(); }));
                    }
                    else
                    {
                        textBox1.Text = random.Next(1, 10000).ToString();
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            });
        }

        

    }
}
