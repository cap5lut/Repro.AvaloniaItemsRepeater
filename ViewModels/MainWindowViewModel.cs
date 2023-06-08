using System.Collections.ObjectModel;

namespace Repro.AvaloniaItemsRepeater.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ExampleViewModel> Examples { get; } = new ObservableCollection<ExampleViewModel>()
    {
        new ExampleViewModel(),
        new ExampleViewModel(),
        new ExampleViewModel(),
        new ExampleViewModel(),
        new ExampleViewModel()
    };
}
