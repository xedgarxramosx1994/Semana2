using eramos_TallerS2.Views;

namespace eramos_TallerS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new vHome();
        }
    }
}
