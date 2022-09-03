using SingleBoerseNRW.Core;
using System;


namespace SingleBoerseNRW.MVVM.View
{
    private object _currentView;

    public object CurrentView
    {
        get { return _curentView; }
        set 
        { 
            _currentView = value;
            OnPropertyChanged();
        }
    }

    class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }
    }
}
