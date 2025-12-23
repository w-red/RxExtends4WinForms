#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogExpander"/>.</summary>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574
#endif
public static class TaskDialogExpanderRxExtends
{
#if NET5_0_OR_GREATER
    extension(TaskDialogExpander tde)
    {
        /// <summary><see cref="TaskDialogExpander.ExpandedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ExpandedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tde.ExpandedChanged += h,
                h => tde.ExpandedChanged -= h);
    }
#endif
}
