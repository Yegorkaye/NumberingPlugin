using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace TeklaCustomNumbering
{
    public class PartNumerator
    {
        public string ProjectCode { get; set; }
        public int InitialNumber { get; set; }
        public void Number(List<Part> parts)
        {
            var partNumbersTable = new List<Tuple<Part, int>>();
            var currentNumber = InitialNumber;

            foreach (var currentPart in parts)
            {
                var partNumbered = false;
                if (!IsOnePieceAssembly(currentPart))
                {
                    foreach (var numberedPart in partNumbersTable)
                    {
                        if (!partNumbered && currentPart.CompareTo(numberedPart.Item1))
                        {
                            SetPartNumber(currentPart, numberedPart.Item2);
                            partNumbered = true;
                        }
                    }

                    if (!partNumbered)
                    {
                        partNumbersTable.Add(new Tuple<Part, int>(currentPart, currentNumber));
                        SetPartNumber(currentPart, currentNumber++);
                    }
                }
            }
        }

        public void ClearNumbers(List<Part> parts)
        {
            foreach (var currentPart in parts)
            {
                currentPart.SetUserProperty("SP_DWG_N", "");
                currentPart.SetUserProperty("SP_DWG_NUM", "");
                currentPart.Modify();
            }
        }

        private void SetPartNumber(Part part, int number)
        {
            part.SetUserProperty("SP_DWG_N", $"{ProjectCode}-D-{number.ToString().PadLeft(4, '0')}");
            part.SetUserProperty("SP_DWG_NUM", number.ToString());
            part.Modify();
        }

        private bool IsOnePieceAssembly(Part part)
        {
            var assembly = part.GetAssembly();
            var assemblyPartsCount = assembly.GetSecondaries().Count + 1;
            return assemblyPartsCount == 1 ? true : false;
        }
    }
}
