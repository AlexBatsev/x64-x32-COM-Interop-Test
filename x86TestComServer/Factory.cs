using System.Runtime.InteropServices;

namespace x86TestComServer
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("410B8E64-27DB-40BD-8847-FC3A0E96147D")]
    public interface IFactory
    {
        int PlusOne(int i);
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("207FC3AB-0EFB-459A-B222-41E281F044F9")]
    public class Factory : IFactory
    {
        public int PlusOne(int i) => i + 1;
    }
}
