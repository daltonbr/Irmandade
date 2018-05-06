using System;

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

//public class Weekdays
//{

//    private Days _days;

//    //public Weekdays(params Days[] daysInput)
//    //{
//    //    //_days = Days.Nenhum;
//    //    foreach (Days d in daysInput)
//    //    {
//    //        _days |= d;
//    //    }
//    //}

//    public bool Contains(Days daysMask)
//    {
//        return (_days & daysMask) == daysMask;
//    }

//    //public bool Contains(params Days[] daysMasks)
//    //{
//    //    //Days mask = Days.Nenhum;
//    //    foreach (Days d in daysMasks)
//    //    {
//    //        mask |= d;
//    //    }
//    //    return (_days & mask) == mask;
//    //}

//}