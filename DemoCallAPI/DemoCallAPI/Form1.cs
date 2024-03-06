using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức GetWeatherForecastAsync để gọi API
                string weatherForecast = await GetWeatherForecastAsync();

                // Hiển thị kết quả trong TextBox
                txtWeatherForecast.Text = weatherForecast;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
        private async Task<string> GetWeatherForecastAsync()
        {
            try
            {
                // Khởi tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Đặt BaseAddress của HttpClient đến API của bạn
                    client.BaseAddress = new Uri("http://localhost:5122"); // Thay đổi theo URL của API của bạn

                    // Gửi yêu cầu GET đến API và nhận kết quả trả về
                    HttpResponseMessage response = await client.GetAsync("weatherforecast");

                    // Nếu yêu cầu thành công (200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc nội dung trả về từ API
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {
                        // Xử lý trường hợp lỗi nếu yêu cầu không thành công
                        return $"Error: {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra trong quá trình gọi API
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }
    }
}
