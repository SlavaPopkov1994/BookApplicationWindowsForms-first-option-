namespace BookApplicationWindowsForms
{
    partial class BookFormView
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
            this.ListBooksTb = new System.Windows.Forms.ListBox();
            this.ListBooksBt = new System.Windows.Forms.Button();
            this.SaveBooksXML = new System.Windows.Forms.Button();
            this.openFileDialogBook = new System.Windows.Forms.OpenFileDialog();
            this.SaveBooksDB = new System.Windows.Forms.Button();
            this.ExitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBooksTb
            // 
            this.ListBooksTb.FormattingEnabled = true;
            this.ListBooksTb.ItemHeight = 16;
            this.ListBooksTb.Location = new System.Drawing.Point(12, 27);
            this.ListBooksTb.Name = "ListBooksTb";
            this.ListBooksTb.Size = new System.Drawing.Size(558, 196);
            this.ListBooksTb.TabIndex = 0;
            // 
            // ListBooksBt
            // 
            this.ListBooksBt.Location = new System.Drawing.Point(305, 250);
            this.ListBooksBt.Name = "ListBooksBt";
            this.ListBooksBt.Size = new System.Drawing.Size(113, 43);
            this.ListBooksBt.TabIndex = 1;
            this.ListBooksBt.Text = "List Books";
            this.ListBooksBt.UseVisualStyleBackColor = true;
            this.ListBooksBt.Click += new System.EventHandler(this.ListBooksBt_Click);
            // 
            // SaveBooksXML
            // 
            this.SaveBooksXML.Location = new System.Drawing.Point(158, 250);
            this.SaveBooksXML.Name = "SaveBooksXML";
            this.SaveBooksXML.Size = new System.Drawing.Size(113, 43);
            this.SaveBooksXML.TabIndex = 2;
            this.SaveBooksXML.Text = "Save Books in XML";
            this.SaveBooksXML.UseVisualStyleBackColor = true;
            this.SaveBooksXML.Click += new System.EventHandler(this.SaveBooksXML_Click);
            // 
            // openFileDialogBook
            // 
            this.openFileDialogBook.FileName = "BookFile.xml";
            // 
            // SaveBooksDB
            // 
            this.SaveBooksDB.Location = new System.Drawing.Point(457, 250);
            this.SaveBooksDB.Name = "SaveBooksDB";
            this.SaveBooksDB.Size = new System.Drawing.Size(113, 43);
            this.SaveBooksDB.TabIndex = 3;
            this.SaveBooksDB.Text = "Save Books in DB";
            this.SaveBooksDB.UseVisualStyleBackColor = true;
            this.SaveBooksDB.Click += new System.EventHandler(this.SaveBooksDB_Click);
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(12, 250);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(113, 43);
            this.ExitBt.TabIndex = 4;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // BookForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 305);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.SaveBooksDB);
            this.Controls.Add(this.SaveBooksXML);
            this.Controls.Add(this.ListBooksBt);
            this.Controls.Add(this.ListBooksTb);
            this.Name = "BookForms";
            this.Text = "BookFormView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookForms_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBooksTb;
        private System.Windows.Forms.Button ListBooksBt;
        private System.Windows.Forms.Button SaveBooksXML;
        private System.Windows.Forms.OpenFileDialog openFileDialogBook;
        private System.Windows.Forms.Button SaveBooksDB;
        private System.Windows.Forms.Button ExitBt;
    }
}