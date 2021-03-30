using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Painting.LoadPaintingForm = PaintingForm.Run;
            Photograph.LoadPhotographForm = PhotographForm.Run;
            Sculpture.LoadSculptureForm = SculptureForm.Run;
            Application.Run(MainForm.Instance);
        }
    }
}
