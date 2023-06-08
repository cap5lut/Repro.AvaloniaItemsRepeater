using Avalonia.Controls.Templates;
using Avalonia.Controls;
using Avalonia.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Repro.AvaloniaItemsRepeater.ViewModels;

namespace Repro.AvaloniaItemsRepeater;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        var typeName = param!.GetType().FullName!.Replace("ViewModels", "Views").Replace("ViewModel", string.Empty);

        var type = Type.GetType(typeName);
        if (type is null)
        {
            return new TextBlock
            {
                Text = "[View not found]"
            };
        }

        return (Control?)Activator.CreateInstance(type);
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
