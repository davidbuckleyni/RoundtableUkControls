The following is a control to over come a problem I was having. While we have the excellent RG popups their 
was no example of using a drop down with the control. I had look at input kit and others but I just wanted
something small that I could drop in when I need a popup with the dropdown within it its very easy to setup 
and will save you loads of time.


Setup Andriod
1. As we are using RG popups for the program you will need to add it to your MainActivity.cs

      Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);



2. The control will take a standard IEnumerable list which you can pass as a parameter in the constructor. The 
Control has a in built class which comprises of the following markup. This will allow us to send back to the object
what item is selected you will get back the value for example below you see 0001 that is what would be returned.

      public class PickerModel
      {
         public long Value { get; set; }
          public string Description { get; set; }
       }
 

            List<PickerModel> demoList= new List<PickerModel>();
            PickerModel item = new PickerModel();
            item.Description = "Test1";
            item.Value = 0001;
            demoList.Add(item);

            var selectionTest = Plugin.DialogKit.RoundTableDialogKit.Current.GetPickerChoice("RoundTable", "Please select an item ", demoList, null, Keyboard.Numeric);
            await DisplayAlert("RoundTable", $"This is what was selected {selectionTest.ToString()}","OK");

Please let me no what you think and send me an email at davidbuckleyweb@gmail.com. Raise any issues on Github first please.
