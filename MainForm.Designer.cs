namespace oaip12
{
    partial class MainForm
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
            this.AppsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton_Click = new System.Windows.Forms.Button();
            this.ExitButton_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppsDataGridView
            // 
            this.AppsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.AppsDataGridView.Name = "AppsDataGridView";
            this.AppsDataGridView.RowHeadersWidth = 51;
            this.AppsDataGridView.RowTemplate.Height = 29;
            this.AppsDataGridView.Size = new System.Drawing.Size(556, 426);
            this.AppsDataGridView.TabIndex = 0;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(649, 37);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(94, 29);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Добавить";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // DeleteBookButton_Click
            // 
            this.DeleteBookButton_Click.Location = new System.Drawing.Point(649, 84);
            this.DeleteBookButton_Click.Name = "DeleteBookButton_Click";
            this.DeleteBookButton_Click.Size = new System.Drawing.Size(94, 29);
            this.DeleteBookButton_Click.TabIndex = 2;
            this.DeleteBookButton_Click.Text = "Удалить";
            this.DeleteBookButton_Click.UseVisualStyleBackColor = true;
            this.DeleteBookButton_Click.Click += new System.EventHandler(this.DeleteBookButton_Click_Click);
            // 
            // ExitButton_Click
            // 
            this.ExitButton_Click.Location = new System.Drawing.Point(694, 409);
            this.ExitButton_Click.Name = "ExitButton_Click";
            this.ExitButton_Click.Size = new System.Drawing.Size(94, 29);
            this.ExitButton_Click.TabIndex = 3;
            this.ExitButton_Click.Text = "Выход";
            this.ExitButton_Click.UseVisualStyleBackColor = true;
            this.ExitButton_Click.Click += new System.EventHandler(this.ExitButton_Click_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton_Click);
            this.Controls.Add(this.DeleteBookButton_Click);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.AppsDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.AppsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddBookButton;
        public DataGridView AppsDataGridView;
        private TextBox textBox1;
        private Button DeleteBookButton_Click;
        public Button ExitButton_Click;
        public Button button1;
    }
}