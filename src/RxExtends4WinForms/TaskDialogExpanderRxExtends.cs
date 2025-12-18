#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogExpander"/>.</summary>
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
