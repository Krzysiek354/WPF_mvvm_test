using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace wpf_mvvm_test.Modelwidoku
{
    using Model;
    public class model_widoku : INotifyPropertyChanged
    {
        private model_mvvm model = new model_mvvm();

        public double wartosc
        {
            get
            { return model.wartosc; }

            set { model.wartosc = value;
                onPropertyChane(nameof(wartosc));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void onPropertyChane(string nazwa_wlasnosci)
        {
            if (PropertyChanged != null) PropertyChanged(this,new PropertyChangedEventArgs(nazwa_wlasnosci));
        }
    }
}
