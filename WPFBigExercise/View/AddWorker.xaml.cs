using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Workers;
using WPFBigExercise.ViewModel;

namespace WPFBigExercise.View
{
    /// <summary>
    /// Interaction logic for AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        public AddWorker(ObservableCollection<Worker> workers) {
            InitializeComponent();
            DataContext = new AddWorkerViewModel(workers);
        }

        
    }
}
