using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripButton"/>.</summary>
public static class ToolStripButtonRxExtends
{
    extension(ToolStripButton tsb)
    {
        /// <summary><see cref="ToolStripButton.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsb.CheckedChanged += h,
                h => tsb.CheckedChanged -= h);

        /// <summary><see cref="ToolStripButton.CheckStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckStateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsb.CheckStateChanged += h,
                h => tsb.CheckStateChanged -= h);
    }
}
