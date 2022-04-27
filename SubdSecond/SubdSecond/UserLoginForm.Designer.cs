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
            this.mainTableLayoutPanel.SuspendLayout();
            this.upperLoginTableLayoutPanel.SuspendLayout();
            this.loginParolTableLayoutPanel.SuspendLayout();
            this.lowerLoginTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
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
            this.loginParolTableLayoutPanel.ColumnCount = 1;
            this.loginParolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginParolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.loginParolTableLayoutPanel.Controls.Add(this.loginMaskedTextBox, 0, 0);
            this.loginParolTableLayoutPanel.Controls.Add(this.passwordMaskedTextBox, 0, 1);
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
            this.loginMaskedTextBox.Location = new System.Drawing.Point(43, 16);
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
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(43, 78);
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
            this.logoLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.875F, System.Drawing.FontStyle.Bold);
            this.logoLabel.Location = new System.Drawing.Point(356, 94);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(168, 25);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Моя библиотека";
            // 
            // lowerLoginTableLayoutPanel
            // 
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
            this.signUpLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(348, 82);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(183, 26);
            this.signUpLinkLabel.TabIndex = 1;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Создать аккаунт";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(312, 3);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(256, 57);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Войти в аккаунт";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(887, 605);
            this.Controls.Add(this.mainTableLayoutPanel);
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
    }
}