namespace Автостоянка
{
    partial class Стоянка
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.СтоянкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автостоянкаDataSet1 = new Автостоянка.АвтостоянкаDataSet();
            this.СтоянкаTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.СтоянкаTableAdapter();
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобильTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter();
            this.едИзмВремениBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.едИзмВремениTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаВремяНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВремяОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплаченоDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЕдИзмВремениDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.категорияTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter();
            this.клиентTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.КлиентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.СтоянкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.едИзмВремениBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // СтоянкаBindingSource
            // 
            this.СтоянкаBindingSource.DataMember = "Стоянка";
            this.СтоянкаBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // автостоянкаDataSet1
            // 
            this.автостоянкаDataSet1.DataSetName = "АвтостоянкаDataSet";
            this.автостоянкаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // СтоянкаTableAdapter
            // 
            this.СтоянкаTableAdapter.ClearBeforeFill = true;
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // едИзмВремениBindingSource
            // 
            this.едИзмВремениBindingSource.DataMember = "ЕдИзмВремени";
            this.едИзмВремениBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // едИзмВремениTableAdapter
            // 
            this.едИзмВремениTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 28);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(84, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 23);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(3, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Завести";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.iDАвтомобиляDataGridViewTextBoxColumn,
            this.датаВремяНачалаDataGridViewTextBoxColumn,
            this.датаВремяОкончанияDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.оплаченоDataGridViewCheckBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.iDЕдИзмВремениDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.СтоянкаBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDАвтомобиляDataGridViewTextBoxColumn
            // 
            this.iDАвтомобиляDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "ID Автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.DataSource = this.автомобильBindingSource;
            this.iDАвтомобиляDataGridViewTextBoxColumn.DisplayMember = "Гос_номер";
            this.iDАвтомобиляDataGridViewTextBoxColumn.FillWeight = 75F;
            this.iDАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Гос номер Автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.iDАвтомобиляDataGridViewTextBoxColumn.Name = "iDАвтомобиляDataGridViewTextBoxColumn";
            this.iDАвтомобиляDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDАвтомобиляDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDАвтомобиляDataGridViewTextBoxColumn.ValueMember = "Код";
            // 
            // датаВремяНачалаDataGridViewTextBoxColumn
            // 
            this.датаВремяНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата время начала";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.датаВремяНачалаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаВремяНачалаDataGridViewTextBoxColumn.HeaderText = "Дата время начала";
            this.датаВремяНачалаDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.датаВремяНачалаDataGridViewTextBoxColumn.Name = "датаВремяНачалаDataGridViewTextBoxColumn";
            // 
            // датаВремяОкончанияDataGridViewTextBoxColumn
            // 
            this.датаВремяОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата время окончания";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.датаВремяОкончанияDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.датаВремяОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата время окончания";
            this.датаВремяОкончанияDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.датаВремяОкончанияDataGridViewTextBoxColumn.Name = "датаВремяОкончанияDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.суммаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // оплаченоDataGridViewCheckBoxColumn
            // 
            this.оплаченоDataGridViewCheckBoxColumn.DataPropertyName = "Оплачено";
            this.оплаченоDataGridViewCheckBoxColumn.HeaderText = "Оплачено";
            this.оплаченоDataGridViewCheckBoxColumn.Name = "оплаченоDataGridViewCheckBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.времяDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // iDЕдИзмВремениDataGridViewTextBoxColumn
            // 
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.DataPropertyName = "ID Ед изм времени";
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.DataSource = this.едИзмВремениBindingSource;
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.FillWeight = 75F;
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.HeaderText = "Ед изм времени";
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.Name = "iDЕдИзмВремениDataGridViewTextBoxColumn";
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.ValueMember = "Код";
            this.iDЕдИзмВремениDataGridViewTextBoxColumn.Width = 75;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // Стоянка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Стоянка";
            this.Text = "Стоянка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СтоянкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.едИзмВремениBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private АвтостоянкаDataSet автостоянкаDataSet1;
        private АвтостоянкаDataSetTableAdapters.СтоянкаTableAdapter СтоянкаTableAdapter;
        private System.Windows.Forms.BindingSource СтоянкаBindingSource;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private System.Windows.Forms.BindingSource едИзмВремениBindingSource;
        private АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter едИзмВремениTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВремяНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВремяОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn оплаченоDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDЕдИзмВремениDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CreateButton;
        private АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private АвтостоянкаDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
    }
}

