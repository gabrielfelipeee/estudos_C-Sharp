using System;

class Enum

{
    // Enum
    enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main()
    {
        DiasSemana domingo = DiasSemana.Domingo; // Domingo

        // Por índice
        DiasSemana segunda = (DiasSemana)1; // Segunda

        


        // Typecast => Converter um tipo em outro
        float n1 = 10.5f;
        int n2 = (int)n1; // type cast => convertendo o float em um int


        short nShort = 10;
        int nInt = (int)nShort;
    }
}
