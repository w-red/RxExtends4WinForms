using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripProgressBar"/>.</summary>
public static class ToolStripProgressBarRxExtends
{
    extension(ToolStripProgressBar tspb)
    {
        /// <summary><see cref="ToolStripProgressBar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tspb.RightToLeftLayoutChanged += h,
                h => tspb.RightToLeftLayoutChanged -= h);
    }
}
