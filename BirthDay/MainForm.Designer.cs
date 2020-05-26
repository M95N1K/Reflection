namespace BirthDay
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
            this.tTick = new System.Windows.Forms.Timer(this.components);
            this.LBBirthDay = new System.Windows.Forms.ListBox();
            this.panelBirthDay = new System.Windows.Forms.Panel();
            this.lCountYear = new System.Windows.Forms.Label();
            this.CountYear = new System.Windows.Forms.Label();
            this.lBirthDay = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkCurrentDate = new System.Windows.Forms.CheckBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.panelBirthDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTick
            // 
            this.tTick.Enabled = true;
            // 
            // LBBirthDay
            // 
            this.LBBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBBirthDay.FormattingEnabled = true;
            this.LBBirthDay.ItemHeight = 20;
            this.LBBirthDay.Location = new System.Drawing.Point(14, 116);
            this.LBBirthDay.Name = "LBBirthDay";
            this.LBBirthDay.Size = new System.Drawing.Size(233, 304);
            this.LBBirthDay.TabIndex = 2;
            this.LBBirthDay.SelectedIndexChanged += new System.EventHandler(this.LBBirthDay_SelectedIndexChanged);
            // 
            // panelBirthDay
            // 
            this.panelBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBirthDay.Controls.Add(this.lCountYear);
            this.panelBirthDay.Controls.Add(this.CountYear);
            this.panelBirthDay.Controls.Add(this.lBirthDay);
            this.panelBirthDay.Controls.Add(this.BirthDayLabel);
            this.panelBirthDay.Controls.Add(this.lFirstName);
            this.panelBirthDay.Controls.Add(this.lName);
            this.panelBirthDay.Controls.Add(this.FirstNameLabel);
            this.panelBirthDay.Controls.Add(this.NameLabel);
            this.panelBirthDay.Location = new System.Drawing.Point(263, 122);
            this.panelBirthDay.Name = "panelBirthDay";
            this.panelBirthDay.Size = new System.Drawing.Size(177, 310);
            this.panelBirthDay.TabIndex = 3;
            // 
            // lCountYear
            // 
            this.lCountYear.AutoSize = true;
            this.lCountYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountYear.Location = new System.Drawing.Point(4, 274);
            this.lCountYear.Name = "lCountYear";
            this.lCountYear.Size = new System.Drawing.Size(132, 20);
            this.lCountYear.TabIndex = 7;
            this.lCountYear.Text = "Количество лет";
            // 
            // CountYear
            // 
            this.CountYear.AutoSize = true;
            this.CountYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountYear.Location = new System.Drawing.Point(4, 243);
            this.CountYear.Name = "CountYear";
            this.CountYear.Size = new System.Drawing.Size(132, 20);
            this.CountYear.TabIndex = 6;
            this.CountYear.Text = "Количество лет";
            // 
            // lBirthDay
            // 
            this.lBirthDay.AutoSize = true;
            this.lBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBirthDay.Location = new System.Drawing.Point(4, 202);
            this.lBirthDay.Name = "lBirthDay";
            this.lBirthDay.Size = new System.Drawing.Size(128, 20);
            this.lBirthDay.TabIndex = 5;
            this.lBirthDay.Text = "Дата рождения";
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDayLabel.Location = new System.Drawing.Point(4, 172);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(128, 20);
            this.BirthDayLabel.TabIndex = 4;
            this.BirthDayLabel.Text = "Дата рождения";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFirstName.Location = new System.Drawing.Point(4, 128);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(81, 20);
            this.lFirstName.TabIndex = 3;
            this.lFirstName.Text = "Фамилия";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(4, 50);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(40, 20);
            this.lName.TabIndex = 2;
            this.lName.Text = "Имя";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(4, 96);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(81, 20);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(4, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(14, 71);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // checkCurrentDate
            // 
            this.checkCurrentDate.AutoSize = true;
            this.checkCurrentDate.Checked = true;
            this.checkCurrentDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCurrentDate.Location = new System.Drawing.Point(14, 12);
            this.checkCurrentDate.Name = "checkCurrentDate";
            this.checkCurrentDate.Size = new System.Drawing.Size(134, 24);
            this.checkCurrentDate.TabIndex = 5;
            this.checkCurrentDate.Text = "Текущая дата";
            this.checkCurrentDate.UseVisualStyleBackColor = true;
            this.checkCurrentDate.CheckedChanged += new System.EventHandler(this.CheckCurrentDate_CheckedChanged);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(376, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Редактор";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Enabled = false;
            this.checkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAll.Location = new System.Drawing.Point(14, 41);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(100, 24);
            this.checkAll.TabIndex = 7;
            this.checkAll.Text = "Все даты";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.checkCurrentDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.panelBirthDay);
            this.Controls.Add(this.LBBirthDay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 489);
            this.MinimumSize = new System.Drawing.Size(479, 489);
            this.Name = "MainForm";
            this.Text = "Дни рождения";
            this.panelBirthDay.ResumeLayout(false);
            this.panelBirthDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tTick;
        private System.Windows.Forms.ListBox LBBirthDay;
        private System.Windows.Forms.Panel panelBirthDay;
        private System.Windows.Forms.Label lCountYear;
        private System.Windows.Forms.Label CountYear;
        private System.Windows.Forms.Label lBirthDay;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkCurrentDate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.CheckBox checkAll;
    }
}

