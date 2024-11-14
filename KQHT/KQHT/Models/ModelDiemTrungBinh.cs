using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelDiemTrungBinh : IModel
    {
        public int STT { get; set; }
        public string MaDTB { get; set; }
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public string DiemTB { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
