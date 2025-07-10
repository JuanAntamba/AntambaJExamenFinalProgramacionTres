using AntambaJExamenFinalProgramacionTres.Services;

namespace AntambaJExamenFinalProgramacionTres.Views
{
    public partial class LogsPage : ContentPage
    {
        public LogsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var logs = await LogService.LeerLogs();
            LogList.ItemsSource = logs;
        }
    }
}