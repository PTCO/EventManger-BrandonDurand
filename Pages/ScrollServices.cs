using Microsoft.JSInterop;

public class ScrollServices
{
    private readonly IJSRuntime _jsRuntime;

    public ScrollServices(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    private double scrollTop;
    private double scrollHeight;
    private double clientHeight;

    public async Task HandleScroll(string elementId)
    {
        var isAtBottom = await _jsRuntime.InvokeAsync<bool>("checkIfScrolledToBottom", elementId);
        if (isAtBottom)
        {
            // Handle the scroll event when the user is at the bottom
            Console.WriteLine("User scrolled to the bottom of the div.");
        }
    }

    public class ScrollData
    {
        public double scrollTop { get; set; }
        public double scrollLeft { get; set; }
        public double scrollHeight { get; set; }
        public double clientHeight { get; set; }
    }
}
