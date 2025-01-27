﻿using KQHT.Model;
using KQHT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KQHT.Controllers
{
    internal interface IController
    {
        List<IModel> Items { get; }

        bool Add(IModel model);
        bool Update(IModel model);
        bool Delete(IModel model);
        bool Load();
        bool Delete(object id);
        IModel Read(object id);
        bool IsExist(object id);
        //bool Close (object id);

    }
}
