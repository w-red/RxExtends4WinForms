using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="CurrencyManager"/>.</summary>
public static class CurrencyManagerRxExtends
{
    extension(CurrencyManager cm)
    {
        /// <summary><see cref="CurrencyManager.ItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ItemChangedEventArgs> ItemChangedAsObservable() =>
            Observable.FromEvent<ItemChangedEventHandler, ItemChangedEventArgs>(
                h => (s, e) => h(e),
                h => cm.ItemChanged += h,
                h => cm.ItemChanged -= h);

        /// <summary><see cref="CurrencyManager.ListChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ListChangedEventArgs> ListChangedAsObservable() =>
            Observable.FromEvent<ListChangedEventHandler, ListChangedEventArgs>(
                h => (s, e) => h(e),
                h => cm.ListChanged += h,
                h => cm.ListChanged -= h);

        /// <summary><see cref="CurrencyManager.MetaDataChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MetaDataChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cm.MetaDataChanged += h,
                h => cm.MetaDataChanged -= h);
    }
}
