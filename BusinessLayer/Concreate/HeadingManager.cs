﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading GetById(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GEtlist()
        {
            return _headingDal.List();
        }

        public List<Heading> GetListbyWriter(int id)
        {
            return _headingDal.List(x=>x.WriterID==id);
        }

        public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HEadingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
