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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kfioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_parm_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kafDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kafedra1DataSet = new kafedra_DBGrid.Kafedra1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.kafDBTableAdapter1 = new kafedra_DBGrid.Kafedra1DataSetTableAdapters.KafDBTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.to_excel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedra1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.kfioDataGridViewTextBoxColumn,
            this.kpostDataGridViewTextBoxColumn,
            this.kdegreeDataGridViewTextBoxColumn,
            this.ksubjectDataGridViewTextBoxColumn,
            this.kloadDataGridViewTextBoxColumn,
            this.k_parm_time});
            this.dataGridView1.DataSource = this.kafDBBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(51, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 429);
            this.dataGridView1.TabIndex = 0;
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
            // k_parm_time
            // 
            this.k_parm_time.DataPropertyName = "k_parm_time";
            this.k_parm_time.HeaderText = "Совместительство";
            this.k_parm_time.Name = "k_parm_time";
            this.k_parm_time.Width = 150;
            // 
            // kafDBBindingSource1
            // 
            this.kafDBBindingSource1.DataMember = "KafDB";
            this.kafDBBindingSource1.DataSource = this.kafedra1DataSet;
            // 
            // kafedra1DataSet
            // 
            this.kafedra1DataSet.DataSetName = "Kafedra1DataSet";
            this.kafedra1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // kafDBTableAdapter1
            // 
            this.kafDBTableAdapter1.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(501, 18);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // to_excel_button
            // 
            this.to_excel_button.Location = new System.Drawing.Point(623, 17);
            this.to_excel_button.Name = "to_excel_button";
            this.to_excel_button.Size = new System.Drawing.Size(105, 23);
            this.to_excel_button.TabIndex = 6;
            this.to_excel_button.Text = "Экспорт в Excel";
            this.to_excel_button.UseVisualStyleBackColor = true;
            this.to_excel_button.Click += new System.EventHandler(this.to_excel_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.to_excel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedra1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NameButton;
        private Kafedra1DataSet kafedra1DataSet;
        private System.Windows.Forms.BindingSource kafDBBindingSource1;
        private Kafedra1DataSetTableAdapters.KafDBTableAdapter kafDBTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kfioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_parm_time;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button to_excel_button;
    }
}

