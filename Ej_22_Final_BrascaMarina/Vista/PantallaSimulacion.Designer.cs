
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSimulacion));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cant_simulaciones = new System.Windows.Forms.TextBox();
            this.btn_generar_sim = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_Simulacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_probA_1 = new System.Windows.Forms.TextBox();
            this.txt_duracionLimite = new System.Windows.Forms.TextBox();
            this.txt_A_duracion_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_probCumplirAB = new System.Windows.Forms.TextBox();
            this.txt_duracionM = new System.Windows.Forms.TextBox();
            this.lbl_conclusion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_A_duracion_4 = new System.Windows.Forms.TextBox();
            this.txt_probA_4 = new System.Windows.Forms.TextBox();
            this.txt_A_duracion_3 = new System.Windows.Forms.TextBox();
            this.txt_probA_3 = new System.Windows.Forms.TextBox();
            this.txt_A_duracion_2 = new System.Windows.Forms.TextBox();
            this.txt_probA_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_C_duracion_5 = new System.Windows.Forms.TextBox();
            this.txt_C_duracion_4 = new System.Windows.Forms.TextBox();
            this.txt_probC_5 = new System.Windows.Forms.TextBox();
            this.txt_probC_4 = new System.Windows.Forms.TextBox();
            this.txt_C_duracion_3 = new System.Windows.Forms.TextBox();
            this.txt_probC_3 = new System.Windows.Forms.TextBox();
            this.txt_C_duracion_2 = new System.Windows.Forms.TextBox();
            this.txt_probC_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_C_duracion_1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_probC_1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_B_duracion_3 = new System.Windows.Forms.TextBox();
            this.txt_probB_3 = new System.Windows.Forms.TextBox();
            this.txt_B_duracion_2 = new System.Windows.Forms.TextBox();
            this.txt_probB_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_B_duracion_1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_probB_1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_D_duracion_2 = new System.Windows.Forms.TextBox();
            this.txt_probD_2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_D_duracion_1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_probD_1 = new System.Windows.Forms.TextBox();
            this.txt_probCumplirM = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Simulacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Simulaciones :";
            // 
            // txt_cant_simulaciones
            // 
            this.txt_cant_simulaciones.Location = new System.Drawing.Point(176, 12);
            this.txt_cant_simulaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant_simulaciones.Name = "txt_cant_simulaciones";
            this.txt_cant_simulaciones.Size = new System.Drawing.Size(66, 23);
            this.txt_cant_simulaciones.TabIndex = 4;
            this.txt_cant_simulaciones.Text = "1000";
            this.txt_cant_simulaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // btn_generar_sim
            // 
            this.btn_generar_sim.BackColor = System.Drawing.Color.Indigo;
            this.btn_generar_sim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar_sim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generar_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generar_sim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_generar_sim.Location = new System.Drawing.Point(914, 30);
            this.btn_generar_sim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar_sim.Name = "btn_generar_sim";
            this.btn_generar_sim.Size = new System.Drawing.Size(92, 35);
            this.btn_generar_sim.TabIndex = 8;
            this.btn_generar_sim.Text = "Simular";
            this.btn_generar_sim.UseVisualStyleBackColor = false;
            this.btn_generar_sim.Click += new System.EventHandler(this.btn_generar_sim_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(1211, 773);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 30);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_Simulacion
            // 
            this.dgv_Simulacion.AccessibleName = "dgvSimulacion";
            this.dgv_Simulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Simulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Simulacion.Location = new System.Drawing.Point(48, 122);
            this.dgv_Simulacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Simulacion.Name = "dgv_Simulacion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Simulacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Simulacion.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_Simulacion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Simulacion.Size = new System.Drawing.Size(834, 681);
            this.dgv_Simulacion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Con actividades A y B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(917, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Actividad A";
            // 
            // txt_probA_1
            // 
            this.txt_probA_1.Location = new System.Drawing.Point(106, 35);
            this.txt_probA_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probA_1.Name = "txt_probA_1";
            this.txt_probA_1.Size = new System.Drawing.Size(54, 23);
            this.txt_probA_1.TabIndex = 25;
            this.txt_probA_1.Text = "25";
            this.txt_probA_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_duracionLimite
            // 
            this.txt_duracionLimite.Location = new System.Drawing.Point(130, 17);
            this.txt_duracionLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_duracionLimite.Name = "txt_duracionLimite";
            this.txt_duracionLimite.Size = new System.Drawing.Size(61, 23);
            this.txt_duracionLimite.TabIndex = 23;
            this.txt_duracionLimite.Text = "33";
            this.txt_duracionLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_A_duracion_1
            // 
            this.txt_A_duracion_1.Location = new System.Drawing.Point(30, 35);
            this.txt_A_duracion_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_duracion_1.Name = "txt_A_duracion_1";
            this.txt_A_duracion_1.Size = new System.Drawing.Size(57, 23);
            this.txt_A_duracion_1.TabIndex = 22;
            this.txt_A_duracion_1.Text = "5";
            this.txt_A_duracion_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Duración";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Probabilidad de cumplir el límite con A y B:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Duración M:";
            // 
            // txt_probCumplirAB
            // 
            this.txt_probCumplirAB.Enabled = false;
            this.txt_probCumplirAB.Location = new System.Drawing.Point(285, 58);
            this.txt_probCumplirAB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probCumplirAB.Name = "txt_probCumplirAB";
            this.txt_probCumplirAB.Size = new System.Drawing.Size(83, 23);
            this.txt_probCumplirAB.TabIndex = 36;
            this.txt_probCumplirAB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_duracionM
            // 
            this.txt_duracionM.Location = new System.Drawing.Point(302, 17);
            this.txt_duracionM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_duracionM.Name = "txt_duracionM";
            this.txt_duracionM.Size = new System.Drawing.Size(66, 23);
            this.txt_duracionM.TabIndex = 37;
            this.txt_duracionM.Text = "13";
            this.txt_duracionM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // lbl_conclusion
            // 
            this.lbl_conclusion.AutoSize = true;
            this.lbl_conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_conclusion.Location = new System.Drawing.Point(923, 723);
            this.lbl_conclusion.Name = "lbl_conclusion";
            this.lbl_conclusion.Size = new System.Drawing.Size(48, 13);
            this.lbl_conclusion.TabIndex = 38;
            this.lbl_conclusion.Text = "label16";
            this.lbl_conclusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_A_duracion_4);
            this.panel1.Controls.Add(this.txt_probA_4);
            this.panel1.Controls.Add(this.txt_A_duracion_3);
            this.panel1.Controls.Add(this.txt_probA_3);
            this.panel1.Controls.Add(this.txt_A_duracion_2);
            this.panel1.Controls.Add(this.txt_probA_2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_A_duracion_1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_probA_1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(916, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 180);
            this.panel1.TabIndex = 39;
            // 
            // txt_A_duracion_4
            // 
            this.txt_A_duracion_4.Location = new System.Drawing.Point(30, 128);
            this.txt_A_duracion_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_duracion_4.Name = "txt_A_duracion_4";
            this.txt_A_duracion_4.Size = new System.Drawing.Size(57, 23);
            this.txt_A_duracion_4.TabIndex = 31;
            this.txt_A_duracion_4.Text = "8";
            this.txt_A_duracion_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probA_4
            // 
            this.txt_probA_4.Location = new System.Drawing.Point(106, 128);
            this.txt_probA_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probA_4.Name = "txt_probA_4";
            this.txt_probA_4.Size = new System.Drawing.Size(54, 23);
            this.txt_probA_4.TabIndex = 32;
            this.txt_probA_4.Text = "15";
            this.txt_probA_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_A_duracion_3
            // 
            this.txt_A_duracion_3.Location = new System.Drawing.Point(30, 97);
            this.txt_A_duracion_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_duracion_3.Name = "txt_A_duracion_3";
            this.txt_A_duracion_3.Size = new System.Drawing.Size(57, 23);
            this.txt_A_duracion_3.TabIndex = 29;
            this.txt_A_duracion_3.Text = "7";
            this.txt_A_duracion_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probA_3
            // 
            this.txt_probA_3.Location = new System.Drawing.Point(106, 97);
            this.txt_probA_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probA_3.Name = "txt_probA_3";
            this.txt_probA_3.Size = new System.Drawing.Size(54, 23);
            this.txt_probA_3.TabIndex = 30;
            this.txt_probA_3.Text = "25";
            this.txt_probA_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_A_duracion_2
            // 
            this.txt_A_duracion_2.Location = new System.Drawing.Point(30, 66);
            this.txt_A_duracion_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_duracion_2.Name = "txt_A_duracion_2";
            this.txt_A_duracion_2.Size = new System.Drawing.Size(57, 23);
            this.txt_A_duracion_2.TabIndex = 27;
            this.txt_A_duracion_2.Text = "6";
            this.txt_A_duracion_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probA_2
            // 
            this.txt_probA_2.Location = new System.Drawing.Point(106, 66);
            this.txt_probA_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probA_2.Name = "txt_probA_2";
            this.txt_probA_2.Size = new System.Drawing.Size(54, 23);
            this.txt_probA_2.TabIndex = 28;
            this.txt_probA_2.Text = "35";
            this.txt_probA_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(106, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Prob (%)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_probCumplirM);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txt_duracionLimite);
            this.panel2.Controls.Add(this.txt_duracionM);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_probCumplirAB);
            this.panel2.Controls.Add(this.label14);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(917, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 141);
            this.panel2.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Duración Límite:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.txt_desde);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_cant_simulaciones);
            this.panel3.Location = new System.Drawing.Point(374, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 49);
            this.panel3.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(269, 15);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 15);
            this.label23.TabIndex = 5;
            this.label23.Text = "Mostrar desde iteración ... ";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(423, 12);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(51, 23);
            this.txt_desde.TabIndex = 6;
            this.txt_desde.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(45, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 36);
            this.label16.TabIndex = 42;
            this.label16.Text = "EXAMEN FINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MATERIA: Simulación";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(443, 102);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(439, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Toda duración será medida y especificada en semanas como unidad de medida.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(917, 521);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 26);
            this.label18.TabIndex = 43;
            this.label18.Text = "Métrica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1128, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Actividad C";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_C_duracion_5);
            this.panel4.Controls.Add(this.txt_C_duracion_4);
            this.panel4.Controls.Add(this.txt_probC_5);
            this.panel4.Controls.Add(this.txt_probC_4);
            this.panel4.Controls.Add(this.txt_C_duracion_3);
            this.panel4.Controls.Add(this.txt_probC_3);
            this.panel4.Controls.Add(this.txt_C_duracion_2);
            this.panel4.Controls.Add(this.txt_probC_2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txt_C_duracion_1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_probC_1);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(1127, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 209);
            this.panel4.TabIndex = 45;
            // 
            // txt_C_duracion_5
            // 
            this.txt_C_duracion_5.Location = new System.Drawing.Point(29, 159);
            this.txt_C_duracion_5.Margin = new System.Windows.Forms.Padding(4);
            this.txt_C_duracion_5.Name = "txt_C_duracion_5";
            this.txt_C_duracion_5.Size = new System.Drawing.Size(57, 23);
            this.txt_C_duracion_5.TabIndex = 31;
            this.txt_C_duracion_5.Text = "18";
            this.txt_C_duracion_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_C_duracion_4
            // 
            this.txt_C_duracion_4.Location = new System.Drawing.Point(28, 128);
            this.txt_C_duracion_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_C_duracion_4.Name = "txt_C_duracion_4";
            this.txt_C_duracion_4.Size = new System.Drawing.Size(57, 23);
            this.txt_C_duracion_4.TabIndex = 31;
            this.txt_C_duracion_4.Text = "16";
            this.txt_C_duracion_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probC_5
            // 
            this.txt_probC_5.Location = new System.Drawing.Point(105, 159);
            this.txt_probC_5.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probC_5.Name = "txt_probC_5";
            this.txt_probC_5.Size = new System.Drawing.Size(54, 23);
            this.txt_probC_5.TabIndex = 32;
            this.txt_probC_5.Text = "5";
            this.txt_probC_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_probC_4
            // 
            this.txt_probC_4.Location = new System.Drawing.Point(104, 128);
            this.txt_probC_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probC_4.Name = "txt_probC_4";
            this.txt_probC_4.Size = new System.Drawing.Size(54, 23);
            this.txt_probC_4.TabIndex = 32;
            this.txt_probC_4.Text = "20";
            this.txt_probC_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_C_duracion_3
            // 
            this.txt_C_duracion_3.Location = new System.Drawing.Point(28, 97);
            this.txt_C_duracion_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_C_duracion_3.Name = "txt_C_duracion_3";
            this.txt_C_duracion_3.Size = new System.Drawing.Size(57, 23);
            this.txt_C_duracion_3.TabIndex = 29;
            this.txt_C_duracion_3.Text = "14";
            this.txt_C_duracion_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probC_3
            // 
            this.txt_probC_3.Location = new System.Drawing.Point(104, 97);
            this.txt_probC_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probC_3.Name = "txt_probC_3";
            this.txt_probC_3.Size = new System.Drawing.Size(54, 23);
            this.txt_probC_3.TabIndex = 30;
            this.txt_probC_3.Text = "40";
            this.txt_probC_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_C_duracion_2
            // 
            this.txt_C_duracion_2.Location = new System.Drawing.Point(28, 66);
            this.txt_C_duracion_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_C_duracion_2.Name = "txt_C_duracion_2";
            this.txt_C_duracion_2.Size = new System.Drawing.Size(57, 23);
            this.txt_C_duracion_2.TabIndex = 27;
            this.txt_C_duracion_2.Text = "12";
            this.txt_C_duracion_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probC_2
            // 
            this.txt_probC_2.Location = new System.Drawing.Point(104, 66);
            this.txt_probC_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probC_2.Name = "txt_probC_2";
            this.txt_probC_2.Size = new System.Drawing.Size(54, 23);
            this.txt_probC_2.TabIndex = 28;
            this.txt_probC_2.Text = "25";
            this.txt_probC_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(104, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Prob (%)";
            // 
            // txt_C_duracion_1
            // 
            this.txt_C_duracion_1.Location = new System.Drawing.Point(28, 35);
            this.txt_C_duracion_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_C_duracion_1.Name = "txt_C_duracion_1";
            this.txt_C_duracion_1.Size = new System.Drawing.Size(57, 23);
            this.txt_C_duracion_1.TabIndex = 22;
            this.txt_C_duracion_1.Text = "10";
            this.txt_C_duracion_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Duración";
            // 
            // txt_probC_1
            // 
            this.txt_probC_1.Location = new System.Drawing.Point(104, 35);
            this.txt_probC_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probC_1.Name = "txt_probC_1";
            this.txt_probC_1.Size = new System.Drawing.Size(54, 23);
            this.txt_probC_1.TabIndex = 25;
            this.txt_probC_1.Text = "10";
            this.txt_probC_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(917, 319);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 26);
            this.label12.TabIndex = 46;
            this.label12.Text = "Actividad B";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txt_B_duracion_3);
            this.panel5.Controls.Add(this.txt_probB_3);
            this.panel5.Controls.Add(this.txt_B_duracion_2);
            this.panel5.Controls.Add(this.txt_probB_2);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txt_B_duracion_1);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.txt_probB_1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(916, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 153);
            this.panel5.TabIndex = 47;
            // 
            // txt_B_duracion_3
            // 
            this.txt_B_duracion_3.Location = new System.Drawing.Point(30, 102);
            this.txt_B_duracion_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_B_duracion_3.Name = "txt_B_duracion_3";
            this.txt_B_duracion_3.Size = new System.Drawing.Size(57, 23);
            this.txt_B_duracion_3.TabIndex = 29;
            this.txt_B_duracion_3.Text = "7";
            this.txt_B_duracion_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probB_3
            // 
            this.txt_probB_3.Location = new System.Drawing.Point(106, 102);
            this.txt_probB_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probB_3.Name = "txt_probB_3";
            this.txt_probB_3.Size = new System.Drawing.Size(54, 23);
            this.txt_probB_3.TabIndex = 30;
            this.txt_probB_3.Text = "25";
            this.txt_probB_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_B_duracion_2
            // 
            this.txt_B_duracion_2.Location = new System.Drawing.Point(30, 71);
            this.txt_B_duracion_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_B_duracion_2.Name = "txt_B_duracion_2";
            this.txt_B_duracion_2.Size = new System.Drawing.Size(57, 23);
            this.txt_B_duracion_2.TabIndex = 27;
            this.txt_B_duracion_2.Text = "5";
            this.txt_B_duracion_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probB_2
            // 
            this.txt_probB_2.Location = new System.Drawing.Point(106, 71);
            this.txt_probB_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probB_2.Name = "txt_probB_2";
            this.txt_probB_2.Size = new System.Drawing.Size(54, 23);
            this.txt_probB_2.TabIndex = 28;
            this.txt_probB_2.Text = "55";
            this.txt_probB_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(106, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Prob (%)";
            // 
            // txt_B_duracion_1
            // 
            this.txt_B_duracion_1.Location = new System.Drawing.Point(30, 40);
            this.txt_B_duracion_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_B_duracion_1.Name = "txt_B_duracion_1";
            this.txt_B_duracion_1.Size = new System.Drawing.Size(57, 23);
            this.txt_B_duracion_1.TabIndex = 22;
            this.txt_B_duracion_1.Text = "3";
            this.txt_B_duracion_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(30, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Duración";
            // 
            // txt_probB_1
            // 
            this.txt_probB_1.Location = new System.Drawing.Point(106, 40);
            this.txt_probB_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probB_1.Name = "txt_probB_1";
            this.txt_probB_1.Size = new System.Drawing.Size(54, 23);
            this.txt_probB_1.TabIndex = 25;
            this.txt_probB_1.Text = "20";
            this.txt_probB_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(1128, 353);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 26);
            this.label20.TabIndex = 46;
            this.label20.Text = "Actividad D";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txt_D_duracion_2);
            this.panel6.Controls.Add(this.txt_probD_2);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.txt_D_duracion_1);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.txt_probD_1);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(1127, 384);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 120);
            this.panel6.TabIndex = 47;
            // 
            // txt_D_duracion_2
            // 
            this.txt_D_duracion_2.Location = new System.Drawing.Point(28, 71);
            this.txt_D_duracion_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_D_duracion_2.Name = "txt_D_duracion_2";
            this.txt_D_duracion_2.Size = new System.Drawing.Size(57, 23);
            this.txt_D_duracion_2.TabIndex = 27;
            this.txt_D_duracion_2.Text = "10";
            this.txt_D_duracion_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // txt_probD_2
            // 
            this.txt_probD_2.Location = new System.Drawing.Point(104, 71);
            this.txt_probD_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probD_2.Name = "txt_probD_2";
            this.txt_probD_2.Size = new System.Drawing.Size(54, 23);
            this.txt_probD_2.TabIndex = 28;
            this.txt_probD_2.Text = "40";
            this.txt_probD_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(104, 15);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 15);
            this.label21.TabIndex = 26;
            this.label21.Text = "Prob (%)";
            // 
            // txt_D_duracion_1
            // 
            this.txt_D_duracion_1.Location = new System.Drawing.Point(28, 40);
            this.txt_D_duracion_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_D_duracion_1.Name = "txt_D_duracion_1";
            this.txt_D_duracion_1.Size = new System.Drawing.Size(57, 23);
            this.txt_D_duracion_1.TabIndex = 22;
            this.txt_D_duracion_1.Text = "8";
            this.txt_D_duracion_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entero_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(28, 15);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "Duración";
            // 
            // txt_probD_1
            // 
            this.txt_probD_1.Location = new System.Drawing.Point(104, 40);
            this.txt_probD_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probD_1.Name = "txt_probD_1";
            this.txt_probD_1.Size = new System.Drawing.Size(54, 23);
            this.txt_probD_1.TabIndex = 25;
            this.txt_probD_1.Text = "60";
            this.txt_probD_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_decimal_KeyPress);
            // 
            // txt_probCumplirM
            // 
            this.txt_probCumplirM.Enabled = false;
            this.txt_probCumplirM.Location = new System.Drawing.Point(285, 94);
            this.txt_probCumplirM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probCumplirM.Name = "txt_probCumplirM";
            this.txt_probCumplirM.Size = new System.Drawing.Size(83, 23);
            this.txt_probCumplirM.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 98);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(219, 15);
            this.label24.TabIndex = 38;
            this.label24.Text = "Probabilidad de cumplir el límite con M:";
            // 
            // PantallaSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1356, 832);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_conclusion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Simulacion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_generar_sim);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaSimulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ej. 22 : Duración de Proyecto";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Simulacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

