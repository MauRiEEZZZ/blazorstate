using System.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace blazorstate.Components;

public sealed partial class SettingsProvider
{
    [Inject] private SettingsService Service { get; set; } = null!;
    [Parameter] public RenderFragment ChildContent { get; set; } = null!;

    private Settings _settings { get; set; } = new();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Service.Changed += SettingsChanged!;
            await LoadSettings();
        }
        await base.OnAfterRenderAsync(firstRender);
    }
    private async void SettingsChanged(object? sender, PropertyChangedEventArgs e)
    {
        await LoadSettings();
        StateHasChanged();
    }

    private async Task LoadSettings()
    {
        _settings = await Service.GetSettings();
    }
    public void Dispose()
    {
        Service.Changed -= SettingsChanged;
    }


}