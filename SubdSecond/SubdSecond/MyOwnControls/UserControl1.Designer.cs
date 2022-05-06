namespace SubdSecond.MyOwnControls
{
    partial class singleBookPanelControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SubdSecond.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookNameLabel.Location = new System.Drawing.Point(0, 255);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(230, 25);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Название книги";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookNameLabel.MouseEnter += new System.EventHandler(this.bookNameLabel_MouseEnter);
            this.bookNameLabel.MouseLeave += new System.EventHandler(this.bookNameLabel_MouseLeave);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(0, 0);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(230, 33);
            this.statusComboBox.TabIndex = 3;
            this.statusComboBox.Visible = false;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            this.statusComboBox.SelectionChangeCommitted += new System.EventHandler(this.statusComboBox_SelectionChangeCommitted);
            this.statusComboBox.MouseEnter += new System.EventHandler(this.statusComboBox_MouseEnter);
            this.statusComboBox.MouseLeave += new System.EventHandler(this.statusComboBox_MouseLeave);
            // 
            // singleBookPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.bookNameLabel);
            this.Name = "singleBookPanelControl";
            this.Size = new System.Drawing.Size(230, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label bookNameLabel;
        internal System.Windows.Forms.ComboBox statusComboBox;
    }
}
