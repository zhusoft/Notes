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
    public partial class DateSelect : ContentPage
    {
        public DateSelect(Note employeeToDisplay)
        {
            InitializeComponent();
            this.BindingContext = employeeToDisplay;

            var firstName = new Entry()

            {

                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            firstName.SetBinding(Entry.TextProperty, "Text");

            // Rest of the code omitted…
        }
    }
}