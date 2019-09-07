namespace BooksReaded.Forms
{
    partial class FrmEditBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbAuthorToEdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTitleToEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYearToEdit = new System.Windows.Forms.TextBox();
            this.BtnSaveBookChanges = new System.Windows.Forms.Button();
            this.BtnCancelBookChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // CbAuthorToEdit
            // 
            this.CbAuthorToEdit.FormattingEnabled = true;
            this.CbAuthorToEdit.Location = new System.Drawing.Point(72, 6);
            this.CbAuthorToEdit.Name = "CbAuthorToEdit";
            this.CbAuthorToEdit.Size = new System.Drawing.Size(142, 21);
            this.CbAuthorToEdit.TabIndex = 2;
            this.CbAuthorToEdit.SelectedIndexChanged += new System.EventHandler(this.CbAuthorToEdit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // TxtTitleToEdit
            // 
            this.TxtTitleToEdit.Location = new System.Drawing.Point(72, 47);
            this.TxtTitleToEdit.Name = "TxtTitleToEdit";
            this.TxtTitleToEdit.Size = new System.Drawing.Size(142, 20);
            this.TxtTitleToEdit.TabIndex = 4;
            this.TxtTitleToEdit.TextChanged += new System.EventHandler(this.TxtTitleToEdit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year of Publication";
            // 
            // TxtYearToEdit
            // 
            this.TxtYearToEdit.Location = new System.Drawing.Point(114, 88);
            this.TxtYearToEdit.Name = "TxtYearToEdit";
            this.TxtYearToEdit.Size = new System.Drawing.Size(100, 20);
            this.TxtYearToEdit.TabIndex = 6;
            this.TxtYearToEdit.TextChanged += new System.EventHandler(this.TxtYearToEdit_TextChanged);
            this.TxtYearToEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYearToEdit_KeyPress);
            // 
            // BtnSaveBookChanges
            // 
            this.BtnSaveBookChanges.Location = new System.Drawing.Point(9, 147);
            this.BtnSaveBookChanges.Name = "BtnSaveBookChanges";
            this.BtnSaveBookChanges.Size = new System.Drawing.Size(87, 23);
            this.BtnSaveBookChanges.TabIndex = 7;
            this.BtnSaveBookChanges.Text = "Save Changes";
            this.BtnSaveBookChanges.UseVisualStyleBackColor = true;
            this.BtnSaveBookChanges.Click += new System.EventHandler(this.BtnSaveBookChanges_Click);
            // 
            // BtnCancelBookChanges
            // 
            this.BtnCancelBookChanges.Location = new System.Drawing.Point(127, 147);
            this.BtnCancelBookChanges.Name = "BtnCancelBookChanges";
            this.BtnCancelBookChanges.Size = new System.Drawing.Size(87, 23);
            this.BtnCancelBookChanges.TabIndex = 8;
            this.BtnCancelBookChanges.Text = "Cancel";
            this.BtnCancelBookChanges.UseVisualStyleBackColor = true;
            this.BtnCancelBookChanges.Click += new System.EventHandler(this.BtnCancelBookChanges_Click);
            // 
            // FrmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 192);
            this.Controls.Add(this.BtnCancelBookChanges);
            this.Controls.Add(this.BtnSaveBookChanges);
            this.Controls.Add(this.TxtYearToEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTitleToEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbAuthorToEdit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmEditBook";
            this.Text = "Edit Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbAuthorToEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitleToEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYearToEdit;
        private System.Windows.Forms.Button BtnSaveBookChanges;
        private System.Windows.Forms.Button BtnCancelBookChanges;
    }
}