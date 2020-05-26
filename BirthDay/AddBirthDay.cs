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
    public partial class AddBirthDay : Form
    {
        private ListBirthDay databas;
        private DateTime birthDay;
        public AddBirthDay()
        {
            InitializeComponent();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databas.Load();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databas.Save();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFile.ShowDialog();
            if (importFile.FileName == "")
                return;
            databas.Import(importFile.FileName);
        }

        private void AddBirthDay_Load(object sender, EventArgs e)
        {
            databas = new ListBirthDay();
            databas.OnLoad += new ListBirthDay.onEvent(Databas_OnLoad);
            databas.OnAdd += Databas_OnAdd;
            databas.OnRemove += Databas_OnRemove;
            databas.OnError += Databas_OnError;
            databas.Load();
            
        }

        private void Databas_OnRemove(int index)
        {
            listBirthDay.Items.RemoveAt(index);
        }

        private void Databas_OnError(string message)
        {
            MessageBox.Show(message);
        }

        private void Databas_OnAdd(string name, string firstname, DateTime birthDay)
        {
            listBirthDay.Items.Add(string.Format("{0} {1}", firstname,name));
        }

        private void Databas_OnLoad(object sender)
        {
            for (int i = 0; i < databas.Count; i++)
            {
                listBirthDay.Items.Add(string.Format("{0} {1}", databas[i].firstname, databas[i].name));
            }
        }

        private void AddBirthDay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (databas != null)
                databas.IsNotSave();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databas.Add(tbName.Text, tbFirstName.Text, birthDay);
            tbFirstName.Text = "";
            tbName.Text = "";
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBirthDay.Items.Count > 0 && listBirthDay.SelectedItem != null)
                if (MessageBox.Show("Вы хотите удалить дату?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    databas.Remove(listBirthDay.SelectedIndex);
                }
        }

        private void ListBirthDay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listBirthDay.SelectedItem != null)
                {
                    contextMenu.Top = Top + e.Y;
                    contextMenu.Left = Left + e.X;
                    contextMenu.Show((sender as ListBox), e.X, e.Y);
                }
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                bAdd.Enabled = false;
                addToolStripMenuItem.Enabled = false;
            }
            else
            {
                bAdd.Enabled = true;
                addToolStripMenuItem.Enabled = true;
            }

        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            birthDay = e.Start;
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile.ShowDialog();
            if (exportFile.FileName == "")
                return;
            databas.Export(exportFile.FileName);
        }
    }
}
