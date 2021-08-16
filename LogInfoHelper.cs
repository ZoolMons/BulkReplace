using NLog;
using System;

namespace BulkReplace.Helper
{
    public static class LogInfoHelper
    {
        private static ILogger logger = LogManager.GetLogger("BulkReplace");

        public static void Error(string moduleName, string msg, Exception ex)
        {
            string logInfo = "";
            logInfo = WriteLog(moduleName, msg, ex);
            logger.Error(logInfo);
        }

        public static void Error(string moduleName, string msg)
        {
            string logInfo = "";
            logInfo = WriteLog(moduleName, msg);
            logger.Error(logInfo);
        }

        public static void Info(string moduleName, string msg, Exception ex)
        {
            string logInfo = "";
            logInfo = WriteLog(moduleName, msg, ex);
            logger.Info(logInfo);
        }

        public static void Info(string moduleName, string msg)
        {
            string logInfo = "";
            logInfo = WriteLog(moduleName, msg);
            logger.Info(logInfo);
        }


        public static string WriteLog(string moduleName, string msg, Exception ex)
        {
            string retValue = "";
            retValue = $"[{moduleName}]->{msg}\r\n";
            return retValue;
        }

        private static string GetMsgContent(Exception ee)
        {
            return ee.Message + "\r\n" + ee.StackTrace + "\r\n\r\n";
        }

        public static string WriteLog(string moudleName, string msg)
        {
            return WriteLog(moudleName, msg, null);
        }
    }
}
