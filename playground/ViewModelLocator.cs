using System;
using playground.ViewModels;

namespace playground
{
    public static class ViewModelLocator
    {
        static DesignMainViewModel mainViewModel;

        public static DesignMainViewModel DesignMainViewModel => mainViewModel ?? (mainViewModel = new DesignMainViewModel());

    }
}
