using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;


namespace Forma
{
    public partial class BooksForm : Form
    {

        private readonly HttpClient _httpClient = new HttpClient();
        public BooksForm()
        {
            InitializeComponent();
            _httpClient.BaseAddress = new Uri("https://localhost:7186/");
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                var books = await _httpClient.GetFromJsonAsync<List<Book>>("api/Books");
                dataGridViewBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private async void BooksForm_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }


        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
