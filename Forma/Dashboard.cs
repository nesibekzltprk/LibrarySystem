using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            // Kitaplar formunu aç
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.ShowDialog();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            PublishersForm publishersForm = new PublishersForm();
            publishersForm.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm();
            reservationsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
