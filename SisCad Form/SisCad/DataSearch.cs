using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Data;

namespace SisCad
{
    public partial class DataSearch
    {
        public static void DoSearch<T>(SisCadEntities dataContext, EventHandler onSelected,params Search[] search)
        {
            frmPesquisa pesquisa = new frmPesquisa();
            pesquisa.Bind<T>(dataContext, search);
            if (pesquisa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                onSelected(pesquisa, new SearchSelectedEventArgs(pesquisa.Selected));
            }
        }
    }
}
