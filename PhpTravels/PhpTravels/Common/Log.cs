using log4net;
using log4net.Config;

namespace PhpTravels.Common
{
   public static class Log
    {
        public static ILog Write = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Configure()
        {
            XmlConfigurator.Configure();
        }

    }
}
