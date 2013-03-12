using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Data;

namespace SisCad.Forms
{
    public partial class Lookup : UserControl
    {
        public Lookup()
        {
            InitializeComponent();
        }

        public void Bind<T>(SisCadEntities dataContext, SetValue<T> setValue, BindingSource bindingSource, string title, string field, params Search[] search)
        {
            this.valueTextBox.DataBindings.Add("Text", bindingSource, field, true, DataSourceUpdateMode.OnPropertyChanged);
            this.labelTitulo.Text = title;
            this.btnShow.Click += (s2, e2) =>
            {
                if (bindingSource.Current != null)
                {
                    EventHandler click = (s, e) =>
                    {
                        SearchSelectedEventArgs selected = (SearchSelectedEventArgs)e;
                        setValue(bindingSource.Current, (T)selected.selected);
                        bindingSource.ResetBindings(true);
                    };
                    DataSearch.DoSearch<T>(dataContext, click, search);
                }
            };
            this.btnClear.Click += (s, e) =>
            {
                if (bindingSource.Current != null)
                {

                }
            };
        }

        public void Bind<T>(SisCadEntities dataContext, SetValue<T> setValue, BindingSource bindingSource, string title, params Search[] search)
        {
            Bind<T>(dataContext, setValue, bindingSource, title,typeof(T).Name, search);
        }
    }
}
