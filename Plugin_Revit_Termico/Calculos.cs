using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin_Revit_Termico
{
    class Calculos
    {
        //RETORNA OS VALORES DA TRANSMITÂNCIA TÉRMICA (W/M2.K) E A CAPACIDADE TÉRMICA (KJ/M2.K)
        //DE ACORDO COM OS PADRÔES DA NORMA
        public double[] retornaPropriedadesTermicasParedesNorma(int indicador)
        {
            double[] propriedadesTermicas = new double[2];
            switch(indicador)
            {
                case 1:
                    propriedadesTermicas[0] = 5.04;
                    propriedadesTermicas[1] = 120;
                    break;
                case 2:
                    propriedadesTermicas[0] = 4.4;
                    propriedadesTermicas[1] = 240;
                    break;
                case 3:
                    propriedadesTermicas[0] = 3.7;
                    propriedadesTermicas[1] = 149;
                    break;
                case 4:
                    propriedadesTermicas[0] = 2.48;
                    propriedadesTermicas[1] = 159;
                    break;
                case 5:
                    propriedadesTermicas[0] = 2.49;
                    propriedadesTermicas[1] = 158;
                    break;
                case 6:
                    propriedadesTermicas[0] = 2.24;
                    propriedadesTermicas[1] = 167;
                    break;
                case 7:
                    propriedadesTermicas[0] = 2.28;
                    propriedadesTermicas[1] = 168;
                    break;
                case 8:
                    propriedadesTermicas[0] = 2.49;
                    propriedadesTermicas[1] = 186;
                    break;
                case 9:
                    propriedadesTermicas[0] = 2.43;
                    propriedadesTermicas[1] = 192;
                    break;
                case 10:
                    propriedadesTermicas[0] = 3.13;
                    propriedadesTermicas[1] = 255;
                    break;
                case 11:
                    propriedadesTermicas[0] = 2.45;
                    propriedadesTermicas[1] = 203;
                    break;
                case 12:
                    propriedadesTermicas[0] = 2.43;
                    propriedadesTermicas[1] = 220;
                    break;
                case 13:
                    propriedadesTermicas[0] = 2.02;
                    propriedadesTermicas[1] = 192;
                    break;
                case 14:
                    propriedadesTermicas[0] = 2.31;
                    propriedadesTermicas[1] = 227;
                    break;
                case 15:
                    propriedadesTermicas[0] = 1.92;
                    propriedadesTermicas[1] = 202;
                    break;
                case 16:
                    propriedadesTermicas[0] = 1.8;
                    propriedadesTermicas[1] = 231;
                    break;
                case 17:
                    propriedadesTermicas[0] = 1.61;
                    propriedadesTermicas[1] = 232;
                    break;
                case 18:
                    propriedadesTermicas[0] = 1.52;
                    propriedadesTermicas[1] = 248;
                    break;
                case 19:
                    propriedadesTermicas[0] = 2.3;
                    propriedadesTermicas[1] = 430;
                    break;
                case 20:
                    propriedadesTermicas[0] = 2.25;
                    propriedadesTermicas[1] = 445;
                    break;
                case 21:
                    propriedadesTermicas[0] = 1.54;
                    propriedadesTermicas[1] = 368;
                    break;
                case 22:
                    propriedadesTermicas[0] = 1.21;
                    propriedadesTermicas[1] = 312;
                    break;
                case 23:
                    propriedadesTermicas[0] = 1.12;
                    propriedadesTermicas[1] = 364;
                    break;
                case 24:
                    propriedadesTermicas[0] = 0.98;
                    propriedadesTermicas[1] = 368;
                    break;
            }
            return propriedadesTermicas;
        }

        //CONVERTE UNIDADE DE ÁREA DE PÉS QUADRADOS PARA METROS
        public double converterAreaMetroQuadrado(double areaFtq)
        {
            double areaMq = areaFtq / 10.764;
            areaMq = Math.Round(areaMq, 3);
            return areaMq;
        }

        //CONVERTE UNIDADE DE COMPRIMENTO DE PÉS PARA METROS
        public double converterPesMetros(double compPes)
        {
            double compMetros = compPes * 0.3048;
            compMetros = Math.Round(compMetros, 2);
            return compMetros;
        }

        //CONVERTER UNIDADE DE PÉS CÚBICOS PARA METROS CÚBICOS
        public double converterMetroCubico(double volumePes)
        {
            double volume = volumePes * 0.028316819907857;
            volume = Math.Round(volume, 3);
            return volume;
        }

        //CALCULAR ESPESSURA DA PAREDE EM CENTÍMETROS
        //ÁREA DADA EM METROS QUADRADOS E VOLUME EM METROS QUADRADOS
        public double calculaEspessura(double area,double volume)
        {
            double espessura = volume / area;
            espessura = espessura * 100;
            espessura = Math.Round(espessura, 0);
            return espessura;
        }

        //----->>>>> FUNÇÕES PARA O CÁLCULO MANUAL

        //public const double espessuraReboco = 0.02;

        // RETORNA A DENSIDADE EM KG/M3
        public double densidade(string tipoMaterial)
        {
            double dens = 0;
            switch(tipoMaterial)
            {
                case "ceramica":
                    dens = 1600;
                    break;
                case "reboco":
                    dens = 2000;
                    break;
                case "concreto":
                    dens = 2400;
                    break;
            }
            return dens;
        }

        // RETORNA A CONDUTIVIDADE TÉRMICA EM W/M.K
        public double condutividadeTermica(string tipoMaterial)
        {
            double ct = 0;
            switch (tipoMaterial)
            {
                case "ceramica":
                    ct = 0.9;
                    break;
                case "reboco":
                    ct = 1.15;
                    break;
                case "concreto":
                    ct = 1.75;
                    break;
            }
            return ct;
        }

        // RETORNA O CALOR ESPECÍFICO EM KJ/KG.K
        public double calorEspecifico(string tipoMaterial)
        {
            double ce = 0;
            switch (tipoMaterial)
            {
                case "ceramica":
                    ce = 0.92;
                    break;
                case "reboco":
                    ce = 1;
                    break;
                case "concreto":
                    ce = 1;
                    break;
            }
            return ce;
        }

        // CÁLCULO PARA UMA PAREDE MACIÇA DE TIJOLO CERÂMICO
        public double[] paredeMacica(string tipoMaterialParede,double espessuraParede, double espessuraReboco)
        {
            double[] dados = new double[2];
            espessuraParede = espessuraParede / 100;
            espessuraReboco = espessuraReboco / 100;
            double Aa = 0;
            double Ab = 0;
            double Ra = 0;
            double Rb = 0;
            double den = 0;
            double num = 0;
            double Rt = 0;
            double Rtotal = 0;
            double U = 0;
            double Cta = 0;
            double Ctb = 0;
            double Ct = 0;

            if (tipoMaterialParede == "ceramica")
            {
                //RESISTÊNCIA TÉRMICA DA PAREDE
                Aa = (0.01 * 0.19) + (0.01 * 0.06);
                Ra = ((2 * espessuraReboco) + espessuraParede) / (condutividadeTermica("reboco"));

                Ab = 0.05 * 0.19;
                Rb = ((2 * espessuraReboco) / (condutividadeTermica("reboco"))) + ((espessuraParede) / (condutividadeTermica(tipoMaterialParede)));

                den = (Aa / Ra) + (Ab / Rb);
                num = Aa + Ab;
                Rt = num / den;

                Rtotal = Rt + 0.13 + 0.04;
                U = Math.Round(1 / Rtotal, 2);

                //CAPACIDADE TÉRMICA
                Cta = ((2 * espessuraReboco) + espessuraParede) * calorEspecifico("reboco") * densidade("reboco");
                Ctb = (2 * espessuraReboco * calorEspecifico("reboco") * densidade("reboco")) + (espessuraParede * calorEspecifico(tipoMaterialParede) * densidade(tipoMaterialParede));

                den = (Aa / Cta) + (Ab / Ctb);
                Ct = num / den;
                Ct = Math.Round(Ct, 0);
            }
            else if (tipoMaterialParede == "concreto")
            {
                //RESISTÊNCIA TÉRMICA DA PAREDE
                Aa = (0.02 * 0.19);
                Ra = ((2 * espessuraReboco) / condutividadeTermica("reboco"))+ ((espessuraParede) / condutividadeTermica(tipoMaterialParede));

                Ab = 0.165 * 0.19;
                Rb = ((2 * espessuraReboco) / (condutividadeTermica("reboco"))) + ((0.04) / (condutividadeTermica(tipoMaterialParede)));

                den = (3 * Aa / Ra) + (2 * Ab / Rb);
                num = 3 * Aa + 2 * Ab;
                Rt = num / den;

                Rtotal = Rt + 0.13 + 0.04;
                U = Math.Round(1 / Rtotal, 2);

                //CAPACIDADE TÉRMICA
                Cta = ((2 * espessuraReboco) + espessuraParede) * calorEspecifico("reboco") * densidade("reboco");
                Ctb = (2 * espessuraReboco * calorEspecifico("reboco") * densidade("reboco")) + (0.04 * calorEspecifico(tipoMaterialParede) * densidade(tipoMaterialParede));

                den = (3 * Aa / Cta) + (2 * Ab / Ctb);
                Ct = num / den;
                Ct = Math.Round(Ct, 0);
            }

            dados[0] = U;
            dados[1] = Ct;

            return dados;
        }

    }
}
