using System.Text.Json;

public class Program
{
    public static async Task Main()
    {
        string nombre_Pokemon;

        Console.WriteLine("Ingrese el nombre del pokemon el cual quiera saber la informacion");
        nombre_Pokemon = Console.ReadLine();

        Console.WriteLine(await Buscar_Pokemon(nombre_Pokemon));




        Console.ReadKey();
    }

    public static async Task<PokemonSpecies> Buscar_Pokemon(string nombre_Pokemon)
    {
        string url = "https://pokeapi.co/api/v2/pokemon-species/" + nombre_Pokemon;

        HttpClient client = new HttpClient();

        var httpResponde = await client.GetAsync(url);

        if (httpResponde.IsSuccessStatusCode)
        {
            var content = await httpResponde.Content.ReadAsStringAsync();

            PokemonSpecies pokemon = JsonSerializer.Deserialize<PokemonSpecies>(content);

            return pokemon;
        }
        else
        {
            return null;
        }
    }

}

public class PokemonSpecies
{
    public int id { get; set; }
    public string name { get; set; }

    public List<FlavorText> flavor_text_entries { get; set; }


    public override string ToString()
    {

        if (flavor_text_entries.Count == 0)
        {
            return name + " " + "No se encontro informacion de este pokemon";
        }
        else
        {
            return name + " " + flavor_text_entries[5].flavor_text;
        }

    }
}

public class FlavorText
{

    public string flavor_text { get; set; }
    public NamedAPIResource language { get; set; }
}

public class NamedAPIResource
{

    public string name { get; set; }
    public string url { get; set; }

}

public class PokemonClient
{
    public static async Task<PokemonSpecies> Buscar_Pokemon(string nombre_Pokemon)
    {
        string url = "https://pokeapi.co/api/v2/pokemon-species/" + nombre_Pokemon;

        HttpClient client = new HttpClient();

        var httpResponde = await client.GetAsync(url);

        if (httpResponde.IsSuccessStatusCode)
        {
            var content = await httpResponde.Content.ReadAsStringAsync();

            PokemonSpecies pokemon = JsonSerializer.Deserialize<PokemonSpecies>(content);

            return pokemon;
        }
        else
        {
            return null;
        }
    }
}