using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Panel"/>.</summary>
public static class PanelRxExtends
{
    extension(Panel p)
    {
        /// <summary><see cref="Panel.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => p.AutoSizeChanged += h,
                h => p.AutoSizeChanged -= h);
    }
}
