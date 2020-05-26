using System;
using System.Windows.Forms;

//Задание 2
//  Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
//Выполнил Виль В. В.

namespace DZ_Less8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal tmp;
            if (decimal.TryParse(textBox1.Text, out tmp))
                if ((tmp <= numericUpDown1.Maximum) && (tmp >= numericUpDown1.Minimum))
                    numericUpDown1.Value = tmp;
        }
    }
}
