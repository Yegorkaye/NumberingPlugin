using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Drawing;
using Tekla.Structures.Model;
using DrwPart = Tekla.Structures.Drawing.Part;
using Part = Tekla.Structures.Model.Part;

namespace TeklaCustomNumbering
{
    public class DrawingNumerator
    {
        public void Number(List<Drawing> drawings)
        {
            foreach (var drawing in drawings)
            {
                if (drawing is AssemblyDrawing assemblyDrawing)
                {
                    SetAssemblyDrawingNumber(assemblyDrawing);
                }
                else if (drawing is SinglePartDrawing singlePartDrawing)
                {
                    SetSinglePartDrawingNumber(singlePartDrawing);
                }
            }
        }

        private void SetAssemblyDrawingNumber(AssemblyDrawing drawing)
        {
            var assemblyType = 0;
            drawing.GetUserProperty(@"DR_SET_ASS_TYPE", ref assemblyType);
            if (assemblyType == 0)
            {
                var assemblyId = drawing.AssemblyIdentifier;
                var assembly = new Model().SelectModelObject(assemblyId) as Assembly;
                var mainPart = assembly.GetMainPart() as Part;
                if (mainPart != null)
                {
                    var markParam = "";
                    mainPart.GetUserProperty("DWG_N", ref markParam);
                    var markRev = "";
                    mainPart.GetUserProperty("REV_DWG", ref markRev);
                    drawing.SetUserProperty("DR_SET_PLOT", $"{markParam}_{markRev}");
                }
            }
        }

        private void SetSinglePartDrawingNumber(SinglePartDrawing drawing)
        {
            var partId = drawing.PartIdentifier;
            var part = new Model().SelectModelObject(partId) as Part;
            if (part != null)
            {
                var partParam = "";
                part.GetUserProperty("SP_DWG_N", ref partParam);
                var partRev = "";
                part.GetUserProperty("SP_REV_DWG", ref partRev);
                drawing.SetUserProperty("DR_SET_PLOT", $"{partParam}_{partRev}");
            }
        }
    }
}
