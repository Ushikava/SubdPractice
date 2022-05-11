namespace SubdSecond
{
    partial class AddBookForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookPagesTextBox = new System.Windows.Forms.TextBox();
            this.bookGenreLabel = new System.Windows.Forms.Label();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookPagesLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookGenreComboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.choosePictureButton = new System.Windows.Forms.Button();
            this.addPictureLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.bookNameLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bookPagesTextBox, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.bookGenreLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.bookAuthorTextBox, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.bookAuthorLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.bookPagesLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.bookNameTextBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bookGenreComboBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.acceptButton, 1, 5);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.choosePictureButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.addPictureLabel, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90383F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90383F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90383F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90383F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90383F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48086F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(582, 390);
            this.mainTableLayoutPanel.TabIndex = 8;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookNameLabel.Location = new System.Drawing.Point(2, 0);
            this.bookNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(287, 65);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Название:";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookPagesTextBox
            // 
            this.bookPagesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookPagesTextBox.Location = new System.Drawing.Point(293, 212);
            this.bookPagesTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookPagesTextBox.Name = "bookPagesTextBox";
            this.bookPagesTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookPagesTextBox.TabIndex = 7;
            this.bookPagesTextBox.TextChanged += new System.EventHandler(this.bookPagesTextBox_TextChanged);
            // 
            // bookGenreLabel
            // 
            this.bookGenreLabel.AutoSize = true;
            this.bookGenreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGenreLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookGenreLabel.Location = new System.Drawing.Point(2, 65);
            this.bookGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookGenreLabel.Name = "bookGenreLabel";
            this.bookGenreLabel.Size = new System.Drawing.Size(287, 65);
            this.bookGenreLabel.TabIndex = 1;
            this.bookGenreLabel.Text = "Жанр:";
            this.bookGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookAuthorTextBox.Location = new System.Drawing.Point(293, 147);
            this.bookAuthorTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookAuthorTextBox.TabIndex = 6;
            this.bookAuthorTextBox.TextChanged += new System.EventHandler(this.bookAuthorTextBox_TextChanged);
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAuthorLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookAuthorLabel.Location = new System.Drawing.Point(2, 130);
            this.bookAuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(287, 65);
            this.bookAuthorLabel.TabIndex = 2;
            this.bookAuthorLabel.Text = "Автор:";
            this.bookAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookPagesLabel
            // 
            this.bookPagesLabel.AutoSize = true;
            this.bookPagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPagesLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookPagesLabel.Location = new System.Drawing.Point(2, 195);
            this.bookPagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookPagesLabel.Name = "bookPagesLabel";
            this.bookPagesLabel.Size = new System.Drawing.Size(287, 65);
            this.bookPagesLabel.TabIndex = 3;
            this.bookPagesLabel.Text = "Кол-во страниц:";
            this.bookPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookNameTextBox.Location = new System.Drawing.Point(293, 17);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookNameTextBox.TabIndex = 4;
            this.bookNameTextBox.TextChanged += new System.EventHandler(this.bookNameTextBox_TextChanged);
            // 
            // bookGenreComboBox
            // 
            this.bookGenreComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookGenreComboBox.FormattingEnabled = true;
            this.bookGenreComboBox.Location = new System.Drawing.Point(293, 81);
            this.bookGenreComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookGenreComboBox.Name = "bookGenreComboBox";
            this.bookGenreComboBox.Size = new System.Drawing.Size(250, 33);
            this.bookGenreComboBox.TabIndex = 10;
            this.bookGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.bookGenreComboBox_SelectedIndexChanged);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(351, 328);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(171, 59);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(63, 328);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(164, 59);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // choosePictureButton
            // 
            this.choosePictureButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.choosePictureButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePictureButton.Location = new System.Drawing.Point(293, 266);
            this.choosePictureButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.choosePictureButton.Name = "choosePictureButton";
            this.choosePictureButton.Size = new System.Drawing.Size(166, 52);
            this.choosePictureButton.TabIndex = 11;
            this.choosePictureButton.Text = "Выбрать";
            this.choosePictureButton.UseVisualStyleBackColor = true;
            this.choosePictureButton.Click += new System.EventHandler(this.choosePictureButton_Click);
            // 
            // addPictureLabel
            // 
            this.addPictureLabel.AutoSize = true;
            this.addPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPictureLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPictureLabel.Location = new System.Drawing.Point(2, 260);
            this.addPictureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPictureLabel.Name = "addPictureLabel";
            this.addPictureLabel.Size = new System.Drawing.Size(287, 65);
            this.addPictureLabel.TabIndex = 12;
            this.addPictureLabel.Text = "Обложка:";
            this.addPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 390);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Добавить книгу";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label bookGenreLabel;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookPagesLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox bookPagesTextBox;
        private System.Windows.Forms.ComboBox bookGenreComboBox;
        private System.Windows.Forms.Button choosePictureButton;
        private System.Windows.Forms.Label addPictureLabel;
    }
}