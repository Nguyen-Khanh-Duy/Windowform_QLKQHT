using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelDiemRenLuyen : IModel
    {
        public int STT { get; set; }
        public string MaRL { get; set; }
        public string MaSV { get; set; }
        public string MaHD { get; set; }
        public string DiemRL { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
