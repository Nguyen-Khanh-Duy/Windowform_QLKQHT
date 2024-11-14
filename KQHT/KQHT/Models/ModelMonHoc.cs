using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelMonHoc : IModel
    {
        public int STT { get; set; }
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string SoTinChi { get; set; }
        public string MoTa { get; set; }
        public string GiangVienPhuTrach { get; set; }
        public string MaGV { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
