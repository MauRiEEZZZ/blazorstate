using Blazored.LocalStorage;
using Blazored.LocalStorage.StorageOptions;

namespace blazorstate.Components;

public static class SettingsExtensions
{
    public static IServiceCollection AddSettingsProvider(
        this IServiceCollection services,
        Action<LocalStorageOptions>? configure = null)
    {
        return services.AddBlazoredLocalStorage(configure).AddScoped<SettingsProvider.SettingsService>();
    }
}