using HBDday.Common;
using HBDday.Model;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace HBDday.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddPage : HBPage
    {
        public AddPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void SaveAppBarButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            HBModel model = new HBModel()
            {
                DDay = DdayDatePicker.Date.DateTime,
                Title = TitleTextBox.Text,
                UseAlarm = AlertToggleSwitch.IsOn
            };


            App.Current.Manager.Items.Add(model);
            await HBManager.SaveManagerAsync(App.Current.Manager);
        }

        private void BackgroundPanel_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BackgroundSelectPage));
        }
    }
}
