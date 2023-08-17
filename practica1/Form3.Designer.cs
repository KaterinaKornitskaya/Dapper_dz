namespace practica1
{
    partial class Form3
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
            this.listBoxOneAuthallBooks = new System.Windows.Forms.ListBox();
            this.buttonCloseForm3 = new System.Windows.Forms.Button();
            this.textBoxOneAuthForAllBooks = new System.Windows.Forms.TextBox();
            this.buttonOneAuthallBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxOneAuthallBooks
            // 
            this.listBoxOneAuthallBooks.FormattingEnabled = true;
            this.listBoxOneAuthallBooks.HorizontalScrollbar = true;
            this.listBoxOneAuthallBooks.Location = new System.Drawing.Point(12, 74);
            this.listBoxOneAuthallBooks.Name = "listBoxOneAuthallBooks";
            this.listBoxOneAuthallBooks.Size = new System.Drawing.Size(369, 95);
            this.listBoxOneAuthallBooks.TabIndex = 19;
            // 
            // buttonCloseForm3
            // 
            this.buttonCloseForm3.Location = new System.Drawing.Point(42, 187);
            this.buttonCloseForm3.Name = "buttonCloseForm3";
            this.buttonCloseForm3.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseForm3.TabIndex = 20;
            this.buttonCloseForm3.Text = "Закрыть";
            this.buttonCloseForm3.UseVisualStyleBackColor = true;
            this.buttonCloseForm3.Click += new System.EventHandler(this.buttonCloseForm3_Click);
            // 
            // textBoxOneAuthForAllBooks
            // 
            this.textBoxOneAuthForAllBooks.Location = new System.Drawing.Point(33, 48);
            this.textBoxOneAuthForAllBooks.Name = "textBoxOneAuthForAllBooks";
            this.textBoxOneAuthForAllBooks.Size = new System.Drawing.Size(100, 20);
            this.textBoxOneAuthForAllBooks.TabIndex = 21;
            // 
            // buttonOneAuthallBooks
            // 
            this.buttonOneAuthallBooks.Location = new System.Drawing.Point(170, 46);
            this.buttonOneAuthallBooks.Name = "buttonOneAuthallBooks";
            this.buttonOneAuthallBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonOneAuthallBooks.TabIndex = 22;
            this.buttonOneAuthallBooks.Text = "Показать";
            this.buttonOneAuthallBooks.UseVisualStyleBackColor = true;
            this.buttonOneAuthallBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id автора";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOneAuthallBooks);
            this.Controls.Add(this.textBoxOneAuthForAllBooks);
            this.Controls.Add(this.buttonCloseForm3);
            this.Controls.Add(this.listBoxOneAuthallBooks);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOneAuthallBooks;
        private System.Windows.Forms.Button buttonCloseForm3;
        private System.Windows.Forms.TextBox textBoxOneAuthForAllBooks;
        private System.Windows.Forms.Button buttonOneAuthallBooks;
        private System.Windows.Forms.Label label1;
    }
}