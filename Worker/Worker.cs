using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Workers
{
    public class Worker:INotifyPropertyChanged
    {
        string _name;
        string _position;
        DateTime _dateOfBirth;
        public string Name { get =>_name;
            set {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        
        }
        public string Position { get => _position;
            set
            {
                if (value != _position)
                {
                    _position = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime DateOfBirth { get => _dateOfBirth;
            set
            {
                if (value != _dateOfBirth)
                {
                    _dateOfBirth = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
