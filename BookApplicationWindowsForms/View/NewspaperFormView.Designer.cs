namespace BookApplicationWindowsForms
{
    partial class NewspaperFormView
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
            this.ListNewspapersTb = new System.Windows.Forms.ListBox();
            this.ListNewspapersBt = new System.Windows.Forms.Button();
            this.SaveNewspapers = new System.Windows.Forms.Button();
            this.openFileDialogNewspaper = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ListNewspapersTb
            // 
            this.ListNewspapersTb.FormattingEnabled = true;
            this.ListNewspapersTb.ItemHeight = 16;
            this.ListNewspapersTb.Location = new System.Drawing.Point(12, 26);
            this.ListNewspapersTb.Name = "ListNewspapersTb";
            this.ListNewspapersTb.Size = new System.Drawing.Size(558, 196);
            this.ListNewspapersTb.TabIndex = 0;
            // 
            // ListNewspapersBt
            // 
            this.ListNewspapersBt.Location = new System.Drawing.Point(237, 250);
            this.ListNewspapersBt.Name = "ListNewspapersBt";
            this.ListNewspapersBt.Size = new System.Drawing.Size(113, 43);
            this.ListNewspapersBt.TabIndex = 1;
            this.ListNewspapersBt.Text = "List Newspapers";
            this.ListNewspapersBt.UseVisualStyleBackColor = true;
            this.ListNewspapersBt.Click += new System.EventHandler(this.ListNewspapersBt_Click);
            // 
            // SaveNewspapers
            // 
            this.SaveNewspapers.Location = new System.Drawing.Point(86, 250);
            this.SaveNewspapers.Name = "SaveNewspapers";
            this.SaveNewspapers.Size = new System.Drawing.Size(113, 43);
            this.SaveNewspapers.TabIndex = 2;
            this.SaveNewspapers.Text = "Save Newspapers";
            this.SaveNewspapers.UseVisualStyleBackColor = true;
            this.SaveNewspapers.Click += new System.EventHandler(this.SaveNewspapers_Click);
            // 
            // openFileDialogNewspaper
            // 
            this.openFileDialogNewspaper.FileName = "NewspaperFile.txt";
            // 
            // NewspapersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 305);
            this.Controls.Add(this.SaveNewspapers);
            this.Controls.Add(this.ListNewspapersBt);
            this.Controls.Add(this.ListNewspapersTb);
            this.Name = "NewspapersForms";
            this.Text = "NewspaperFormView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListNewspapersTb;
        private System.Windows.Forms.Button ListNewspapersBt;
        private System.Windows.Forms.Button SaveNewspapers;
        private System.Windows.Forms.OpenFileDialog openFileDialogNewspaper;
    }
}