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
    public partial class ReservationsForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public ReservationsForm()
        {
            InitializeComponent();
            this.Load += ReservationsForm_Load;

            _httpClient.BaseAddress = new Uri("https://localhost:7186/");
        }

        private async void ReservationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var reservations = await _httpClient.GetFromJsonAsync<List<Reservation>>("api/Reservations");
                
                dataGridViewReser.DataSource = reservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewReser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
