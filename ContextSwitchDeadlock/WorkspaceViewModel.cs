using System.Collections.ObjectModel;

namespace ContextSwitchDeadlock
{
    public class WorkspaceViewModel : ViewModelBase
    {
        public WorkspaceViewModel()
        {
            Worksheets = new ObservableCollection<WorksheetViewModelBase>();
        }

        public ObservableCollection<WorksheetViewModelBase> Worksheets { get; }
    }

}
