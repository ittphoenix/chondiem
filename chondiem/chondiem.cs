using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chonmat
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class chonmat : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            XYZ point1 = uidoc.Selection.PickPoint();
            XYZ point2 = uidoc.Selection.PickPoint();
            XYZ point3 = uidoc.Selection.PickPoint();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(point1.ToString());
            sb.AppendLine(point2.ToString());
            sb.AppendLine(point3.ToString());

            MessageBox.Show(sb.ToString(), "Thông tin điểm");
            return Result.Succeeded;




        }
    }
}