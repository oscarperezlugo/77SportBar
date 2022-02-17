using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phixser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
            //var fotos = new List<string>
            //{
            //    "https://www.phixser.com/phixser/wp-content/uploads/2020/05/Dise%C3%B1o-App-OK3-e1588366593178.png",
            //    "https://www.phixser.com/phixser/wp-content/uploads/2020/05/Dise%C3%B1o-App-OK2-e1588366668310.png",
            //    "https://www.phixser.com/phixser/wp-content/uploads/2020/05/Dise%C3%B1o-App-OK-3-e1588366743914.png",
            //};
            //slider.ItemsSource = fotos;
        }
        public void MapClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        public void FormClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            Form myHomePage = new Form();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        public void ReviewClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            Page1 myHomePage = new Page1();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        private void OpenWhatsApp(object sender, EventArgs e)
        {
            Chat myHomePage = new Chat();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);
        }
        private void PhixserNumber(object sender, EventArgs e)
        {
            long number = +13057351477;
            PhoneDialer.Open(number.ToString());
        }
        public void HubClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            ClienPage myHomePage = new ClienPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
    }
}