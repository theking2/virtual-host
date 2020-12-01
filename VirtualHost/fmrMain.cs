using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualHost
{
    public partial class frmMain : Form
    {
        /** Path to root of host */
        private string Path;
        /** Name of host to add **/
        private string Hostname;

        public frmMain()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            if( args.Length < 2 )
            {
                MessageBox.Show("Need at least one argument.");
                Application.Exit();
            }

            this.Path = args[1].Replace('\\', '/');
            this.txtPath.Text = this.Path;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hostname = this.txtHostname.Text;

            String result = String.Format( TEMPLATE, this.Path, this.Hostname );
            Clipboard.SetDataObject(result);

            MessageBox.Show(String.Format("vhost-Setup copied to Cliboard\r\nAdd the following line to the \\etc\\hosts file:\r\n127.0.0.1\t{0}", this.Hostname ) );
            using (StreamWriter hosts = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", append:true))
            {
                hosts.WriteLine();
                hosts.WriteLine("#Added by VirtualHost\r\n" + this.Hostname);
                hosts.WriteLine("127.0.0.1\t" + this.Hostname);
                hosts.WriteLine("::1\t" + this.Hostname);
                hosts.WriteLine("#End added by VirtualHosts");
                hosts.WriteLine();

                hosts.Close();
            }

            Application.Exit();
        }

        const string TEMPLATE = @"#
<VirtualHost *:80>
    ServerName {1}

    DocumentRoot ""{0}""
    <Directory  ""{0}"">
        Options +Indexes +Includes +FollowSymLinks +MultiViews

        AllowOverride All

        Require local
    </Directory>
</VirtualHost>
";

        private void txtHostname_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = txtHostname.Text.Length == 0;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
