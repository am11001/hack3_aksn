using Microsoft.JSInterop;

namespace HACKH.Services
{
    public class NotificationService
    {
        public static async Task ShowNotificationAsync(IJSRuntime jsRuntime, string title, string message)
        {
            await jsRuntime.InvokeAsync<object>("showNotification", title, new
            {
                body = message
            });
        }
    }
}
