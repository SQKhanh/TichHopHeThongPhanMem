using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnTapTX2
{
    internal class DataUtil
    {
        string fileName;
        XmlDocument doc = new XmlDocument();
        XmlElement root;

        public DataUtil(string fileName)
        {
            this.fileName = fileName;
            if (File.Exists(fileName) == false)
            {
                XmlElement root = doc.CreateElement("congty");
                doc.AppendChild(root);
                doc.Save(fileName);
            }
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<NhanVien> getAll()
        {
            List<NhanVien> nvs = new List<NhanVien>();

            XmlNodeList nodes = root.SelectNodes("nhanvien");

            foreach (XmlNode node in nodes)
            {

                var nv = new NhanVien();
                nv.maNv = node.Attributes[0].Value;
                nv.ten = node.SelectSingleNode("hoten").InnerText;
                nv.tuoi = int.Parse(node.SelectSingleNode("tuoi").InnerText);
                nv.luong = int.Parse(node.SelectSingleNode("luong").InnerText);
                var diachi = node.SelectSingleNode("diachi");
                nv.diachi.xa = diachi.SelectSingleNode("xa").InnerText;
                nv.diachi.huyen = diachi.SelectSingleNode("huyen").InnerText;
                nv.diachi.tinh = diachi.SelectSingleNode("tinh").InnerText;
                nv.dienThoai = node.SelectSingleNode("dienthoai").InnerText;
                nvs.Add(nv);
            }

            return nvs;
        }

        public void addNhanVien(NhanVien nv)
        {
            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = nv.ten;


            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = nv.tuoi + "";

            XmlElement luong = doc.CreateElement("luong");
            luong.InnerText = nv.luong + "";

            XmlElement diachi = doc.CreateElement("diachi");

            XmlElement xa = doc.CreateElement("xa");
            xa.InnerText = nv.diachi.xa;

            XmlElement huyen = doc.CreateElement("huyen");
            huyen.InnerText = nv.diachi.huyen;

            XmlElement tinh = doc.CreateElement("tinh");
            tinh.InnerText = nv.diachi.tinh;

            diachi.AppendChild(xa);
            diachi.AppendChild(huyen);
            diachi.AppendChild(tinh);




            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = nv.dienThoai;

            var nvXml = doc.CreateElement("nhanvien");
            nvXml.SetAttribute("manv", nv.maNv);
            nvXml.AppendChild(hoten);
            nvXml.AppendChild(tuoi);
            nvXml.AppendChild(luong);
            nvXml.AppendChild(diachi);
            nvXml.AppendChild(dienthoai);


            root.AppendChild(nvXml);

            doc.Save(fileName);

        }
    }
}
