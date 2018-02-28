namespace laba1
{
    partial class Form1
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
            this.infoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rshColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qntBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(451, 60);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(102, 23);
            this.infoBtn.TabIndex = 0;
            this.infoBtn.Text = "О разработчике";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тип данных";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(12, 25);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 6;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(228, 124);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(102, 23);
            this.runBtn.TabIndex = 13;
            this.runBtn.Text = "Отсортировать";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sortColumn,
            this.qntColumn,
            this.cmpColumn,
            this.rshColumn,
            this.timeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 76);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sortColumn
            // 
            this.sortColumn.HeaderText = "Вид сортировки";
            this.sortColumn.Name = "sortColumn";
            // 
            // qntColumn
            // 
            this.qntColumn.HeaderText = "Количество элементов";
            this.qntColumn.Name = "qntColumn";
            // 
            // cmpColumn
            // 
            this.cmpColumn.HeaderText = "Количество сравнений";
            this.cmpColumn.Name = "cmpColumn";
            // 
            // rshColumn
            // 
            this.rshColumn.HeaderText = "Количество перестановок";
            this.rshColumn.Name = "rshColumn";
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Время выполнения";
            this.timeColumn.Name = "timeColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите вид сортировки";
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(12, 126);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 21);
            this.sortBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите количество данных*";
            // 
            // qntBox
            // 
            this.qntBox.FormattingEnabled = true;
            this.qntBox.Location = new System.Drawing.Point(12, 76);
            this.qntBox.Name = "qntBox";
            this.qntBox.Size = new System.Drawing.Size(121, 21);
            this.qntBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "*5,10,25 - для массива записей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "10, 100, 1000, 10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "- для массива чисел";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 212);
            this.listBox1.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(340, 264);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(213, 212);
            this.listBox2.TabIndex = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.qntBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rshColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox qntBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        public  System.Windows.Forms.ListBox listBox2;
    }
}

