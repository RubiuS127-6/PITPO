namespace Автостоянка
{
    partial class ЕдИзмВремени
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
            this.ЕдИзмВремениBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автостоянкаDataSet1 = new Автостоянка.АвтостоянкаDataSet();
            this.ЕдИзмВремениTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.базоваяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЕдИзмВремениBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.базоваяСтоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ЕдИзмВремениBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // ЕдИзмВремениBindingSource
            // 
            this.ЕдИзмВремениBindingSource.DataMember = "ЕдИзмВремени";
            this.ЕдИзмВремениBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // автостоянкаDataSet1
            // 
            this.автостоянкаDataSet1.DataSetName = "АвтостоянкаDataSet";
            this.автостоянкаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ЕдИзмВремениTableAdapter
            // 
            this.ЕдИзмВремениTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // базоваяСтоимостьDataGridViewTextBoxColumn
            // 
            this.базоваяСтоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.базоваяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Базовая стоимость";
            this.базоваяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Базовая стоимость";
            this.базоваяСтоимостьDataGridViewTextBoxColumn.Name = "базоваяСтоимостьDataGridViewTextBoxColumn";
            this.базоваяСтоимостьDataGridViewTextBoxColumn.Width = 200;
            // 
            // ЕдИзмВремени
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ЕдИзмВремени";
            this.Text = "Парковочные места";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЕдИзмВремениBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private АвтостоянкаDataSet автостоянкаDataSet1;
        private АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter ЕдИзмВремениTableAdapter;
        private System.Windows.Forms.BindingSource ЕдИзмВремениBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn базоваяСтоимостьDataGridViewTextBoxColumn;
    }
}

