using System.CommandLine;
using System.Runtime.InteropServices;
using Spectre.Console;

[DllImport("user32.dll")]
static extern bool SetCursorPos(int x, int y);

[DllImport("user32.dll")]
static extern bool mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

var periodOption = new Option<int>(
    name: "-t",
    description: "The time interval between invocations of callback , in milliseconds. Specify System.Threading.Timeout.Infinite to disable periodic signaling.",
    getDefaultValue: () => 60000
);
var xOption = new Option<int>(
    name: "-x",
    description: "The new x-coordinate of the cursor, in screen coordinates.",
    getDefaultValue: () => 200
);
var yOption = new Option<int>(
    name: "-y",
    description: "The new y-coordinate of the cursor, in screen coordinates.",
    getDefaultValue: () => 200
);

var rootCommand = new RootCommand("Moves the cursor to the specified screen coordinates. Controls various aspects of mouse motion and button clicking.");
rootCommand.AddOption(periodOption);
rootCommand.AddOption(xOption);
rootCommand.AddOption(yOption);

rootCommand.SetHandler((period, x, y) =>
{
    AnsiConsole.Status()
        .Start("Thinking...", ctx =>
        {
            var timer = new Timer(new TimerCallback(_ =>
            {
                AnsiConsole.MarkupLine(DateTime.Now.ToString());
                SetCursorPos(x, y);
                mouse_event(0x02, x, y, 0, 0);
                mouse_event(0x04, x, y, 0, 0);
            }), null, 0, period);
            Console.ReadKey();
        });
}, periodOption, xOption, yOption);

await rootCommand.InvokeAsync(args);

AnsiConsole.MarkupLine("[underline red]Hello[/] World!");
