using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ProgressBar"/>.</summary>
public static class ProgressBarRxExtends
{
    extension(ProgressBar ss)
    {
        /// <summary><see cref="ProgressBar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ss.RightToLeftLayoutChanged += h,
                h => ss.RightToLeftLayoutChanged -= h);
    }
}
