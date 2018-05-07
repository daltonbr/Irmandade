using System;

namespace Irmandade.Model
{
    [Flags]
    public enum Dias
    {
        Segunda = 1,
        Terça = 2,
        Quarta = 4,
        Quinta = 8,
        Sexta = 16
        //Sabado = 32,
        //Domingo = 64,
        //SegundaASexta = 31,
        //Todos = 127,
        //Nenhum = 0
    }
 
}
