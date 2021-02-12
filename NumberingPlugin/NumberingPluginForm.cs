using System;
using System.Collections.Generic;

using TeklaCustomNumbering;

namespace NumberingPlugin
{
    public partial class NumberingPluginForm : Tekla.Structures.Dialog.PluginFormBase
    {
        public NumberingPluginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numberPartsButton_Click(object sender, EventArgs e)
        {
            var parseResult = int.TryParse(startPartNumberTextBox.Text, out int initialPartNumber);
            if (parseResult)
            {
                var objectSelector = new PluginObjectSelector();
                var selectedParts = objectSelector.GetSelectedParts();

                var partNumerator = new PartNumerator();
                partNumerator.InitialNumber = initialPartNumber;
                partNumerator.ProjectCode = projectCodeTextBox.Text;
                partNumerator.Number(selectedParts);
            }
        }

        private void numberMarksButton_Click(object sender, EventArgs e)
        {
            var parseResult = int.TryParse(startMarkNumberTextBox.Text, out int initialMarkNumber);
            if (parseResult)
            {
                var objectSelector = new PluginObjectSelector();
                var selectedMarks = objectSelector.GetPartsAssemblies();
                var markNumerator = new AssemblyNumerator();
                markNumerator.InitialNumber = initialMarkNumber;
                markNumerator.ProjectCode = projectCodeTextBox.Text;
                markNumerator.Number(selectedMarks);
            }
        }

        private void deletePartNumbersButton_Click(object sender, EventArgs e)
        {
            var objectSelector = new PluginObjectSelector();
            var selectedParts = objectSelector.GetSelectedParts();
            var partNumerator = new PartNumerator();
            partNumerator.ClearNumbers(selectedParts);
        }

        private void deleteMarkNumbersButton_Click(object sender, EventArgs e)
        {
            var objectSelector = new PluginObjectSelector();
            var selectedMarks = objectSelector.GetPartsAssemblies();
            var markNumerator = new AssemblyNumerator();
            markNumerator.ClearNumbers(selectedMarks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drawingHandler = new Tekla.Structures.Drawing.DrawingHandler();
            var selectedDrawings = drawingHandler.GetDrawingSelector().GetSelected();
            var drawingNumerator = new DrawingNumerator();

            var drawings = new List<Tekla.Structures.Drawing.Drawing>();

            while (selectedDrawings.MoveNext())
            {
                drawings.Add(selectedDrawings.Current);
            }

            drawingNumerator.Number(drawings);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var parseResult = int.TryParse(SAStartNumberTextBox.Text, out int initialMarkNumber);
            if (parseResult)
            {
                var objSelector = new PluginObjectSelector();
                var subAssemblies = objSelector.GetSelectedSubAssemblies();
                var saNumerator = new SubAssemblyNumerator();
                saNumerator.ProjectCode = projectCodeTextBox.Text;
                saNumerator.InitialNumber = initialMarkNumber;
                saNumerator.Number(subAssemblies);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var objSelector = new PluginObjectSelector();
            var subAssemblies = objSelector.GetSelectedSubAssemblies();
            var saNumerator = new SubAssemblyNumerator();
            saNumerator.ClearNumbers(subAssemblies);
        }
    }
}
