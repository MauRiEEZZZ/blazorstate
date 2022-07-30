using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace blazorstate.Components;

public partial class SettingsProvider
{
    public record Settings
    {
        public event PropertyChangedEventHandler? OnPropertyChanged;

        private bool _autoRefreshLists;
        private bool _isDarkMode;

        public bool AutoRefreshLists
        {
            get => _autoRefreshLists;
            set
            {
                _autoRefreshLists = value;
                PropertyChanged();
            }
        }

        public bool IsDarkMode
        {
            get => _isDarkMode;
            set
            {
                _isDarkMode = value;
                PropertyChanged();
            }
        }

        private void PropertyChanged([CallerMemberName] string? propertyName = null)
        {
            OnPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
