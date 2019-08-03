namespace BooksReaded.UserControls
{
    partial class UcMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNewBook = new System.Windows.Forms.Button();
            this.TxtPublishYear = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateAuthor = new System.Windows.Forms.Button();
            this.TxtAuthorName = new System.Windows.Forms.TextBox();
            this.GridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEditAuthor = new System.Windows.Forms.Button();
            this.CbAuthorsList = new System.Windows.Forms.ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBooks)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNewBook);
            this.groupBox1.Controls.Add(this.TxtPublishYear);
            this.groupBox1.Controls.Add(this.TxtTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbAuthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert a New Book";
            // 
            // BtnNewBook
            // 
            this.BtnNewBook.Location = new System.Drawing.Point(91, 140);
            this.BtnNewBook.Name = "BtnNewBook";
            this.BtnNewBook.Size = new System.Drawing.Size(130, 23);
            this.BtnNewBook.TabIndex = 4;
            this.BtnNewBook.Text = "Insert a new Book";
            this.BtnNewBook.UseVisualStyleBackColor = true;
            this.BtnNewBook.Click += new System.EventHandler(this.BtnNewBook_Click);
            // 
            // TxtPublishYear
            // 
            this.TxtPublishYear.Location = new System.Drawing.Point(135, 102);
            this.TxtPublishYear.Name = "TxtPublishYear";
            this.TxtPublishYear.Size = new System.Drawing.Size(100, 20);
            this.TxtPublishYear.TabIndex = 3;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(90, 70);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(145, 20);
            this.TxtTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of Publication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // CbAuthor
            // 
            this.CbAuthor.FormattingEnabled = true;
            this.CbAuthor.Location = new System.Drawing.Point(90, 35);
            this.CbAuthor.Name = "CbAuthor";
            this.CbAuthor.Size = new System.Drawing.Size(145, 21);
            this.CbAuthor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnCreateAuthor);
            this.groupBox2.Controls.Add(this.TxtAuthorName);
            this.groupBox2.Location = new System.Drawing.Point(301, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 90);
            this.groupBox2.TabIndex = 1;
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
            // GridViewBooks
            // 
            this.GridViewBooks.AutoGenerateColumns = false;
            this.GridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBookDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.YearPublication,
            this.authorDataGridViewTextBoxColumn});
            this.GridViewBooks.DataSource = this.bookBindingSource;
            this.GridViewBooks.Location = new System.Drawing.Point(5, 205);
            this.GridViewBooks.Name = "GridViewBooks";
            this.GridViewBooks.Size = new System.Drawing.Size(595, 193);
            this.GridViewBooks.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEditAuthor);
            this.groupBox3.Controls.Add(this.CbAuthorsList);
            this.groupBox3.Location = new System.Drawing.Point(301, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 84);
            this.groupBox3.TabIndex = 3;
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
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BooksReaded.Models.Book);
            // 
            // idBookDataGridViewTextBoxColumn
            // 
            this.idBookDataGridViewTextBoxColumn.DataPropertyName = "IdBook";
            this.idBookDataGridViewTextBoxColumn.HeaderText = "IdBook";
            this.idBookDataGridViewTextBoxColumn.Name = "idBookDataGridViewTextBoxColumn";
            this.idBookDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // YearPublication
            // 
            this.YearPublication.DataPropertyName = "YearPublication";
            this.YearPublication.HeaderText = "YearPublication";
            this.YearPublication.Name = "YearPublication";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // UcMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GridViewBooks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcMainScreen";
            this.Size = new System.Drawing.Size(605, 418);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBooks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNewBook;
        private System.Windows.Forms.TextBox TxtPublishYear;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCreateAuthor;
        private System.Windows.Forms.DataGridView GridViewBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAuthorName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEditAuthor;
        private System.Windows.Forms.ComboBox CbAuthorsList;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
    }
}
