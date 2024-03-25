using Microsoft.AspNetCore.Components;
using TableViewerBlazor.Service;

namespace TableViewerBlazor.Internal.Editor;

public partial class TvDateTimeEditor : TvEditorBase
{
    [Inject] DateTimeService DateTimeService { get; set; } = null!;
    [Parameter] public DateTime Data { get; set; }

    DateTime dateTime;

    protected override Task OnInitializedAsync()
    {
        dateTime = Data.ToUniversalTime();
        var options = DateTimeService.Options;
        if (options != null)
        {
            dateTime = dateTime.AddHours(- (options.Offset / 60));
        }
        return base.OnInitializedAsync();
    }
}
