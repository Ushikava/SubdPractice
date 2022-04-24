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
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.bookGenreComboBox = new System.Windows.Forms.ComboBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
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
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.acceptButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.bookGenreComboBox, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(574, 349);
            this.mainTableLayoutPanel.TabIndex = 8;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookNameLabel.Location = new System.Drawing.Point(3, 0);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(281, 69);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Название:";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookPagesTextBox
            // 
            this.bookPagesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookPagesTextBox.Location = new System.Drawing.Point(290, 226);
            this.bookPagesTextBox.Name = "bookPagesTextBox";
            this.bookPagesTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookPagesTextBox.TabIndex = 7;
            this.bookPagesTextBox.TextChanged += new System.EventHandler(this.bookPagesTextBox_TextChanged);
            // 
            // bookGenreLabel
            // 
            this.bookGenreLabel.AutoSize = true;
            this.bookGenreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGenreLabel.Location = new System.Drawing.Point(3, 69);
            this.bookGenreLabel.Name = "bookGenreLabel";
            this.bookGenreLabel.Size = new System.Drawing.Size(281, 69);
            this.bookGenreLabel.TabIndex = 1;
            this.bookGenreLabel.Text = "Жанр:";
            this.bookGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookAuthorTextBox.Location = new System.Drawing.Point(290, 157);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookAuthorTextBox.TabIndex = 6;
            this.bookAuthorTextBox.TextChanged += new System.EventHandler(this.bookAuthorTextBox_TextChanged);
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAuthorLabel.Location = new System.Drawing.Point(3, 138);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(281, 69);
            this.bookAuthorLabel.TabIndex = 2;
            this.bookAuthorLabel.Text = "Автор:";
            this.bookAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookPagesLabel
            // 
            this.bookPagesLabel.AutoSize = true;
            this.bookPagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPagesLabel.Location = new System.Drawing.Point(3, 207);
            this.bookPagesLabel.Name = "bookPagesLabel";
            this.bookPagesLabel.Size = new System.Drawing.Size(281, 69);
            this.bookPagesLabel.TabIndex = 3;
            this.bookPagesLabel.Text = "Кол-во страниц:";
            this.bookPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookNameTextBox.Location = new System.Drawing.Point(290, 19);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(250, 31);
            this.bookNameTextBox.TabIndex = 4;
            this.bookNameTextBox.TextChanged += new System.EventHandler(this.bookNameTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(63, 286);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 53);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.Location = new System.Drawing.Point(350, 286);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(160, 53);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // bookGenreComboBox
            // 
            this.bookGenreComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookGenreComboBox.FormattingEnabled = true;
            this.bookGenreComboBox.Location = new System.Drawing.Point(290, 87);
            this.bookGenreComboBox.Name = "bookGenreComboBox";
            this.bookGenreComboBox.Size = new System.Drawing.Size(250, 33);
            this.bookGenreComboBox.TabIndex = 10;
            this.bookGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.bookGenreComboBox_SelectedIndexChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 349);
            this.Controls.Add(this.mainTableLayoutPanel);
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
    }
}