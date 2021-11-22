using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace baithi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        private void cbDevType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(cbDevType.SelectedIndex == -1))
            {
                //Get the selected object and use the usage IDs
                HidDeviceClass seln = (HidDeviceClass)cbDevType.SelectedItem;
                //tb_usagepageID.Text = "0x" + seln.PageID.ToString("00");
               // tb_usageID.Text = "0x" + seln.UsageID.ToString("00");
            }
        }

        private List<HidDeviceClass> HidDeviceClasses;

        public class HidDeviceClass
        {
            public HidDeviceClass(string usageName, ushort pageID, ushort usageID)
            {
                UsageName = usageName;
                PageID = pageID;
                UsageID = usageID;
            }

            public string UsageName { get; set; }
            public ushort PageID { get; set; }
            public ushort UsageID { get; set; }
        }

        private void GetUagePageInfo()
        {
            using (StreamReader file = File.OpenText(".\\usagepage.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jObject = (JObject)JToken.ReadFrom(reader);
                var hidDeviceClasses =
                from p in jObject["hidDeviceClasses"]
                select new HidDeviceClass((string)p["UsageName"], (ushort)p["PageID"], (ushort)p["UsageID"]);
                HidDeviceClasses = hidDeviceClasses.ToList<HidDeviceClass>();
                cbDevType.DataContext = HidDeviceClasses;
            }

        }

        
    }
}
