using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace TeklaCustomNumbering
{
    public class PluginObjectSelector
    {
        public List<Part> GetSelectedParts()
        {
            var modelObjectSelector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            var selectedObjects = modelObjectSelector.GetSelectedObjects();
            var parts = new List<Part>();

            while (selectedObjects.MoveNext())
            {
                var currentObject = selectedObjects.Current;
                if (currentObject is Part currentPart)
                    parts.Add(currentPart);
                if (currentObject is Assembly currentAssembly)
                {
                    var assemblyParts = GetAssemblyParts(currentAssembly);

                    foreach (var part in assemblyParts)
                    {
                        parts.Add(part);
                    }
                }
            }

            return parts;
        }

        public List<Assembly> GetPartsAssemblies()
        {
            var modelObjectSelector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            var selectedObjects = modelObjectSelector.GetSelectedObjects();
            var assemblies = new List<Assembly>();

            while (selectedObjects.MoveNext())
            {
                var currentObject = selectedObjects.Current;
                if (currentObject is Part currentPart)
                {
                    var assembly = currentPart.GetAssembly();
                    if (IsPartAssembly(assembly) && !IsListContainsAssembly(assemblies, assembly))
                        assemblies.Add(assembly);
                }
                if (currentObject is Assembly currentAssembly)
                {
                    var partAssemblies = GetPartAssemblies(currentAssembly);

                    foreach (var partAssembly in partAssemblies)
                    {
                        if (!IsListContainsAssembly(assemblies, partAssembly))
                            assemblies.Add(partAssembly);
                    }
                }
            }

            return assemblies;

        }

        private List<Part> GetAssemblyParts(Assembly assembly)
        {
            var mainPart = assembly.GetMainPart();
            var secondaryParts = assembly.GetSecondaries();
            secondaryParts.Add(mainPart);
            var allParts = ArrayListToPartList(secondaryParts);
            var subAssemblies = assembly.GetSubAssemblies();

            var subAssembliesParts = new List<Part>();

            foreach (var subAssembly in subAssemblies)
            {
                var subAssemblyParts = GetAssemblyParts(subAssembly as Assembly);
                subAssembliesParts.AddRange(subAssemblyParts);
            }

            allParts.AddRange(subAssembliesParts);
            return allParts;
        }

        private List<Part> ArrayListToPartList(ArrayList parts)
        {
            var result = new List<Part>();

            foreach (Part part in parts)
            {
                result.Add(part);
            }

            return result;
        }

        private bool IsPartAssembly(Assembly assembly)
        {
            return assembly.GetSubAssemblies().Count == 0 ? true : false;
        }

        private List<Assembly> GetPartAssemblies(Assembly assembly)
        {
            var result = new List<Assembly>();

            if (IsPartAssembly(assembly))
            {
                result.Add(assembly);
            }
            else
            {
                var subAssemblies = assembly.GetSubAssemblies();
                foreach (Assembly subAssembly in subAssemblies)
                    result.AddRange(GetPartAssemblies(subAssembly));
            }

            return result;
        }

        private bool IsListContainsAssembly(List<Assembly> list, Assembly assembly)
        {
            foreach (var assemblyInList in list)
            {
                if (assembly.Identifier.GUID == assemblyInList.Identifier.GUID)
                    return true;
            }

            return false;
        }
    }
}
