using SingleBoerseNRW.Core;
using SingleBoerseNRW.MVVM.ViewModel;
using System;


namespace SingleBoerseNRW.MVVM.View
{
   
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AnmeldenViewCommand { get; set; }
        public RelayCommand RegistrierenViewCommand { get; set; }




        public HomeViewModel HomeVM { get; set; }
        public AnmeldenViewModel AnmeldenVM { get; set; }
        public RegistrierenViewModel RegistrierenVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AnmeldenVM = new AnmeldenViewModel();
            RegistrierenVM = new RegistrierenViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });



            AnmeldenViewCommand = new RelayCommand(o =>
            {
                CurrentView = AnmeldenVM;
            });

            RegistrierenViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegistrierenVM;
            });



        }
    }
}
