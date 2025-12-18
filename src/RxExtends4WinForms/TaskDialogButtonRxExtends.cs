#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogButton"/>.</summary>
public static class TaskDialogButtonRxExtends
{
#if NET5_0_OR_GREATER
    extension(TaskDialogButton tdb)
    {
        /// <summary><see cref="TaskDialogButton.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdb.Click += h,
                h => tdb.Click -= h);
    }
#endif
}
