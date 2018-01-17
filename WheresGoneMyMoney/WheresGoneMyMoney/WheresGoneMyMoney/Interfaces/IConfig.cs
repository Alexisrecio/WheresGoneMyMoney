using SQLite.Net.Interop;

namespace WheresGoneMyMoney.Interfaces
{
    public interface IConfig
    {
        string DirectoryDb { get; }

        ISQLitePlatform Platform { get; }
    }
}
