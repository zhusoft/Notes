using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OCRpage : ContentPage
    {
        public OCRpage()
        {
            InitializeComponent();
        }
        //身份证识别
        public void testOCR()
        {
            Baidu.Aip.Ocr.Ocr ocr = new Baidu.Aip.Ocr.Ocr("", "") { Timeout = 6000 };
            byte[] imagebytes =new byte[1];
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("language_type","CHN_ENG");
            options.Add("paragraph",true);
            var results =  ocr.Idcard(imagebytes,"",options);
            //var list = JsonConvert.DeserializeObject<RootObject>(results.ToString());
            foreach (var item in results)
            {
                string IDstr = item.Key;
                string addr = item.Value.First().ToString();
            }
        }
    }
}