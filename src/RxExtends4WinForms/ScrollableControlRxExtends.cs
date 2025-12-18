using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ScrollableControl"/>.</summary>
public static class ScrollableControlRxExtends
{
    extension(ScrollableControl sc)
    {
        /// <summary><see cref="ScrollableControl.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<ScrollEventArgs> ScrollAsObservable() =>
            Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
                h => (s, e) => h(e),
                h => sc.Scroll += h,
                h => sc.Scroll -= h);
    }
}
