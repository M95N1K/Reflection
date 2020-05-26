using System;
using System.Windows.Forms;

//Задание 3
//  а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
//      (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//  б) Изменить интерфейс программы, увеличив шрифт, 
//      поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//  в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
//  г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
//Выполнил Виль В. В.

namespace DZ_Less8_3
{
    public partial class MainForm : Form
    {
        ListQuests database;
        

        public MainForm()
        {
            InitializeComponent();
            ListQuests.OnCreate += ListQuests_OnCreate;
            openFileDialog1.FileName = "";
            saveFileDialog1.FileName = "";
        }

        private void ListQuests_OnCreate(object sender)
        {
            ListQuests _database = sender as ListQuests;
            _database.OnLoad += Database_OnLoad;
            _database.OnError += Database_OnError;
            _database.OnAdd += Database_OnAdd;
            _database.OnRemove += Database_OnRemove;
        }

        private void Database_OnRemove(int index)
        {
            listBoxQuests.Items.RemoveAt(index);
        }

        private void Database_OnAdd(string quest, bool answer)
        {
            listBoxQuests.Items.Add(quest);
        }

        private void Database_OnError(string message)
        {
            MessageBox.Show(message);
        }

        private void Database_OnLoad(object sender)
        {
            listBoxQuests.Items.Clear();
            for (int i = 0; i < database.Count; i++)
            {
                listBoxQuests.Items.Add(database[i].quest);
            }
            panelQuests.Enabled = true;
        }



        private void CheckBoxAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnswer.Checked)
                checkBoxAnswer.Text = "Правда";
            else checkBoxAnswer.Text = "Ложь";
        }

        private void textBoxQuest_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuest.Text.Length > 0)
                buttonNextQuest.Enabled = true;
            else buttonNextQuest.Enabled = false;
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            if (database != null)
                IsNotSave();
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName == "") return;
            panelQuests.Enabled = true;
            database = new ListQuests(saveFileDialog1.FileName);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (database != null)
                IsNotSave();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "") return;

            database = new ListQuests(openFileDialog1.FileName);
            database.Load();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxQuests.Items.Count > 0)
                if (MessageBox.Show("Вы хотите удалить вопрос?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    database.Remove(listBoxQuests.SelectedIndex);
                }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void saveAsFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == "") return;

            database.SaveAs(saveFileDialog1.FileName);
        }

        private void buttonNextQuest_Click(object sender, EventArgs e)
        {
            database.Add(textBoxQuest.Text, checkBoxAnswer.Checked);
            textBoxQuest.Text = "";
            checkBoxAnswer.Checked = false;
        }

        private void listBoxQuests_DoubleClick(object sender, EventArgs e)
        {
            textBoxQuest.Text = database[listBoxQuests.SelectedIndex].quest;
            checkBoxAnswer.Checked = database[listBoxQuests.SelectedIndex].trueFalse;
        }

        private void IsNotSave()
        {
            if (!database.Changed)
                return;
            if (MessageBox.Show("Файл не сохранен!!!\nХотите его сохранить?", "Внимание!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                database.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (database != null)
                IsNotSave();
        }

        private void listBoxQuests_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listBoxQuests.SelectedItem != null)
                {
                    contextMenuList.Top = Top + e.Y;
                    contextMenuList.Left = Left + e.X;
                    contextMenuList.Show((sender as ListBox), e.X, e.Y);
                }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout aboutForm = new FAbout();
            aboutForm.ShowDialog();
        }
    }
}
