using System.ComponentModel;
using Blazored.LocalStorage;
using blazorstate.Components;

namespace blazorstate.Components;

public sealed partial class SettingsProvider
{
    public class SettingsService
    {
        private readonly ILocalStorageService _localStorageService;

        private const string SettingsIdentifier = "_SETTINGS_";

        private SettingsProvider.Settings? _settings;

        public event PropertyChangedEventHandler? Changed;

        public SettingsService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async ValueTask<SettingsProvider.Settings> GetSettings()
        {
            if (_settings is not null)
                return _settings;
            _settings = new();
            if (await _localStorageService.ContainKeyAsync(SettingsIdentifier))
            {
                _settings.AutoRefreshLists =
                    (await _localStorageService.GetItemAsync<SettingsProvider.Settings>(SettingsIdentifier))
                    .AutoRefreshLists;
                _settings.IsDarkMode =
                    (await _localStorageService.GetItemAsync<SettingsProvider.Settings>(SettingsIdentifier)).IsDarkMode;
            }

            _settings.OnPropertyChanged += SettingsChanged!;
            Changed?.Invoke(this, null!);
            return _settings;
        }

        private async void SettingsChanged(object? sender, PropertyChangedEventArgs e)
        {
            Changed?.Invoke(sender!, e!);
            await Save();
        }

        private async Task Save()
        {
            await _localStorageService.SetItemAsync(SettingsIdentifier, _settings);
        }
    }
}
