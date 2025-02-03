using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_SIM_Brasca.Entidades;
using Final_SIM_Brasca.Vista;

namespace Final_SIM_Brasca.Vista
{
    public partial class PantallaSimulacion : Form
    {
        DataTable CSV;
        CsvReader CSVReader;
        public PantallaSimulacion()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_generar_sim_Click(object sender, EventArgs e)
        {
            double[] probabA;
            int[] tiemposA;

            double[] probabB;
            int[] tiemposB;

            double[] probabC;
            int[] tiemposC;

            double[] probabD;
            int[] tiemposD;



            int bandera;
            // el ErrorProvider valida que no queden vacios los txt y que no se intente realizar calculos hasta que se completen
            ErrorProvider erro = new ErrorProvider();
            if (txt_cant_simulaciones.Text.Length == 0 || txt_desde.Text.Length == 0)
            {
                erro.SetError(txt_cant_simulaciones, "No puede dejar este campo vacio");
                erro.SetError(txt_mostrar_desde, "Debe llenar este campo");
                bandera = 1;
            }
            else
            {

                if (int.Parse(txt_cant_simulaciones.Text) < 1)
                {
                    MessageBox.Show("Debe generarse al menos una simulación.");
                    txt_cant_simulaciones.Text = "";
                    txt_cant_simulaciones.Focus();
                    bandera = 1;
                }
                else
                {
                    bandera = 0;
                }

                if (bandera == 0)
                {
                    
                    // Convertir los valores de los TextBox a arreglos de double e int
                    probabA = new double[]
                    {
                        double.Parse(txt_probA_1.Text),
                        double.Parse(txt_probA_2.Text),
                        double.Parse(txt_probA_3.Text),
                        double.Parse(txt_probA_4.Text)
                    };

                    probabB = new double[]
                    {
                        double.Parse(txt_probB_1.Text),
                        double.Parse(txt_probB_2.Text),
                        double.Parse(txt_probB_3.Text)
                    };

                    probabC = new double[]
                    {
                        double.Parse(txt_probC_1.Text),
                        double.Parse(txt_probC_2.Text),
                        double.Parse(txt_probC_3.Text),
                        double.Parse(txt_probC_4.Text),
                        double.Parse(txt_probC_5.Text)
                    };

                    probabD = new double[]
                    {
                        double.Parse(txt_probD_1.Text),
                        double.Parse(txt_probD_2.Text)
                    };

                    tiemposA = new int[]
                    {
                        int.Parse(txt_A_duracion_1.Text),
                        int.Parse(txt_A_duracion_2.Text),
                        int.Parse(txt_A_duracion_3.Text),
                        int.Parse(txt_A_duracion_4.Text)
                    };

                    tiemposB = new int[]
                    {
                        int.Parse(txt_B_duracion_1.Text),
                        int.Parse(txt_B_duracion_2.Text),
                        int.Parse(txt_B_duracion_3.Text)
                    };

                    tiemposC = new int[]
                    {
                        int.Parse(txt_C_duracion_1.Text),
                        int.Parse(txt_C_duracion_2.Text),
                        int.Parse(txt_C_duracion_3.Text),
                        int.Parse(txt_C_duracion_4.Text),
                        int.Parse(txt_C_duracion_5.Text)
                    };

                    tiemposD = new int[]
                    {
                        int.Parse(txt_D_duracion_1.Text),
                        int.Parse(txt_D_duracion_2.Text)
                    };

                    GestorSimulacion gestorSimulacion = new GestorSimulacion(int.Parse(txt_cant_simulaciones.Text), int.Parse(txt_desde.Text), int.Parse(txt_duracionM.Text), int.Parse(txt_duracionLimite.Text), probabA, tiemposA,
                    probabB,tiemposB,probabC,tiemposC,probabD,tiemposD);

                    gestorSimulacion.Simular();

                    CSVReader = new CsvReader(gestorSimulacion.Datos);
                    CSV = new DataTable();

                    //Carga la grilla con los contenidos del CSV

                    // aca metodo CSV reader devuelve las 2 probabilidades a cargar
                    double[] resultado = CSVReader.LoadCsvData(CSV);
                    dgv_Simulacion.DataSource = CSV;

                    // Estetico Columnas Tabla
                    foreach (DataGridViewColumn columna in dgv_Simulacion.Columns)
                    {
                        columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    // Cargamos la probabilidad

                    txt_probCumplirAB.Text = resultado[0].ToString(); // agregar despues manejo de errores en caso devuelva null
                    txt_probCumplirM.Text = resultado[1].ToString();

                    
                    /// CAMBIAR LAS VARIABLES COMPARADAS Y LAS CITADAS EN LA RESPUESTA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (resultado[0] > resultado[1])
                    {
                        lbl_conclusion.Text = "Se recomienda mantener las actividades A y B,\n ya que se lograría con mayor frecuencia terminar el " +
                            "proyecto en un tiempo menor a las (" + txt_duracionLimite.Text + ") semanas consideradas respecto al uso de la actividad M.";
                    }
                    else
                    {
                        lbl_conclusion.Text = "Se recomienda imponer una actividad M que resuma las actividades A y B,\n ya que se lograría con mayor " +
                            "frecuencia terminar el proyecto en un tiempo menor a las (" + txt_duracionLimite.Text + ") semanas consideradas respecto al uso de las actividades A y B.";
                    }

                }
                //Las siguientes dos lineas eran para desactivar el aviso de txt vacio a rellenar
                //erro.SetError(this.txt_simulaciones, String.Empty);
                //erro.SetError(this.txt_mostrar_desde, String.Empty);
            }

        }

     

        private void Form_Load(object sender, EventArgs e)
                {
                    lbl_conclusion.Text = "";
                    
                }


        // Validaciones de txt
       
        private void txt_decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permite dígitos, teclas de control y un solo punto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquea el carácter
            }

            // Solo permite un punto
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Bloquea el segundo punto
            }

            // Si ya hay un punto, verifica que no se ingresen más de dos dígitos después de él
            if (textBox.Text.Contains("."))
            {
                int indexOfDecimal = textBox.Text.IndexOf('.');
                string decimalPart = textBox.Text.Substring(indexOfDecimal + 1);

                // Si ya hay dos dígitos después del punto, bloquea nuevos caracteres
                if (decimalPart.Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    

        private void txt_entero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite dígitos (0-9) y teclas de control (como retroceso o suprimir)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el carácter ingresado
            }
        }
    }
}
