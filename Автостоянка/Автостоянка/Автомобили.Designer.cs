namespace Автостоянка
{
    partial class Автомобили
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
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автостоянкаDataSet1 = new Автостоянка.АвтостоянкаDataSet();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АвтомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АвтомобильTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter();
            this.клиентTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.КлиентTableAdapter();
            this.категорияTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDКатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АвтомобильBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.госномерDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDКатегорииDataGridViewTextBoxColumn,
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.АвтомобильBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // автостоянкаDataSet1
            // 
            this.автостоянкаDataSet1.DataSetName = "АвтостоянкаDataSet";
            this.автостоянкаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // АвтомобильBindingSource
            // 
            this.АвтомобильBindingSource.DataMember = "Автомобиль";
            this.АвтомобильBindingSource.DataSource = this.автостоянкаDataSet1;
            // 
            // АвтомобильTableAdapter
            // 
            this.АвтомобильTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.FillWeight = 125F;
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.FillWeight = 150F;
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // госномерDataGridViewTextBoxColumn
            // 
            this.госномерDataGridViewTextBoxColumn.DataPropertyName = "Гос_номер";
            this.госномерDataGridViewTextBoxColumn.FillWeight = 75F;
            this.госномерDataGridViewTextBoxColumn.HeaderText = "Гос_номер";
            this.госномерDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.госномерDataGridViewTextBoxColumn.Name = "госномерDataGridViewTextBoxColumn";
            this.госномерDataGridViewTextBoxColumn.Width = 75;
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.FillWeight = 75F;
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            this.цветDataGridViewTextBoxColumn.Width = 75;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.DataSource = this.клиентBindingSource;
            this.iDКлиентаDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.iDКлиентаDataGridViewTextBoxColumn.FillWeight = 150F;
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.iDКлиентаDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКлиентаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКлиентаDataGridViewTextBoxColumn.ValueMember = "Код";
            this.iDКлиентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDКатегорииDataGridViewTextBoxColumn
            // 
            this.iDКатегорииDataGridViewTextBoxColumn.DataPropertyName = "ID категории";
            this.iDКатегорииDataGridViewTextBoxColumn.DataSource = this.категорияBindingSource;
            this.iDКатегорииDataGridViewTextBoxColumn.DisplayMember = "Категория";
            this.iDКатегорииDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.iDКатегорииDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.iDКатегорииDataGridViewTextBoxColumn.Name = "iDКатегорииDataGridViewTextBoxColumn";
            this.iDКатегорииDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКатегорииDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКатегорииDataGridViewTextBoxColumn.ValueMember = "Код";
            // 
            // количествоЗанимаемыхМестDataGridViewTextBoxColumn
            // 
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.DataPropertyName = "Количество занимаемых мест";
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.FillWeight = 75F;
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.HeaderText = "Количество занимаемых мест";
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.Name = "количествоЗанимаемыхМестDataGridViewTextBoxColumn";
            this.количествоЗанимаемыхМестDataGridViewTextBoxColumn.Width = 75;
            // 
            // Автомобили
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 412);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Автомобили";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АвтомобильBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private АвтостоянкаDataSet автостоянкаDataSet1;
        private АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter АвтомобильTableAdapter;
        private System.Windows.Forms.BindingSource АвтомобильBindingSource;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private АвтостоянкаDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЗанимаемыхМестDataGridViewTextBoxColumn;
    }
}

