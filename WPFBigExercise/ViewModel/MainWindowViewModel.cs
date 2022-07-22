using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Workers;
using WPFBigExercise.Infrastructure;
using WPFBigExercise.View;

namespace WPFBigExercise.ViewModel
{
    class MainWindowViewModel:INotifyPropertyChanged
    {
        ObservableCollection<Worker> _listWorkers;
        public ObservableCollection<Worker> ListWorkers {
            get => _listWorkers;
            set {
                if (value != _listWorkers)
                {
                    _listWorkers = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICollectionView Sorted { get; private set; }
        private DelegateCom addCommand;
        private DelegateCom sortCommand;
        private DelegateCom delCommand;
        private DelegateCom chaCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            _listWorkers = new ObservableCollection<Worker>() { 
                new Worker(){Name= "Artem", Position="nano", DateOfBirth=new DateTime(2010,5,10) },
                new Worker(){Name= "Ivan", Position="lalo", DateOfBirth=new DateTime(1999,10,10) },
                new Worker(){Name= "Petya", Position="qwqw", DateOfBirth=new DateTime(1234,5,10) },
                
            };

            Sorted = CollectionViewSource.GetDefaultView(ListWorkers);
            Sorted.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }


        public DelegateCom SortCommand
        {
            get
            {
                return sortCommand ?? (sortCommand = new DelegateCom(SortCommandMethod));
            }
        }


        public DelegateCom AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new DelegateCom(obj =>
                {
                    var win = new AddWorker(ListWorkers);
                    win.Show();
                }
                ));
            }
        }
        public DelegateCom DelCommand
        {
            get
            {
                return delCommand ?? (delCommand = new DelegateCom(obj =>
                {
                    var tmpList = obj as ListView;
                    if (tmpList.SelectedItem != null)
                        ListWorkers.Remove((Worker)tmpList.SelectedItem);
                }
                ));
            }
        }


        public DelegateCom ChaCommand
        {
            get
            {
                return chaCommand ?? (chaCommand = new DelegateCom(obj =>
                {
                    var tmp = obj as ListView;
                    if (tmp.SelectedItem != null)
                    {
                        var win = new ChangePosition((Worker)tmp.SelectedItem);
                        win.Show();
                    }
                   
                }
                ));
            }
        }


        void SortCommandMethod(object obj)
        {
            var columm = (obj as GridViewColumnHeader);
            var sortBy = columm.Tag.ToString();
            var dir = Sorted.SortDescriptions[0].Direction;
            var col = Sorted.SortDescriptions[0].PropertyName;
            Sorted.SortDescriptions.Clear();
            if (sortBy == col && dir == ListSortDirection.Ascending)
                Sorted.SortDescriptions.Add(
                    new SortDescription(sortBy,
                    ListSortDirection.Descending));
            else Sorted.SortDescriptions.Add(
                    new SortDescription(sortBy,
                    ListSortDirection.Ascending));
        }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
