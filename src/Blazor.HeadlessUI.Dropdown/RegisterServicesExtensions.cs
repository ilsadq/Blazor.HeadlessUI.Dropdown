using Blazor.FloatingUI;
using Blazor.FocusTrapJs;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.HeadlessUI.Dropdown;

public static class DependencyInjectionExtensions
{
    public static void AddDropdownServices(this IServiceCollection services)
    {
        services.AddScoped<FocusTrapJsProvider>();
    }
}