using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DomainUpDown"/>.</summary>
public static class DomainUpDownRxExtends
{
    extension(DomainUpDown dud)
    {
        /// <summary><see cref="DomainUpDown.SelectedItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedItemChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dud.SelectedItemChanged += h,
                h => dud.SelectedItemChanged -= h);
    }
}
