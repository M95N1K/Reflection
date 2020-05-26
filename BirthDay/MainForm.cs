using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDay
{
    public partial class MainForm : Form
    {
        List<BirthDayClass> list;
        public ListBirthDay database;

        public MainForm()
        {
            InitializeComponent();
            database = new ListBirthDay();
            database.OnLoad += DB_OnLoad;
            database.Load();
        }

        private void DB_OnLoad(object sender)
        {
            LBBirthDay.Items.Clear();
            list = database.CurrentBirthDay(dateTimePicker.Value);
            for (int i = 0; i < list.Count; i++)
            {
                LBBirthDay.Items.Add(string.Format("{0} {1}", list[i].firstname, list[i].name));
            }
        }

        

        private void CheckCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCurrentDate.Checked)
            {
                checkCurrentDate.Text = "Текущая дата";
                dateTimePicker.Value = DateTime.Now;
                checkAll.Checked = false;
            }
            else
            {
                checkCurrentDate.Text = "Выберите дату";
                checkAll.Enabled = true;
            }

            dateTimePicker.Enabled = !checkCurrentDate.Checked;
        }

        private void LBBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBBirthDay.SelectedItem == null)
                return;
            if (!checkAll.Checked)
            {
                lName.Text = list[LBBirthDay.SelectedIndex].name;
                lFirstName.Text = list[LBBirthDay.SelectedIndex].firstname;
                lBirthDay.Text = new DateTime(list[LBBirthDay.SelectedIndex].year, list[LBBirthDay.SelectedIndex].month, list[LBBirthDay.SelectedIndex].day).ToShortDateString();
                lCountYear.Text = list[LBBirthDay.SelectedIndex].NumOfYear.ToString();
            }
            else
            {
                lName.Text = database[LBBirthDay.SelectedIndex].name;
                lFirstName.Text = database[LBBirthDay.SelectedIndex].firstname;
                lBirthDay.Text = new DateTime(database[LBBirthDay.SelectedIndex].year, database[LBBirthDay.SelectedIndex].month, database[LBBirthDay.SelectedIndex].day).ToShortDateString();
                lCountYear.Text = database[LBBirthDay.SelectedIndex].NumOfYear.ToString();
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            list = database.CurrentBirthDay(dateTimePicker.Value);
            LBBirthDay.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                LBBirthDay.Items.Add(string.Format("{0} {1}", list[i].firstname, list[i].name));
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            AddBirthDay addBirthDay = new AddBirthDay();
            addBirthDay.FormClosed += AddBirthDay_FormClosed;
            addBirthDay.ShowDialog();
            
        }

        private void AddBirthDay_FormClosed(object sender, FormClosedEventArgs e)
        {
            database.Load();
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                LBBirthDay.Items.Clear();
                for (int i = 0; i < database.Count; i++)
                {
                    LBBirthDay.Items.Add(string.Format("{0} {1}", database[i].firstname, database[i].name));
                }
            }
            else
            {
                list = database.CurrentBirthDay(dateTimePicker.Value);
                LBBirthDay.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    LBBirthDay.Items.Add(string.Format("{0} {1}", list[i].firstname, list[i].name));
                }
            }
        }
    }
}
