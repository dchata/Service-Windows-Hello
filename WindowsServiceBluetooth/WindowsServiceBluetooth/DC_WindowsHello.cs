using System.ServiceProcess;
using WindowsServiceBluetooth.Core;

namespace WindowsServiceBluetooth
{
    public partial class DC_WindowsHello : ServiceBase
    {
        #region Fields
        private DC_WindowsHelloCore _Core;
        #endregion Fields
        
        #region Constructors
        public DC_WindowsHello()
        {
            InitializeComponent();
            _Core = new DC_WindowsHelloCore();
        }
        #endregion Constructors

        #region Methods
        protected override void OnStart(string[] args) => _Core.Start();

        protected override void OnStop() => _Core.Stop();
        #endregion
    }
}
