using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_TinhLuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NVToanTG nVToanTG = new NVToanTG(30000000);
            NVBanTG nVBanTG = new NVBanTG(100000, 2);
            NVThucTap nVThucTap = new NVThucTap(5000000);
            Console.WriteLine($"Nhan vien toan thoi gian: {nVToanTG.TinhLuong()}");
            Console.WriteLine($"Nhan vien ban thoi gian: {nVBanTG.TinhLuong()}");
            Console.WriteLine($"Nhan vien thuc tap: {nVThucTap.TinhLuong()}");
            Console.ReadLine(); 

        }
    }
}
