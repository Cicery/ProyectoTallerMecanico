using Serilog;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Configuración dse log 
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 //.WriteTo.Console(LogEventLevel.Information)
                 .WriteTo.File(new JsonFormatter(),path:"C:\\Logs\\TallerMecanico\\Log.json", rollingInterval: RollingInterval.Day,shared:true) //Con esta línea configuramos la salida a fichero
                 .CreateLogger();

            Application.Run(new FrmCategoriacs());
        }
    }
}
