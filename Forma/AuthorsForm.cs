using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Forma
{
    public partial class AuthorsForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public AuthorsForm()
        {
            InitializeComponent();
            _httpClient.BaseAddress = new Uri("https://localhost:7186/");
        }

        private async void AuthorsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var authors = await _httpClient.GetFromJsonAsync<List<Author>>("api/Authors");
                dataGridViewAuthors.DataSource = authors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazarlar yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
