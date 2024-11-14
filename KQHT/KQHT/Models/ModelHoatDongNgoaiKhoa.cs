using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelHoatDongNgoaiKhoa : IModel
    {
        public int STT { get; set; }
        public string MaHD { get; set; }
        public string MaSV { get; set; }
        public string TenHD { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }
        public string DiaDiem { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
