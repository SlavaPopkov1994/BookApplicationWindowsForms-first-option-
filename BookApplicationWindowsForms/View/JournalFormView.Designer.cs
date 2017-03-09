namespace BookApplicationWindowsForms
{
    partial class JournalFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListJournalsTb = new System.Windows.Forms.ListBox();
            this.ListJournalsBt = new System.Windows.Forms.Button();
            this.SaveJournals = new System.Windows.Forms.Button();
            this.openFileDialogJournal = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ListJournalsTb
            // 
            this.ListJournalsTb.FormattingEnabled = true;
            this.ListJournalsTb.ItemHeight = 16;
            this.ListJournalsTb.Location = new System.Drawing.Point(12, 26);
            this.ListJournalsTb.Name = "ListJournalsTb";
            this.ListJournalsTb.Size = new System.Drawing.Size(558, 196);
            this.ListJournalsTb.TabIndex = 0;
            // 
            // ListJournalsBt
            // 
            this.ListJournalsBt.Location = new System.Drawing.Point(237, 250);
            this.ListJournalsBt.Name = "ListJournalsBt";
            this.ListJournalsBt.Size = new System.Drawing.Size(113, 43);
            this.ListJournalsBt.TabIndex = 1;
            this.ListJournalsBt.Text = "List Journals";
            this.ListJournalsBt.UseVisualStyleBackColor = true;
            this.ListJournalsBt.Click += new System.EventHandler(this.ListJournalsBt_Click);
            // 
            // SaveJournals
            // 
            this.SaveJournals.Location = new System.Drawing.Point(86, 250);
            this.SaveJournals.Name = "SaveJournals";
            this.SaveJournals.Size = new System.Drawing.Size(113, 43);
            this.SaveJournals.TabIndex = 2;
            this.SaveJournals.Text = "Save Journals";
            this.SaveJournals.UseVisualStyleBackColor = true;
            this.SaveJournals.Click += new System.EventHandler(this.SaveJournals_Click);
            // 
            // openFileDialogJournal
            // 
            this.openFileDialogJournal.FileName = "JournalFile.txt";
            // 
            // JournalsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 305);
            this.Controls.Add(this.SaveJournals);
            this.Controls.Add(this.ListJournalsBt);
            this.Controls.Add(this.ListJournalsTb);
            this.Name = "JournalsForms";
            this.Text = "JournalFormView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListJournalsTb;
        private System.Windows.Forms.Button ListJournalsBt;
        private System.Windows.Forms.Button SaveJournals;
        private System.Windows.Forms.OpenFileDialog openFileDialogJournal;
    }
}