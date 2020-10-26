using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Plugins;

namespace NumberingPlugin
{
    [Plugin("Нумерация деталей и марок")]
    [PluginUserInterface("NumberingPlugin.NumberingPluginForm")]
    class KgcmNumberingPlugin : PluginBase
    {
        public override List<InputDefinition> DefineInput()
        {
            return null;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            return true;
        }
    }
}
