namespace WindowsFormsApp4
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
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInfoSelectedItem = new System.Windows.Forms.TextBox();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.Location = new System.Drawing.Point(25, 13);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(274, 342);
            this.listBoxElements.TabIndex = 0;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(25, 374);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(274, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Удалить выбранный элемент";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(25, 415);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(274, 23);
            this.buttonClearList.TabIndex = 2;
            this.buttonClearList.Text = "Очистить весь список";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация о выбранном элементе";
            // 
            // textBoxInfoSelectedItem
            // 
            this.textBoxInfoSelectedItem.Location = new System.Drawing.Point(340, 45);
            this.textBoxInfoSelectedItem.Multiline = true;
            this.textBoxInfoSelectedItem.Name = "textBoxInfoSelectedItem";
            this.textBoxInfoSelectedItem.ReadOnly = true;
            this.textBoxInfoSelectedItem.Size = new System.Drawing.Size(385, 60);
            this.textBoxInfoSelectedItem.TabIndex = 4;
            this.textBoxInfoSelectedItem.Text = "Элемент не выбран";
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxNewItem.Location = new System.Drawing.Point(340, 126);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(385, 20);
            this.textBoxNewItem.TabIndex = 5;
            this.textBoxNewItem.Text = "Введите элемент для добавления";
            this.textBoxNewItem.TextChanged += new System.EventHandler(this.textBoxNewItem_TextChanged);
            this.textBoxNewItem.MouseEnter += new System.EventHandler(this.textBoxNewItem_MouseEnter);
            this.textBoxNewItem.MouseLeave += new System.EventHandler(this.textBoxNewItem_MouseLeave);
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(580, 152);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(145, 23);
            this.buttonAddElement.TabIndex = 6;
            this.buttonAddElement.Text = "Добавить элемент ";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(340, 203);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(385, 194);
            this.textBoxLog.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "События списка";
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(580, 415);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(145, 23);
            this.buttonClearLog.TabIndex = 9;
            this.buttonClearLog.Text = "Очистить лог событий";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonAddElement);
            this.Controls.Add(this.textBoxNewItem);
            this.Controls.Add(this.textBoxInfoSelectedItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxElements);
            this.Name = "Form1";
            this.Text = "Работа со списками";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInfoSelectedItem;
        private System.Windows.Forms.TextBox textBoxNewItem;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearLog;
    }
}

