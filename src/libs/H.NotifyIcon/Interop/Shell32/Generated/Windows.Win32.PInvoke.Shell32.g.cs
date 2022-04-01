﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436
namespace Windows.Win32
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using winmdroot = global::Windows.Win32;


    /// <content>
    /// Contains extern methods from "Shell32.dll".
    /// </content>
    internal static partial class PInvoke
    {
        /// <summary>Sends an appbar message to the system.</summary>
        /// <param name="dwMessage">Type: <b>DWORD</b></param>
        /// <param name="pData">
        /// <para>Type: <b>PAPPBARDATA</b> A pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-appbardata">APPBARDATA</a> structure. The content of the structure on entry and on exit depends on the value set in the <i>dwMessage</i> parameter. See the individual message pages for specifics.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>UINT_PTR</b> This function returns a message-dependent value. For more information, see the Windows SDK documentation for the specific appbar message sent. Links to those documents are given in the See Also section.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern unsafe nuint SHAppBarMessage(uint dwMessage, winmdroot.UI.Shell.APPBARDATA32* pData);

        /// <summary>Sends an appbar message to the system.</summary>
        /// <param name="dwMessage">Type: <b>DWORD</b></param>
        /// <param name="pData">
        /// <para>Type: <b>PAPPBARDATA</b> A pointer to an <a href="https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-appbardata">APPBARDATA</a> structure. The content of the structure on entry and on exit depends on the value set in the <i>dwMessage</i> parameter. See the individual message pages for specifics.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>UINT_PTR</b> This function returns a message-dependent value. For more information, see the Windows SDK documentation for the specific appbar message sent. Links to those documents are given in the See Also section.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern unsafe nuint SHAppBarMessage(uint dwMessage, winmdroot.UI.Shell.APPBARDATA64* pData);

        /// <summary>Sends a message to the taskbar's status area.</summary>
        /// <param name="dwMessage">Type: <b>DWORD</b></param>
        /// <param name="lpData">
        /// <para>Type: <b>PNOTIFYICONDATA</b> A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-notifyicondataa">NOTIFYICONDATA</a> structure. The content of the structure depends on the value of <i>dwMessage</i>. It can define an icon to add to the notification area, cause that icon to display a notification, or identify an icon to modify or delete.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b> Returns <b>TRUE</b> if successful, or <b>FALSE</b> otherwise. If <i>dwMessage</i> is set to NIM_SETVERSION, the function returns <b>TRUE</b> if the version was successfully changed, or <b>FALSE</b> if the requested version is not supported.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true, EntryPoint = "Shell_NotifyIconW")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern unsafe winmdroot.Foundation.BOOL Shell_NotifyIcon(winmdroot.UI.Shell.NOTIFY_ICON_MESSAGE dwMessage, winmdroot.UI.Shell.NOTIFYICONDATAW32* lpData);

        /// <summary>Sends a message to the taskbar's status area.</summary>
        /// <param name="dwMessage">Type: <b>DWORD</b></param>
        /// <param name="lpData">
        /// <para>Type: <b>PNOTIFYICONDATA</b> A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-notifyicondataa">NOTIFYICONDATA</a> structure. The content of the structure depends on the value of <i>dwMessage</i>. It can define an icon to add to the notification area, cause that icon to display a notification, or identify an icon to modify or delete.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b> Returns <b>TRUE</b> if successful, or <b>FALSE</b> otherwise. If <i>dwMessage</i> is set to NIM_SETVERSION, the function returns <b>TRUE</b> if the version was successfully changed, or <b>FALSE</b> if the requested version is not supported.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true, EntryPoint = "Shell_NotifyIconW")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern unsafe winmdroot.Foundation.BOOL Shell_NotifyIcon(winmdroot.UI.Shell.NOTIFY_ICON_MESSAGE dwMessage, winmdroot.UI.Shell.NOTIFYICONDATAW64* lpData);
    }
}