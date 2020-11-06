using System.Windows.Controls;

namespace ContextSwitchDeadlock
{
    public class WpfWorksheetViewModel : WorksheetViewModelBase
    {
        public ContentControl Form { get; set; }

        public WpfWorksheetViewModel(ContentControl form)
        {
            Form = form;
        }
    }
}
