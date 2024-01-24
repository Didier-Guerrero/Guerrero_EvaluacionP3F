namespace Guerrero_EvaluacionP3F.DG_Views;
using System.Text.Json;
using Newtonsoft.Json;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Guerrero_EvaluacionP3F.DG_Models;
public partial class DG_PaisAPI : ContentPage
{
	public DG_PaisAPI()
	{
		InitializeComponent();
	}
    private async void DG_Consultar_Clicked(object sender, EventArgs e)
    {
        string DG_PaisC = DG_Pais.Text;
        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            using (var DG_client = new HttpClient())
            {
                string DG_url = $"https://restcountries.com/v3.1/name/"+ DG_PaisC;

                var DG_response = await DG_client.GetAsync(DG_url);
                if (DG_response.IsSuccessStatusCode)
                {
                    var DG_json = await DG_response.Content.ReadAsStringAsync();
                    var DG_PaisAPI = JsonConvert.DeserializeObject<List<Root>>(DG_json);


                    if (DG_PaisAPI.Count > 0)
                    {
                        var firstCountry = DG_PaisAPI[0];
                    }

                }

            }
        }
    }
}