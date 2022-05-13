namespace SubdSecond
{
    partial class FindBookForm
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
            this.findBookTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.chooseCharLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.paramComboBox = new System.Windows.Forms.ComboBox();
            this.findBookTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findBookTableLayoutPanel
            // 
            this.findBookTableLayoutPanel.ColumnCount = 2;
            this.findBookTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.findBookTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.findBookTableLayoutPanel.Controls.Add(this.acceptButton, 1, 2);
            this.findBookTableLayoutPanel.Controls.Add(this.cancelButton, 0, 2);
            this.findBookTableLayoutPanel.Controls.Add(this.chooseCharLabel, 0, 0);
            this.findBookTableLayoutPanel.Controls.Add(this.descriptionLabel, 0, 1);
            this.findBookTableLayoutPanel.Controls.Add(this.keyTextBox, 1, 1);
            this.findBookTableLayoutPanel.Controls.Add(this.paramComboBox, 1, 0);
            this.findBookTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findBookTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.findBookTableLayoutPanel.Name = "findBookTableLayoutPanel";
            this.findBookTableLayoutPanel.RowCount = 3;
            this.findBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.findBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.findBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.findBookTableLayoutPanel.Size = new System.Drawing.Size(643, 369);
            this.findBookTableLayoutPanel.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acceptButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(412, 297);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(140, 50);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Найти";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(90, 297);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chooseCharLabel
            // 
            this.chooseCharLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCharLabel.AutoSize = true;
            this.chooseCharLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseCharLabel.Location = new System.Drawing.Point(43, 81);
            this.chooseCharLabel.Name = "chooseCharLabel";
            this.chooseCharLabel.Size = new System.Drawing.Size(275, 66);
            this.chooseCharLabel.TabIndex = 2;
            this.chooseCharLabel.Text = "Выберите параметр для поиска";
            this.chooseCharLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(33, 204);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(285, 33);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Введите ключевое слово:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyTextBox.Location = new System.Drawing.Point(324, 200);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(257, 40);
            this.keyTextBox.TabIndex = 5;
            // 
            // paramComboBox
            // 
            this.paramComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paramComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paramComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramComboBox.FormattingEnabled = true;
            this.paramComboBox.Items.AddRange(new object[] {
            "по названию",
            "по автору"});
            this.paramComboBox.Location = new System.Drawing.Point(324, 103);
            this.paramComboBox.Name = "paramComboBox";
            this.paramComboBox.Size = new System.Drawing.Size(257, 41);
            this.paramComboBox.TabIndex = 4;
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(643, 369);
            this.Controls.Add(this.findBookTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindBookForm";
            this.Text = "Найти книгу в списке";
            this.findBookTableLayoutPanel.ResumeLayout(false);
            this.findBookTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel findBookTableLayoutPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label chooseCharLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.ComboBox paramComboBox;
    }
}