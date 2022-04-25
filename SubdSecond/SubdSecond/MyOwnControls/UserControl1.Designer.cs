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
            this.bookStatusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookStatusLabel
            // 
            this.bookStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.bookStatusLabel.Name = "bookStatusLabel";
            this.bookStatusLabel.Size = new System.Drawing.Size(230, 25);
            this.bookStatusLabel.TabIndex = 0;
            this.bookStatusLabel.Text = "label1";
            this.bookStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SubdSecond.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookNameLabel.Location = new System.Drawing.Point(0, 255);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(230, 25);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "label1";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singleBookPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.bookStatusLabel);
            this.Name = "singleBookPanelControl";
            this.Size = new System.Drawing.Size(230, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bookStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bookNameLabel;
    }
}
