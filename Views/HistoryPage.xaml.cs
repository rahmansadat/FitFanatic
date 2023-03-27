using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkApp.Views;

public partial class HistoryPage : ContentPage
{
    public HistoryPage(ViewModels.HistoryPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        var viewModel = new ViewModels.HistoryPageViewModel();
        mainStack.Children.Clear();
        if (File.Exists(Constants.WorkoutLogPath))
        {
            var fileData = File.ReadAllText(Constants.WorkoutLogPath);
            string[] tempFileDataInArray = fileData.Split(new string[] { "\n\n" }, StringSplitOptions.None);
            string[] fileDataInArray = tempFileDataInArray.Take(tempFileDataInArray.Count() - 1).ToArray();

            foreach (string workout in fileDataInArray)
            {
                mainStack.Add(new Border
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
                    Content = new Label
                    {
                        Text = workout,
                        TextColor = Colors.White,
                        FontSize = 14,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center,
                    }
                });
            }

            Button button = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Text = "Erase workout history",
                BorderColor = Colors.Black,
                TextColor = Colors.Black,
                BorderWidth = 4,
                BackgroundColor = Colors.DarkGreen,
                CornerRadius = 50
            };
            button.Clicked += async (sender, args) => EraseWorkoutLog();
            mainStack.Add(button);


        } else
        {
            mainStack.Add(new Label {Text = "No workouts logged"});
        }
    }

    void EraseWorkoutLog()
    {
        File.Delete(Constants.WorkoutLogPath);
        Preferences.Default.Remove("workoutsCount");
        OnAppearing();
    }


}
