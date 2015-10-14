// Sebastian De GambeBlockControlBlockControl2015

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using BlockControl.Annotations;

namespace BlockControl
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand ChangedControlValueCommand { get; private set; }

        public MainViewModel()
        {
            ChangedControlValueCommand = new DelegateCommand(v =>
            {
                var eventArgs = v as RoutedEventArgs;
                if (eventArgs != null)
                {
                    eventArgs.Handled = !CanChanged;
                }
            });
        }

        private bool _canChanged;

        public bool CanChanged
        {
            get { return _canChanged; }
            set
            {
                if (_canChanged == value)
                    return;
                _canChanged = value;
                OnPropertyChanged(nameof(CanChanged));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}