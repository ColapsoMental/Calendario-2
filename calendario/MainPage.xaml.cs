using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DevExpress.XamarinForms.Scheduler;


namespace calendario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            DevExpress.XamarinForms.Scheduler.Initializer.Init();

            InitializeComponent();
        }
    }
}
