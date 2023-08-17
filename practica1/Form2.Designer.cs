namespace practica1
{
    partial class Form2
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
            this.listBoxAllAuthAllBooks = new System.Windows.Forms.ListBox();
            this.buttonCloseForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAllAuthAllBooks
            // 
            this.listBoxAllAuthAllBooks.FormattingEnabled = true;
            this.listBoxAllAuthAllBooks.HorizontalScrollbar = true;
            this.listBoxAllAuthAllBooks.Location = new System.Drawing.Point(12, 12);
            this.listBoxAllAuthAllBooks.Name = "listBoxAllAuthAllBooks";
            this.listBoxAllAuthAllBooks.Size = new System.Drawing.Size(378, 160);
            this.listBoxAllAuthAllBooks.TabIndex = 22;
            // 
            // buttonCloseForm2
            // 
            this.buttonCloseForm2.Location = new System.Drawing.Point(315, 187);
            this.buttonCloseForm2.Name = "buttonCloseForm2";
            this.buttonCloseForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseForm2.TabIndex = 23;
            this.buttonCloseForm2.Text = "Закрыть";
            this.buttonCloseForm2.UseVisualStyleBackColor = true;
            this.buttonCloseForm2.Click += new System.EventHandler(this.buttonCloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 225);
            this.Controls.Add(this.buttonCloseForm2);
            this.Controls.Add(this.listBoxAllAuthAllBooks);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllAuthAllBooks;
        private System.Windows.Forms.Button buttonCloseForm2;
    }
}