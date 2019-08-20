namespace BooksReaded.UserControls
{
    partial class UcEditAuthor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEditAuthor = new System.Windows.Forms.Button();
            this.CbAuthorsList = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEditAuthor);
            this.groupBox3.Controls.Add(this.CbAuthorsList);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Author";
            // 
            // BtnEditAuthor
            // 
            this.BtnEditAuthor.Location = new System.Drawing.Point(172, 28);
            this.BtnEditAuthor.Name = "BtnEditAuthor";
            this.BtnEditAuthor.Size = new System.Drawing.Size(96, 23);
            this.BtnEditAuthor.TabIndex = 1;
            this.BtnEditAuthor.Text = "Edit Author";
            this.BtnEditAuthor.UseVisualStyleBackColor = true;
            this.BtnEditAuthor.Click += new System.EventHandler(this.BtnEditAuthor_Click);
            // 
            // CbAuthorsList
            // 
            this.CbAuthorsList.FormattingEnabled = true;
            this.CbAuthorsList.Location = new System.Drawing.Point(6, 30);
            this.CbAuthorsList.Name = "CbAuthorsList";
            this.CbAuthorsList.Size = new System.Drawing.Size(138, 21);
            this.CbAuthorsList.TabIndex = 0;
            // 
            // UcEditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "UcEditAuthor";
            this.Size = new System.Drawing.Size(308, 92);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEditAuthor;
        private System.Windows.Forms.ComboBox CbAuthorsList;
    }
}
