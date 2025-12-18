using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="FileDialog"/>.</summary>
public static class FileDialogRxExtends
{
    extension(FileDialog fd)
    {
        /// <summary><see cref="FileDialog.FileOk"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> FileOkAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => fd.FileOk += h,
                h => fd.FileOk -= h);
    }
}

