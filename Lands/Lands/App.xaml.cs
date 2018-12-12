using Xamarin.Forms.Xaml;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Lands
{
    using Lands.Views;
    using System;
    using Xamarin.Forms;

    public partial class App : Application
    {

#region Constructors
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            //Se ejecuta una sola vez, cuando la app comienza.
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            //Las app no se cierran se duermen, ej en whatsapp cuando te llega un msj
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            //Al abrir whatsapp despues de la llegada de un msj se ejecuta este metodo que te muestra todo como se dejo antes de dormirla
            // Handle when your app resumes
        } 
        #endregion
    }
}
