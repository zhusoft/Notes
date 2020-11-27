using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
            List<string> strList = new List<string>() { "A", "B","C" };
            BindingContext = strList;
        }

        async void OnSaveButtonClicked(object sender,EventArgs e)
        { 
            var note = (Note)BindingContext;
            note.Date = DateTime.Now;
            await App.Database.SaveNoteAsync(note);
            //if (string.IsNullOrWhiteSpace(note.Filename))
            //{
            //    //保存
            //    var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
            //    File.WriteAllText(filename, note.Text);
            //}
            //else
            //{
            //    //更新
            //    File.WriteAllText(note.Filename,note.Text);
            //}
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            //if (File.Exists(note.Filename))
            //{
            //    File.Delete(note.Filename);
            //}
            await Navigation.PopAsync();
        }



    }
}