namespace DZ_Less8_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelQuests = new System.Windows.Forms.Panel();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.checkBoxAnswer = new System.Windows.Forms.CheckBox();
            this.textBoxQuest = new System.Windows.Forms.TextBox();
            this.labelQuest = new System.Windows.Forms.Label();
            this.buttonNextQuest = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxQuests = new System.Windows.Forms.ListBox();
            this.contextMenuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuests.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.contextMenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuests
            // 
            this.panelQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuests.Controls.Add(this.labelAnswer);
            this.panelQuests.Controls.Add(this.checkBoxAnswer);
            this.panelQuests.Controls.Add(this.textBoxQuest);
            this.panelQuests.Controls.Add(this.labelQuest);
            this.panelQuests.Controls.Add(this.buttonNextQuest);
            this.panelQuests.Enabled = false;
            this.panelQuests.Location = new System.Drawing.Point(0, 27);
            this.panelQuests.Name = "panelQuests";
            this.panelQuests.Size = new System.Drawing.Size(297, 192);
            this.panelQuests.TabIndex = 0;
            // 
            // labelAnswer
            // 
            this.labelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(7, 114);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(37, 13);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Ответ";
            // 
            // checkBoxAnswer
            // 
            this.checkBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAnswer.AutoSize = true;
            this.checkBoxAnswer.Location = new System.Drawing.Point(7, 133);
            this.checkBoxAnswer.Name = "checkBoxAnswer";
            this.checkBoxAnswer.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAnswer.TabIndex = 2;
            this.checkBoxAnswer.Text = "Ложь";
            this.checkBoxAnswer.UseVisualStyleBackColor = true;
            this.checkBoxAnswer.CheckedChanged += new System.EventHandler(this.CheckBoxAnswer_CheckedChanged);
            // 
            // textBoxQuest
            // 
            this.textBoxQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuest.Location = new System.Drawing.Point(7, 21);
            this.textBoxQuest.Multiline = true;
            this.textBoxQuest.Name = "textBoxQuest";
            this.textBoxQuest.Size = new System.Drawing.Size(287, 76);
            this.textBoxQuest.TabIndex = 1;
            this.textBoxQuest.TextChanged += new System.EventHandler(this.textBoxQuest_TextChanged);
            // 
            // labelQuest
            // 
            this.labelQuest.AutoSize = true;
            this.labelQuest.Location = new System.Drawing.Point(4, 4);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(44, 13);
            this.labelQuest.TabIndex = 0;
            this.labelQuest.Text = "Вопрос";
            // 
            // buttonNextQuest
            // 
            this.buttonNextQuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextQuest.Enabled = false;
            this.buttonNextQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextQuest.Location = new System.Drawing.Point(3, 166);
            this.buttonNextQuest.Name = "buttonNextQuest";
            this.buttonNextQuest.Size = new System.Drawing.Size(291, 23);
            this.buttonNextQuest.TabIndex = 1;
            this.buttonNextQuest.Text = "Добавить новый вопрос";
            this.buttonNextQuest.UseVisualStyleBackColor = true;
            this.buttonNextQuest.Click += new System.EventHandler(this.buttonNextQuest_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(551, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.saveFile,
            this.saveAsFile});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "&Файл";
            // 
            // newFile
            // 
            this.newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(154, 22);
            this.newFile.Text = "&Новый файл";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(154, 22);
            this.openFile.Text = "&Открыть";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(154, 22);
            this.saveFile.Text = "&Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveAsFile
            // 
            this.saveAsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveAsFile.Name = "saveAsFile";
            this.saveAsFile.Size = new System.Drawing.Size(154, 22);
            this.saveAsFile.Text = "Сохранить &как";
            this.saveAsFile.Click += new System.EventHandler(this.saveAsFile_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNew.Location = new System.Drawing.Point(8, 246);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(83, 23);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Новый файл";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.newFile_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpen.Location = new System.Drawing.Point(103, 246);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(83, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.openFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Location = new System.Drawing.Point(199, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // listBoxQuests
            // 
            this.listBoxQuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQuests.FormattingEnabled = true;
            this.listBoxQuests.Location = new System.Drawing.Point(313, 27);
            this.listBoxQuests.Name = "listBoxQuests";
            this.listBoxQuests.Size = new System.Drawing.Size(224, 238);
            this.listBoxQuests.TabIndex = 5;
            this.listBoxQuests.DoubleClick += new System.EventHandler(this.listBoxQuests_DoubleClick);
            this.listBoxQuests.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxQuests_MouseClick);
            // 
            // contextMenuList
            // 
            this.contextMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuList.Name = "contextMenu";
            this.contextMenuList.ShowImageMargin = false;
            this.contextMenuList.Size = new System.Drawing.Size(94, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "Файл вопросов ответов | *.qxf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл вопросов ответов | *.qxf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "Файл вопросов ответов | *.qxf";
            this.saveFileDialog1.Filter = "Файл вопросов ответов | *.qxf";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О &программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 297);
            this.Controls.Add(this.listBoxQuests);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panelQuests);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(567, 336);
            this.Name = "MainForm";
            this.Text = "Создание вопросов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelQuests.ResumeLayout(false);
            this.panelQuests.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelQuests;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.CheckBox checkBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuest;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.Button buttonNextQuest;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsFile;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxQuests;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

