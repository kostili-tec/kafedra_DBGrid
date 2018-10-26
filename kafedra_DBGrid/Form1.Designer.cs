namespace kafedra_DBGrid
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kafDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kafDataSet = new kafedra_DBGrid.KafDataSet();
            this.kafDBTableAdapter = new kafedra_DBGrid.KafDataSetTableAdapters.KafDBTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.kafDataSet1 = new kafedra_DBGrid.KafDataSet();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kfioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.kfioDataGridViewTextBoxColumn,
            this.kpostDataGridViewTextBoxColumn,
            this.kdegreeDataGridViewTextBoxColumn,
            this.ksubjectDataGridViewTextBoxColumn,
            this.kloadDataGridViewTextBoxColumn,
            this.ksalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kafDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // kafDBBindingSource
            // 
            this.kafDBBindingSource.DataMember = "KafDB";
            this.kafDBBindingSource.DataSource = this.kafDataSet;
            // 
            // kafDataSet
            // 
            this.kafDataSet.DataSetName = "KafDataSet";
            this.kafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kafDBTableAdapter
            // 
            this.kafDBTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(393, 18);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 3;
            this.NameButton.Text = "Поиск";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(532, 18);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "TestButton";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // kafDataSet1
            // 
            this.kafDataSet1.DataSetName = "KafDataSet";
            this.kafDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "id";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 35;
            // 
            // kfioDataGridViewTextBoxColumn
            // 
            this.kfioDataGridViewTextBoxColumn.DataPropertyName = "k_fio";
            this.kfioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.kfioDataGridViewTextBoxColumn.Name = "kfioDataGridViewTextBoxColumn";
            this.kfioDataGridViewTextBoxColumn.Width = 200;
            // 
            // kpostDataGridViewTextBoxColumn
            // 
            this.kpostDataGridViewTextBoxColumn.DataPropertyName = "k_post";
            this.kpostDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.kpostDataGridViewTextBoxColumn.Name = "kpostDataGridViewTextBoxColumn";
            this.kpostDataGridViewTextBoxColumn.Width = 150;
            // 
            // kdegreeDataGridViewTextBoxColumn
            // 
            this.kdegreeDataGridViewTextBoxColumn.DataPropertyName = "k_degree";
            this.kdegreeDataGridViewTextBoxColumn.HeaderText = "Ученая степень";
            this.kdegreeDataGridViewTextBoxColumn.Name = "kdegreeDataGridViewTextBoxColumn";
            // 
            // ksubjectDataGridViewTextBoxColumn
            // 
            this.ksubjectDataGridViewTextBoxColumn.DataPropertyName = "k_subject";
            this.ksubjectDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.ksubjectDataGridViewTextBoxColumn.Name = "ksubjectDataGridViewTextBoxColumn";
            // 
            // kloadDataGridViewTextBoxColumn
            // 
            this.kloadDataGridViewTextBoxColumn.DataPropertyName = "k_load";
            this.kloadDataGridViewTextBoxColumn.HeaderText = "Загрузка";
            this.kloadDataGridViewTextBoxColumn.Name = "kloadDataGridViewTextBoxColumn";
            // 
            // ksalaryDataGridViewTextBoxColumn
            // 
            this.ksalaryDataGridViewTextBoxColumn.DataPropertyName = "k_salary";
            this.ksalaryDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.ksalaryDataGridViewTextBoxColumn.Name = "ksalaryDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KafDataSet kafDataSet;
        private System.Windows.Forms.BindingSource kafDBBindingSource;
        private KafDataSetTableAdapters.KafDBTableAdapter kafDBTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button TestButton;
        private KafDataSet kafDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kfioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksalaryDataGridViewTextBoxColumn;
    }
}

