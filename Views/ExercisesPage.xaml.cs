using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkApp.Views;

public partial class ExercisesPage : ContentPage
{
    public ExercisesPage(ViewModels.ExercisesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;


        // Creating carousel view of exercises
        CarouselView carouselView = new CarouselView();
        carouselView.SetBinding(ItemsView.ItemsSourceProperty, "Items");
        carouselView.ItemTemplate = new DataTemplate(() =>
        {
            Grid grid = new Grid
            {
                Padding = 10, VerticalOptions = LayoutOptions.Center
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            Image image = new Image { Aspect = Aspect.AspectFill, HeightRequest = 280, WidthRequest = 350};
            image.SetBinding(Image.SourceProperty, "ImageURL");

            Label nameLabel = new Label { FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            Label bodypartLabel = new Label { FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
            bodypartLabel.SetBinding(Label.TextProperty, "Bodypart");

            Label instructionsLabel = new Label { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(20, 0), FontAttributes = FontAttributes.Italic, MaximumWidthRequest = 300};
            instructionsLabel.SetBinding(Label.TextProperty, "Instructions");
            
            grid.Add(nameLabel, 0, 0);
            grid.Add(image, 0, 1);
            grid.Add(bodypartLabel, 0, 2);
            grid.Add(instructionsLabel, 0, 3);

            return grid;
        });

        // Adding border around the carousel view
        mygrid.Add(new Border
        {
            Stroke = Color.FromArgb("#58CD36"),
            Background = Color.FromArgb("DarkGreen"),
            StrokeThickness = 4,
            WidthRequest = 350,
            HeightRequest = 500,
            Padding = new Thickness(16, 8),
            HorizontalOptions = LayoutOptions.Center,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(30, 30, 30, 30)
            },
            Content = carouselView

        }, 0, 1);
    }
}
