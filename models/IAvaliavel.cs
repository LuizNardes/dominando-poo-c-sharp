namespace ScreenSound.models;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; } 
}