using SQLite.Net.Interop;

namespace WheresGoneMyMoney.Infrastructure
{
    public interface IConfig
    {
        string DirectoryDb { get; }

        ISQLitePlatform Platform { get; }
    }
}
