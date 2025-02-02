using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace TP5.Entidades
{
    internal class CsvReader
    {
        StreamReader streamReader;

        public CsvReader(string filePath)
        {
            // Instancia el objeto que nos permite escribir en el archivo CSV
            streamReader = new StreamReader(filePath);
        }

        private static double Truncar(double nro) => Math.Truncate(nro * 10000) / 10000;

        public double[]? LoadCsvData(DataTable dt)
        {
            // Carga con los numeros contenidos en el CSV una tabla, un array (frecObs) con las frecuencias
            // observadas de cada intervalo y otro array (arrayLimSup) con los limites superiores de cada intervalo

            try
            {
                // Crea la cabecera de la tabla
                dt.Columns.Add("Iteracion");
                // AGREGAR TODOS LOS OTROS CABEZALES IGUAL A ESTE!!!

                var lineList = new List<string>();

                // Inicializamos las estadísticas para evitar errores

                #region Valores de Calculo
                lineList[19]= "0"; // T Espera AC Basket
                lineList[20]= "0"; // T Espera AC Futbol
                lineList[21] = "0"; // T Espera AC Handball
                lineList[22] = "0"; // Contador EsperaFinalizada Basket
                lineList[23] = "0"; // Contador EsperaFinalizada Futbol
                lineList[24] = "0"; // Contador EsperaFinalizada Handball
                lineList[25] = "0"; // Cont Llegadas
                lineList[26] = "0"; // Cont Retirados sin Jugar
                #endregion

                using (streamReader)
                {
                    string? currentLine;
                    // Leer las líneas del archivo y cargar la tabla de datos
                    while ((currentLine = streamReader.ReadLine()) != null)
                    {
                        lineList = currentLine.Split(';').ToList();
                        DataRow lineRow = dt.NewRow();

                        lineRow["Iteracion"] = lineList[0];
                        // AGREGAR TODOS LOS OTROS CABEZALES IGUAL A ESTE!!!

                        dt.Rows.Add(lineRow);
                    }
                }

                // Se calcula las probabilidades
                var iteracionesTotales = double.Parse(lineList[0]);

                // AGREGAR INDICES CORRECTOS A LAS SIGUIENTES LINEAS
                // var contadorMenosDeLimiteAB = double.Parse(lineList[...]);
                // var contadorMenosDeLimiteM = double.Parse(lineList[...]);
                var contadorMenosDeLimiteAB = 0.0;
                var contadorMenosDeLimiteM = 0.0;

                var probabilidadAB = Truncar(contadorMenosDeLimiteAB / iteracionesTotales);
                var probabilidadM = Truncar(contadorMenosDeLimiteM / iteracionesTotales);

                return new double[] { probabilidadAB, probabilidadM };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al cargar datos del CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}