using NossaTrip.model.domain.trip;
using NossaTrip.model.domain.user;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NossaTrip.control.controllers.feed
{
    public class FeedController
    {
        public async static Task<IList<Trip>> GetAllTrips()
        {
            var rnd = new Random();
            var list = new List<Trip>();

            for (var i = 0; i < 50; i++)
            {
                var user = new User { Name = "Leonardo Camilo", Url = "http://www.lovemarks.com/wp-content/uploads/profile-avatars/default-avatar-tech-guy.png" };

                list.Add(new Trip
                {
                    Url = "https://s-media-cache-ak0.pinimg.com/originals/53/7b/3e/537b3e250746bb712510f81d1d241520.jpg",
                    Description = "Conhecer Nova Iorque é um sonho, uma viagem onde você traz as histórias dos filmes para dentro de sua realidade. Tudo é muito incrível em Nova Yorque e existem inúmeros pontos turísticos.\n\nEm minha viagem aos Estados Unidos, eu me hospedei na cidade de Farfield que fica em um estado vizinho, chamado Connecticut.A cidade é pequena e linda, muito arborizada e muito bem cuidada, uma cidade com muitas residências e poucos comércios.\n\nMesmo sendo em outro estado, Farfield pertence a região metropolitana de Nova Yorque, então meu ponto de partida foi a Estação Central de Nova Yorque que por si só já é uma atração turística.\n\nA estação é muito grande e possui várias lojas, cafés e lanchonetes e lá eu encontrei também uma loja da Apple. Através desta estação é possível viajar para várias cidades dos Estados Unidos, com trens partindo de cinco em cinco.",
                    CreationDate = "06:30 pm\nMay 16, 2017",
                    UserCreator = user,
                    Name = "Best trip USA ever!!",
                    Address = "New York, USA",
                    Likes = rnd.Next(0, 999),
                    Tags = new List<string> { "cold", "NYC", "America", "North America", "USA", "new york" },
                    Comments = new List<Comment>
                    {
                        new Comment { Commenter = user, Date = "10/06/2017", Txt = "Eu achei essa viagem muito boa" },
                        new Comment { Commenter = user, Date = "22/08/2017", Txt = "Aqui é Body Builder Ipsum PORRA! Vai subir árvore é o caralho porra! É verão o ano todo vem cumpadi. Não vai dá não. É esse que a gente quer, é ele que nóis vamo buscar. Eita porra!, tá saindo da jaula o monstro! Que não vai dá rapaiz, não vai dá essa porra. É esse que a gente quer, é ele que nóis vamo buscar. Vo derrubar tudo essas árvore do parque ibirapuera. Eu quero esse 13 daqui a pouquinho aí. Sai de casa comi pra caralho porra.Boraaa, Hora do Show Porra. Vem porra!" },
                        new Comment { Commenter = user, Date = "05/04/2017", Txt = "Aqui é Body Builder Ipsum PORRA! Vem porra! Ele tá olhando pra gente. Negativa Bambam negativa. Ajuda o maluco que tá doente. É 13 porra! Boraaa, Hora do Show Porra." },
                    }
                });
            }

            return list;
        }
    }
}
