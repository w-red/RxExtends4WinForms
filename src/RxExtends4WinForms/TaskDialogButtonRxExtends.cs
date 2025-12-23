#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogButton"/>.</summary>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574
#endif
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
