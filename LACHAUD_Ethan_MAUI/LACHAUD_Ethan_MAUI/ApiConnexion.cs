using System.Collections.ObjectModel;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace LACHAUD_Ethan_MAUI;

public class ApiConnexion
{
    public ObservableCollection<Futurama> Characters { get; } = new ObservableCollection<Futurama>();

    public ApiConnexion()
    {
        Task.Run(() => GetCharacters());

    }
    
    private async Task GetCharacters()
    {
        var client = new HttpClient();
        var response = await client.GetStringAsync("https://api.sampleapis.com/futurama/characters");
        var characters = JsonSerializer.Deserialize<List<Futurama>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        foreach (var character in characters)
        {
            Characters.Add(character);
        }
    }
}

