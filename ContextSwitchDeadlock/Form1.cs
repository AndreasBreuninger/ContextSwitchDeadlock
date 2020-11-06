using System;
using System.Windows.Forms;

namespace ContextSwitchDeadlock
{
    public partial class Form1 : Form
    {

        private readonly WorkspaceViewModel _workspace = new WorkspaceViewModel();

        public Form1()
        {
            InitializeComponent();

            elementHost1.Child = new MainControl(){DataContext = _workspace};

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _workspace.Worksheets.Add(new WpfWorksheetViewModel(new System.Windows.Controls.Button(){Content = "WPF", Width = 200, Height = 16}));
            _workspace.Worksheets.Add(new WinformsWorksheetViewModel(new HostFormControl(new System.Windows.Controls.TextBox() {Width = 200, Height = 16})));
        }
    }
}
