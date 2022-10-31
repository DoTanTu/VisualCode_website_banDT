using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG_2050531200324.App_Code
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;

        public ITEM()
        {
        }


        public ITEM(string masanpham, string tensanpham, string hinhanh , int soluong,double dongia)
        {
            this.Masanpham = masanpham;
            this.Tensanpham = tensanpham;
            this.Dongia = dongia;
            this.Soluong = soluong;
            this.Hinhanh = hinhanh;
        }


        public double THANHTIEN
        {
            get { return this.soluong * this.dongia; }
        }

        public string Masanpham
        {
            get
            {
                return masanpham;
            }

            set
            {
                this.masanpham = value;
            }
        }

        public string Tensanpham
        {
            get
            {
                return tensanpham;
            }

            set
            {
                this.tensanpham = value;
            }
        }

        public double Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Hinhanh
        {
            get
            {
                return hinhanh;
            }

            set
            {
                this.hinhanh = value;
            }
        }
    }
}