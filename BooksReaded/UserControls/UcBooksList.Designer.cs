namespace BooksReaded.UserControls
{
    partial class UcBooksList
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
            this.GridViewBooks = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewBooks
            // 
            this.GridViewBooks.AutoGenerateColumns = false;
            this.GridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBookDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.YearPublication,
            this.authorDataGridViewTextBoxColumn,
            this.Edit});
            this.GridViewBooks.DataSource = this.bookBindingSource;
            this.GridViewBooks.Location = new System.Drawing.Point(3, 3);
            this.GridViewBooks.Name = "GridViewBooks";
            this.GridViewBooks.Size = new System.Drawing.Size(612, 193);
            this.GridViewBooks.TabIndex = 3;
            this.GridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBooks_CellClick);
            this.GridViewBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridViewBooks_CellFormatting);
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
            this.YearPublication.HeaderText = "Year of Publication";
            this.YearPublication.Name = "YearPublication";
            this.YearPublication.ReadOnly = true;
            this.YearPublication.Width = 120;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Book";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            // 
            // UcBooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewBooks);
            this.Name = "UcBooksList";
            this.Size = new System.Drawing.Size(618, 200);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewBooks;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}
