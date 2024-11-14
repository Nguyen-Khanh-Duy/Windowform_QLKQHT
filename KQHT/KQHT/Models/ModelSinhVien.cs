using KQHT.Model;
using System;

namespace KQHT.Models
{
    public class ModelSinhVien : IModel
    {
        public int STT { get; set; }
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string MoTa { get; set; }

        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
