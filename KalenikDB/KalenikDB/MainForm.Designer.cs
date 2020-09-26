namespace KalenikDB
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new KalenikDB.mydbDataSet();
            this.namesTableAdapter = new KalenikDB.mydbDataSetTableAdapters.namesTableAdapter();
            this.DBshowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IDDeleteButton = new System.Windows.Forms.Button();
            this.IDDeleteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RedactSurnameTextBox = new System.Windows.Forms.TextBox();
            this.RedactAcceptButton = new System.Windows.Forms.Button();
            this.RedactNameTextBox = new System.Windows.Forms.TextBox();
            this.RedactIDTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 48);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(6, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(112, 19);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 3;
            this.SurnameTextBox.Enter += new System.EventHandler(this.SurnameTextBox_Enter);
            this.SurnameTextBox.Leave += new System.EventHandler(this.SurnameTextBox_Leave);
            // 
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // DBshowButton
            // 
            this.DBshowButton.Location = new System.Drawing.Point(18, 53);
            this.DBshowButton.Name = "DBshowButton";
            this.DBshowButton.Size = new System.Drawing.Size(206, 22);
            this.DBshowButton.TabIndex = 4;
            this.DBshowButton.Text = "Открыть таблицу БД";
            this.DBshowButton.UseVisualStyleBackColor = true;
            this.DBshowButton.Click += new System.EventHandler(this.DBshowButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "добавление записи";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.IDDeleteButton);
            this.groupBox2.Controls.Add(this.IDDeleteTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Удалить запись по id";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(6, 19);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(206, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить все записи";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IDDeleteButton
            // 
            this.IDDeleteButton.Location = new System.Drawing.Point(112, 68);
            this.IDDeleteButton.Name = "IDDeleteButton";
            this.IDDeleteButton.Size = new System.Drawing.Size(100, 21);
            this.IDDeleteButton.TabIndex = 1;
            this.IDDeleteButton.Text = "Удалить";
            this.IDDeleteButton.UseVisualStyleBackColor = true;
            this.IDDeleteButton.Click += new System.EventHandler(this.IDDeleteButton_Click);
            // 
            // IDDeleteTextBox
            // 
            this.IDDeleteTextBox.Location = new System.Drawing.Point(6, 69);
            this.IDDeleteTextBox.Name = "IDDeleteTextBox";
            this.IDDeleteTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDDeleteTextBox.TabIndex = 0;
            this.IDDeleteTextBox.Enter += new System.EventHandler(this.IDDeleteTextBox_Enter);
            this.IDDeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDDeleteTextBox_KeyPress);
            this.IDDeleteTextBox.Leave += new System.EventHandler(this.IDDeleteTextBox_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RedactSurnameTextBox);
            this.groupBox3.Controls.Add(this.RedactAcceptButton);
            this.groupBox3.Controls.Add(this.RedactNameTextBox);
            this.groupBox3.Controls.Add(this.RedactIDTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование записей";
            // 
            // RedactSurnameTextBox
            // 
            this.RedactSurnameTextBox.Location = new System.Drawing.Point(112, 45);
            this.RedactSurnameTextBox.Name = "RedactSurnameTextBox";
            this.RedactSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RedactSurnameTextBox.TabIndex = 9;
            this.RedactSurnameTextBox.Enter += new System.EventHandler(this.RedactSurnameTextBox_Enter);
            this.RedactSurnameTextBox.Leave += new System.EventHandler(this.RedactSurnameTextBox_Leave);
            // 
            // RedactAcceptButton
            // 
            this.RedactAcceptButton.Location = new System.Drawing.Point(6, 45);
            this.RedactAcceptButton.Name = "RedactAcceptButton";
            this.RedactAcceptButton.Size = new System.Drawing.Size(100, 20);
            this.RedactAcceptButton.TabIndex = 8;
            this.RedactAcceptButton.Text = "Подтвердить";
            this.RedactAcceptButton.UseVisualStyleBackColor = true;
            this.RedactAcceptButton.Click += new System.EventHandler(this.RedactAcceptButton_Click);
            // 
            // RedactNameTextBox
            // 
            this.RedactNameTextBox.Location = new System.Drawing.Point(112, 19);
            this.RedactNameTextBox.Name = "RedactNameTextBox";
            this.RedactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RedactNameTextBox.TabIndex = 2;
            this.RedactNameTextBox.Enter += new System.EventHandler(this.RedactNameTextBox_Enter);
            this.RedactNameTextBox.Leave += new System.EventHandler(this.RedactNameTextBox_Leave);
            // 
            // RedactIDTextBox
            // 
            this.RedactIDTextBox.Location = new System.Drawing.Point(6, 19);
            this.RedactIDTextBox.Name = "RedactIDTextBox";
            this.RedactIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.RedactIDTextBox.TabIndex = 1;
            this.RedactIDTextBox.Enter += new System.EventHandler(this.RedactIDTextBox_Enter);
            this.RedactIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RedactIDTextBox_KeyPress);
            this.RedactIDTextBox.Leave += new System.EventHandler(this.RedactIDTextBox_Leave);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(18, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(206, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Завершить работу";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Location = new System.Drawing.Point(18, 372);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(206, 20);
            this.InformationButton.TabIndex = 9;
            this.InformationButton.Text = "О приложении";
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(18, 346);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(206, 20);
            this.PrintButton.TabIndex = 10;
            this.PrintButton.Text = "Сохранить БД в текстовом файле";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 406);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DBshowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private mydbDataSetTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button DBshowButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button IDDeleteButton;
        private System.Windows.Forms.TextBox IDDeleteTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RedactAcceptButton;
        private System.Windows.Forms.TextBox RedactNameTextBox;
        private System.Windows.Forms.TextBox RedactIDTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox RedactSurnameTextBox;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button PrintButton;
    }
}

