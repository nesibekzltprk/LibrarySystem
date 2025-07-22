using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class PublishersForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public PublishersForm()
        {
            InitializeComponent();
            _httpClient.BaseAddress = new Uri("https://localhost:7186/");
        }

        private async void PublishersForm_Load(object sender, EventArgs e)
        {
            try
            {
                var authors = await _httpClient.GetFromJsonAsync<List<Publisher>>("api/Publishers");
                dataGridViewPublishers.DataSource = authors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yayınevleri yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
