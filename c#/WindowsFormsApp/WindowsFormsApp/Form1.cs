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
        Button remember_button;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 그냥 버튼
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // 체크박스
        {
            string text = "false";
            if(checkBox1.Checked) text = "true";

            Button new_button = new Button()
            {
                Width = 75,
                Height = 23,
                Left = 150,
                Top = 150,
                Text = text
            };

            this.Controls.Remove(remember_button);
            remember_button = new_button;
            this.Controls.Add(new_button);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) // 체크박스 리스트
        {
            int index = checkedListBox1.SelectedIndex;
            string item = checkedListBox1.SelectedItem.ToString();
            Console.WriteLine(index + "/" + item + "이 선택됨");
            bool s = checkedListBox1.GetItemChecked(index);
            Console.WriteLine(s);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // 콤보박스
        {
            int index = comboBox1.SelectedIndex;
            string item = comboBox1.SelectedItem.ToString();
            Console.WriteLine(index + "/" + item + "이 선택됨");
        }
    }
}
