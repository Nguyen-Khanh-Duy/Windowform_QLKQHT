using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelGiangVien : IModel
    {
        public int STT { get; set; }
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string ChuyenMon { get; set; }
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
