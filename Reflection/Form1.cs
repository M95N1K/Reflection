using System;
using System.Windows.Forms;


//Задание 1
//  С помощью рефлексии выведите все свойства структуры DateTime
//Выполнил Виль В. В.

namespace Reflections
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Type TDataTime = typeof(DateTime);
            System.Reflection.PropertyInfo[] propertyInfos;
            propertyInfos = TDataTime.GetProperties();
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                listBox1.Items.Add(string.Format("{0,10}\t{1}", propertyInfos[i].Name, propertyInfos[i].PropertyType.ToString()));
            }
        }
    }
}
