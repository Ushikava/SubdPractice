namespace SubdSecond
{
    partial class LibraryForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sayHiLabel = new System.Windows.Forms.Label();
            this.parrotFlatMenuStrip = new ReaLTaiizor.Controls.ParrotFlatMenuStrip();
            this.библиотекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавтьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOwnPanel = new SubdSecond.MyOwnControls.MyOwnPanelcs();
            this.parrotFlatMenuStrip.SuspendLayout();
            this.sortTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayHiLabel
            // 
            this.sayHiLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sayHiLabel.AutoSize = true;
            this.sayHiLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sayHiLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.875F);
            this.sayHiLabel.ForeColor = System.Drawing.Color.Black;
            this.sayHiLabel.Location = new System.Drawing.Point(1326, 16);
            this.sayHiLabel.Name = "sayHiLabel";
            this.sayHiLabel.Size = new System.Drawing.Size(245, 35);
            this.sayHiLabel.TabIndex = 3;
            this.sayHiLabel.Text = "Добро пожаловать! ";
            // 
            // parrotFlatMenuStrip
            // 
            this.parrotFlatMenuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.parrotFlatMenuStrip.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parrotFlatMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.parrotFlatMenuStrip.HoverBackColor = System.Drawing.Color.CornflowerBlue;
            this.parrotFlatMenuStrip.HoverTextColor = System.Drawing.Color.White;
            this.parrotFlatMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.parrotFlatMenuStrip.ItemBackColor = System.Drawing.Color.CornflowerBlue;
            this.parrotFlatMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.библиотекаToolStripMenuItem,
            this.профильToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.parrotFlatMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.parrotFlatMenuStrip.Name = "parrotFlatMenuStrip";
            this.parrotFlatMenuStrip.SelectedBackColor = System.Drawing.Color.CornflowerBlue;
            this.parrotFlatMenuStrip.SelectedTextColor = System.Drawing.Color.WhiteSmoke;
            this.parrotFlatMenuStrip.SeperatorColor = System.Drawing.Color.WhiteSmoke;
            this.parrotFlatMenuStrip.Size = new System.Drawing.Size(1574, 48);
            this.parrotFlatMenuStrip.TabIndex = 7;
            this.parrotFlatMenuStrip.Text = "parrotFlatMenuStrip1";
            this.parrotFlatMenuStrip.TextColor = System.Drawing.Color.White;
            // 
            // библиотекаToolStripMenuItem
            // 
            this.библиотекаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавтьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.библиотекаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.библиотекаToolStripMenuItem.Name = "библиотекаToolStripMenuItem";
            this.библиотекаToolStripMenuItem.Size = new System.Drawing.Size(168, 40);
            this.библиотекаToolStripMenuItem.Text = "Библиотека";
            // 
            // добавтьToolStripMenuItem
            // 
            this.добавтьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.добавтьToolStripMenuItem.Name = "добавтьToolStripMenuItem";
            this.добавтьToolStripMenuItem.Size = new System.Drawing.Size(263, 44);
            this.добавтьToolStripMenuItem.Text = "Добавть...";
            this.добавтьToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(263, 44);
            this.удалитьToolStripMenuItem.Text = "Удалить...";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.профильToolStripMenuItem.Text = "Профиль";
            this.профильToolStripMenuItem.Click += new System.EventHandler(this.профильToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(132, 40);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // sortTableLayoutPanel
            // 
            this.sortTableLayoutPanel.ColumnCount = 3;
            this.sortTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sortTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sortTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.sortTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sortTableLayoutPanel.Controls.Add(this.sortByLabel, 0, 0);
            this.sortTableLayoutPanel.Controls.Add(this.sayHiLabel, 2, 0);
            this.sortTableLayoutPanel.Controls.Add(this.sortByComboBox, 1, 0);
            this.sortTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortTableLayoutPanel.Location = new System.Drawing.Point(0, 1061);
            this.sortTableLayoutPanel.Name = "sortTableLayoutPanel";
            this.sortTableLayoutPanel.RowCount = 1;
            this.sortTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortTableLayoutPanel.Size = new System.Drawing.Size(1574, 68);
            this.sortTableLayoutPanel.TabIndex = 9;
            // 
            // sortByLabel
            // 
            this.sortByLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByLabel.Location = new System.Drawing.Point(57, 16);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(199, 35);
            this.sortByLabel.TabIndex = 0;
            this.sortByLabel.Text = "Сортировать по:";
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "названию",
            "кол-ву страниц",
            "автору",
            "жанру"});
            this.sortByComboBox.Location = new System.Drawing.Point(356, 12);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(230, 43);
            this.sortByComboBox.TabIndex = 1;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(263, 44);
            this.найтиToolStripMenuItem.Text = "Найти...";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // myOwnPanel
            // 
            this.myOwnPanel.AutoScroll = true;
            this.myOwnPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.myOwnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myOwnPanel.Location = new System.Drawing.Point(0, 48);
            this.myOwnPanel.Name = "myOwnPanel";
            this.myOwnPanel.Size = new System.Drawing.Size(1574, 1081);
            this.myOwnPanel.TabIndex = 8;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.sortTableLayoutPanel);
            this.Controls.Add(this.myOwnPanel);
            this.Controls.Add(this.parrotFlatMenuStrip);
            this.Name = "LibraryForm";
            this.Text = "Моя библиотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryForm_FormClosed);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.parrotFlatMenuStrip.ResumeLayout(false);
            this.parrotFlatMenuStrip.PerformLayout();
            this.sortTableLayoutPanel.ResumeLayout(false);
            this.sortTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sayHiLabel;
        private ReaLTaiizor.Controls.ParrotFlatMenuStrip parrotFlatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem библиотекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавтьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private MyOwnControls.MyOwnPanelcs myOwnPanel;
        private System.Windows.Forms.TableLayoutPanel sortTableLayoutPanel;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
    }
}

