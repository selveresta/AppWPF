using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Workers;
using WPFBigExercise.Infrastructure;
using WPFBigExercise.View;

namespace WPFBigExercise.ViewModel
{
    class ChangePositionViewModel
    {
        Worker _tmpWorker;
        List<string> tmpList;
        DelegateCom changeCommand;
        public ChangePositionViewModel(Worker tmp) {
            tmpList = new List<string> {
                new string("proger"),
                new string("designer"),
                new string("verstalchik"),
                new string("manager")
            };
            _tmpWorker = tmp;
            
        }

        public List<string> TmpList { get => tmpList; private set => tmpList = value; }

        public DelegateCom ChangeCommand {
            get {
                return changeCommand ?? (
                            changeCommand = new DelegateCom(obj =>
                            {
                                _tmpWorker.Position = ((ComboBox)obj).SelectedItem.ToString();
                            }));
            }
        }
    }
}
