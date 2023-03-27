using Microsoft.Maui.Controls;
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

            Label nameLabel = new Label { FontAttributes = FontAttributes.Bold };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            Label bodypartLabel = new Label { FontAttributes = FontAttributes.Bold};
            bodypartLabel.SetBinding(Label.TextProperty, "Bodypart");

            Label instructionsLabel = new Label { FontAttributes = FontAttributes.Italic, MaximumWidthRequest = 300};
            instructionsLabel.SetBinding(Label.TextProperty, "Instructions");
            
            grid.Add(nameLabel, 0, 0);
            grid.Add(image, 0, 1);
            grid.Add(bodypartLabel, 0, 2);
            grid.Add(instructionsLabel, 0, 3);

            return grid;
        });

        IndicatorView indicatorView = new IndicatorView()
        {
            IndicatorColor = Colors.Red,
            SelectedIndicatorColor = Colors.DarkRed,
            IndicatorSize = 12,
            Margin = new Thickness(0, 0, 0, 40)
        };

        mygrid.Add(carouselView, 0, 1);
        mygrid.Add(indicatorView, 0, 0);

    }
}
