using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_TinhLuong
{
    internal class NVToanTG : NhanVien
    {
        public decimal tinhLuong {  get; set; } 
          

        public NVToanTG (decimal tinhluong)
        {
            tinhLuong = tinhluong;  
        }
        public override decimal TinhLuong()
        {
            return tinhLuong ;
        }
    }
}
