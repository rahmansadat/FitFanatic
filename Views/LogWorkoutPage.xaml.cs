using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkApp.Models;
using CourseworkApp.ViewModels;

namespace CourseworkApp.Views;

public partial class LogWorkoutPage : ContentPage
{
    public LogWorkoutPage(ViewModels.LogWorkoutPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        stepperLabel1.Text = stepper1.Value.ToString();
        stepperLabel2.Text = stepper2.Value.ToString();
        stepperLabel3.Text = stepper3.Value.ToString();
        stepperLabel4.Text = stepper4.Value.ToString();
        stepperLabel5.Text = stepper5.Value.ToString();
        stepperLabel6.Text = stepper6.Value.ToString();

        var viewModel = (BindingContext as LogWorkoutPageViewModel);
        viewModel.Sets1 = (int)stepper1.Value;
        viewModel.Sets2 = (int)stepper2.Value;
        viewModel.Sets3 = (int)stepper3.Value;
        viewModel.Sets4 = (int)stepper4.Value;
        viewModel.Sets5 = (int)stepper5.Value;
        viewModel.Sets6 = (int)stepper6.Value;
    }

    void OnRepsEntryValueChanged(object sender, TextChangedEventArgs e)
    {
        //Type type = reps1.Text.GetType();
        //Console.WriteLine("The value is now: ");
        //Console.WriteLine(type);

        var viewModel = (BindingContext as LogWorkoutPageViewModel);
        // Set model value according to the value in the field
        if (reps1.Text != null && reps1.Text != string.Empty) viewModel.Reps1 = int.Parse(reps1.Text);
        if (reps2.Text != null && reps2.Text != string.Empty) viewModel.Reps2 = int.Parse(reps2.Text);
        if (reps3.Text != null && reps3.Text != string.Empty) viewModel.Reps3 = int.Parse(reps3.Text);
        if (reps4.Text != null && reps4.Text != string.Empty) viewModel.Reps4 = int.Parse(reps4.Text);
        if (reps5.Text != null && reps5.Text != string.Empty) viewModel.Reps5 = int.Parse(reps5.Text);
        if (reps6.Text != null && reps6.Text != string.Empty) viewModel.Reps6 = int.Parse(reps6.Text);

        // Set value to 0 if the string is empty
        if (reps1.Text == string.Empty) viewModel.Reps1 = 0;
        if (reps2.Text == string.Empty) viewModel.Reps2 = 0;
        if (reps3.Text == string.Empty) viewModel.Reps3 = 0;
        if (reps4.Text == string.Empty) viewModel.Reps4 = 0;
        if (reps5.Text == string.Empty) viewModel.Reps5 = 0;
        if (reps6.Text == string.Empty) viewModel.Reps6 = 0;
    }

    void OnPickerValueChanged(object sender, EventArgs e)
    {
        var viewModel = (BindingContext as LogWorkoutPageViewModel);
        if (picker1.SelectedIndex != -1) viewModel.Exercise1 = (ExerciseModel)picker1.ItemsSource[picker1.SelectedIndex];
        if (picker2.SelectedIndex != -1) viewModel.Exercise2 = (ExerciseModel)picker2.ItemsSource[picker2.SelectedIndex];
        if (picker3.SelectedIndex != -1) viewModel.Exercise3 = (ExerciseModel)picker3.ItemsSource[picker3.SelectedIndex];
        if (picker4.SelectedIndex != -1) viewModel.Exercise4 = (ExerciseModel)picker4.ItemsSource[picker4.SelectedIndex];
        if (picker5.SelectedIndex != -1) viewModel.Exercise5 = (ExerciseModel)picker5.ItemsSource[picker5.SelectedIndex];
        if (picker6.SelectedIndex != -1) viewModel.Exercise6 = (ExerciseModel)picker6.ItemsSource[picker6.SelectedIndex];
    }
}