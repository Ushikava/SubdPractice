namespace SubdSecond
{
    partial class UserLoginForm
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
            this.upperLoginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginParolTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.lowerLoginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signInButton = new System.Windows.Forms.Button();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.upperLoginTableLayoutPanel.SuspendLayout();
            this.loginParolTableLayoutPanel.SuspendLayout();
            this.lowerLoginTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackgroundImage = global::SubdSecond.Properties.Resources.MainBackground;
            this.mainTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.upperLoginTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lowerLoginTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(887, 605);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // upperLoginTableLayoutPanel
            // 
            this.upperLoginTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.upperLoginTableLayoutPanel.ColumnCount = 3;
            this.upperLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.upperLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.upperLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.upperLoginTableLayoutPanel.Controls.Add(this.loginParolTableLayoutPanel, 1, 1);
            this.upperLoginTableLayoutPanel.Controls.Add(this.logoLabel, 1, 0);
            this.upperLoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLoginTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upperLoginTableLayoutPanel.Name = "upperLoginTableLayoutPanel";
            this.upperLoginTableLayoutPanel.RowCount = 2;
            this.upperLoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.upperLoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.upperLoginTableLayoutPanel.Size = new System.Drawing.Size(881, 357);
            this.upperLoginTableLayoutPanel.TabIndex = 0;
            // 
            // loginParolTableLayoutPanel
            // 
            this.loginParolTableLayoutPanel.BackgroundImage = global::SubdSecond.Properties.Resources.LoginPasswordBackground;
            this.loginParolTableLayoutPanel.ColumnCount = 2;
            this.loginParolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.loginParolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.loginParolTableLayoutPanel.Controls.Add(this.loginMaskedTextBox, 1, 0);
            this.loginParolTableLayoutPanel.Controls.Add(this.passwordMaskedTextBox, 1, 1);
            this.loginParolTableLayoutPanel.Controls.Add(this.loginPictureBox, 0, 0);
            this.loginParolTableLayoutPanel.Controls.Add(this.passwordPictureBox, 0, 1);
            this.loginParolTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginParolTableLayoutPanel.Location = new System.Drawing.Point(179, 217);
            this.loginParolTableLayoutPanel.Name = "loginParolTableLayoutPanel";
            this.loginParolTableLayoutPanel.RowCount = 2;
            this.loginParolTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginParolTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginParolTableLayoutPanel.Size = new System.Drawing.Size(522, 137);
            this.loginParolTableLayoutPanel.TabIndex = 0;
            // 
            // loginMaskedTextBox
            // 
            this.loginMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginMaskedTextBox.Location = new System.Drawing.Point(77, 16);
            this.loginMaskedTextBox.Name = "loginMaskedTextBox";
            this.loginMaskedTextBox.Size = new System.Drawing.Size(435, 49);
            this.loginMaskedTextBox.TabIndex = 0;
            this.loginMaskedTextBox.Text = "NewUser";
            this.loginMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginMaskedTextBox_KeyDown);
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(77, 78);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.PasswordChar = '*';
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(435, 49);
            this.passwordMaskedTextBox.TabIndex = 1;
            this.passwordMaskedTextBox.Text = "1992";
            this.passwordMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordMaskedTextBox_KeyDown);
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.logoLabel.Location = new System.Drawing.Point(236, 71);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(408, 71);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Моя библиотека";
            // 
            // lowerLoginTableLayoutPanel
            // 
            this.lowerLoginTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.lowerLoginTableLayoutPanel.ColumnCount = 3;
            this.lowerLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lowerLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerLoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lowerLoginTableLayoutPanel.Controls.Add(this.signUpLinkLabel, 1, 1);
            this.lowerLoginTableLayoutPanel.Controls.Add(this.signInButton, 1, 0);
            this.lowerLoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLoginTableLayoutPanel.Location = new System.Drawing.Point(3, 366);
            this.lowerLoginTableLayoutPanel.Name = "lowerLoginTableLayoutPanel";
            this.lowerLoginTableLayoutPanel.RowCount = 2;
            this.lowerLoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.lowerLoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.lowerLoginTableLayoutPanel.Size = new System.Drawing.Size(881, 236);
            this.lowerLoginTableLayoutPanel.TabIndex = 1;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLinkLabel.LinkColor = System.Drawing.Color.White;
            this.signUpLinkLabel.Location = new System.Drawing.Point(355, 82);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(170, 29);
            this.signUpLinkLabel.TabIndex = 1;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Создать аккаунт";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signInButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signInButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(312, 3);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(256, 57);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Войти в аккаунт";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPictureBox.BackgroundImage = global::SubdSecond.Properties.Resources.Login;
            this.loginPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPictureBox.Location = new System.Drawing.Point(14, 15);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(50, 50);
            this.loginPictureBox.TabIndex = 2;
            this.loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordPictureBox.BackgroundImage = global::SubdSecond.Properties.Resources.Password;
            this.passwordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordPictureBox.Location = new System.Drawing.Point(11, 77);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(53, 50);
            this.passwordPictureBox.TabIndex = 3;
            this.passwordPictureBox.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 605);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.Text = "Войти в аккаунт";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.upperLoginTableLayoutPanel.ResumeLayout(false);
            this.upperLoginTableLayoutPanel.PerformLayout();
            this.loginParolTableLayoutPanel.ResumeLayout(false);
            this.loginParolTableLayoutPanel.PerformLayout();
            this.lowerLoginTableLayoutPanel.ResumeLayout(false);
            this.lowerLoginTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upperLoginTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel loginParolTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel lowerLoginTableLayoutPanel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.MaskedTextBox loginMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
    }
}