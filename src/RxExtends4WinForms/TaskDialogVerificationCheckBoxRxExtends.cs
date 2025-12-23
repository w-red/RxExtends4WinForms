#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogVerificationCheckBox"/>.</summary>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574
#endif
public static class TaskDialogVerificationCheckBoxRxExtends
{
#if NET5_0_OR_GREATER
    extension(TaskDialogVerificationCheckBox tdvcb)
    {
        /// <summary><see cref="TaskDialogVerificationCheckBox.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdvcb.CheckedChanged += h,
                h => tdvcb.CheckedChanged -= h);
    }
#endif
}
