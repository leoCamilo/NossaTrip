using NossaTrip.view.pages.config;
using NossaTrip.view.pages.favorites;
using NossaTrip.view.pages.feed;
using NossaTrip.view.pages.profile;
using System;
using Xamarin.Forms;

namespace NossaTrip.control.page
{
    public enum AppPage { Feed, Profile, Favorites, MyTrips, Config }

    public class ScreenController
    {
        private Page[] _pages;
        private Type[] _pagesType;
        private const int pageCount = 5;

        private static ScreenController instance;
        public static ScreenController Instance => instance ?? (instance = new ScreenController());

        public ScreenController()
        {
            _pages = new Page[pageCount];
            _pagesType = new Type[] 
            {
                typeof(FeedPage),
                typeof(ProfilePage),
                typeof(FavoritesPage),
                typeof(MyTripsPage),
                typeof(ConfigPage)
            };
        }

        public Page GetPage(AppPage page)
        {
            var i = (int)page;
            return _pages[i] ?? (_pages[i] = (Page)Activator.CreateInstance(_pagesType[i]));
        }
    }
}
