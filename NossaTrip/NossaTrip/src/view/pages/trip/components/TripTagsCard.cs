using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripTagsCard : Label
    {
        public float LineSpacing { get; set; }
        private static Random _rnd = new Random();

        public TripTagsCard(string tags)
        {
            Margin = 5;
            
            var tags_fs = new FormattedString();

            foreach (var tag in tags.Split('|'))
            {
                tags_fs.Spans.Add(new Span {
                    Text = " " + tag + " ",
                    ForegroundColor = Color.White,
                    BackgroundColor = Color.FromRgb(_rnd.Next(100, 200), _rnd.Next(100, 200), _rnd.Next(100, 200))
                });

                tags_fs.Spans.Add(new Span { Text = " " });
            }

            FormattedText = tags_fs;
        }
    }
}
