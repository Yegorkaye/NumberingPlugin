using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace TeklaCustomNumbering
{
    public class AssemblyNumerator
    {
        public string ProjectCode { get; set; }
        public int InitialNumber { get; set; }

        public void Number(List<Assembly> assemblies)
        {
            var assemblyNumberTable = new List<Tuple<Assembly, int>>();
            var currentNumber = InitialNumber;

            foreach (var currentAssembly in assemblies)
            {
                var assemblyNumbered = false;
                foreach (var numberedAssembly in assemblyNumberTable)
                {
                    if (!assemblyNumbered && currentAssembly.CompareTo(numberedAssembly.Item1))
                    {
                        SetAssemblyNumber(currentAssembly, numberedAssembly.Item2);
                        assemblyNumbered = true;
                    }
                }

                if (!assemblyNumbered)
                {
                    assemblyNumberTable.Add(new Tuple<Assembly, int>(currentAssembly, currentNumber));
                    SetAssemblyNumber(currentAssembly, currentNumber++);
                }
            }
        }

        public void ClearNumbers(List<Assembly> marks)
        {
            foreach (var currentMark in marks)
            {
                var mainPart = currentMark.GetMainPart();
                var secondaryParts = currentMark.GetSecondaries();
                secondaryParts.Add(mainPart);
                var allParts = secondaryParts;

                foreach (Part currentPart in allParts)
                {
                    currentPart.SetUserProperty("DWG_N", "");
                    currentPart.Modify();
                }
            }
        }

        private void SetAssemblyNumber(Assembly assembly, int number)
        {
            var mainPart = assembly.GetMainPart();
            var secondaryParts = assembly.GetSecondaries();
            secondaryParts.Add(mainPart);
            var allParts = secondaryParts;

            foreach (Part part in allParts)
            {
                part.SetUserProperty("DWG_N", $"{ProjectCode}-M-{number.ToString().PadLeft(4, '0')}");
                part.Modify();
            }
        }
    }
}
