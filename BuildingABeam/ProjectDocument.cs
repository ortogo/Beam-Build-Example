using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swcommands;
using System.Windows.Forms;

namespace BuildingABeam
{
    class ProjectDocument
    {
        public double externalDiameter;
        public double depth;
        public double length;
        public double volume;

        public const string workPath = "./";
        public const string docName = "RingBeam.SLDPRT";

        public string pathToBeam;

        public delegate void UpdateState(int progress, string message);
        public ProjectDocument()
        {

        }

        public void Build(UpdateState us)
        {
            us(16, "Запускаем Solidworks");
            SldWorks swApp = new SldWorks();
            
            int error = 0;
            int warning = 0;
            us(32, "Построение 3Д модели");
            ModelDoc2 part = swApp.OpenDoc6(pathToBeam, (int)swDocumentTypes_e.swDocPART, 0, "", ref error, ref warning);
            IModelView myModelView = part.ActiveView;
            myModelView.FrameState = (int)swWindowState_e.swWindowMaximized;
            us(48, "Устанавливаем размеры");
            part.Parameter("length@BeamSketch").SystemValue = length / 1000.0;
            part.Parameter("depth@BeamSketch").SystemValue = depth / 1000.0;
            part.Parameter("externalDiameter@BeamSketch").SystemValue
                = externalDiameter / 1000.0;
            us(64, "Перестраиваем");
            part.EditRebuild3();
            part.ForceRebuild3(false);
            us(80,"Отображаем");
            swApp.FrameState = (int)swWindowState_e.swWindowMaximized;
            us(100, "Готов");
        }

        public void CreateSheet()
        {

        }
    }
}
