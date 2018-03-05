using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NMCT.Resto.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.ViewModels
{
    public class RestoTabsViewModel : MvxViewModel
    {
        private readonly Lazy<TabInfoViewModel> _tabInfoViewModel;
        public TabInfoViewModel TabInfoVM => _tabInfoViewModel.Value;

        //private readonly Lazy<TabReviewViewModel> _tabReviewViewModel;
        //public TabReviewViewModel TabReviewVM => _tabReviewViewModel.Value;

        protected readonly IRestoDataService _restoDataService;
        public RestoTabsViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;
            _tabInfoViewModel = new Lazy<TabInfoViewModel>(Mvx.IocConstruct<TabInfoViewModel>);
        }
    }
}
