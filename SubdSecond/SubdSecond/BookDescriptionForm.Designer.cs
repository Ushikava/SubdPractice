namespace SubdSecond
{
    partial class BookDescriptionForm
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
            this.backgroundLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imageAndDescrLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundLayoutPanel.SuspendLayout();
            this.imageAndDescrLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundLayoutPanel
            // 
            this.backgroundLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backgroundLayoutPanel.ColumnCount = 1;
            this.backgroundLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backgroundLayoutPanel.Controls.Add(this.imageAndDescrLayoutPanel, 0, 1);
            this.backgroundLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.backgroundLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundLayoutPanel.Name = "backgroundLayoutPanel";
            this.backgroundLayoutPanel.RowCount = 2;
            this.backgroundLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.backgroundLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.backgroundLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.backgroundLayoutPanel.TabIndex = 0;
            // 
            // imageAndDescrLayoutPanel
            // 
            this.imageAndDescrLayoutPanel.ColumnCount = 2;
            this.imageAndDescrLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.imageAndDescrLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.imageAndDescrLayoutPanel.Controls.Add(this.bookPictureBox, 0, 0);
            this.imageAndDescrLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageAndDescrLayoutPanel.Location = new System.Drawing.Point(3, 70);
            this.imageAndDescrLayoutPanel.Name = "imageAndDescrLayoutPanel";
            this.imageAndDescrLayoutPanel.RowCount = 1;
            this.imageAndDescrLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageAndDescrLayoutPanel.Size = new System.Drawing.Size(794, 377);
            this.imageAndDescrLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.875F);
            this.label1.Location = new System.Drawing.Point(301, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "bookNameLabel";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPictureBox.Image = global::SubdSecond.Properties.Resources.dog;
            this.bookPictureBox.Location = new System.Drawing.Point(3, 3);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(232, 371);
            this.bookPictureBox.TabIndex = 0;
            this.bookPictureBox.TabStop = false;
            // 
            // BookDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroundLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookDescriptionForm";
            this.Text = "BookDescriptionForm";
            this.backgroundLayoutPanel.ResumeLayout(false);
            this.backgroundLayoutPanel.PerformLayout();
            this.imageAndDescrLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backgroundLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel imageAndDescrLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bookPictureBox;
    }
}