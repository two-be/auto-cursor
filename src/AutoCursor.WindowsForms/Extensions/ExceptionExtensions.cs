using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoCursor.WindowsForms.Extensions;

public static class ExceptionExtensions
{
    public static string GetMessage(this Exception ex)
    {
        if (ex.InnerException is not null)
        {
            return ex.InnerException.Message;
        }
        return ex.Message;
    }
}
