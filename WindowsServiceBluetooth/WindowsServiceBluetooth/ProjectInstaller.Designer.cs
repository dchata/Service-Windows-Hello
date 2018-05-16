namespace WindowsServiceBluetooth
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerDC_WindowsHello = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerDC_WindowsHello = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerDC_WindowsHello
            // 
            this.serviceProcessInstallerDC_WindowsHello.Password = null;
            this.serviceProcessInstallerDC_WindowsHello.Username = null;
            // 
            // serviceInstallerDC_WindowsHello
            // 
            this.serviceInstallerDC_WindowsHello.DelayedAutoStart = true;
            this.serviceInstallerDC_WindowsHello.Description = "DC Lock / Unlock PC when bluetooth device nerby / away";
            this.serviceInstallerDC_WindowsHello.DisplayName = "DC Windows Hello Bluetooth";
            this.serviceInstallerDC_WindowsHello.ServiceName = "DC_WindowsHello";
            this.serviceInstallerDC_WindowsHello.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerDC_WindowsHello,
            this.serviceInstallerDC_WindowsHello});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerDC_WindowsHello;
        private System.ServiceProcess.ServiceInstaller serviceInstallerDC_WindowsHello;
    }
}