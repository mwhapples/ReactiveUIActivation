using ReactiveUI;

namespace ReactiveUIActivation
{
    public class MainViewModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();
    }
}
