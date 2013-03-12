using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Data;

namespace Model.Data
{
    public static class Context
    {
        static SisCadEntities dataContext;
        private static object obj = new object();
        public static SisCadEntities GetDataContext()
        {
            lock (obj)
            {
                if (dataContext == null)
                {
                    dataContext = new SisCadEntities();
                }
                return dataContext;
            }
        }
    }
}
