using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelKetQuaHocTap : IModel
    {
        public int STT { get; set; }
        public string MaKQ { get; set; }
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string MaDTB { get; set; }
        public string DiemTBM { get; set; }
        public string MaRL { get; set; }
        public string DiemRL { get; set; }
        public string XepLoai { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
