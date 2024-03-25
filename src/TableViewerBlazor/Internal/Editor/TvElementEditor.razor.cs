using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using TableViewerBlazor.Helper;

namespace TableViewerBlazor.Internal.Editor;

public partial class TvElementEditor : TvEditorBase
{
    [Parameter] public object? Parent { get; set; }
    [Parameter] public object? Data { get; set; }

    private bool IsNumber => Data switch
    {
        byte => true,
        int => true,
        long => true,
        float => true,
        double => true,
        decimal => true,
        _ => false,
    };

    private bool IsObjectArray => Data.IsObjectArray();
}
