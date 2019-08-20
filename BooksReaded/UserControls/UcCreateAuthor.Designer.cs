namespace BooksReaded.UserControls
{
    partial class UcCreateAuthor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateAuthor = new System.Windows.Forms.Button();
            this.TxtAuthorName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnCreateAuthor);
            this.groupBox2.Controls.Add(this.TxtAuthorName);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a new Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Author\'s Name";
            // 
            // BtnCreateAuthor
            // 
            this.BtnCreateAuthor.Location = new System.Drawing.Point(69, 54);
            this.BtnCreateAuthor.Name = "BtnCreateAuthor";
            this.BtnCreateAuthor.Size = new System.Drawing.Size(129, 23);
            this.BtnCreateAuthor.TabIndex = 0;
            this.BtnCreateAuthor.Text = "Create a new Author";
            this.BtnCreateAuthor.UseVisualStyleBackColor = true;
            this.BtnCreateAuthor.Click += new System.EventHandler(this.BtnCreateAuthor_Click);
            // 
            // TxtAuthorName
            // 
            this.TxtAuthorName.Location = new System.Drawing.Point(123, 25);
            this.TxtAuthorName.Name = "TxtAuthorName";
            this.TxtAuthorName.Size = new System.Drawing.Size(145, 20);
            this.TxtAuthorName.TabIndex = 3;
            // 
            // UcCreateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UcCreateAuthor";
            this.Size = new System.Drawing.Size(307, 96);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreateAuthor;
        private System.Windows.Forms.TextBox TxtAuthorName;
    }
}
