namespace PR7
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label booksLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            booksLabel = new Label();
            booksListBox = new ListBox();
            createOrderButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(121, 25);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(234, 34);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Система предзаказов";
            titleLabel.Click += titleLabel_Click;
            // 
            // booksLabel
            // 
            booksLabel.Location = new Point(170, 89);
            booksLabel.Margin = new Padding(4, 0, 4, 0);
            booksLabel.Name = "booksLabel";
            booksLabel.Size = new Size(120, 23);
            booksLabel.TabIndex = 1;
            booksLabel.Text = "Доступные книги:";
            // 
            // booksListBox
            // 
            booksListBox.ForeColor = Color.Green;
            booksListBox.FormattingEnabled = true;
            booksListBox.ItemHeight = 15;
            booksListBox.Location = new Point(24, 116);
            booksListBox.Margin = new Padding(4, 4, 4, 4);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(407, 229);
            booksListBox.TabIndex = 2;
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(24, 369);
            createOrderButton.Margin = new Padding(4, 4, 4, 4);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(149, 34);
            createOrderButton.TabIndex = 3;
            createOrderButton.Text = "Оформить предзаказ";
            createOrderButton.Click += createOrderButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(315, 369);
            exitButton.Margin = new Padding(4, 4, 4, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(116, 34);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 482);
            Controls.Add(titleLabel);
            Controls.Add(booksLabel);
            Controls.Add(booksListBox);
            Controls.Add(createOrderButton);
            Controls.Add(exitButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Издательство - Система предзаказов";
            Load += MainForm_Load;
            ResumeLayout(false);
        }
    }
}