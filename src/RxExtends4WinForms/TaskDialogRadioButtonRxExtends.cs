#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogRadioButton"/>.</summary>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574
#endif
public static class TaskDialogRadioButtonRxExtends
{
#if NET5_0_OR_GREATER
    extension(TaskDialogRadioButton tdrb)
    {
        /// <summary><see cref="TaskDialogRadioButton.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdrb.CheckedChanged += h,
                h => tdrb.CheckedChanged -= h);
    }
#endif
}
