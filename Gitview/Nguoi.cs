﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitview
{
    class Nguoi
    {
        string ten, diaChi, gioiTinh, tuoi;

        public Nguoi(string ten, string tuoi, string gioiTinh, string diaChi)
        {
            Ten = ten;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;

        }

        string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                ten = value;
                if (string.IsNullOrEmpty(ten))
                    throw new AggregateException("nhập lại tên");
            }
        }

        string Tuoi
        {
            get
            {
                return tuoi;
            }
            set
            {
                tuoi = value;
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("nhập lại tuổi");
            }
        }

        string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
                if (string.IsNullOrEmpty(value))
                    throw new Exception("nhập lại địa chỉ");
            }

        }

        string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
                if (string.IsNullOrEmpty(value))
                    throw new AccessViolationException("nhập lại giới tính");
            }
        }

        public override string ToString()
        {
            return Ten + "," + Tuoi + "," + GioiTinh + "," + DiaChi ;
        }
    }
}
