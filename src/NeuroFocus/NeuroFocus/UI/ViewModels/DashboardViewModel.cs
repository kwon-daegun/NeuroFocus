using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace NeuroFocus.UI.ViewModels {
    public class DashboardViewModel : INotifyPropertyChanged {
        private string _greetingText = "";
        private DispatcherTimer _timer;

        public string Greetings {
            get { return _greetingText; }
            set {
                if(_greetingText != value) {
                    _greetingText = value;
                    OnPropertyChanged();
                }
            }
        }

        public DashboardViewModel() {
            UpdateGreeting();

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMinutes(1);
            _timer.Tick += (s, e) => UpdateGreeting();
            _timer.Start();
        }

        private void UpdateGreeting() {
            var hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
                Greetings = "Good Morning";
            else if (hour >= 12 && hour < 17)
                Greetings = "Good Afternoon";
            else if (hour >= 17 && hour < 21)
                Greetings = "Good Evening";
            else
                Greetings = "Good Night";
        }


        // boilerplate for INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}