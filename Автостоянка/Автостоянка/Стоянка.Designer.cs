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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Стоянка));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.автостоянкаDataSet = new Автостоянка.АвтостоянкаDataSet();
            this.стоянкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоянкаTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.СтоянкаTableAdapter();
            this.tableAdapterManager = new Автостоянка.АвтостоянкаDataSetTableAdapters.TableAdapterManager();
            this.автомобильTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter();
            this.едИзмВремениTableAdapter = new Автостоянка.АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter();
            this.стоянкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.стоянкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.стоянкаDataGridView = new System.Windows.Forms.DataGridView();
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.едИзмВремениBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.КодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.АвтомобильDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОплаченоDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ВремяDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЕдИзмВремениDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.МестаColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаBindingNavigator)).BeginInit();
            this.стоянкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.едИзмВремениBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 28);
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
            // автостоянкаDataSet
            // 
            this.автостоянкаDataSet.DataSetName = "АвтостоянкаDataSet";
            this.автостоянкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стоянкаBindingSource
            // 
            this.стоянкаBindingSource.DataMember = "Стоянка";
            this.стоянкаBindingSource.DataSource = this.автостоянкаDataSet;
            // 
            // стоянкаTableAdapter
            // 
            this.стоянкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Автостоянка.АвтостоянкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = this.автомобильTableAdapter;
            this.tableAdapterManager.ЕдИзмВремениTableAdapter = this.едИзмВремениTableAdapter;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.Парковочное_местоTableAdapter = null;
            this.tableAdapterManager.СтоянкаTableAdapter = this.стоянкаTableAdapter;
            this.tableAdapterManager.Стоянки_Парковочные_местаTableAdapter = null;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // едИзмВремениTableAdapter
            // 
            this.едИзмВремениTableAdapter.ClearBeforeFill = true;
            // 
            // стоянкаBindingNavigator
            // 
            this.стоянкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.стоянкаBindingNavigator.BindingSource = this.стоянкаBindingSource;
            this.стоянкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.стоянкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.стоянкаBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.стоянкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.стоянкаBindingNavigatorSaveItem});
            this.стоянкаBindingNavigator.Location = new System.Drawing.Point(0, 437);
            this.стоянкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.стоянкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.стоянкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.стоянкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.стоянкаBindingNavigator.Name = "стоянкаBindingNavigator";
            this.стоянкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.стоянкаBindingNavigator.Size = new System.Drawing.Size(1148, 25);
            this.стоянкаBindingNavigator.TabIndex = 2;
            this.стоянкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // стоянкаBindingNavigatorSaveItem
            // 
            this.стоянкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.стоянкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("стоянкаBindingNavigatorSaveItem.Image")));
            this.стоянкаBindingNavigatorSaveItem.Name = "стоянкаBindingNavigatorSaveItem";
            this.стоянкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.стоянкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.стоянкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.стоянкаBindingNavigatorSaveItem_Click_1);
            // 
            // стоянкаDataGridView
            // 
            this.стоянкаDataGridView.AutoGenerateColumns = false;
            this.стоянкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.стоянкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.КодDataGridViewTextBoxColumn1,
            this.АвтомобильDataGridViewTextBoxColumn,
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3,
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4,
            this.СуммаDataGridViewTextBoxColumn5,
            this.ОплаченоDataGridViewCheckBoxColumn1,
            this.ВремяDataGridViewTextBoxColumn6,
            this.ЕдИзмВремениDataGridViewTextBoxColumn7,
            this.МестаColumn});
            this.стоянкаDataGridView.DataSource = this.стоянкаBindingSource;
            this.стоянкаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.стоянкаDataGridView.Location = new System.Drawing.Point(0, 28);
            this.стоянкаDataGridView.Name = "стоянкаDataGridView";
            this.стоянкаDataGridView.Size = new System.Drawing.Size(1148, 409);
            this.стоянкаDataGridView.TabIndex = 2;
            this.стоянкаDataGridView.VirtualMode = true;
            this.стоянкаDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.стоянкаDataGridView_RowValidating);
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.автостоянкаDataSet;
            // 
            // едИзмВремениBindingSource
            // 
            this.едИзмВремениBindingSource.DataMember = "ЕдИзмВремени";
            this.едИзмВремениBindingSource.DataSource = this.автостоянкаDataSet;
            // 
            // КодDataGridViewTextBoxColumn1
            // 
            this.КодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.КодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.КодDataGridViewTextBoxColumn1.Name = "КодDataGridViewTextBoxColumn1";
            this.КодDataGridViewTextBoxColumn1.Visible = false;
            // 
            // АвтомобильDataGridViewTextBoxColumn
            // 
            this.АвтомобильDataGridViewTextBoxColumn.DataPropertyName = "ID Автомобиля";
            this.АвтомобильDataGridViewTextBoxColumn.DataSource = this.автомобильBindingSource;
            this.АвтомобильDataGridViewTextBoxColumn.DisplayMember = "Гос_номер";
            this.АвтомобильDataGridViewTextBoxColumn.HeaderText = "Автомобиль";
            this.АвтомобильDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.АвтомобильDataGridViewTextBoxColumn.Name = "АвтомобильDataGridViewTextBoxColumn";
            this.АвтомобильDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.АвтомобильDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.АвтомобильDataGridViewTextBoxColumn.ValueMember = "Код";
            // 
            // ДатаВремяНачалаDataGridViewTextBoxColumn3
            // 
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.DataPropertyName = "Дата время начала";
            dataGridViewCellStyle1.Format = "g";
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.FillWeight = 150F;
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.HeaderText = "Дата время начала";
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.Name = "ДатаВремяНачалаDataGridViewTextBoxColumn3";
            this.ДатаВремяНачалаDataGridViewTextBoxColumn3.Width = 150;
            // 
            // ДатаВремяОкончанияDataGridViewTextBoxColumn4
            // 
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.DataPropertyName = "Дата время окончания";
            dataGridViewCellStyle2.Format = "g";
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.FillWeight = 150F;
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.HeaderText = "Дата время окончания";
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.MinimumWidth = 150;
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.Name = "ДатаВремяОкончанияDataGridViewTextBoxColumn4";
            this.ДатаВремяОкончанияDataGridViewTextBoxColumn4.Width = 150;
            // 
            // СуммаDataGridViewTextBoxColumn5
            // 
            this.СуммаDataGridViewTextBoxColumn5.DataPropertyName = "Сумма";
            this.СуммаDataGridViewTextBoxColumn5.FillWeight = 150F;
            this.СуммаDataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.СуммаDataGridViewTextBoxColumn5.MinimumWidth = 150;
            this.СуммаDataGridViewTextBoxColumn5.Name = "СуммаDataGridViewTextBoxColumn5";
            this.СуммаDataGridViewTextBoxColumn5.Width = 150;
            // 
            // ОплаченоDataGridViewCheckBoxColumn1
            // 
            this.ОплаченоDataGridViewCheckBoxColumn1.DataPropertyName = "Оплачено";
            this.ОплаченоDataGridViewCheckBoxColumn1.FillWeight = 75F;
            this.ОплаченоDataGridViewCheckBoxColumn1.HeaderText = "Оплачено";
            this.ОплаченоDataGridViewCheckBoxColumn1.MinimumWidth = 75;
            this.ОплаченоDataGridViewCheckBoxColumn1.Name = "ОплаченоDataGridViewCheckBoxColumn1";
            this.ОплаченоDataGridViewCheckBoxColumn1.Width = 75;
            // 
            // ВремяDataGridViewTextBoxColumn6
            // 
            this.ВремяDataGridViewTextBoxColumn6.DataPropertyName = "Время";
            this.ВремяDataGridViewTextBoxColumn6.FillWeight = 75F;
            this.ВремяDataGridViewTextBoxColumn6.HeaderText = "Время";
            this.ВремяDataGridViewTextBoxColumn6.MinimumWidth = 75;
            this.ВремяDataGridViewTextBoxColumn6.Name = "ВремяDataGridViewTextBoxColumn6";
            this.ВремяDataGridViewTextBoxColumn6.Width = 75;
            // 
            // ЕдИзмВремениDataGridViewTextBoxColumn7
            // 
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.DataPropertyName = "ID Ед изм времени";
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.DataSource = this.едИзмВремениBindingSource;
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.DisplayMember = "Наименование";
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.HeaderText = "Ед изм времени";
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.MinimumWidth = 100;
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.Name = "ЕдИзмВремениDataGridViewTextBoxColumn7";
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ЕдИзмВремениDataGridViewTextBoxColumn7.ValueMember = "Код";
            // 
            // МестаColumn
            // 
            this.МестаColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.МестаColumn.HeaderText = "Места";
            this.МестаColumn.MinimumWidth = 50;
            this.МестаColumn.Name = "МестаColumn";
            // 
            // Стоянка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 462);
            this.Controls.Add(this.стоянкаDataGridView);
            this.Controls.Add(this.стоянкаBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Стоянка";
            this.Text = "Стоянка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаBindingNavigator)).EndInit();
            this.стоянкаBindingNavigator.ResumeLayout(false);
            this.стоянкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.стоянкаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.едИзмВремениBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CreateButton;
        private АвтостоянкаDataSet автостоянкаDataSet;
        private System.Windows.Forms.BindingSource стоянкаBindingSource;
        private АвтостоянкаDataSetTableAdapters.СтоянкаTableAdapter стоянкаTableAdapter;
        private АвтостоянкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator стоянкаBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton стоянкаBindingNavigatorSaveItem;
        private АвтостоянкаDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private System.Windows.Forms.DataGridView стоянкаDataGridView;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private АвтостоянкаDataSetTableAdapters.ЕдИзмВремениTableAdapter едИзмВремениTableAdapter;
        private System.Windows.Forms.BindingSource едИзмВремениBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn КодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn АвтомобильDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВремяНачалаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВремяОкончанияDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ОплаченоDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВремяDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn ЕдИзмВремениDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn МестаColumn;
    }
}

