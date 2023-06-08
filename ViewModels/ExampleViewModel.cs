using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repro.AvaloniaItemsRepeater.ViewModels;
public class ExampleViewModel : ViewModelBase
{
    public int Number { get; } = Random.Shared.Next(0, 100);
}
