using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TableViewerBlazor.Internal.Editor;
using TableViewerBlazor.Options;

namespace TableViewerBlazor;

public partial class TableEditor : TvEditorBase
{
    [Inject] public IJSRuntime Js { get; set; } = null!;
    [Parameter] public object? Data { get; set; }

    protected override Task OnInitializedAsync()
    {
        if (Options == null)
        {
            Options = new TvOptions();
        }
        return base.OnInitializedAsync();
    }
}
