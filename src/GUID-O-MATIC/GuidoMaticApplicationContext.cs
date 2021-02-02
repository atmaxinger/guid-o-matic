using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID_O_MATIC
{
    class GuidoMaticApplicationContext : ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;
        private readonly GuidOptions _options = new GuidOptions();

        public GuidoMaticApplicationContext()
        {
            var icon = new System.Drawing.Icon(GetType().Assembly.GetManifestResourceStream("GUID_O_MATIC.robot.ico"));

            var menu = new ContextMenuStrip();
            var generateItem = new ToolStripMenuItem("Generate new Guid ...", null, ShowMainWindow);
            generateItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.G;

            menu.Items.Add(generateItem);
            menu.Items.Add(new ToolStripMenuItem("About ...", null, ShowAboutDialog));
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            // Initialize Tray Icon
            _trayIcon = new NotifyIcon()
            {
                Icon = icon,
                BalloonTipText = "GUID-O-MATIC running in background. Press CTRL-ALT-G",
                ContextMenuStrip = menu,
                Visible = true,
            };

            var hook = new KeyboardHook();
            hook.RegisterHotKey(ModifierKeys.Control | ModifierKeys.Alt, Keys.G);
            hook.KeyPressed += ShowMainWindow;

            _trayIcon.ShowBalloonTip(1500);
        }

        void ShowMainWindow(object sender, EventArgs e)
        {
            _options.CurrentGuid = Guid.NewGuid();
            var f = new GuidForm(_options);
            f.ShowDialog();
        }

        void ShowAboutDialog(object sender, EventArgs e)
        {
            var a = new AboutDialog();
            a.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
