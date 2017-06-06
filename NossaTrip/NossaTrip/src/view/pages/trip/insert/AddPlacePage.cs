using NossaTrip.global;
using NossaTrip.model.domain.place;
using NossaTrip.view.pages.trip.components;
using NossaTrip.view.pages.trip.insert.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert
{
    public class AddPlacePage : ContentPage
    {
        private readonly ScrollView _scrool;
        private readonly StackLayout _stack;

        public AddPlacePage()
        {
            BackgroundColor = ColorConstants.NewTripBackground;

            _stack = new StackLayout { Margin = new Thickness(0, 20, 0, 0) };
            _scrool = new ScrollView { Content = _stack };

            var instructions = new AddPlaceLabelInstruction();

            var addPlaceBtn = new ToolbarItem { Icon = ImgConstants.Add };
            var saveBtn = new ToolbarItem { Icon = ImgConstants.Check };

            addPlaceBtn.Clicked += (sender, e) => Navigation.PushModalAsync(new AddPlaceSearchPage(_stack));

            ToolbarItems.Add(addPlaceBtn);
            ToolbarItems.Add(saveBtn);

            // Content = instructions;
            Content = _scrool;
        }
    }
}
