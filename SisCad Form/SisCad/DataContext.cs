using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Data;

namespace Model.Data
{
    public static class Context
    {
        static DataContext dataContext;
        private static object obj = new object();
        public static DataContext GetDataContext()
        {
            lock (obj)
            {
                if (dataContext == null)
                {
                    dataContext = new DataContext("name=SisCadEntities", "SisCadEntities");
                }
                return dataContext;
            }
        }
    }
}
