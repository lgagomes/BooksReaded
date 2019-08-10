namespace BooksReaded.Forms
{
    partial class FrmEditAuthor
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
            this.BtnSaveAuthorChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAuthorEditName = new System.Windows.Forms.TextBox();
            this.BtnCancelAuthorEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSaveAuthorChange
            // 
            this.BtnSaveAuthorChange.Location = new System.Drawing.Point(14, 50);
            this.BtnSaveAuthorChange.Name = "BtnSaveAuthorChange";
            this.BtnSaveAuthorChange.Size = new System.Drawing.Size(93, 23);
            this.BtnSaveAuthorChange.TabIndex = 5;
            this.BtnSaveAuthorChange.Text = "Save Changes";
            this.BtnSaveAuthorChange.UseVisualStyleBackColor = true;
            this.BtnSaveAuthorChange.Click += new System.EventHandler(this.BtnSaveAuthorChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author\'s Name";
            // 
            // TxtAuthorEditName
            // 
            this.TxtAuthorEditName.Location = new System.Drawing.Point(93, 11);
            this.TxtAuthorEditName.Name = "TxtAuthorEditName";
            this.TxtAuthorEditName.Size = new System.Drawing.Size(130, 20);
            this.TxtAuthorEditName.TabIndex = 3;
            this.TxtAuthorEditName.TextChanged += new System.EventHandler(this.TxtAuthorEditName_TextChanged);
            // 
            // BtnCancelAuthorEdit
            // 
            this.BtnCancelAuthorEdit.Location = new System.Drawing.Point(130, 50);
            this.BtnCancelAuthorEdit.Name = "BtnCancelAuthorEdit";
            this.BtnCancelAuthorEdit.Size = new System.Drawing.Size(93, 23);
            this.BtnCancelAuthorEdit.TabIndex = 6;
            this.BtnCancelAuthorEdit.Text = "Cancel";
            this.BtnCancelAuthorEdit.UseVisualStyleBackColor = true;
            this.BtnCancelAuthorEdit.Click += new System.EventHandler(this.BtnCancelAuthorEdit_Click);
            // 
            // FrmEditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 94);
            this.Controls.Add(this.BtnCancelAuthorEdit);
            this.Controls.Add(this.BtnSaveAuthorChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAuthorEditName);
            this.MaximizeBox = false;
            this.Name = "FrmEditAuthor";
            this.Text = "Edit Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveAuthorChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAuthorEditName;
        private System.Windows.Forms.Button BtnCancelAuthorEdit;
    }
}