 
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using RoundTable.Controls.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using Xamarin.Forms;

namespace RoundTable.Controls.Shared
{
    public class DialogKit : IDialogKit
    {
        
        public Task<string> GetPickerChoice(string title, string message, IEnumerable ItemSource, string currentText = null, Keyboard keyboard = null)
        {
            if (keyboard == null) keyboard = Keyboard.Default;
            var cts = new TaskCompletionSource<string>();
            var _dialogView = new PickerPopupView(title, message, ItemSource, currentText, keyboard);
            PopupNavigation.PushAsync(new PopupPage { Content = _dialogView });
            _dialogView.Picked += (s, o) => { cts.SetResult(o); PopupNavigation.PopAsync(); };
            return cts.Task;
        }
    }
}
