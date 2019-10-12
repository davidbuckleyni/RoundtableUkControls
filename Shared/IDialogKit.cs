using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoundTable.Controls.Shared
{
    public interface IDialogKit
    {
         /// <summary>
        /// Pushes a popup with includes a picker control for choice
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="ItemSource"></param>
        /// <param name="currentText"></param>
        /// <param name="keyboard"></param>
        /// <returns></returns>
        Task<string> GetPickerChoice(string title, string message, IEnumerable ItemSource, string currentText = null,
            Keyboard keyboard = null);



    }
}