namespace BooksReaded
{
    partial class Form1
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
            this.ucMainScreen1 = new BooksReaded.UserControls.UcMainScreen();
            this.SuspendLayout();
            // 
            // ucMainScreen1
            // 
            this.ucMainScreen1.Location = new System.Drawing.Point(12, 12);
            this.ucMainScreen1.Name = "ucMainScreen1";
            this.ucMainScreen1.Size = new System.Drawing.Size(605, 418);
            this.ucMainScreen1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 429);
            this.Controls.Add(this.ucMainScreen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcMainScreen ucMainScreen1;
    }
}

