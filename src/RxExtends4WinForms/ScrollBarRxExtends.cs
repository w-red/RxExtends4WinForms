using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ScrollBar"/>.</summary>
public static class ScrollBarRxExtends
{
    extension(ScrollBar sb)
    {
        /// <summary><see cref="ScrollBar.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<ScrollEventArgs> ScrollAsObservable() =>
            Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
                h => (s, e) => h(e),
                h => sb.Scroll += h,
                h => sb.Scroll -= h);

        /// <summary><see cref="ScrollBar.ValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => sb.ValueChanged += h,
                h => sb.ValueChanged -= h);
    }
}
