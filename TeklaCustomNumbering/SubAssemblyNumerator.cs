using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace TeklaCustomNumbering
{
    public class SubAssemblyNumerator
    {
        public string ProjectCode { get; set; }
        public int InitialNumber { get; set; }

        public void Number(List<Assembly> subAssemblies)
        {
            var currentNumber = InitialNumber;
            foreach (var subAssembly in subAssemblies)
            {
                var code = $"{ProjectCode}-SA-{currentNumber.ToString().PadLeft(4, '0')}";
                var parts = GetAllParts(subAssembly);
                foreach (var part in parts)
                {
                    part.SetUserProperty("SA_DWG_N", code);
                }
                currentNumber++;
            }
        }

        public void ClearNumbers(List<Assembly> subAssemblies)
        {
            foreach (var subAssembly in subAssemblies)
            {
                var parts = GetAllParts(subAssembly);
                foreach (var part in parts)
                {
                    part.SetUserProperty("SA_DWG_N", "");
                }
            }
        }

        private List<Part> GetAllParts(Assembly assembly)
        {
            var result = new List<Part>();
            var mainPart = assembly.GetMainPart();
            if (mainPart is Part)
                result.Add(mainPart as Part);

            var secondaries = assembly.GetSecondaries();
            foreach (var secondary in secondaries)
            {
                if (secondary is Part part)
                    result.Add(part);
            }

            var subAssemblies = assembly.GetSubAssemblies();

            foreach (var subAssembly in subAssemblies)
            {
                if (subAssembly is Assembly sa)
                    result.AddRange(GetAllParts(sa));
            }

            return result;
        }
    }
}
