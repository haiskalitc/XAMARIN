using BaiTap.MVV;
using BaiTap.MVVM.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.ViewModel
{
    class ViewModelBase : BindableBase
    {
        public ViewModelBase()
        {
           
        }

        private string _tittle;
        public string Tittle
        {
            get { return _tittle; }
            set { SetProperty(ref _tittle, value); }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value, () => { RaisePropertyChanged(nameof(isContentAhi)); }); }
        }
        public string isContentAhi => _content + " Ahihi";
    
    }
}
