using WindowsServiceBluetooth.Core;

namespace WindowsServiceBluetooth.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DC_WindowsHelloCore core = new DC_WindowsHelloCore();

            core.Start();
        }
    }
}
