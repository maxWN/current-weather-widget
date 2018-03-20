using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormInstaller
{
    public static class AppLog
    {
        #region private class variables

            private static readonly ILogger performanceLog;
            private static readonly ILogger usageLog;
            private static readonly ILogger errorLog;
            private static readonly ILogger diagnosticLog;

        #endregion private class variables

        static AppLog() {
            errorLog = new LoggerConfiguration().WriteTo.File(path: "error-log.txt").CreateLogger();
        }

        //public static void InformErrors(AppLog errorDetails) {
        //    errorLog.Write(LogEventLevel.Information, "{@errorDetails}", errorDetails);
        //}
    }
}
