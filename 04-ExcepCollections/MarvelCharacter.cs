class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }

   public override string ToString()
    {
        return $"Hola soy {Name} del equipo {Team} y me dicen {Alias}";
    }
    
}
