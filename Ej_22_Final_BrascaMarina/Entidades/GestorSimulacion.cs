using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades
{
    internal class GestorSimulacion
    {
        public string Datos = @"./datos.csv";

        int IteracionesTotales;

        Random RndA;
        Random RndB;
        Random RndC;
        Random RndD;

        int DuracionM;
        int DuracionLimite;

        double[] ProbabilidadesA;
        int[] TiemposA;

        double[] ProbabilidadesB;
        int[] TiemposB;

        double[] ProbabilidadesC;
        int[] TiemposC;

        double[] ProbabilidadesD;
        int[] TiemposD;

        public GestorSimulacion(double inicioImp, int Cantidad, double FinSim, double limsLlegFutbol, double[] limsLlegHandball,
            double[] limsLlegBasket, double[] limsOcupFutbol, double[] limsOcupHandball, double[] limsOcupBasket,
            double h, double baskD, double futD, double handD)
        {
            RndA = new Random();
            RndB = new Random();
            RndC = new Random();
            RndD = new Random();

            // DuracionM = duracionM;
            DuracionM = 13;

            // DuracionLimite = duracionLimite;
            DuracionLimite = 33;

            //ProbabilidadesA = probabilidadesA;
            ProbabilidadesA = new double[] { 0.25, 0.35, 0.25, 0.15 };
            TiemposA = new int[] { 5, 6, 7 };

            ProbabilidadesB = new double[] { 0.2, 0.55, 0.25 };
            TiemposB = new int[] { 3, 5, 7 };

            ProbabilidadesC = new double[] { 0.1, 0.25, 0.4, 0.2, 0.5 };
            TiemposC = new int[] { 10, 12, 14, 16, 18 };

            ProbabilidadesD = new double[] { 0.6, 0.4 };
            TiemposD = new int[] { 8, 10 };
        }

        #region CALCULAR DURACIONES
        int CalcularDuracionA(double rnd)
        {
            if (rnd < ProbabilidadesA[0])
                return TiemposA[0];

            if (rnd < ProbabilidadesA[0] + ProbabilidadesA[1])
                return TiemposA[1];

            if (rnd < ProbabilidadesA[0] + ProbabilidadesA[1] + ProbabilidadesA[2])
                return TiemposA[2];

            return TiemposA[3];
        }

        int CalcularDuracionB(double rnd)
        {
            if (rnd < ProbabilidadesB[0])
                return TiemposB[0];

            if (rnd < ProbabilidadesB[0] + ProbabilidadesB[1])
                return TiemposB[1];

            return TiemposB[2];
        }

        int CalcularDuracionC(double rnd)
        {
            if (rnd < ProbabilidadesC[0])
                return TiemposC[0];

            if (rnd < ProbabilidadesC[0] + ProbabilidadesC[1])
                return TiemposC[1];

            if (rnd < ProbabilidadesC[0] + ProbabilidadesC[1] + ProbabilidadesC[2])
                return TiemposC[2];

            if (rnd < ProbabilidadesC[0] + ProbabilidadesC[1] + ProbabilidadesC[2] + ProbabilidadesC[3])
                return TiemposC[3];

            return TiemposB[4];
        }

        int CalcularDuracionD(double rnd)
        {
            if (rnd < ProbabilidadesD[0])
                return TiemposD[0];

            return TiemposD[1];
        }
        #endregion

        public void Simular()
        {
            // Para escribir archivo CSV
            StreamWriter CSVWriter = new StreamWriter(Datos);

            var contadorConvieneM = 0;
            var contadorMenosDeLimiteAB = 0;
            var contadorMenosDeLimiteM = 0;

            for (int i = 0; i < IteracionesTotales; i++)
            {
                var valorRndA = RndA.NextDouble();
                var durA = CalcularDuracionA(valorRndA);

                var valorRndB = RndB.NextDouble();
                var durB = CalcularDuracionB(valorRndB);

                var valorRndC = RndC.NextDouble();
                var durC = CalcularDuracionC(valorRndC);

                var valorRndD = RndD.NextDouble();
                var durD = CalcularDuracionD(valorRndD);

                if (durA + durB > DuracionM)
                    contadorConvieneM++;

                var durTotalAB = durA + durB + durC + durD;
                if (durTotalAB < DuracionLimite)
                    contadorMenosDeLimiteAB++;

                var durTotalM = DuracionM + +durC + durD;
                if (durTotalAB < DuracionLimite)
                    contadorMenosDeLimiteM++;

                // Escribir linea CSV...
                // , RNDs, , M, AB vs M, ...
                var builder = new StringBuilder().AppendJoin(';',               //SEPARADOR CSV
                    i,                                                          //Nro Iteracion

                    valorRndA, valorRndB, valorRndC, valorRndD,                 // RNDs
                    
                    durA, durB, durC, durD, DuracionM,                          // Duraciones
                    
                    durA + durB > DuracionM ? "Si" : "No", contadorConvieneM,   //AB vs M
                    
                    durTotalAB,                                                 //ProyectoAB vs Lim
                    durTotalAB < DuracionLimite ? "Si" : "No",
                    contadorMenosDeLimiteAB,
                    
                    durTotalM,                                                  //ProyectoM vs Lim
                    durTotalM < DuracionLimite ? "Si" : "No",
                    contadorMenosDeLimiteM
                );

                CSVWriter.WriteLine(builder.ToString());
            }

            CSVWriter.Close();
        }
    }
}
