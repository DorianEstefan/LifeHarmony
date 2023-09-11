using LifeHarmony.src.Models;
using Microsoft.VisualBasic;

namespace LifeHarmony;

public partial class MainPage : ContentPage
{
    private readonly Connection connect;
    public MainPage()
	{
		InitializeComponent();
        connect = new Connection();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await CargarDatos();
    }

    private async Task CargarDatos()
    {
        List<PlanAlimentacion> plan = await connect.GetPlanAPI();
        PlanAlimentacionCollection.ItemsSource = plan;
    }

}

