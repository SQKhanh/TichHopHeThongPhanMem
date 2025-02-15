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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            load();
        }
        private string api = "http://localhost:14432/api/";

        public void load()
        {
            var svs = this.getSinhVien();

            dataGridView1.DataSource = svs;
        }

        private List<SinhVien> getSinhVien()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(api)
            };

            var respond = client.GetAsync("sinhvien").Result;
            if (respond.IsSuccessStatusCode)
            {
                return respond.Content.ReadAsAsync<List<SinhVien>>().Result;
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var code = tbCode.Text;

            var name = tbFullName.Text;

            var birth = dateTimePicker1.Value;

            var sv = new SinhVien()
            {
                code = code,
                fullname = name,
                birthday = birth,
            };

            var client = new HttpClient()
            {
                BaseAddress = new Uri(api)
            };

            var respond = client.PostAsJsonAsync("sinhvien", sv).Result;
            if (respond.IsSuccessStatusCode)
            {
                load();
            }
            else
            {
                MessageBox.Show("Không thể thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
