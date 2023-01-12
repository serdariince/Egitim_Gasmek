using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EkleButton();
        }
        private Button NewButton()
        {
            var button = new Button();
            return button;
        }

        void EkleButton(){
            this.Controls.Add(NewButton());
        }

    }
}
