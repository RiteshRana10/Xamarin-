using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cview
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class onboarding1 : ContentPage
    {
        public onboarding1()
        {
            InitializeComponent();
           
        }
        async void OnAcceptTapped2(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new onboarding2());
        }
       
    }

}
