using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TabPage"/>.</summary>
public static class TabPageRxExtends
{
    extension(TabPage tp)
    {
        /// <summary><see cref="TabPage.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tp.TextChanged += h,
                h => tp.TextChanged -= h);
    }
}
