using System;
using System.Windows.Forms;
using AutoVer;
using AutoVerUICS.Forms;

namespace AutoVerUICS
{
    static class Program
    {
        private static ErrorReporter _frmErrorReporter;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.Run(new frmMain());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string strLogFolder = null;
            try
            {
                ConfigEngine config = new ConfigEngine();
                strLogFolder = config.AppConfigFolder;
                config.Log.Error(e.Exception.ToString(), "UnhandledException");
            }
            catch (Exception ex)
            {
                strLogFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\AutoVer\\";
                try
                {
                    if (!System.IO.Directory.Exists(strLogFolder))
                        System.IO.Directory.CreateDirectory(strLogFolder);
                }
                catch
                {
                }
            }
            if ((_frmErrorReporter == null) || !_frmErrorReporter.Visible)
                _frmErrorReporter = new ErrorReporter(strLogFolder);
            _frmErrorReporter.ErrorException = e.Exception;
            _frmErrorReporter.Show();
            _frmErrorReporter.Activate();
        }
    }
}
