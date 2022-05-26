using System;

static class Escape
{
    private string[] _incognitasSalas; private int _estadoJuego;
}
public Escape(int estadoJuego)
{
    _estadoJuego = estadoJuego;
}
public int estadoJuego
{
    get { return _estadoJuego; }
}
private static void inicializarJuego()
{
    _incognitasSalas[0] = "atraco"; _incognitasSalas[1] = "CDP"; _incognitasSalas[2] = "Nairobi"; _incognitasSalas[3] = "Profesor";
    _estadoJuego = 1;
}
public static bool resolverSala(int sala, string incognita)
{
    if(incognita == _incognitasSalas[sala]) return true;
    else return false;
}