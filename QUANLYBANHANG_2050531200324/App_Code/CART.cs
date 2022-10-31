using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG_2050531200324.App_Code
{
    public class CART
    {
        Dictionary<string, ITEM> listCarts;

        public Dictionary<string, ITEM> LISTCARTS
        {
            get { return this.listCarts; }
        }

        public CART()
        {
            listCarts = new Dictionary<string, ITEM>();
        }

        public void AddCart(string masanpham, string tensanpham, string hinhanh, int soluong, int dongia)
        {
            ITEM item = new ITEM(masanpham, tensanpham, hinhanh, soluong, dongia);
            if (listCarts.ContainsKey(item.Masanpham))
                listCarts[item.Masanpham].Soluong += item.Soluong;
            else
                listCarts.Add(item.Masanpham, item);
        }
        public void RemoveCart(string masanpham)
        {
            listCarts.Remove(masanpham);
        }

        public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listCarts.Values)
                total += item.THANHTIEN;
            return total;
        }

    }
}