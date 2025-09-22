
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace NICVC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NICVCTabbedPage : Xamarin.Forms.TabbedPage
    {
        public NICVCTabbedPage()
        {
            InitializeComponent();
            Lbl_Header.Text = App.GetLabelByKey("nicvdconf");        

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            Children.Add(new Dashboard_Page());
            Children.Add(new ReserveNicDashboardPage());
            Children.Add(new FeedbackPage());
            Children.Add(new AboutUsPage());          
            CurrentPage = Children[App.CurrentTabpageIndex];

        }

    }
}