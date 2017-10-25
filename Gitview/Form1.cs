using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitview
{
    public partial class Form1 : Form
    {
        string ten, gioiTinh, diaChi, tuoi;


        private void cbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ThongTin();
            LuuDuLieu();
        }

        void LuuDuLieu()
        {
            string path = @"D:\Data.txt";
            string appendText = Nguoi() + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTin();
            GridviewBang.Rows.Add(ten, tuoi, gioiTinh, diaChi);
        }

        void ThongTin()
        {
            if (cbGioiTinh.Checked)
            {
                gioiTinh = "nam";
            }
            else gioiTinh = "nu";
            ten = txtTen.Text;
            tuoi = txtTuoi.Text;
            diaChi = txtDiaChi.Text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", "\n", "\r" };

            string path = @"D:\Data.txt";
            if (!File.Exists(path))
                MessageBox.Show("file không tồn tại");
            else
            {
                var file = File.ReadAllText(path);
                var tuTrongFile = file.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tuTrongFile.Length - 4; i = i + 4)
                {
                    ten = tuTrongFile[i];
                    tuoi = (tuTrongFile[i + 1]);
                    gioiTinh = tuTrongFile[i + 2];
                    diaChi = tuTrongFile[i + 3];
                    GridviewBang.Rows.Add(ten, tuoi, gioiTinh, diaChi);
                }
                {
                    var z = File.ReadAllLines(path);
                    for (int i = 0; i < z.Length; i++)
                    {
                        var x = z[i].Split(',');
                        ten = x[0];
                        tuoi = x[1];
                        gioiTinh = x[2];
                        diaChi = x[3];
                        GridviewBang.Rows.Add(ten, tuoi, gioiTinh, diaChi);
                    }




                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GridviewBang.RowCount <= 0)
            {
                MessageBox.Show("bang chua tao");
            }
            else
            {
                int row = GridviewBang.CurrentCell.RowIndex;
                GridviewBang.Rows.RemoveAt(row);
            }
        }

        public string Nguoi()
        {
            ThongTin();
            Nguoi peoPle = new Nguoi(ten, tuoi, gioiTinh, diaChi);
            return peoPle.ToString();
        }
    }
}
