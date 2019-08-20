namespace BooksReaded.Forms
{
    partial class FrmMainScreen
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
            this.ucBooksList1 = new BooksReaded.UserControls.UcBooksList();
            this.ucEditAuthor1 = new BooksReaded.UserControls.UcEditAuthor();
            this.ucCreateAuthor1 = new BooksReaded.UserControls.UcCreateAuthor();
            this.ucCreateBook1 = new BooksReaded.UserControls.UcCreateBook();
            this.SuspendLayout();
            // 
            // ucBooksList1
            // 
            this.ucBooksList1.Location = new System.Drawing.Point(12, 218);
            this.ucBooksList1.Name = "ucBooksList1";
            this.ucBooksList1.Size = new System.Drawing.Size(624, 200);
            this.ucBooksList1.TabIndex = 3;
            // 
            // ucEditAuthor1
            // 
            this.ucEditAuthor1.Location = new System.Drawing.Point(328, 120);
            this.ucEditAuthor1.Name = "ucEditAuthor1";
            this.ucEditAuthor1.Size = new System.Drawing.Size(308, 92);
            this.ucEditAuthor1.TabIndex = 2;
            // 
            // ucCreateAuthor1
            // 
            this.ucCreateAuthor1.Location = new System.Drawing.Point(328, 11);
            this.ucCreateAuthor1.Name = "ucCreateAuthor1";
            this.ucCreateAuthor1.Size = new System.Drawing.Size(307, 96);
            this.ucCreateAuthor1.TabIndex = 1;
            // 
            // ucCreateBook1
            // 
            this.ucCreateBook1.Location = new System.Drawing.Point(12, 12);
            this.ucCreateBook1.Name = "ucCreateBook1";
            this.ucCreateBook1.Size = new System.Drawing.Size(299, 196);
            this.ucCreateBook1.TabIndex = 0;
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 420);
            this.Controls.Add(this.ucBooksList1);
            this.Controls.Add(this.ucEditAuthor1);
            this.Controls.Add(this.ucCreateAuthor1);
            this.Controls.Add(this.ucCreateBook1);
            this.MaximizeBox = false;
            this.Name = "FrmMainScreen";
            this.Text = "Books Readed";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcCreateBook ucCreateBook1;
        private UserControls.UcCreateAuthor ucCreateAuthor1;
        private UserControls.UcEditAuthor ucEditAuthor1;
        private UserControls.UcBooksList ucBooksList1;
    }
}