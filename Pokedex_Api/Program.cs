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
        return new PokemonSpecies(420,nombre_Pokemon,new List<FlavorText>());
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
        return "Texto generico";
    }
}

public class FlavorText
{
    public string Text { get; set; }
    public NamedAPIResource Language { get; set; }

}

public class NamedAPIResource
{
    public string Name { get; set; }
    public string Url { get; set; }

}