using ScreenSound.models;

namespace ScreenSound.menus;

internal class MenuSair:Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        System.Console.WriteLine("Tcha tchau ;)");;
    }
}