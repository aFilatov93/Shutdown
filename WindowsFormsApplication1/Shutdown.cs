using System;
using System.Windows.Forms;
using System.Diagnostics;

public class Shutdown
{
    private const int maxHours = 6;
    public int MaxHours
    {
        get { return maxHours; }
    }

    public void shutdown(int hours)
    {
        if (hours < maxHours && hours != 0)
        {
            hours *= 3600;
            string hoursStr = Convert.ToString(hours);
            string cmd = "shutdown -s -t " + hoursStr;
            var proc = new ProcessStartInfo()
            {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmd,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(proc);
        }
        else throw new Exception();
    }
}
