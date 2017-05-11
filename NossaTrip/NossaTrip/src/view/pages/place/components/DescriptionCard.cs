using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class DescriptionCard : Frame
    {
        public DescriptionCard()
        {
            HasShadow = false;
            CornerRadius = 0;
            Padding = 15;
            Margin = 0;
            BackgroundColor = Color.FromHex("#323232");

            var contentLabel = new Label
            {
                Text = "Manguinhos is a beach near Vitoria (30 Km) where you can find peace, nice people e good food. My advise is to get the beach in front of the Estação Primeira de Manguinhos (Vagão) - a nice restaurant builded from an old train wagon. To eat, the best place is the restaurant Enseada de Manguinhos (known as Geraldinho, the nickname of the boss). You must eat a Moqueca Capixaba with shrimp sauce and Pastel of shrimps by entries.",
                TextColor = Color.White
            };

            Content = contentLabel;
        }
    }
}
