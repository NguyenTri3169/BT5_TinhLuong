using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_TinhLuong
{
    internal class NVThucTap : NhanVien
    {
        public decimal tinhLuong {  get; set; }
        public NVThucTap(decimal tinhluong)
        {
            tinhLuong = tinhluong;  
        }

        public override decimal TinhLuong()
        {
            return tinhLuong;
        }
    }
}
