namespace Plugin_Revit_Termico
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBoxParedes = new System.Windows.Forms.PictureBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAvancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelecionarParede = new System.Windows.Forms.Button();
            this.rbCalculoNorma = new System.Windows.Forms.RadioButton();
            this.rbCalculoManual = new System.Windows.Forms.RadioButton();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidadeTermica = new System.Windows.Forms.TextBox();
            this.txtTransmitancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEspessura = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeParede = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLevaReboco = new System.Windows.Forms.CheckBox();
            this.cbTipoTijolo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbZonaBioClim = new System.Windows.Forms.ComboBox();
            this.txtEspessuraReboco = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParedes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParedes
            // 
            this.pictureBoxParedes.Location = new System.Drawing.Point(548, 22);
            this.pictureBoxParedes.Name = "pictureBoxParedes";
            this.pictureBoxParedes.Size = new System.Drawing.Size(230, 318);
            this.pictureBoxParedes.TabIndex = 0;
            this.pictureBoxParedes.TabStop = false;
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Location = new System.Drawing.Point(599, 345);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(25, 27);
            this.btVoltar.TabIndex = 1;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAvancar
            // 
            this.btAvancar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAvancar.BackgroundImage")));
            this.btAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAvancar.Location = new System.Drawing.Point(719, 345);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(25, 27);
            this.btAvancar.TabIndex = 2;
            this.btAvancar.UseVisualStyleBackColor = true;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paredes pré definidas pela Norma";
            // 
            // btSelecionarParede
            // 
            this.btSelecionarParede.BackColor = System.Drawing.Color.White;
            this.btSelecionarParede.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelecionarParede.Location = new System.Drawing.Point(630, 345);
            this.btSelecionarParede.Name = "btSelecionarParede";
            this.btSelecionarParede.Size = new System.Drawing.Size(83, 27);
            this.btSelecionarParede.TabIndex = 4;
            this.btSelecionarParede.Text = "Selecionar";
            this.btSelecionarParede.UseVisualStyleBackColor = false;
            this.btSelecionarParede.Click += new System.EventHandler(this.btSelecionarParede_Click);
            // 
            // rbCalculoNorma
            // 
            this.rbCalculoNorma.AutoSize = true;
            this.rbCalculoNorma.Location = new System.Drawing.Point(9, 52);
            this.rbCalculoNorma.Name = "rbCalculoNorma";
            this.rbCalculoNorma.Size = new System.Drawing.Size(273, 18);
            this.rbCalculoNorma.TabIndex = 5;
            this.rbCalculoNorma.TabStop = true;
            this.rbCalculoNorma.Text = "Norma (selecionar uma das paredes ao lado)";
            this.rbCalculoNorma.UseVisualStyleBackColor = true;
            this.rbCalculoNorma.CheckedChanged += new System.EventHandler(this.rbCalculoNorma_CheckedChanged);
            // 
            // rbCalculoManual
            // 
            this.rbCalculoManual.AutoSize = true;
            this.rbCalculoManual.Location = new System.Drawing.Point(9, 76);
            this.rbCalculoManual.Name = "rbCalculoManual";
            this.rbCalculoManual.Size = new System.Drawing.Size(128, 18);
            this.rbCalculoManual.TabIndex = 6;
            this.rbCalculoManual.TabStop = true;
            this.rbCalculoManual.Text = "Dados do desenho";
            this.rbCalculoManual.UseVisualStyleBackColor = true;
            this.rbCalculoManual.CheckedChanged += new System.EventHandler(this.rbCalculoManual_CheckedChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(94, 106);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Transmitância Térmica (W/m2K):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.txtCapacidadeTermica);
            this.groupBox1.Controls.Add(this.txtTransmitancia);
            this.groupBox1.Controls.Add(this.rbCalculoManual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbCalculoNorma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selecione a forma de cálculo:";
            // 
            // txtCapacidadeTermica
            // 
            this.txtCapacidadeTermica.Location = new System.Drawing.Point(197, 172);
            this.txtCapacidadeTermica.Name = "txtCapacidadeTermica";
            this.txtCapacidadeTermica.ReadOnly = true;
            this.txtCapacidadeTermica.Size = new System.Drawing.Size(58, 22);
            this.txtCapacidadeTermica.TabIndex = 11;
            // 
            // txtTransmitancia
            // 
            this.txtTransmitancia.Location = new System.Drawing.Point(197, 144);
            this.txtTransmitancia.Name = "txtTransmitancia";
            this.txtTransmitancia.ReadOnly = true;
            this.txtTransmitancia.Size = new System.Drawing.Size(58, 22);
            this.txtTransmitancia.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Capacidade Térmica (Kj/m2K):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEspessura);
            this.groupBox2.Controls.Add(this.txtVolume);
            this.groupBox2.Controls.Add(this.txtArea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomeParede);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da parede";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(147, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(147, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "cm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "m";
            // 
            // txtEspessura
            // 
            this.txtEspessura.Location = new System.Drawing.Point(77, 116);
            this.txtEspessura.Name = "txtEspessura";
            this.txtEspessura.Size = new System.Drawing.Size(51, 22);
            this.txtEspessura.TabIndex = 7;
            this.txtEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(77, 88);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(51, 22);
            this.txtVolume.TabIndex = 6;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(77, 60);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(51, 22);
            this.txtArea.TabIndex = 5;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Área:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Espessura:";
            // 
            // txtNomeParede
            // 
            this.txtNomeParede.Location = new System.Drawing.Point(77, 32);
            this.txtNomeParede.Name = "txtNomeParede";
            this.txtNomeParede.Size = new System.Drawing.Size(192, 22);
            this.txtNomeParede.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtEspessuraReboco);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cbTipoTijolo);
            this.groupBox3.Controls.Add(this.cbLevaReboco);
            this.groupBox3.Location = new System.Drawing.Point(292, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 110);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materiais";
            // 
            // cbLevaReboco
            // 
            this.cbLevaReboco.AutoSize = true;
            this.cbLevaReboco.Checked = true;
            this.cbLevaReboco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLevaReboco.Location = new System.Drawing.Point(6, 55);
            this.cbLevaReboco.Name = "cbLevaReboco";
            this.cbLevaReboco.Size = new System.Drawing.Size(96, 18);
            this.cbLevaReboco.TabIndex = 0;
            this.cbLevaReboco.Text = "Leva reboco?";
            this.cbLevaReboco.UseVisualStyleBackColor = true;
            this.cbLevaReboco.CheckedChanged += new System.EventHandler(this.cbLevaReboco_CheckedChanged);
            // 
            // cbTipoTijolo
            // 
            this.cbTipoTijolo.FormattingEnabled = true;
            this.cbTipoTijolo.Items.AddRange(new object[] {
            "Cerâmico",
            "Concreto"});
            this.cbTipoTijolo.Location = new System.Drawing.Point(135, 25);
            this.cbTipoTijolo.Name = "cbTipoTijolo";
            this.cbTipoTijolo.Size = new System.Drawing.Size(109, 22);
            this.cbTipoTijolo.TabIndex = 1;
            this.cbTipoTijolo.Text = "Cerâmico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tipo de tijolo/bloco:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbZonaBioClim);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(292, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 52);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zona Bioclimática";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "Selecionar zona:";
            // 
            // cbZonaBioClim
            // 
            this.cbZonaBioClim.FormattingEnabled = true;
            this.cbZonaBioClim.Items.AddRange(new object[] {
            "Zona 1",
            "Zona 2",
            "Zona 3",
            "Zona 4",
            "Zona 5",
            "Zona 6",
            "Zona 7",
            "Zona 8"});
            this.cbZonaBioClim.Location = new System.Drawing.Point(135, 24);
            this.cbZonaBioClim.Name = "cbZonaBioClim";
            this.cbZonaBioClim.Size = new System.Drawing.Size(109, 22);
            this.cbZonaBioClim.TabIndex = 1;
            // 
            // txtEspessuraReboco
            // 
            this.txtEspessuraReboco.Location = new System.Drawing.Point(135, 78);
            this.txtEspessuraReboco.Name = "txtEspessuraReboco";
            this.txtEspessuraReboco.Size = new System.Drawing.Size(57, 22);
            this.txtEspessuraReboco.TabIndex = 13;
            this.txtEspessuraReboco.Text = "0";
            this.txtEspessuraReboco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 14);
            this.label16.TabIndex = 14;
            this.label16.Text = "Espessura do reboco:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 14);
            this.label17.TabIndex = 15;
            this.label17.Text = "cm";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 385);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSelecionarParede);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.pictureBoxParedes);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 424);
            this.MinimumSize = new System.Drawing.Size(797, 424);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desempenho Térmico";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParedes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParedes;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelecionarParede;
        private System.Windows.Forms.RadioButton rbCalculoNorma;
        private System.Windows.Forms.RadioButton rbCalculoManual;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidadeTermica;
        private System.Windows.Forms.TextBox txtTransmitancia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEspessura;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeParede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbLevaReboco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTipoTijolo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbZonaBioClim;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEspessuraReboco;
    }
}