using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.Win32;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoVerUICS.Forms
{
    public partial class ErrorReporter : Form
    {
        public Exception ErrorException;
        private StringBuilder sb = new StringBuilder();
        private bool DetailsInserted = false;
        private string strLogFile;

        //For connection status

        /// <summary>
        ///     Retrieves the connected state of the local system.
        ///     <para>
        ///     For more information go to
        ///     https://msdn.microsoft.com/en-us/library/windows/desktop/aa384702%28v=vs.85%29.aspx
        ///     </para>
        /// </summary>
        /// <param name="description">
        ///     C++ ( lpdwFlags [out]. Type: LPDWORD )<br />Pointer to a variable that receives the connection description. This
        ///     parameter may return a valid flag even when the function returns FALSE. This parameter can be one or more of the
        ///     following values.
        ///     <list type="table">
        ///     <listheader>
        ///         <term>Internet Connection State Possible Flags</term>
        ///     </listheader>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_CONFIGURED (0x40)</term>
        ///         <description>
        ///         Local system has a valid connection to the Internet, but it might or might not be currently
        ///         connected.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_LAN (0x02)</term>
        ///         <description>Local system uses a local area network to connect to the Internet.</description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_MODEM (0x01)</term>
        ///         <description>Local system uses a modem to connect to the Internet.</description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_MODEM_BUSY (0x08)</term>
        ///         <description>No longer used.</description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_OFFLINE (0x20)</term>
        ///         <description>Local system is in offline mode.</description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_CONNECTION_PROXY (0x04)</term>
        ///         <description>Local system uses a proxy server to connect to the Internet.</description>
        ///     </item>
        ///     <item>
        ///         <term>INTERNET_RAS_INSTALLED (0x10)</term>
        ///         <description>Local system has RAS installed.</description>
        ///     </item>
        ///     </list>
        /// </param>
        /// <param name="reservedValue">C++ ( dwReserved [in].Type: )<br />This parameter is reserved and must be 0.</param>
        /// <returns>
        ///     <c>true</c> if there is an active modem or a LAN Internet connection, <c>false</c> if there is no Internet
        ///     connection, or if all possible Internet connections are not currently active.
        /// </returns>
        /// <remarks>
        ///     A return value of TRUE from InternetGetConnectedState indicates that at least one connection to the Internet is
        ///     available. It does not guarantee that a connection to a specific host can be established. Applications should
        ///     always check for errors returned from API calls that connect to a server. InternetCheckConnection can be called to
        ///     determine if a connection to a specific destination can be established.
        ///     <br />A return value of TRUE indicates that either the modem connection is active, or a LAN connection is active
        ///     and a proxy is properly configured for the LAN.A return value of FALSE indicates that neither the modem nor the LAN
        ///     is connected.If FALSE is returned, the INTERNET_CONNECTION_CONFIGURED flag may be set to indicate that autodial is
        ///     configured to "always dial" but is not currently active.If autodial is not configured, the function returns FALSE.
        ///     <br />Like all other aspects of the WinINet API, this function cannot be safely called from within DllMain or the
        ///     constructors and destructors of global objects.
        ///     <br />Note WinINet does not support server implementations. In addition, it should not be used from a service. For
        ///     server implementations or services use Microsoft Windows HTTP Services (WinHTTP).
        /// </remarks>
        [DllImport("wininet.dll", SetLastError = true)]
        static extern bool InternetGetConnectedState(out int lpdwFlags, int dwReserved);

        //For screen capture
        /// <summary>
        ///    Performs a bit-block transfer of the color data corresponding to a
        ///    rectangle of pixels from the specified source device context into
        ///    a destination device context.
        /// </summary>
        /// <param name="hdc">Handle to the destination device context.</param>
        /// <param name="nXDest">The leftmost x-coordinate of the destination rectangle (in pixels).</param>
        /// <param name="nYDest">The topmost y-coordinate of the destination rectangle (in pixels).</param>
        /// <param name="nWidth">The width of the source and destination rectangles (in pixels).</param>
        /// <param name="nHeight">The height of the source and the destination rectangles (in pixels).</param>
        /// <param name="hdcSrc">Handle to the source device context.</param>
        /// <param name="nXSrc">The leftmost x-coordinate of the source rectangle (in pixels).</param>
        /// <param name="nYSrc">The topmost y-coordinate of the source rectangle (in pixels).</param>
        /// <param name="dwRop">A raster-operation code.</param>
        /// <returns>
        ///    <c>true</c> if the operation succeedes, <c>false</c> otherwise. To get extended error information, call <see cref="System.Runtime.InteropServices.Marshal.GetLastWin32Error"/>.
        /// </returns>
        [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);
        static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll")]
        static extern int GetDC(int hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(int hWnd, int hDC);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);


        public ErrorReporter(string logPath)
        {
            Load += ErrorReporter_Load;
            InitializeComponent();
            strLogFile = logPath;
        }

        private void ErrorReporter_Load(System.Object sender, System.EventArgs e)
        {
            /*
            strLogFile += "ErrorLog" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";

            this.Focus();
            this.Cursor = Cursors.WaitCursor;
            txtErrorText.Text = ErrorException.Message;
            lblStatus.Text = "Collecting Data...";
            Application.DoEvents();

            sb.AppendLine(My.Application.Info.ProductName + " " + My.Application.Info.Version.Major + "." + My.Application.Info.Version.Minor + "." + My.Application.Info.Version.Build);
            sb.AppendLine(DateTime.Now);
            sb.AppendLine(ErrorException.ToString());
            sb.AppendLine();

            //Event viewer
            AttachFiles("*.ini", 30000);
            AttachFiles("*.xml", 50000);
            AttachFiles("*Log.txt", 30000);
            //EventLog("AutoVer", 100) 'move list to .config file
            GetDriveWindowsInfo();
            //Screenshot()
            sb.AppendLine("Hardware ============================================================================================================");
            Management("BIOS");
            Management("Processor");
            Management("PhysicalMemory");
            sb.AppendLine();
            Management("NetworkAdapterConfiguration");
            sb.AppendLine();
            NetworkConnections();
            GetProcesses();
            StartUp();
            //InstalledPrograms()
            sb.AppendLine("END ============================================================================================================");

            WriteLog();
            this.Cursor = Cursors.Default;
            lblStatus.Text = string.Empty;
            */
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(System.Object sender, System.EventArgs e)
        {
            /*
            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Sending...";
            Application.DoEvents();
            //Dim strImageFile As String = strLogFile.Substring(0, strLogFile.Length - 3) & "jpg"
            //Dim Fs As New System.IO.FileStream(strImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            //Dim bytFile(Fs.Length - 1) As Byte
            //Fs.Read(bytFile, 0, Fs.Length)
            //Fs.Close()
            if (!DetailsInserted & (txtNameEmail.Text.Trim != string.Empty | txtRecreate.Text.Trim != string.Empty))
            {
                DetailsInserted = true;
                sb.Insert(sb.ToString.IndexOf(Constants.vbCrLf, StringComparison.Ordinal), Constants.vbCrLf + txtNameEmail.Text + Constants.vbCrLf + txtRecreate.Text);
                WriteLog();
            }

            try
            {
                beanlandnetau.BeanAppService wsBeanWeb = new beanlandnetau.BeanAppService();
                wsBeanWeb.ReportError("AutoVer." + System.Windows.Forms.SystemInformation.ComputerName, txtNameEmail.Text, sb.ToString, null);

                this.Cursor = Cursors.Default;
                Application.Exit();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                lblStatus.Text = "Error connecting to web site";
            }
            */
        }

        private void lklErrorReport_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start(strLogFile);
            this.Cursor = Cursors.Default;
        }

        //****************************************************************************************************************************

        private void AttachFiles(string strFileSpec, long lngLastXBytes)
        {
            //Attach last x bytes of all files matching the spec to the output
            string[] strFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\AutoVer\\", strFileSpec);
            StreamReader reader = null;
            foreach (string strFile in strFiles)
            {
                if (!strFile.StartsWith("Error"))
                {
                    try
                    {
                        //read
                        sb.AppendLine(new FileInfo(strFile).Name + " ============================================================================================================");
                        reader = new StreamReader(strFile, true);
                        if (reader.BaseStream.Length > lngLastXBytes)
                        {
                            sb.Append("[Truncated]... ");
                            reader.BaseStream.Seek(reader.BaseStream.Length - lngLastXBytes, SeekOrigin.Begin);
                        }
                        while (!reader.EndOfStream)
                        {
                            sb.Append(reader.ReadToEnd());
                        }
                        sb.AppendLine();
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine(ex.Message);
                    }
                    finally
                    {
                        if ((reader != null))
                            reader.Close();
                    }
                }
            }
            if (strFiles.Length > 0)
                sb.AppendLine();
        }

        public void EventLog(string strLogNameStartsWith, int LastXEvents)
        {
            //Read Windows Event log
            strLogNameStartsWith = strLogNameStartsWith.ToLower();
            try
            {
                EventLog objEventLog = null;
                EventLog[] EventLogs = null;
                EventLogEntry objEntry = null;
                EventLogs = System.Diagnostics.EventLog.GetEventLogs();
                foreach (EventLog objEventLog_loopVariable in EventLogs)
                {
                    objEventLog = objEventLog_loopVariable;
                    if (objEventLog.Log.ToString().ToLower().StartsWith(strLogNameStartsWith))
                    {
                        sb.AppendLine("Event Log: " + objEventLog.Log.ToString() + " =========================================================================================================");
                        for (int intEntry = objEventLog.Entries.Count - 1; intEntry >= 0; intEntry += -1)
                        {
                            objEntry = objEventLog.Entries[intEntry];
                            if (objEventLog.Entries.Count - intEntry == LastXEvents)
                                break; // TODO: might not be correct. Was : Exit For
                            sb.Append(objEntry.EntryType.ToString() + ", ");
                            if (objEntry.Category.ToString() != "(0)")
                                sb.Append(objEntry.Category.ToString() + ", ");
                            sb.Append(objEntry.Source.ToString() + ", ");
                            sb.Append(objEntry.TimeGenerated.ToString() + ", ");
                            sb.AppendLine(objEntry.Message.Replace("\r\n\r\n", "\r\n").Replace(string.Concat(Environment.NewLine, Environment.NewLine), Environment.NewLine));
                        }
                        sb.AppendLine();
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
        }

        private void GetDriveWindowsInfo()
        {
            /*
            //Windows and drive info
            sb.AppendLine("Windows ============================================================================================================");
            try
            {
                sb.Append("Windows Version: ");
                sb.AppendLine(Environment.OSVersion.VersionString);
                sb.Append("Windows System Folder: ");
                sb.AppendLine(Environment.GetFolderPath(Environment.SpecialFolder.System));
                sb.Append("Program Files Folder: ");
                sb.AppendLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
                sb.Append("Documents Folder: ");
                sb.AppendLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                sb.Append("Boot Mode: ");
                sb.AppendLine(SystemInformation.BootMode.ToString());
                sb.Append("Windows Up Time: ");
                TimeSpan ts = new TimeSpan(Convert.ToInt64(Environment.TickCount) * 10000);
                sb.AppendLine(string.Format("{0}d, {1}h, {2}m, {3}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds));
                sb.Append("Screen Resolution: ");
                sb.AppendLine(SystemInformation.VirtualScreen.Width.ToString() + "w x " + SystemInformation.VirtualScreen.Height.ToString() + "h px"));
                sb.Append("Region: ");
                sb.AppendLine(System.Globalization.RegionInfo.CurrentRegion.EnglishName + " (" + System.Globalization.CultureInfo.CurrentCulture.EnglishName + ")");
                sb.Append("User Name: ");
                sb.AppendLine(System.Windows.Forms.SystemInformation.UserName);
                sb.Append("Computer Name: ");
                sb.AppendLine(System.Windows.Forms.SystemInformation.ComputerName);
                sb.Append("Host/IP: ");
                sb.AppendLine(System.Net.Dns.GetHostName() + " / " + System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0].ToString());
                sb.AppendLine();
                sb.Append(".NET Versions: (");
                sb.AppendLine(Environment.Version.ToString() + " currently running)");
                RegistryKey componentsKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
                string[] instComps = componentsKey.GetSubKeyNames();
                foreach (string instComp in instComps)
                {
                    RegistryKey key = componentsKey.OpenSubKey(instComp);
                    string friendlyName = key.GetValue(null);
                    // Gets the (Default) value from this key
                    if ((friendlyName != null) && friendlyName.IndexOf(".NET Framework", System.StringComparison.Ordinal) >= 0)
                    {
                        string version = key.GetValue("Version");
                        //if(version!=null && version.Split(',').Length>=4)
                        sb.Append(friendlyName);
                        if ((version == null))
                        {
                            sb.AppendLine();
                        }
                        else
                        {
                            sb.AppendLine(" (" + version + ")");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            sb.AppendLine();

            sb.AppendLine("Drives ============================================================================================================");
            System.IO.DriveInfo Drive = null;
            foreach (System.IO.DriveInfo Drive_loopVariable in System.IO.DriveInfo.GetDrives())
            {
                Drive = Drive_loopVariable;
                try
                {
                    sb.Append("Drive Name: ");
                    sb.AppendLine(Drive.Name);
                    sb.Append("Drive Type: ");
                    sb.AppendLine(Drive.DriveType.ToString());
                    sb.Append("File System: ");
                    sb.AppendLine(Drive.DriveFormat.ToString());
                    sb.Append("Size: ");
                    sb.AppendLine((Drive.TotalSize / (1024 * 1024)).ToString("#,###,### MB"));
                    sb.Append("Free Space: ");
                    sb.AppendLine((Drive.TotalFreeSpace / (1024 * 1024)).ToString("#,###,### MB"));
                    sb.AppendLine(string.Empty);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);
                }
            }
            */
        }

        public void GetProcesses()
        {
            //loading all processes on current PC 
            sb.AppendLine("Processes ============================================================================================================");
            try
            {
                Process[] aPrc = null;
                Process Prc = null;
                aPrc = System.Diagnostics.Process.GetProcesses();
                foreach (Process Prc_loopVariable in aPrc)
                {
                    Prc = Prc_loopVariable;
                    try
                    {
                        sb.Append(Prc.ProcessName);
                        try
                        {
                            sb.Append(", Started: ");
                            sb.Append(Prc.StartTime);
                        }
                        catch
                        {
                        }
                        sb.Append(", WorkingMemory: ");
                        sb.Append((Prc.WorkingSet64 / 1024).ToString() + "KB");
                        if (!Prc.Responding)
                            sb.Append(", NOT Responding");
                        sb.AppendLine();
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            sb.AppendLine();
        }

        public void InstalledPrograms()
        {
            /*
            //loading all installed programs from registry
            sb.AppendLine("Installed Programs ============================================================================================================");
            RegistryKey Key = default(RegistryKey);
            RegistryKey PR = default(RegistryKey);
            string[] SK = null;
            string DN = null;
            string XK = null;
            try
            {
                Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\");
                SK = Key.GetSubKeyNames();
                foreach (string XK_loopVariable in SK)
                {
                    XK = XK_loopVariable;
                    PR = Key.OpenSubKey(XK);
                    DN = PR.GetValue("DisplayName", "");
                    if (DN != string.Empty)
                    {
                        sb.Append(DN);
                        DN = PR.GetValue("Publisher", "");
                        if (DN.Trim() != string.Empty)
                        {
                            sb.Append(" (");
                            sb.Append(DN);
                            sb.Append(")");
                        }
                        DN = PR.GetValue("DisplayVersion", "");
                        if (DN.Trim() != string.Empty)
                        {
                            sb.Append(", Ver: ");
                            sb.Append(DN);
                        }
                        sb.AppendLine();
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            sb.AppendLine();
            */
        }

        public void StartUp()
        {
            /*
            //loading all StartUp programs from registry 
            sb.AppendLine("Startup Apps ============================================================================================================");
            RegistryKey Key1 = default(RegistryKey);
            RegistryKey Key2 = default(RegistryKey);
            RegistryKey Key3 = default(RegistryKey);
            RegistryKey Key4 = default(RegistryKey);
            RegistryKey Key5 = default(RegistryKey);
            RegistryKey Key6 = default(RegistryKey);
            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;
            long l1 = 0;
            long l2 = 0;
            long l3 = 0;
            long l4 = 0;
            long l5 = 0;
            long l6 = 0;
            try
            {
                Key1 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Key2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Key3 = Registry.Users.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Key4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
                Key5 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
                Key6 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx", true);
                try
                {
                    l1 = Key1.ValueCount;
                    for (i1 = 0; i1 <= l1 - 1; i1++)
                    {
                        sb.Append(Key1.GetValueNames.GetValue(i1));
                        sb.AppendLine(" - HKLM\\Run");
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    l2 = Key2.ValueCount;
                    for (i2 = 0; i2 <= l2 - 1; i2++)
                    {
                        sb.Append(Key2.GetValueNames.GetValue(i2));
                        sb.AppendLine(" - HKCU\\Run");
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    l3 = Key3.ValueCount;
                    for (i3 = 0; i3 <= l3 - 1; i3++)
                    {
                        sb.Append(Key3.GetValueNames.GetValue(i3));
                        sb.AppendLine(" - HKUser\\Run");
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    l4 = Key4.ValueCount;
                    for (i4 = 0; i4 <= l4 - 1; i4++)
                    {
                        sb.Append(Key4.GetValueNames.GetValue(i4));
                        sb.AppendLine(" - HKCU\\RunOnce");
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    l5 = Key5.ValueCount;
                    for (i5 = 0; i5 <= l5 - 1; i5++)
                    {
                        sb.Append(Key5.GetValueNames.GetValue(i5));
                        sb.AppendLine(" - HKLM\\RunOnce");
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    l6 = Key6.ValueCount;
                    for (i6 = 0; i6 <= l6 - 1; i6++)
                    {
                        sb.Append(Key6.GetValueNames.GetValue(i6));
                        sb.AppendLine(" - HKLM\\RunOnceEx");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            sb.AppendLine();
            */
        }

        private ImageCodecInfo GetEncoderInfo(string strMimeType)
        {
            //returns ImageCodecInfo for the specified MIME type
            int j = 0;
            ImageCodecInfo[] objImageCodecInfo = null;
            objImageCodecInfo = ImageCodecInfo.GetImageEncoders();
            j = 0;
            while (j < objImageCodecInfo.Length)
            {
                if (objImageCodecInfo[j].MimeType == strMimeType)
                {
                    return objImageCodecInfo[j];
                }
                j += 1;
            }
            return null;
        }

        private void BitmapToJPEG(Bitmap objBitmap, string strFilename, long lngCompression = 75)
        {
            //save bitmap object to JPEG of specified quality level
            EncoderParameters objEncoderParameters = new EncoderParameters(1);
            ImageCodecInfo objImageCodecInfo = GetEncoderInfo("image/jpeg");

            objEncoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, lngCompression);
            objBitmap.Save(strFilename, objImageCodecInfo, objEncoderParameters);
        }

        private void Screenshot()
        {
            //Take a screenshot of the desktop and saves it as a jpg
            Rectangle objRectangle = Screen.PrimaryScreen.Bounds;
            Bitmap objBitmap = new Bitmap(objRectangle.Right, objRectangle.Bottom);
            Graphics objGraphics = default(Graphics);
            IntPtr hdcDest = default(IntPtr);
            IntPtr hdcSrc = IntPtr.Zero;
            const int SRCCOPY = 0xcc0020;
            objGraphics = Graphics.FromImage(objBitmap);
            //-- get a device context to the windows desktop and our destination  bitmaps
            hdcSrc = GetDC(IntPtr.Zero);
            hdcDest = objGraphics.GetHdc();
            //-- copy what is on the desktop to the bitmap
            BitBlt(hdcDest, 0, 0, objRectangle.Right, objRectangle.Bottom, hdcSrc, 0, 0, SRCCOPY);
            //-- release device contexts
            objGraphics.ReleaseHdc(hdcDest);
            ReleaseDC(0, hdcSrc.ToInt32());
            BitmapToJPEG(objBitmap, strLogFile.Substring(0, strLogFile.Length - 3) + "jpg", 75);
            //objBitmap.Save(Environment.CurrentDirectory & "\ErrorLog" & Now.ToString("yyyyMMdd-HHmm") & ".jpg", Imaging.ImageFormat.Jpeg)
        }

        private void Management(string inf)
        {
            /*
            //loading informations from management
            int count = 0;
            int cap = 0;
            try
            {
                ManagementObject Men = default(ManagementObject);
                ManagementClass MemoClass = new ManagementClass("Win32_" + inf);
                ManagementObjectCollection Memo = MemoClass.GetInstances();
                ManagementObjectCollection MOC = MemoClass.GetInstances();
                ManagementObjectCollection.ManagementObjectEnumerator MemoMenu = Memo.GetEnumerator;
                MemoMenu.MoveNext();
                switch (inf)
                {
                    case "BIOS":
                        sb.Append("Manufacturer/Model: ");
                        sb.Append(MemoMenu.Current.Properties("Manufacturer").Value.ToString());
                        sb.Append(", ");
                        MemoClass = new ManagementClass("Win32_ComputerSystem");
                        Memo = MemoClass.GetInstances();
                        MemoMenu = Memo.GetEnumerator;
                        MemoMenu.MoveNext();
                        sb.AppendLine(MemoMenu.Current.Properties("Model").Value.ToString());
                        break;
                    case "Processor":
                        sb.Append("Name: ");
                        sb.AppendLine(MemoMenu.Current.Properties("Name").Value.ToString.Trim());
                        break;
                    case "PhysicalMemory":
                        foreach (Men in Memo)
                        {
                            count = count + 1;
                            cap = cap + (Convert.ToInt64(Men("capacity")) / (1024 * 1024));
                        }

                        sb.Append("RAM: ");
                        sb.AppendLine(cap + " MB");
                        MemoClass = new ManagementClass("Win32_OperatingSystem");
                        Memo = MemoClass.GetInstances();
                        MemoMenu = Memo.GetEnumerator;
                        MemoMenu.MoveNext();
                        sb.Append("Total Visible Memory Size: ");
                        sb.AppendLine(Strings.FormatNumber((MemoMenu.Current.Properties("TotalVisibleMemorySize").Value / 1024).ToString(), 0) + " MB");
                        sb.Append("Free Physical Memory: ");
                        sb.AppendLine(Strings.FormatNumber(MemoMenu.Current.Properties("FreePhysicalMemory").Value.ToString, 0) + " KB");
                        break;
                    case "NetworkAdapterConfiguration":
                        foreach (Men in Memo)
                        {
                            try
                            {
                                if (Men("IPAddress").Length > 0 & Men("IPSubnet").Length > 0)
                                {
                                    sb.Append("NIC: ");
                                    sb.AppendLine(Men("Description"));
                                    if (Men("IPAddress").Length > 0)
                                        sb.Append("IPAddress: ");
                                    //Dim strItems As String = String.Empty
                                    foreach (string strItem in Men("IPAddress"))
                                    {
                                        if (strItem.Trim() != string.Empty)
                                            sb.AppendLine(strItem);
                                    }
                                    if (Men("IPSubnet").Length > 0)
                                        sb.Append("IPSubnet: ");
                                    //strItems = String.Empty
                                    foreach (string strItem in Men("IPSubnet"))
                                    {
                                        if (strItem.Trim() != string.Empty)
                                            sb.AppendLine(strItem);
                                    }
                                    sb.AppendLine();
                                }

                            }
                            catch
                            {
                            }
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            */
        }

        public void NetworkConnections()
        {
            /*
            //loading informations about network connections
            sb.AppendLine("Network Connections ============================================================================================================");
            int @int = 0x2;
            int flags = 0;
            try
            {
                InternetGetConnectedState(ref flags, 0);
                sb.Append("LAN: ");
                sb.AppendLine(Convert.ToString(flags & @int));
                sb.Append("Internet: ");
                sb.AppendLine(Convert.ToString(InternetGetConnectedState(ref 0, 0)));
                sb.Append("Proxy: ");
                @int = 0x4;
                InternetGetConnectedState(ref flags, 0);
                sb.AppendLine(Convert.ToString(flags & @int));
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            sb.AppendLine();
            */
        }

        private void WriteLog()
        {
            FileStream Fs = default(FileStream);
            StreamWriter writer = default(StreamWriter);
            try
            {
                //Write
                Fs = new FileStream(strLogFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                writer = new StreamWriter(Fs);
                writer.WriteLine(sb.ToString());
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("FileWriter: " + ex.Message);
            }
        }
    }
}
