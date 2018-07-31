using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceExists.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            bool xamarinResource = App.DrawableManager.DoesImageExist("xamarin.png");
            bool notExistsResource = App.DrawableManager.DoesImageExist("somenamethatisnotthere.png");

            imageExistsLabel.Text = xamarinResource ? "xamarin.png is found!" : "xamarin.png is not found :(";
            imageDoesntExistLabel.Text = notExistsResource ? "somenamethatisnotthere.png is found!" : "somenamethatisnotthere.png is not found :)";
        }
    }
}