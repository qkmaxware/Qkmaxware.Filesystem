namespace System.IO {

/// <summary>
/// Qkmaxware.Filesystem extensions for DirectoryInfo objects
/// </summary>
public static class QkmaxwareDirectoryInfoExtensions {
    /// <summary>
    /// Tries to open the OS file explorer to the directory
    /// </summary>
    /// <param name="dir">directory to show in explorer</param>
    public static void TryShowInExplorer(this DirectoryInfo dir) {
        if (System.Environment.OSVersion.Platform == PlatformID.Win32NT) {
            System.Diagnostics.Process.Start("explorer.exe", dir.FullName);
        } else {
            if (dir.Parent != null) {
                System.Diagnostics.Process.Start("mimeopen", dir.Parent.FullName);
            }
        }
    }
}

}