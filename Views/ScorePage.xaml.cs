using CourseworkApp.Services;
using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CourseworkApp.Models;

namespace CourseworkApp.Views;

public partial class ScorePage : ContentPage
{
    public ScorePage(ViewModels.ScorePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {

        // QUOTE SYSTEM

        QuoteModel quote = APIQuoteService.GetRandomQuote();
        mystack1.Children.Clear();

        if (quote.Author != null && quote.Quote != null)
        {
            Label quoteLabel = new Label
            {
                Text = string.Concat("“", quote.Quote, "”"),
                FontAttributes = FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Margin = 20
            };

            Label authorLabel = new Label
            {
                Text = string.Concat("- ", quote.Author),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Margin = 20
            };

            mystack1.Add(quoteLabel);
            mystack1.Add(authorLabel);
            Console.WriteLine("Quote and author added to screen");
        } else
        {
            Label noQuoteLabel = new Label
            {
                Text = "No quote available at the moment.\nCheck your internet connection.",
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            mystack1.Add(noQuoteLabel);
            Console.WriteLine("No quotes available at the moment.");
        }

        // SCORING SYSTEM

        mystack2.Children.Clear();
        int workoutsCount = Preferences.Default.Get("workoutsCount", -1);
        if (workoutsCount == -1)
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal };
            mystack2.Add(new Border
            {
                Stroke = Color.FromArgb("#58CD36"),
                Background = Color.FromArgb("DarkGreen"),
                StrokeThickness = 4,
                WidthRequest = 320,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(30, 30, 30, 30)
                },
                Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_unavailable.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "No Shields Earned",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed 0 workouts total.\nYou need to do 5 more to get the Bronze Shield."
            });

        }
        else if (workoutsCount < 5)
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal };
            mystack2.Add(new Border
            {
                Stroke = Color.FromArgb("#58CD36"),
                Background = Color.FromArgb("DarkGreen"),
                StrokeThickness = 4,
                WidthRequest = 320,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(30, 30, 30, 30)
                },
                Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_unavailable.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "No Shields Earned",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed {workoutsCount} workouts total.\nYou need to do {5 - workoutsCount} more to get the Bronze Shield."
            });

        } else if (workoutsCount < 10)
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal};
            mystack2.Add(new Border
             {
                 Stroke = Color.FromArgb("#58CD36"),
                 Background = Color.FromArgb("DarkGreen"),
                 StrokeThickness = 4,
                 WidthRequest = 320,
                 Padding = new Thickness(16, 8),
                 HorizontalOptions = LayoutOptions.Center,
                 StrokeShape = new RoundRectangle
                 {
                     CornerRadius = new CornerRadius(30, 30, 30, 30)
                 },
                 Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_bronze.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "Bronze Shield",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed {workoutsCount} workouts total.\nYou need to do {10 - workoutsCount} more to get the Silver Shield."
            });

        } else if (workoutsCount < 20)
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal };
            mystack2.Add(new Border
            {
                Stroke = Color.FromArgb("#58CD36"),
                Background = Color.FromArgb("DarkGreen"),
                StrokeThickness = 4,
                WidthRequest = 320,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(30, 30, 30, 30)
                },
                Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_silver.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "Silver Shield",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed {workoutsCount} workouts total.\nYou need to do {20 - workoutsCount} more to get the Gold Shield."
            });

        } else if (workoutsCount < 50)
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal };
            mystack2.Add(new Border
            {
                Stroke = Color.FromArgb("#58CD36"),
                Background = Color.FromArgb("DarkGreen"),
                StrokeThickness = 4,
                WidthRequest = 320,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(30, 30, 30, 30)
                },
                Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_gold.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "Gold Shield",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed {workoutsCount} workouts total.\nYou need to do {50 - workoutsCount} more to get the Platinum Shield."
            });

        } else
        {
            StackLayout badgeStackLayout = new StackLayout { Spacing = 15, Orientation = StackOrientation.Horizontal };
            mystack2.Add(new Border
            {
                Stroke = Color.FromArgb("#58CD36"),
                Background = Color.FromArgb("DarkGreen"),
                StrokeThickness = 4,
                WidthRequest = 320,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(30, 30, 30, 30)
                },
                Content = badgeStackLayout
            });

            badgeStackLayout.Add(new Image
            {
                Source = ImageSource.FromFile("shield_platinum.png"),
                HorizontalOptions = LayoutOptions.Center
            });
            badgeStackLayout.Add(new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = "Platinum Shield",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            });

            mystack2.Add(new Label
            {
                FontAttributes = FontAttributes.Italic,
                Margin = 20,
                Text = $"You have completed {workoutsCount} workouts total.\nYou have been awarded the most prestigious shield."
            });
        }
    }
}



