using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubdSecond
{
    public partial class FindBookForm : Form
    {
        private LibraryForm _libraryform;

        public FindBookForm(LibraryForm libraryform)
        {
            InitializeComponent();
            _libraryform = libraryform;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            switch (paramComboBox.SelectedIndex)
            { 
                case 0:
                    _libraryform.changevaluefunc("name", keyTextBox.Text);
                    this.Close();
                    break;
                case 1:
                    _libraryform.changevaluefunc("author", keyTextBox.Text);
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Выберите параметр!", "Ошибка");
                    break;
            }
        }
    }
}
