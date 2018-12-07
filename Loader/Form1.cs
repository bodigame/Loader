using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using MaterialSkin.Controls;
using System.Net;

namespace Loader
{
    public partial class Form1 : MaterialForm
    {
        [DllImport("InjectLib.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void Inject(byte[] buf);

        public Form1()
        {
            InitializeComponent();

            var SkinManager = MaterialSkin.MaterialSkinManager.Instance;

            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink600, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Purple400, MaterialSkin.TextShade.WHITE);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var dll = new WebClient().DownloadData("https://github.com");

            while (Process.GetProcessesByName("csgo").Length == 0)
            {
                Thread.Sleep(500);
            }

            Inject(dll);

            Process.GetCurrentProcess().Kill();
        }
    }
}
