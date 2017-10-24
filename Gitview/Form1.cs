using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Input;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Gitview
{
    public partial class Form1 : Form
    {
        string ten, gioiTinh, diaChi;
        int tuoi;


        private void cbGioiTinh_Click(object sender, EventArgs e)
        {
            if (cbGioiTinh.Checked == true)
            {
                gioiTinh = "nam";
            }
            else gioiTinh = "nu";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"D:\Data.txt";


            if (!File.Exists(path))
            {
                string createText = Nguoi() + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            else
            {
                string appendText = Nguoi() + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            


        }
        public string Nguoi()
        {
            ten = txtTen.Text;
            tuoi = int.Parse(txtTuoi.Text);
            diaChi = txtDiaChi.Text;
            Nguoi peoPle = new Nguoi(ten, tuoi, gioiTinh, diaChi);
            return peoPle.ToString();
        }
    }
}
