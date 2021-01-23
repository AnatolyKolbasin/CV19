using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Window Title
        private string _Title = "Statistical analysis CV19";

        /// <summary>
        /// Window Title
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        } 
        #endregion
    }
}
