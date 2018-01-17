using WheresGoneMyMoney.ViewModels;

namespace WheresGoneMyMoney.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
