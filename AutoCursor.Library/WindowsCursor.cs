using System.Runtime.InteropServices;

namespace AutoCursor.Library;

public class WindowsCursor
{
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int x, int y);

    [DllImport("user32.dll")]
    static extern bool mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    public void Click(int x, int y)
    {
        SetCursorPos(x, y);
        mouse_event(0x02, x, y, 0, 0);
        mouse_event(0x04, x, y, 0, 0);
    }
}
