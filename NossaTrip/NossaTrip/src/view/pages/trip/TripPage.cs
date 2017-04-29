using NossaTrip.view.pages.trip.components;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip
{
    public class TripPage : ContentPage
    {
        public TripPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var layout = new AbsoluteLayout();
            var info_list = new TripPageStackLayout();

            Background.SetLayoutBackground(layout, "https://s-media-cache-ak0.pinimg.com/originals/53/7b/3e/537b3e250746bb712510f81d1d241520.jpg");            

            info_list.Children.Add(new TripNameLabel("Best U.S.A Trip =)"));
            info_list.Children.Add(new TripAddressLabel("New York, USA"));
            info_list.Children.Add(new TripFunctionsBtn());
            info_list.Children.Add(new TripDescriptionLabel("Conhecer Nova Iorque é um sonho, uma viagem onde você traz as histórias dos filmes para dentro de sua realidade. Tudo é muito incrível em Nova Yorque e existem inúmeros pontos turísticos.\n\nEm minha viagem aos Estados Unidos, eu me hospedei na cidade de Farfield que fica em um estado vizinho, chamado Connecticut.A cidade é pequena e linda, muito arborizada e muito bem cuidada, uma cidade com muitas residências e poucos comércios.\n\nMesmo sendo em outro estado, Farfield pertence a região metropolitana de Nova Yorque, então meu ponto de partida foi a Estação Central de Nova Yorque que por si só já é uma atração turística.\n\nA estação é muito grande e possui várias lojas, cafés e lanchonetes e lá eu encontrei também uma loja da Apple. Através desta estação é possível viajar para várias cidades dos Estados Unidos, com trens partindo de cinco em cinco."));

            var tags_label = new Label
            {
                Margin = new Thickness(0, 20, 0, 0),
                Text = "tags:",
                TextColor = Color.White
            };

            info_list.Children.Add(tags_label);

            var tag_stack = new StackLayout();

            tag_stack.Children.Add(new TripTagCard("cold"));
            tag_stack.Children.Add(new TripTagCard("NYC"));
            tag_stack.Children.Add(new TripTagCard("America"));
            tag_stack.Children.Add(new TripTagCard("North America"));
            tag_stack.Children.Add(new TripTagCard("USA"));
            tag_stack.Children.Add(new TripTagCard("new york"));

            info_list.Children.Add(tag_stack);

            var places_label = new Label
            {
                Margin = new Thickness(0, 20, 0, 0),
                Text = "places:",
                TextColor = Color.White
            };

            info_list.Children.Add(places_label);

            info_list.Children.Add(new TripPlaceCard("Macgaiver's bar", "http://static.wixstatic.com/media/6d576695617ad2f8c0022066227abbe3.wix_mp_1024"));
            info_list.Children.Add(new TripPlaceCard("Central Park", "https://spoilednyc.com/wp-content/uploads///2015/11/13/nycparks-4612.jpg"));
            info_list.Children.Add(new TripPlaceCard("Wall Street", "http://homeandecoration.com/wp-content/uploads/2014/04/best-places-to-visit-nyc-new-york-design-week-icff-2.jpg"));
            info_list.Children.Add(new TripPlaceCard("Liberty Statue", "http://www.theplunge.com/image.php?width=800&height=800&image=http://www.theplunge.com/images/new_articles/top_20_places_to_propose_in_ny/NYC-1.jpg"));
            info_list.Children.Add(new TripPlaceCard("Some Bridge", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTwEoRlSodkMwJ6Qo154njqWYyuievJ_o0gRn1ezLbgaFM02i31"));
            info_list.Children.Add(new TripPlaceCard("Philip's bar", "https://s-media-cache-ak0.pinimg.com/originals/27/a5/8a/27a58a1ab7a9e97fd4fc8ba463ca9438.jpg"));

            var map_label = new Label
            {
                Margin = new Thickness(0, 20, 0, 0),
                Text = "map:",
                TextColor = Color.White
            };

            info_list.Children.Add(map_label);

            info_list.Children.Add(new Image {
                Source = "http://www.droid-life.com/wp-content/uploads/2016/09/google-maps.jpg",

            });

            var comments_label = new Label
            {
                Margin = new Thickness(0, 20, 0, 0),
                Text = "comments:",
                TextColor = Color.White
            };

            info_list.Children.Add(comments_label);

            var comment = "comentário legal sobre algo da viagem";

            for (int i = 0; i < 5; i++)
            {
                info_list.Children.Add(new TripPageComment(comment));
                comment += comment;
            }

            info_list.Children.Add(new Entry { Placeholder = "comment...", PlaceholderColor = Color.FromHex("#ededed"), TextColor = Color.White });

            var scroll = new ScrollView();
            scroll.Content = info_list;

            
            AbsoluteLayout.SetLayoutBounds(scroll, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(scroll, AbsoluteLayoutFlags.SizeProportional);

            layout.Children.Add(scroll);
            Content = layout;
        }
    }
}
