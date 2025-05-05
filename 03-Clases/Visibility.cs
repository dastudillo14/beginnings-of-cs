
using System.Runtime.CompilerServices;

partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new()
        {
            PowerLevel = 1000,
            LightsaberColor = "azul"
        };
        jedi.UseForce();

        jedi.RevealSecrets();

        WriteLine($"{jedi.PublicField}");

        WriteLine("----- Sith -----");

        Sith sith = new()
        {
            PowerLevel = 500,
            LightsaberColor = "rojo"
        };

        sith.ShowProtected();
        sith.UseForce();
    }


}


interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightsaberColor { get; set; }
    void UseForce();
}


class Jedi : IForceUser
{
    public string PublicField = "Soy un Jedi y mi poder es conocido."; //Acceso desde cualquier parte del programa
    private string PrivateField = "Mis pensamientos más profundos son privados.";//Acceso solo dentro de la clase
    protected string ProtectedField = "El lado oscuro no debe conocer mis secretos.";//Acceso dentro de la clase y clase derivadas

    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    //Métodos
    public void UseForce()
    {
        WriteLine($"Soy un Jedi con el sable de luz de color {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }

    private void Meditate()
    {
        WriteLine("Estoy en profunda meditación con la fuerza.");
    }

    protected void Train()
    {
        WriteLine("Estoy entrenando para convertirme en el mejor Jedi");
    }

    public void RevealSecrets()
    {
        WriteLine($"ProtectedField: {ProtectedField} \n PrivateField: {PrivateField}");
    }

}

class Sith : Jedi, IForceUser
{

    public new void UseForce()
    {
        WriteLine($"Soy un Sith con el sable de luz de color {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }

    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}