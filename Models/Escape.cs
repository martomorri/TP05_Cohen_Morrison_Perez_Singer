using System;

public static class Escape
{
    private static string[] _incognitasSalas = new string[0]; private static int _estadoJuego = 1; //private static string[] _incognitas4Fotos = new string[0];
    public static int estadoJuego
    {
        get { return _estadoJuego; }
        set { _estadoJuego = value; }
    }
    private static void inicializarJuego()
    {
        _incognitasSalas = new string[4];
        _incognitasSalas[0] = "ATRACO"; _incognitasSalas[1] = "CDP"; _incognitasSalas[2] = "NAI-RIO-DEN"; _incognitasSalas[3] = "PROFESOR";
        /*_incognitas4Fotos = new string[3];
        _incognitas4Fotos[0] = "NAIROBI"; _incognitas4Fotos[1] = "RIO"; _incognitas4Fotos[2] = "DENVER";*/
    }
    public static bool resolverSala(int sala, string incognita)
    {
        if(_incognitasSalas.Length == 0) inicializarJuego();
        if (incognita.ToUpper() == _incognitasSalas[sala-1]){
            estadoJuego++;
            return true;
        }
        else return false;
    }
    /*public static bool resolver4Fotos(int num, string incognita)
    {
        if(_incognitas4Fotos.Length == 0) inicializarJuego();
        if (incognita.ToUpper() == _incognitas4Fotos[num-1]){
            return true;
        }
        else return false;
    }*/
}