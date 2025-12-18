using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripMenuItem"/>.</summary>
public static class ToolStripMenuItemRxExtends
{
    extension(ToolStripMenuItem tsmi)
    {
        /// <summary><see cref="ToolStripMenuItem.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsmi.CheckedChanged += h,
                h => tsmi.CheckedChanged -= h);

        /// <summary><see cref="ToolStripMenuItem.CheckStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckStateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsmi.CheckStateChanged += h,
                h => tsmi.CheckStateChanged -= h);
    }
}
