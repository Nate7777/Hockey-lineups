using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using em = AlignementJoueursForm.AlignementJoueurGen.ErrorMessages;

namespace AlignementJoueursForm
{
    class AlignementJoueurGen
    {
        public enum ErrorMessages
        {
            EmUnexpected,
            EmFileLoad,
            EmDialog
        }

        public static string[] errorMessages = new string[3];

        /// <summary>
        /// Initialize error messages for the class
        /// </summary>
        public static void InitMessages()
        {
            errorMessages[(int)em.EmUnexpected] = "An unexpected error occurred. " + 
                    Environment.NewLine + "Please contact the programmer";
            errorMessages[(int)em.EmFileLoad] = "Error while loading file.";
            errorMessages[(int)em.EmDialog] = "Error while opening dialog box.";
        }
    }
}
