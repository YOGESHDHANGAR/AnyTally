using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace bharatplantdesktop.Utils
{
    public class TabSwitchMessageFilter : IMessageFilter
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_LEFT = 0x25;
        private const int VK_RIGHT = 0x27;
        private const int VK_CONTROL = 0x11;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN && GetAsyncKeyState(VK_CONTROL) < 0)
            {
                int keyCode = (int)m.WParam.ToInt64();

                if (keyCode == VK_LEFT || keyCode == VK_RIGHT)
                {
                    int direction = keyCode == VK_LEFT ? -1 : 1;
                    SwitchTab(direction);
                    return true; // Handled
                }
            }

            return false; // Not handled, let it be dispatched to the control
        }

        private void SwitchTab(int direction)
        {
            Form activeForm = Form.ActiveForm;

            if (activeForm != null)
            {
                TabControl tabControl = FindTabControl(activeForm);

                if (tabControl != null)
                {
                    int currentIndex = tabControl.SelectedIndex;
                    int nextIndex = (currentIndex + direction + tabControl.TabCount) % tabControl.TabCount;
                    tabControl.SelectedIndex = nextIndex;
                }
            }
        }

        private TabControl FindTabControl(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TabControl tabControl)
                {
                    return tabControl;
                }

                TabControl nestedTabControl = FindTabControl(childControl);
                if (nestedTabControl != null)
                {
                    return nestedTabControl;
                }
            }

            return null;
        }
    }
}
