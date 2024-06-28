using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoCursor.Library;

[StructLayout(LayoutKind.Sequential)]
struct LASTINPUTINFO
{
    public uint cbSize;
    public uint dwTime;
}

public class WindowsLastInput
{
    [DllImport("user32.dll")]
    static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

    [DllImport("kernel32.dll")]
    static extern uint GetTickCount();

    private uint _idleThreshold = 5 * 60 * 1000;

    public uint GetIdleTime()
    {
        LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
        lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);
        GetLastInputInfo(ref lastInputInfo);

        return GetTickCount() - lastInputInfo.dwTime;
    }

    public bool IsIdle()
    {
        uint idleTime = GetIdleTime();
        Console.WriteLine($"Idle Time: {idleTime} ms");

        return idleTime > _idleThreshold;
    }

    public void SetIdleThreshold(uint second)
    {
        _idleThreshold = second * 1000;
    }
}
