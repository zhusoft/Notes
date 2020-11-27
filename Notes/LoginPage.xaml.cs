using Newtonsoft.Json;
using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Login_click(object sender,EventArgs e)
        {
            var isvalid = true;
            if (isvalid)
            {
                //Application.Current.Properties["IsLoggedIn"] = bool.TrueString;
                //bool IsLogIn = Application.Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Application.Current.Properties["IsLoggedIn"]):false;
                //if (IsLogIn)
                //{
                //    //已登录，直接进入界面
                //    Note unote = new Note();
                //    App.Current.Properties["useDetail"] = JsonConvert.SerializeObject(unote);
                //    Note unoteData =(Note)JsonConvert.DeserializeObject(App.Current.Properties["useDetail"].ToString());
                //}
                //else
                //{ 
                //    //转到登录界面
                //}
                Navigation.InsertPageBefore(new NotesPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
               await DisplayAlert("登录提示","登录失败！","取消");
            }
        }
        async void change_Tapped(object sender,EventArgs e)
        {
            Navigation.InsertPageBefore(new NotesPage(), this);
            await Navigation.PopAsync();
        }
    }
}