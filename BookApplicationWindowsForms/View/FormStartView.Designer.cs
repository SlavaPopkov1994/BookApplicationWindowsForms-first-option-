namespace BookApplicationWindowsForms
{
    partial class FormStartView
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
            this.FormBooksBt = new System.Windows.Forms.Button();
            this.FormJournalsBt = new System.Windows.Forms.Button();
            this.FormNewspapersBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormBooksBt
            // 
            this.FormBooksBt.Location = new System.Drawing.Point(12, 17);
            this.FormBooksBt.Name = "FormBooksBt";
            this.FormBooksBt.Size = new System.Drawing.Size(161, 49);
            this.FormBooksBt.TabIndex = 0;
            this.FormBooksBt.Text = "List of books";
            this.FormBooksBt.UseVisualStyleBackColor = true;
            this.FormBooksBt.Click += new System.EventHandler(this.ListBooks_Click);
            // 
            // FormJournalsBt
            // 
            this.FormJournalsBt.Location = new System.Drawing.Point(12, 127);
            this.FormJournalsBt.Name = "FormJournalsBt";
            this.FormJournalsBt.Size = new System.Drawing.Size(161, 49);
            this.FormJournalsBt.TabIndex = 2;
            this.FormJournalsBt.Text = "List of journals";
            this.FormJournalsBt.UseVisualStyleBackColor = true;
            this.FormJournalsBt.Click += new System.EventHandler(this.ListJournalsBt_Click);
            // 
            // FormNewspapersBt
            // 
            this.FormNewspapersBt.Location = new System.Drawing.Point(12, 72);
            this.FormNewspapersBt.Name = "FormNewspapersBt";
            this.FormNewspapersBt.Size = new System.Drawing.Size(161, 49);
            this.FormNewspapersBt.TabIndex = 3;
            this.FormNewspapersBt.Text = "List of newspapers";
            this.FormNewspapersBt.UseVisualStyleBackColor = true;
            this.FormNewspapersBt.Click += new System.EventHandler(this.ListNewspapersBt_Click);
            // 
            // FormStartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 205);
            this.Controls.Add(this.FormNewspapersBt);
            this.Controls.Add(this.FormJournalsBt);
            this.Controls.Add(this.FormBooksBt);
            this.Name = "FormStartView";
            this.Text = "FormStartView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormBooksBt;
        private System.Windows.Forms.Button FormJournalsBt;
        private System.Windows.Forms.Button FormNewspapersBt;
    }
}

