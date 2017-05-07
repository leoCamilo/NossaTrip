using NossaTrip.view.components;
using System;
using Xamarin.Forms;

namespace NossaTrip.control.controllers.trip
{
    public class TripController
    {
        public static EventHandler Like()
        {
            return (sender, e) =>
            {
                var btn = (Label)sender;

                if (btn.TextColor == Color.White)
                {
                    btn.TextColor = Color.Red;
                    btn.Text = FontAwsomeXamarin.FAHeart;
                }
                else
                {
                    btn.TextColor = Color.White;
                    btn.Text = FontAwsomeXamarin.FAHeartO;
                }
            };
        }

        public static EventHandler Share()
        {
            return (sender, e) =>
            {
                
            };
        }

        public static EventHandler Favorite()
        {
            return (sender, e) =>
            {
                var btn = (Label)sender;

                if (btn.TextColor == Color.White)
                {
                    btn.TextColor = Color.Yellow;
                    btn.Text = FontAwsomeXamarin.FAStar;
                }
                else
                {
                    btn.TextColor = Color.White;
                    btn.Text = FontAwsomeXamarin.FAStarO;
                }
            };
        }
    }
}
