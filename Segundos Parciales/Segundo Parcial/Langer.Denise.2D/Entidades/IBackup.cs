namespace Entidades
{
    public interface IBackup
    {
        void LoadBackup(string path);
        void SaveBackup(string path);
    }
}
