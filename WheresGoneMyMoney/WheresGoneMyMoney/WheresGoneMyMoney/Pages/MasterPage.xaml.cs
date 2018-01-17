using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WheresGoneMyMoney.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        
            public MasterPage()
            {
                InitializeComponent();
            }
            protected override void OnAppearing()
            {
                base.OnAppearing();
                App.Master = this;
                App.Navigator = Navigator;
            }

        
        //public MasterPage()
        //{
        //    InitializeComponent();
        //    MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        //}

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as MasterPageMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    Detail = new NavigationPage(page);
        //    IsPresented = false;

        //    MasterPage.ListView.SelectedItem = null;
        //}
    }
}