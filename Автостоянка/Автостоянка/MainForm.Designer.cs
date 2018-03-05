namespace Автостоянка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.МестаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ЕдИзмВремToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.КлиентыButton = new System.Windows.Forms.ToolStripButton();
            this.АвтомобилиToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.КатегорииToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.СтоянкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КлиентыButton,
            this.МестаToolStripButton,
            this.КатегорииToolStripButton,
            this.АвтомобилиToolStripButton,
            this.ЕдИзмВремToolStripButton,
            this.СтоянкаToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // МестаToolStripButton
            // 
            this.МестаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.МестаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.МестаToolStripButton.Name = "МестаToolStripButton";
            this.МестаToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.МестаToolStripButton.Text = "Места";
            this.МестаToolStripButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // ЕдИзмВремToolStripButton
            // 
            this.ЕдИзмВремToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ЕдИзмВремToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ЕдИзмВремToolStripButton.Name = "ЕдИзмВремToolStripButton";
            this.ЕдИзмВремToolStripButton.Size = new System.Drawing.Size(123, 22);
            this.ЕдИзмВремToolStripButton.Text = "Единицы измерения";
            this.ЕдИзмВремToolStripButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // КлиентыButton
            // 
            this.КлиентыButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.КлиентыButton.Image = ((System.Drawing.Image)(resources.GetObject("КлиентыButton.Image")));
            this.КлиентыButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.КлиентыButton.Name = "КлиентыButton";
            this.КлиентыButton.Size = new System.Drawing.Size(59, 22);
            this.КлиентыButton.Text = "Клиенты";
            this.КлиентыButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.КлиентыButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // АвтомобилиToolStripButton
            // 
            this.АвтомобилиToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.АвтомобилиToolStripButton.Name = "АвтомобилиToolStripButton";
            this.АвтомобилиToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.АвтомобилиToolStripButton.Text = "Автомобили";
            this.АвтомобилиToolStripButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // КатегорииToolStripButton
            // 
            this.КатегорииToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.КатегорииToolStripButton.Name = "КатегорииToolStripButton";
            this.КатегорииToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.КатегорииToolStripButton.Text = "Категории";
            this.КатегорииToolStripButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // СтоянкаToolStripButton
            // 
            this.СтоянкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.СтоянкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("СтоянкаToolStripButton.Image")));
            this.СтоянкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.СтоянкаToolStripButton.Name = "СтоянкаToolStripButton";
            this.СтоянкаToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.СтоянкаToolStripButton.Text = "Стоянка";
            this.СтоянкаToolStripButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Автостоянка";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton КлиентыButton;
        private System.Windows.Forms.ToolStripButton МестаToolStripButton;
        private System.Windows.Forms.ToolStripButton ЕдИзмВремToolStripButton;
        private System.Windows.Forms.ToolStripButton АвтомобилиToolStripButton;
        private System.Windows.Forms.ToolStripButton КатегорииToolStripButton;
        private System.Windows.Forms.ToolStripButton СтоянкаToolStripButton;
    }
}

