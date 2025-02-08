using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapTX2
{
    public partial class Form1 : Form
    {

        private DataUtil dataUtil = new DataUtil("congty.xml");

        public Form1()
        {
            InitializeComponent();

            displayData();
        }


        private void displayData()
        {
            var nvs = dataUtil.getAll();
            dataGridView1.DataSource = nvs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var maNv = tbMaNV.Text;
            var ten = tbTen.Text;
            var tuoi = tbTuoi.Text;
            var luong = tbLuong.Text;
            var xa = tbXa.Text;
            var huyen = tbHuyen.Text;
            var tinh = tbTinh.Text;
            var dienthoai = tbDienThoai.Text;

            var nv = new NhanVien();
            nv.maNv = maNv;
            nv.ten = ten;
            nv.tuoi = int.Parse(tuoi);
            nv.luong = int.Parse(luong);
            nv.diachi.xa = xa;
            nv.diachi.huyen = huyen;
            nv.diachi.tinh = tinh;
            nv.dienThoai = dienthoai;

            dataUtil.addNhanVien(nv);

            MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
        }

        private void getNhanVienChoosen(object sender, DataGridViewCellEventArgs e)
        {
            var nv =(NhanVien) dataGridView1.CurrentRow.DataBoundItem;
            tbMaNV.Text = nv.maNv;
            tbTen.Text = nv.ten;
            tbTuoi.Text = nv.tuoi +"";
            tbLuong.Text = nv.luong +""; 
            tbXa.Text = nv.diachi.xa;
            tbHuyen.Text= nv.diachi.huyen;
            tbTinh.Text = nv.diachi.tinh;
            tbDienThoai.Text = nv.dienThoai;



        }
    }
}
