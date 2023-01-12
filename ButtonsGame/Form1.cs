using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private Button NewButton(int local)
        {
            var button = new Button
            {
                Location = new Point(local,local),
            };
            return button;
        }
        int local=0;
        void EkleButton()
        {
            local += 25;
            this.Controls.Add(NewButton(local));

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (local<=350)
            {
                EkleButton();
            }
            else
            {
                timer1.Stop();
            }
            
        }
    }
}
