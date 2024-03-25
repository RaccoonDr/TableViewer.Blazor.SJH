using Microsoft.AspNetCore.Components;
using TableViewerBlazor.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TableViewerBlazor.Internal.Editor;

public class TvEditorBase : ComponentBase
{
    [Parameter] public TvOptions? Options { get; set; }
    [Parameter] public int Depth { get; set; }
    [Parameter] public Func<object?, Task>? DataChanged { get; set; }

    protected async Task EmitDataChanged(object? data)
    {
        if (DataChanged != null)
        {
            await DataChanged(data);
        }
    }
}
