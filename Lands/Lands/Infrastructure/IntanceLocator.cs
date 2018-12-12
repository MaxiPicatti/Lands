namespace Lands.Infrastructure
{
    using Lands.ViewModels;

    public class IntanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
