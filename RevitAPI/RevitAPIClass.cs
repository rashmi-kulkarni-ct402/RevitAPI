using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace RevitAPI
{
    // transactions for this command managed manually
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class RevitAPIClass : IExternalCommand
    {    
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,
          ref string message, ElementSet elements)
        {
            // display dialog box
            TaskDialog.Show("Hi Rashmi!", "This is your Revit API...");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}