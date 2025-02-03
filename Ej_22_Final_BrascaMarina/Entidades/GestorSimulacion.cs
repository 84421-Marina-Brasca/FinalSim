//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
//using System.Threading.Tasks;
using Final_SIM_Brasca.Vista;

namespace Final_SIM_Brasca.Entidades
{
    internal class GestorSimulacion
    {
        public string Datos = @"./datos.csv";

        int IteracionesTotales;
        int MostrarDesde;

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

        public GestorSimulacion(int cantSimulaciones, int mostrarDesde, int duracionM, int duracionLimite, double[] probabA, int[] tiemposA,
            double[] probabB, int[] tiemposB, double[] probabC, int[] tiemposC, double[] probabD, int[] tiemposD)
        {
            RndA = new Random();
            RndB = new Random();
            RndC = new Random();
            RndD = new Random();

            IteracionesTotales = cantSimulaciones;

            MostrarDesde = mostrarDesde;

            DuracionM = duracionM;

            DuracionLimite = duracionLimite;

            ProbabilidadesA = probabA;
            TiemposA = tiemposA;

            ProbabilidadesB = probabB;
            TiemposB = tiemposB;

            ProbabilidadesC = probabA;
            TiemposC = tiemposC;

            ProbabilidadesD = probabA;
            TiemposD = tiemposD;

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
                if (durTotalM< DuracionLimite)
                    contadorMenosDeLimiteM++;

                // Escribir linea CSV...

                var builder = new StringBuilder().AppendJoin(';',               //SEPARADOR CSV
                    i+1,                                                          //Nro Iteracion

                    Truncar(valorRndA), durA, Truncar(valorRndB), durB,                  // RNDs y Duraciones A y B

                    DuracionM,                                         // Duracion M a comparar con A+B (ver si sacarla)

                    durA + durB > DuracionM ? "Si" : "No", contadorConvieneM,   //AB vs M

                    Truncar(valorRndC), durC, Truncar(valorRndD), durD,                 // RNDs y Duraciones C y D
                    
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

        public double Truncar(double valor)
        {
            double factor = Math.Pow(10, 3);
            return Math.Truncate(valor * factor) / factor;
        }
    }
}
