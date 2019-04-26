using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin_Revit_Termico
{
    public partial class FormPrincipal : Form
    {
        public int indicaTipoParede = 1;
        Calculos calculos = new Calculos();
        public string tipoMaterial = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            carregarImagem(1);
            btSelecionarParede.Enabled = false;
            string dados = this.Tag.ToString();
            string[] dadosParede = leDados(dados);
            txtNomeParede.Text = dadosParede[0];
            txtArea.Text = dadosParede[1];
            txtVolume.Text = dadosParede[2];
            txtEspessura.Text = dadosParede[3];
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            if (indicaTipoParede > 1)
            {
                indicaTipoParede = indicaTipoParede - 1;
                carregarImagem(indicaTipoParede);
            }
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (indicaTipoParede < 24)
            {
                indicaTipoParede = indicaTipoParede + 1;
                carregarImagem(indicaTipoParede);
            }
        }

        private void btSelecionarParede_Click(object sender, EventArgs e)
        {
            double[] dados = calculos.retornaPropriedadesTermicasParedesNorma(indicaTipoParede);
            txtTransmitancia.Text = Convert.ToString(dados[0]);
            txtCapacidadeTermica.Text = Convert.ToString(dados[1]);
        }

        private void carregarImagem(int indicador)
        {
            string nomeArquivo = Convert.ToString(indicador);
            //nomeArquivo = "../../Imagens_paredes/" + nomeArquivo + ".png";
            //nomeArquivo = nomeArquivo + ".png";
            nomeArquivo = "D:\\Egito\\Documentos\\Projetos_Computacao\\Projeto_Plugin_Revit\\Plugin_Revit_Termico\\Imagens_paredes\\" + nomeArquivo + ".png";
            pictureBoxParedes.Load(nomeArquivo);
        }

        private void rbCalculoNorma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalculoNorma.Checked == true)
            {
                btSelecionarParede.Enabled = true;
            }
        }

        private void rbCalculoManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalculoManual.Checked == true)
            {
                btSelecionarParede.Enabled = false;
            }
        }

        private void cbLevaReboco_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLevaReboco.Checked == false)
            {
                txtEspessuraReboco.Enabled = false;
            }
            if (cbLevaReboco.Checked == true)
            {
                txtEspessuraReboco.Enabled = true;
            }
        }

        private string carregaTipoMaterial()
        {
            string tipo = cbTipoTijolo.Text;
            string tipoMaterial = "";

            switch(tipo)
            {
                case ("Cerâmico"):
                    tipoMaterial = "ceramica";
                    break;
                case ("Concreto"):
                    tipoMaterial = "concreto";
                    break;
            }
            return tipoMaterial;
        }

        private string[] leDados(string dados)
        {
            string[] infos = dados.Split('#');
            return infos;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string tipoMaterial = "";
            double espessuraReboco = 0;
            double espessuraParede = 0;
            
            //cálculo pela norma
            if (rbCalculoNorma.Checked == true)
            {
                double[] dados = calculos.retornaPropriedadesTermicasParedesNorma(indicaTipoParede);
                txtTransmitancia.Text = Convert.ToString(dados[0]);
                txtCapacidadeTermica.Text = Convert.ToString(dados[1]);
            }

            //cálculo manual
            if (rbCalculoManual.Checked == true)
            {
                if (cbLevaReboco.Checked == true)
                {
                    try
                    {
                        espessuraReboco = Convert.ToDouble(txtEspessuraReboco.Text);
                    }
                    catch { MessageBox.Show("Tipo de entrada inválido para a espessura do reboco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                if (cbLevaReboco.Checked == false) { espessuraReboco = 0; }
                tipoMaterial = carregaTipoMaterial();
                try
                {
                    espessuraParede = Convert.ToDouble(txtEspessura.Text);
                }
                catch { MessageBox.Show("Tipo de entrada inválido para a espessura da parede", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                double[] dados = calculos.paredeMacica(tipoMaterial, espessuraParede, espessuraReboco);
                txtTransmitancia.Text = Convert.ToString(dados[0]);
                txtCapacidadeTermica.Text = Convert.ToString(dados[1]);
            }

        }

        
    }
}
