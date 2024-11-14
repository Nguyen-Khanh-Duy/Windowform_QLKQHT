using KQHT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Models
{
    internal class ModelUserAccount : IModel
    {
        
        public string Username { get; set; }
        public string Password { get; set; }      
        public bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}
