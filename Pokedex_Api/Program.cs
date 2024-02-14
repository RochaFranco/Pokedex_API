public class Program
{
    public static void Main()
    {
        string nombre_Pokemon;

        Console.WriteLine("Ingrese el nombre del pokemon el cual quiera saber la informacion");
        nombre_Pokemon = Console.ReadLine();

        Console.WriteLine(Buscar_Pokemon(nombre_Pokemon));




        Console.ReadKey();
    }

    public static PokemonSpecies Buscar_Pokemon(string nombre_Pokemon)
    {
        var Texto = new FlavorText("Gato", new NamedAPIResource("es", "https://mundogaturro.com"));

        var lista = new List<FlavorText>();

        lista.Add(Texto);

        return new PokemonSpecies(420, nombre_Pokemon, lista);
    }

}

public class PokemonSpecies
{
    public PokemonSpecies(int id, string name, List<FlavorText> flavorText)
    {
        Id = id;
        Name = name;
        FlavorTextEntries = flavorText;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public List<FlavorText> FlavorTextEntries { get; set; }


    public override string ToString()
    {

        if (FlavorTextEntries.Count == 0)
        {
            return Name + " " + "No se encontro informacion de este pokemon";
        }
        else
        {
            return Name + " " + FlavorTextEntries[0].Text;
        }
        
    }
}

public class FlavorText
{
    public FlavorText(string text, NamedAPIResource language)
    {
        Text = text;
        Language = language;
    }

    public string Text { get; set; }
    public NamedAPIResource Language { get; set; }
}

public class NamedAPIResource
{
    public NamedAPIResource(string name, string url)
    {
        Name = name;
        Url = url;
    }

    public string Name { get; set; }
    public string Url { get; set; }

}