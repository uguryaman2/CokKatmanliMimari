﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GEtlist();
        void AboutAdd(About about);
        void AboutDelete(About about);
        void AboutUpdate(About about);
        About GetById(int id);
        List<About> GetListByID(int id);
    }
}
