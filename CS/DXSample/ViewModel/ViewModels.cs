using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXSample.ViewModel {
    public class UserControlViewModel : ViewModelBase {
        private string _ViewName;
        public string ViewName {
            get {
                return _ViewName;
            }
            set {
                SetProperty(ref _ViewName, value, () => ViewName);
            }
        }
    }
}
