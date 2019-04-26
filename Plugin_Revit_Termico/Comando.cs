using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin_Revit_Termico
{
    [Transaction(TransactionMode.Manual)]
    //[Regeneration(RegenerationOption.Manual)]
    public class Comando : IExternalCommand
    {
        Calculos calculos = new Calculos();

        public class MySelectionFilter : ISelectionFilter
        {
            public bool AllowElement(Element elem)
            {
                return elem is Wall;
            }
            public bool AllowReference(Reference reference, XYZ position)
            {
                return true;
            }
        }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            //Informações da parede
            string nomeParede = "";
            double area = 0;
            double espessura = 0;
            double volume = 0;
            double altura = 0;

            ////Acessar a seleção
            //Selection sel = uidoc.Selection;
            //
            ////Buscando cada elemento
            //foreach(ElementId eleId in sel.GetElementIds())
            //{
            //    //pegando o elemento pelo Id
            //    Element ele = doc.GetElement(eleId);
            //    //mostrar caixa de diálogo com o nome do elemento
            //    TaskDialog.Show(ele.Category.Name, ele.Name,TaskDialogCommonButtons.Ok);
            //}
            //
            ////pegando todas as paredes no projeto
            //FilteredElementCollector collParedes = new FilteredElementCollector(doc);
            //collParedes.OfCategory(BuiltInCategory.OST_Walls);
            //collParedes.OfClass(typeof(FamilyInstance));
            //
            ////pegando cada uma das paredes da coleção
            //foreach (Element ele in collParedes)
            //{
            //    //irá conter a informação dos parâmetros
            //    System.Text.StringBuilder paramText = new System.Text.StringBuilder();
            //
            //    foreach (Parameter param in ele.Parameters)
            //    {
            //        //primeiramente, pega-se o nome do parâmetro
            //        paramText.AppendFormat("{0}: ", param.Definition.Name);
            //        //pegando as informações
            //        switch (param.StorageType)
            //        {
            //            case StorageType.String:
            //                paramText.Append(param.AsString());
            //                break;
            //            case StorageType.Double:
            //                paramText.AppendFormat("{0:0.00}", param.AsDouble());
            //                break;
            //        }
            //        //adicionar uma quebra de linha
            //        paramText.AppendLine();
            //    }
            //    MessageBox.Show(paramText.ToString());
            //}


            //usando o PickObject
            try
            {
                while (true)
                {
                    Reference selRef = uidoc.Selection.PickObject(ObjectType.Element, new MySelectionFilter() , "Selecione uma parede");
                    Wall parede = (Wall)uidoc.Document.GetElement(selRef.ElementId);

                    nomeParede = parede.Name;
                    area = retornaAreaParede(parede);
                    area = calculos.converterAreaMetroQuadrado(area);
                    altura = retornaAlturaParede(parede);
                    altura = calculos.converterPesMetros(altura);
                    volume = retornaVolumeParede(parede);
                    volume = calculos.converterMetroCubico(volume);
                    espessura = calculos.calculaEspessura(area, volume);
                    break;
                }
            
            }
            catch(Autodesk.Revit.Exceptions.OperationCanceledException)
            {
                
            }
            string dados = nomeParede + "#" + Convert.ToString(area) + "#" + Convert.ToString(volume) + "#" + Convert.ToString(espessura);
            //MessageBox.Show(volume.ToString());
            FormPrincipal mainForm = new FormPrincipal();
            mainForm.Tag = dados;
            mainForm.ShowDialog();

            return Result.Succeeded;
        }

        private double retornaAreaParede(Wall parede)
        {
            double area = 0;
            area = parede.get_Parameter(BuiltInParameter.HOST_AREA_COMPUTED).AsDouble();
            return area;
        }


        private double retornaAlturaParede(Wall parede)
        {
            double altura = 0;
            altura = parede.get_Parameter(BuiltInParameter.WALL_USER_HEIGHT_PARAM).AsDouble();
            return altura;
        }

        private double retornaVolumeParede(Wall parede)
        {
            double volume = 0;
            foreach (Parameter param in parede.Parameters)
            {
                //primeiramente, pega-se o nome do parâmetro
                if (param.Definition.Name == "Volume")
                {
                    volume = param.AsDouble();
                }
            }
            return volume;
        }


    }
}
