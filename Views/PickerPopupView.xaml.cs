 
using RoundTable.Controls.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace RoundTable.Controls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPopupView : ContentView
    {
        public PickerPopupView(string title, string message, IEnumerable ItemSource, string text = null, Keyboard keyboard = null)
        {
            InitializeComponent();

     
            BindTexts(title, message);
        
            pickItems.ItemsSource = ItemSource.Cast<object>().ToList();
           }
        public event EventHandler<string> Picked;


      

        public int SelectedIndex { get => pickItems.SelectedIndex; }
        public PickerModel SelectedItem { get => pickItems.SelectedItem as PickerModel; }


        private void BindTexts(string title, string message)
        {
            this.BindingContext = new
            {
                Title = title,
                Message = message,
                OK = "OK",
                Cancel = "CANCEL",
            };
        }
        private void Confirm_Clicked(object sender, EventArgs e)
        {
            var item = pickItems.SelectedItem as PickerModel;
            Picked?.Invoke(this, item.Value.ToString());
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Picked?.Invoke(this, null);
        }
    }
}