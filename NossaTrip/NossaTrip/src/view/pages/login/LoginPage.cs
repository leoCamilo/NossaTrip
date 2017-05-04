using NossaTrip.view.pages.login.components;
using System;
using Xamarin.Forms;

namespace NossaTrip.src.view.pages.login
{
    public class LoginPage : ContentPage
    {
        private readonly LoginEntry _emailEntry = new LoginEntry { Placeholder = "E-mail", Margin = new Thickness(0, 0, 0, Device.OnPlatform(5, 0, 0)) };
        private readonly LoginEntry _passEntry = new LoginEntry { Placeholder = "Senha", IsPassword = true, Margin = new Thickness(0, 5, 0, 0) };

        public LoginPage()
        {
            var layout = new RelativeLayout();
            var btnLogin = new Button { Text = "Login", TextColor = Color.White };

            layout.Children.Add(new Image { Aspect = Aspect.AspectFill, Source = "login__bg.jpg" },
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((dad) => dad.Width),
                Constraint.RelativeToParent((dad) => dad.Height)
            );

            layout.Children.Add(new Image { Aspect = Aspect.AspectFit, Source = "splash_screen_logo.png" },
                Constraint.RelativeToParent((dad) => dad.Width * 0.15),
                Constraint.RelativeToParent((dad) => dad.Width * 0.15),
                Constraint.RelativeToParent((dad) => dad.Width * 0.7)
            );

            layout.Children.Add(
                new StackLayout
                {
                    Spacing = 0,
                    Children = { _emailEntry, new CustomShape() { BorderWidth = 2, Color = Color.White, Type = ShapeType.Line, HeightRequest = 1 }, _passEntry }
                },
                Constraint.RelativeToParent((dad) => dad.Width * 0.15),
                Constraint.RelativeToParent((dad) => dad.Width * 0.4),
                Constraint.RelativeToParent((dad) => dad.Width * 0.7)
            );

            layout.Children.Add(new CustomShape {
                    BorderRadius = Device.OnPlatform(0.5f, 0.3f, 0),
                    BorderWidth = Device.OnPlatform(2, 5, 0),
                    Color = Color.White
                },
                Constraint.RelativeToParent((dad) => dad.Width * 0.15),
                Constraint.RelativeToParent((dad) => dad.Width * 0.6),
                Constraint.RelativeToParent((dad) => dad.Width * 0.7),
                Constraint.RelativeToParent((dad) => dad.Width * 0.1)
            );

            layout.Children.Add(btnLogin,
                Constraint.RelativeToParent((dad) => dad.Width * 0.15),
                Constraint.RelativeToParent((dad) => dad.Width * 0.6),
                Constraint.RelativeToParent((dad) => dad.Width * 0.7),
                Constraint.RelativeToParent((dad) => dad.Width * 0.1)
            );

            btnLogin.Clicked += (sender, e) => OnLoginClicked(sender, e);

            Content = layout;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            // var email = _emailEntry.Text;
            // var pass = _passEntry.Text;

            var app = (App) App.Current;
            app.GetIn();
        }
    }
}
