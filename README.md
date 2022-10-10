## Auto Cursor

```fish
Description:
  Moves the cursor to the specified screen coordinates. Controls various aspects of mouse motion and button clicking.

Usage:
  AutoCursor [options]

Options:
  -t <t>          The time interval between invocations of callback , in milliseconds. Specify
                  System.Threading.Timeout.Infinite to disable periodic signaling. [default: 60000]
  -x <x>          The new x-coordinate of the cursor, in screen coordinates. [default: 200]
  -y <y>          The new y-coordinate of the cursor, in screen coordinates. [default: 200]
  --version       Show version information
  -?, -h, --help  Show help and usage information
```