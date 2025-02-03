
using Final_SIM_Brasca.Vista; /// creo no iría

namespace Final_SIM_Brasca.Vista
{
    partial class PantallaSimulacion : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSimulacion));
            label1 = new Label();
            txt_cant_simulaciones = new TextBox();
            btn_generar_sim = new Button();
            btn_salir = new Button();
            dgv_Simulacion = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            txt_probA_1 = new TextBox();
            txt_duracionLimite = new TextBox();
            txt_A_duracion_1 = new TextBox();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            txt_probCumplirAB = new TextBox();
            txt_duracionM = new TextBox();
            lbl_conclusion = new Label();
            panel1 = new Panel();
            txt_A_duracion_4 = new TextBox();
            txt_probA_4 = new TextBox();
            txt_A_duracion_3 = new TextBox();
            txt_probA_3 = new TextBox();
            txt_A_duracion_2 = new TextBox();
            txt_probA_2 = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            txt_probCumplirM = new TextBox();
            label24 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label23 = new Label();
            txt_desde = new TextBox();
            label16 = new Label();
            label2 = new Label();
            label17 = new Label();
            label18 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            txt_C_duracion_5 = new TextBox();
            txt_C_duracion_4 = new TextBox();
            txt_probC_5 = new TextBox();
            txt_probC_4 = new TextBox();
            txt_C_duracion_3 = new TextBox();
            txt_probC_3 = new TextBox();
            txt_C_duracion_2 = new TextBox();
            txt_probC_2 = new TextBox();
            label10 = new Label();
            txt_C_duracion_1 = new TextBox();
            label11 = new Label();
            txt_probC_1 = new TextBox();
            label12 = new Label();
            panel5 = new Panel();
            txt_B_duracion_3 = new TextBox();
            txt_probB_3 = new TextBox();
            txt_B_duracion_2 = new TextBox();
            txt_probB_2 = new TextBox();
            label13 = new Label();
            txt_B_duracion_1 = new TextBox();
            label19 = new Label();
            txt_probB_1 = new TextBox();
            label20 = new Label();
            panel6 = new Panel();
            txt_D_duracion_2 = new TextBox();
            txt_probD_2 = new TextBox();
            label21 = new Label();
            txt_D_duracion_1 = new TextBox();
            label22 = new Label();
            txt_probD_1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Simulacion).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Simulaciones :";
            // 
            // txt_cant_simulaciones
            // 
            txt_cant_simulaciones.Location = new Point(176, 12);
            txt_cant_simulaciones.Margin = new Padding(4);
            txt_cant_simulaciones.Name = "txt_cant_simulaciones";
            txt_cant_simulaciones.Size = new Size(66, 23);
            txt_cant_simulaciones.TabIndex = 4;
            txt_cant_simulaciones.Text = "1000";
            txt_cant_simulaciones.KeyPress += txt_entero_KeyPress;
            // 
            // btn_generar_sim
            // 
            btn_generar_sim.BackColor = Color.Indigo;
            btn_generar_sim.BackgroundImageLayout = ImageLayout.Stretch;
            btn_generar_sim.Cursor = Cursors.Hand;
            btn_generar_sim.FlatStyle = FlatStyle.Popup;
            btn_generar_sim.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_generar_sim.ForeColor = SystemColors.ButtonHighlight;
            btn_generar_sim.Location = new Point(914, 30);
            btn_generar_sim.Margin = new Padding(4);
            btn_generar_sim.Name = "btn_generar_sim";
            btn_generar_sim.Size = new Size(92, 35);
            btn_generar_sim.TabIndex = 8;
            btn_generar_sim.Text = "Simular";
            btn_generar_sim.UseVisualStyleBackColor = false;
            btn_generar_sim.Click += btn_generar_sim_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Maroon;
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salir.ForeColor = SystemColors.ButtonHighlight;
            btn_salir.Location = new Point(1211, 773);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 30);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgv_Simulacion
            // 
            dgv_Simulacion.AccessibleName = "dgvSimulacion";
            dgv_Simulacion.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Simulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Simulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Simulacion.Location = new Point(48, 122);
            dgv_Simulacion.Margin = new Padding(4);
            dgv_Simulacion.Name = "dgv_Simulacion";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Simulacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Simulacion.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dgv_Simulacion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Simulacion.Size = new Size(834, 681);
            dgv_Simulacion.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(46, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 17);
            label3.TabIndex = 14;
            label3.Text = "Con actividades A y B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(917, 91);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 26);
            label5.TabIndex = 17;
            label5.Text = "Actividad A";
            // 
            // txt_probA_1
            // 
            txt_probA_1.Location = new Point(106, 35);
            txt_probA_1.Margin = new Padding(4);
            txt_probA_1.Name = "txt_probA_1";
            txt_probA_1.Size = new Size(54, 23);
            txt_probA_1.TabIndex = 25;
            txt_probA_1.Text = "25";
            txt_probA_1.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_duracionLimite
            // 
            txt_duracionLimite.Location = new Point(130, 17);
            txt_duracionLimite.Margin = new Padding(4);
            txt_duracionLimite.Name = "txt_duracionLimite";
            txt_duracionLimite.Size = new Size(61, 23);
            txt_duracionLimite.TabIndex = 23;
            txt_duracionLimite.Text = "33";
            txt_duracionLimite.KeyPress += txt_entero_KeyPress;
            // 
            // txt_A_duracion_1
            // 
            txt_A_duracion_1.Location = new Point(30, 35);
            txt_A_duracion_1.Margin = new Padding(4);
            txt_A_duracion_1.Name = "txt_A_duracion_1";
            txt_A_duracion_1.Size = new Size(57, 23);
            txt_A_duracion_1.TabIndex = 22;
            txt_A_duracion_1.Text = "5";
            txt_A_duracion_1.KeyPress += txt_entero_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(30, 10);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 18;
            label9.Text = "Duración";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 62);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(235, 15);
            label14.TabIndex = 34;
            label14.Text = "Probabilidad de cumplir el límite con A y B:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(222, 21);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(72, 15);
            label15.TabIndex = 35;
            label15.Text = "Duración M:";
            // 
            // txt_probCumplirAB
            // 
            txt_probCumplirAB.Enabled = false;
            txt_probCumplirAB.Location = new Point(285, 58);
            txt_probCumplirAB.Margin = new Padding(4);
            txt_probCumplirAB.Name = "txt_probCumplirAB";
            txt_probCumplirAB.Size = new Size(83, 23);
            txt_probCumplirAB.TabIndex = 36;
            txt_probCumplirAB.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_duracionM
            // 
            txt_duracionM.Location = new Point(302, 17);
            txt_duracionM.Margin = new Padding(4);
            txt_duracionM.Name = "txt_duracionM";
            txt_duracionM.Size = new Size(66, 23);
            txt_duracionM.TabIndex = 37;
            txt_duracionM.Text = "13";
            txt_duracionM.KeyPress += txt_entero_KeyPress;
            // 
            // lbl_conclusion
            // 
            lbl_conclusion.AutoSize = true;
            lbl_conclusion.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_conclusion.Location = new Point(917, 707);
            lbl_conclusion.Name = "lbl_conclusion";
            lbl_conclusion.Size = new Size(68, 13);
            lbl_conclusion.TabIndex = 38;
            lbl_conclusion.Text = "conclusión";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_A_duracion_4);
            panel1.Controls.Add(txt_probA_4);
            panel1.Controls.Add(txt_A_duracion_3);
            panel1.Controls.Add(txt_probA_3);
            panel1.Controls.Add(txt_A_duracion_2);
            panel1.Controls.Add(txt_probA_2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_A_duracion_1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_probA_1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(916, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 180);
            panel1.TabIndex = 39;
            // 
            // txt_A_duracion_4
            // 
            txt_A_duracion_4.Location = new Point(30, 128);
            txt_A_duracion_4.Margin = new Padding(4);
            txt_A_duracion_4.Name = "txt_A_duracion_4";
            txt_A_duracion_4.Size = new Size(57, 23);
            txt_A_duracion_4.TabIndex = 31;
            txt_A_duracion_4.Text = "8";
            txt_A_duracion_4.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probA_4
            // 
            txt_probA_4.Location = new Point(106, 128);
            txt_probA_4.Margin = new Padding(4);
            txt_probA_4.Name = "txt_probA_4";
            txt_probA_4.Size = new Size(54, 23);
            txt_probA_4.TabIndex = 32;
            txt_probA_4.Text = "15";
            txt_probA_4.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_A_duracion_3
            // 
            txt_A_duracion_3.Location = new Point(30, 97);
            txt_A_duracion_3.Margin = new Padding(4);
            txt_A_duracion_3.Name = "txt_A_duracion_3";
            txt_A_duracion_3.Size = new Size(57, 23);
            txt_A_duracion_3.TabIndex = 29;
            txt_A_duracion_3.Text = "7";
            txt_A_duracion_3.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probA_3
            // 
            txt_probA_3.Location = new Point(106, 97);
            txt_probA_3.Margin = new Padding(4);
            txt_probA_3.Name = "txt_probA_3";
            txt_probA_3.Size = new Size(54, 23);
            txt_probA_3.TabIndex = 30;
            txt_probA_3.Text = "25";
            txt_probA_3.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_A_duracion_2
            // 
            txt_A_duracion_2.Location = new Point(30, 66);
            txt_A_duracion_2.Margin = new Padding(4);
            txt_A_duracion_2.Name = "txt_A_duracion_2";
            txt_A_duracion_2.Size = new Size(57, 23);
            txt_A_duracion_2.TabIndex = 27;
            txt_A_duracion_2.Text = "6";
            txt_A_duracion_2.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probA_2
            // 
            txt_probA_2.Location = new Point(106, 66);
            txt_probA_2.Margin = new Padding(4);
            txt_probA_2.Name = "txt_probA_2";
            txt_probA_2.Size = new Size(54, 23);
            txt_probA_2.TabIndex = 28;
            txt_probA_2.Text = "35";
            txt_probA_2.KeyPress += txt_decimal_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(106, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 26;
            label7.Text = "Prob (%)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_probCumplirM);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(txt_duracionLimite);
            panel2.Controls.Add(txt_duracionM);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_probCumplirAB);
            panel2.Controls.Add(label14);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(917, 552);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 141);
            panel2.TabIndex = 40;
            // 
            // txt_probCumplirM
            // 
            txt_probCumplirM.Enabled = false;
            txt_probCumplirM.Location = new Point(285, 94);
            txt_probCumplirM.Margin = new Padding(4);
            txt_probCumplirM.Name = "txt_probCumplirM";
            txt_probCumplirM.Size = new Size(83, 23);
            txt_probCumplirM.TabIndex = 39;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(28, 98);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(219, 15);
            label24.TabIndex = 38;
            label24.Text = "Probabilidad de cumplir el límite con M:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 21;
            label6.Text = "Duración Límite:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label23);
            panel3.Controls.Add(txt_desde);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_cant_simulaciones);
            panel3.Location = new Point(374, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 49);
            panel3.TabIndex = 41;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(269, 15);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(146, 15);
            label23.TabIndex = 5;
            label23.Text = "Mostrar desde iteración ... ";
            // 
            // txt_desde
            // 
            txt_desde.Location = new Point(423, 12);
            txt_desde.Margin = new Padding(4);
            txt_desde.Name = "txt_desde";
            txt_desde.Size = new Size(51, 23);
            txt_desde.TabIndex = 6;
            txt_desde.Text = "1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label16.Location = new Point(45, 24);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(250, 36);
            label16.TabIndex = 42;
            label16.Text = "EXAMEN FINAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 5;
            label2.Text = "MATERIA: Simulación";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkBlue;
            label17.Location = new Point(443, 102);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(439, 15);
            label17.TabIndex = 5;
            label17.Text = "Toda duración será medida y especificada en semanas como unidad de medida.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label18.Location = new Point(917, 521);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(83, 26);
            label18.TabIndex = 43;
            label18.Text = "Métrica";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(1128, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 26);
            label8.TabIndex = 44;
            label8.Text = "Actividad C";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txt_C_duracion_5);
            panel4.Controls.Add(txt_C_duracion_4);
            panel4.Controls.Add(txt_probC_5);
            panel4.Controls.Add(txt_probC_4);
            panel4.Controls.Add(txt_C_duracion_3);
            panel4.Controls.Add(txt_probC_3);
            panel4.Controls.Add(txt_C_duracion_2);
            panel4.Controls.Add(txt_probC_2);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txt_C_duracion_1);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txt_probC_1);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(1127, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 209);
            panel4.TabIndex = 45;
            // 
            // txt_C_duracion_5
            // 
            txt_C_duracion_5.Location = new Point(29, 159);
            txt_C_duracion_5.Margin = new Padding(4);
            txt_C_duracion_5.Name = "txt_C_duracion_5";
            txt_C_duracion_5.Size = new Size(57, 23);
            txt_C_duracion_5.TabIndex = 31;
            txt_C_duracion_5.Text = "18";
            txt_C_duracion_5.KeyPress += txt_entero_KeyPress;
            // 
            // txt_C_duracion_4
            // 
            txt_C_duracion_4.Location = new Point(28, 128);
            txt_C_duracion_4.Margin = new Padding(4);
            txt_C_duracion_4.Name = "txt_C_duracion_4";
            txt_C_duracion_4.Size = new Size(57, 23);
            txt_C_duracion_4.TabIndex = 31;
            txt_C_duracion_4.Text = "16";
            txt_C_duracion_4.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probC_5
            // 
            txt_probC_5.Location = new Point(105, 159);
            txt_probC_5.Margin = new Padding(4);
            txt_probC_5.Name = "txt_probC_5";
            txt_probC_5.Size = new Size(54, 23);
            txt_probC_5.TabIndex = 32;
            txt_probC_5.Text = "5";
            txt_probC_5.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_probC_4
            // 
            txt_probC_4.Location = new Point(104, 128);
            txt_probC_4.Margin = new Padding(4);
            txt_probC_4.Name = "txt_probC_4";
            txt_probC_4.Size = new Size(54, 23);
            txt_probC_4.TabIndex = 32;
            txt_probC_4.Text = "20";
            txt_probC_4.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_C_duracion_3
            // 
            txt_C_duracion_3.Location = new Point(28, 97);
            txt_C_duracion_3.Margin = new Padding(4);
            txt_C_duracion_3.Name = "txt_C_duracion_3";
            txt_C_duracion_3.Size = new Size(57, 23);
            txt_C_duracion_3.TabIndex = 29;
            txt_C_duracion_3.Text = "14";
            txt_C_duracion_3.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probC_3
            // 
            txt_probC_3.Location = new Point(104, 97);
            txt_probC_3.Margin = new Padding(4);
            txt_probC_3.Name = "txt_probC_3";
            txt_probC_3.Size = new Size(54, 23);
            txt_probC_3.TabIndex = 30;
            txt_probC_3.Text = "40";
            txt_probC_3.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_C_duracion_2
            // 
            txt_C_duracion_2.Location = new Point(28, 66);
            txt_C_duracion_2.Margin = new Padding(4);
            txt_C_duracion_2.Name = "txt_C_duracion_2";
            txt_C_duracion_2.Size = new Size(57, 23);
            txt_C_duracion_2.TabIndex = 27;
            txt_C_duracion_2.Text = "12";
            txt_C_duracion_2.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probC_2
            // 
            txt_probC_2.Location = new Point(104, 66);
            txt_probC_2.Margin = new Padding(4);
            txt_probC_2.Name = "txt_probC_2";
            txt_probC_2.Size = new Size(54, 23);
            txt_probC_2.TabIndex = 28;
            txt_probC_2.Text = "25";
            txt_probC_2.KeyPress += txt_decimal_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(104, 12);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 26;
            label10.Text = "Prob (%)";
            // 
            // txt_C_duracion_1
            // 
            txt_C_duracion_1.Location = new Point(28, 35);
            txt_C_duracion_1.Margin = new Padding(4);
            txt_C_duracion_1.Name = "txt_C_duracion_1";
            txt_C_duracion_1.Size = new Size(57, 23);
            txt_C_duracion_1.TabIndex = 22;
            txt_C_duracion_1.Text = "10";
            txt_C_duracion_1.KeyPress += txt_entero_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 12);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 18;
            label11.Text = "Duración";
            // 
            // txt_probC_1
            // 
            txt_probC_1.Location = new Point(104, 35);
            txt_probC_1.Margin = new Padding(4);
            txt_probC_1.Name = "txt_probC_1";
            txt_probC_1.Size = new Size(54, 23);
            txt_probC_1.TabIndex = 25;
            txt_probC_1.Text = "10";
            txt_probC_1.KeyPress += txt_decimal_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(917, 319);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 26);
            label12.TabIndex = 46;
            label12.Text = "Actividad B";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txt_B_duracion_3);
            panel5.Controls.Add(txt_probB_3);
            panel5.Controls.Add(txt_B_duracion_2);
            panel5.Controls.Add(txt_probB_2);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(txt_B_duracion_1);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(txt_probB_1);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(916, 351);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 153);
            panel5.TabIndex = 47;
            // 
            // txt_B_duracion_3
            // 
            txt_B_duracion_3.Location = new Point(30, 102);
            txt_B_duracion_3.Margin = new Padding(4);
            txt_B_duracion_3.Name = "txt_B_duracion_3";
            txt_B_duracion_3.Size = new Size(57, 23);
            txt_B_duracion_3.TabIndex = 29;
            txt_B_duracion_3.Text = "7";
            txt_B_duracion_3.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probB_3
            // 
            txt_probB_3.Location = new Point(106, 102);
            txt_probB_3.Margin = new Padding(4);
            txt_probB_3.Name = "txt_probB_3";
            txt_probB_3.Size = new Size(54, 23);
            txt_probB_3.TabIndex = 30;
            txt_probB_3.Text = "25";
            txt_probB_3.KeyPress += txt_decimal_KeyPress;
            // 
            // txt_B_duracion_2
            // 
            txt_B_duracion_2.Location = new Point(30, 71);
            txt_B_duracion_2.Margin = new Padding(4);
            txt_B_duracion_2.Name = "txt_B_duracion_2";
            txt_B_duracion_2.Size = new Size(57, 23);
            txt_B_duracion_2.TabIndex = 27;
            txt_B_duracion_2.Text = "5";
            txt_B_duracion_2.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probB_2
            // 
            txt_probB_2.Location = new Point(106, 71);
            txt_probB_2.Margin = new Padding(4);
            txt_probB_2.Name = "txt_probB_2";
            txt_probB_2.Size = new Size(54, 23);
            txt_probB_2.TabIndex = 28;
            txt_probB_2.Text = "55";
            txt_probB_2.KeyPress += txt_decimal_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(106, 17);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 26;
            label13.Text = "Prob (%)";
            // 
            // txt_B_duracion_1
            // 
            txt_B_duracion_1.Location = new Point(30, 40);
            txt_B_duracion_1.Margin = new Padding(4);
            txt_B_duracion_1.Name = "txt_B_duracion_1";
            txt_B_duracion_1.Size = new Size(57, 23);
            txt_B_duracion_1.TabIndex = 22;
            txt_B_duracion_1.Text = "3";
            txt_B_duracion_1.KeyPress += txt_entero_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(30, 17);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(57, 15);
            label19.TabIndex = 18;
            label19.Text = "Duración";
            // 
            // txt_probB_1
            // 
            txt_probB_1.Location = new Point(106, 40);
            txt_probB_1.Margin = new Padding(4);
            txt_probB_1.Name = "txt_probB_1";
            txt_probB_1.Size = new Size(54, 23);
            txt_probB_1.TabIndex = 25;
            txt_probB_1.Text = "20";
            txt_probB_1.KeyPress += txt_decimal_KeyPress;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label20.Location = new Point(1128, 353);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(123, 26);
            label20.TabIndex = 46;
            label20.Text = "Actividad D";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(txt_D_duracion_2);
            panel6.Controls.Add(txt_probD_2);
            panel6.Controls.Add(label21);
            panel6.Controls.Add(txt_D_duracion_1);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(txt_probD_1);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(1127, 384);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 120);
            panel6.TabIndex = 47;
            // 
            // txt_D_duracion_2
            // 
            txt_D_duracion_2.Location = new Point(28, 71);
            txt_D_duracion_2.Margin = new Padding(4);
            txt_D_duracion_2.Name = "txt_D_duracion_2";
            txt_D_duracion_2.Size = new Size(57, 23);
            txt_D_duracion_2.TabIndex = 27;
            txt_D_duracion_2.Text = "10";
            txt_D_duracion_2.KeyPress += txt_entero_KeyPress;
            // 
            // txt_probD_2
            // 
            txt_probD_2.Location = new Point(104, 71);
            txt_probD_2.Margin = new Padding(4);
            txt_probD_2.Name = "txt_probD_2";
            txt_probD_2.Size = new Size(54, 23);
            txt_probD_2.TabIndex = 28;
            txt_probD_2.Text = "40";
            txt_probD_2.KeyPress += txt_decimal_KeyPress;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(104, 15);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(54, 15);
            label21.TabIndex = 26;
            label21.Text = "Prob (%)";
            // 
            // txt_D_duracion_1
            // 
            txt_D_duracion_1.Location = new Point(28, 40);
            txt_D_duracion_1.Margin = new Padding(4);
            txt_D_duracion_1.Name = "txt_D_duracion_1";
            txt_D_duracion_1.Size = new Size(57, 23);
            txt_D_duracion_1.TabIndex = 22;
            txt_D_duracion_1.Text = "8";
            txt_D_duracion_1.KeyPress += txt_entero_KeyPress;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(28, 15);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(57, 15);
            label22.TabIndex = 18;
            label22.Text = "Duración";
            // 
            // txt_probD_1
            // 
            txt_probD_1.Location = new Point(104, 40);
            txt_probD_1.Margin = new Padding(4);
            txt_probD_1.Name = "txt_probD_1";
            txt_probD_1.Size = new Size(54, 23);
            txt_probD_1.TabIndex = 25;
            txt_probD_1.Text = "60";
            txt_probD_1.KeyPress += txt_decimal_KeyPress;
            // 
            // PantallaSimulacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1356, 832);
            Controls.Add(label20);
            Controls.Add(label12);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label2);
            Controls.Add(label16);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(lbl_conclusion);
            Controls.Add(label3);
            Controls.Add(dgv_Simulacion);
            Controls.Add(btn_salir);
            Controls.Add(btn_generar_sim);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "PantallaSimulacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ej. 22 : Duración de Proyecto";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Simulacion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cant_simulaciones;
        private System.Windows.Forms.TextBox txt_mostrar_desde;
        private System.Windows.Forms.Button btn_generar_sim;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_Simulacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_probA_1;
        private System.Windows.Forms.TextBox txt_duracionLimite;
        private System.Windows.Forms.TextBox txt_A_duracion_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_probCumplirAB;
        private System.Windows.Forms.TextBox txt_duracionM;
        private System.Windows.Forms.Label lbl_conclusion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private Label label2;
        private Label label17;
        private Label label18;
        private Label label7;
        private Label label6;
        private TextBox txt_A_duracion_4;
        private TextBox txt_probA_4;
        private TextBox txt_A_duracion_3;
        private TextBox txt_probA_3;
        private TextBox txt_A_duracion_2;
        private TextBox txt_probA_2;
        private Label label8;
        private Panel panel4;
        private TextBox txt_C_duracion_5;
        private TextBox txt_C_duracion_4;
        private TextBox txt_probC_5;
        private TextBox txt_probC_4;
        private TextBox txt_C_duracion_3;
        private TextBox txt_probC_3;
        private TextBox txt_C_duracion_2;
        private TextBox txt_probC_2;
        private Label label10;
        private TextBox txt_C_duracion_1;
        private Label label11;
        private TextBox txt_probC_1;
        private Label label12;
        private Panel panel5;
        private TextBox txt_B_duracion_3;
        private TextBox txt_probB_3;
        private TextBox txt_B_duracion_2;
        private TextBox txt_probB_2;
        private Label label13;
        private TextBox txt_B_duracion_1;
        private Label label19;
        private TextBox txt_probB_1;
        private Label label20;
        private Panel panel6;
        private TextBox txt_D_duracion_2;
        private TextBox txt_probD_2;
        private Label label21;
        private TextBox txt_D_duracion_1;
        private Label label22;
        private TextBox txt_probD_1;
        private Label label23;
        private TextBox txt_desde;
        private TextBox txt_probCumplirM;
        private Label label24;
    }
}

