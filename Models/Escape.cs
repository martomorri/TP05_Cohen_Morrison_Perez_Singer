using System;

public static class Escape
{
    private static string[] _incognitasSalas = new string[0]; private static string[] _incognitasH4 = new string[0]; private static string[] _incognitasH3 = new string[0]; private static int _estadoJuego = 1;
    public static int estadoJuego
    {
        get { return _estadoJuego; }
        set { _estadoJuego = value; }
    }
    private static void inicializarJuego()
    {
        _incognitasSalas = new string[4];
        _incognitasSalas[0] = "ATRACO"; _incognitasSalas[1] = "CDEP"; _incognitasSalas[2] = "NAI-RIO-DEN"; _incognitasSalas[3] = "PROFESOR";
        _incognitasH4 = new string[6]; _incognitasH4[0] = "SERGIO"; _incognitasH4[1] = "PRIETO"; _incognitasH4[2] = "ROMAN"; _incognitasH4[3] = "ESTOCOLMO"; _incognitasH4[4] = "ORO"; _incognitasH4[5] = "FALSO";
        _incognitasH3 = new string[3]; _incognitasH3[0] = "NAIROBI"; _incognitasH3[1] = "RIO"; _incognitasH3[2] = "DENVER";
    }
    public static void reiniciarJuego()
    {
        _estadoJuego = 1;
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
    public static bool resolverPregunta(int pregunta, string incognita)
    {
        if(_incognitasH4.Length == 0) inicializarJuego();
        if (incognita.ToUpper() == _incognitasH4[pregunta]){
            return true;
        }
        else return false;
    }

    public static bool resolver4Fotos(int pregunta, string incognita)
    {
        if(_incognitasH3.Length == 0) inicializarJuego();
        if (incognita.ToUpper() == _incognitasH3[pregunta]){
            return true;
        }
        else return false;
    }
}