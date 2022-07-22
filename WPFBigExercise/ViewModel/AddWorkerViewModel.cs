using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using Workers;
using System.Runtime.CompilerServices;
using WPFBigExercise.Infrastructure;
using System.Windows;

namespace WPFBigExercise.ViewModel
{
    class AddWorkerViewModel:INotifyPropertyChanged
    {
        Worker _tmpWorker;
        ObservableCollection<Worker> _tempWorkers;
        public event PropertyChangedEventHandler PropertyChanged;
        DelegateCom addToOwnerList;
        DelegateCom closeWindow;

        public AddWorkerViewModel(ObservableCollection<Worker> tmp) {
            _tempWorkers = tmp;
            _tmpWorker = new Worker();
        }


        public Worker TemplateWorker
        {
            get => _tmpWorker;
            set
            {
                if (value != _tmpWorker)
                {
                    _tmpWorker = value;
                    OnPropertyChanged();
                }
            }
        }

        public DelegateCom AddToOwnerList
        {
            get
            {
                return addToOwnerList ?? (
                        addToOwnerList = new DelegateCom(obj =>
                        {
                            if (_tmpWorker.Name != string.Empty && _tmpWorker.Position != string.Empty && _tmpWorker.DateOfBirth != null)
                                _tempWorkers.Add(_tmpWorker);

                        }));
            }
        }


        public DelegateCom CloseWindow
        {
            get
            {
                return closeWindow ?? (
                        closeWindow = new DelegateCom(obj =>
                        {
                            var win = obj as Window;
                            win.Close();
                        }));
            }
        }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
