using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button new_button = new Button()
            {
                Width = 75,
                Height = 23,
                Left = 100 + (count += 50),
                Top = 100,
                Text = "asdf"
            };

            this.Controls.Add(new_button);
        }
    }
}
