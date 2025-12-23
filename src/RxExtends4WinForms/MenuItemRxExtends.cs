#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="MenuItem"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class MenuItemRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(MenuItem mi)
    {
        /// <summary><see cref="MenuItem.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Click += h,
                h => mi.Click -= h);

        /// <summary><see cref="MenuItem.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => mi.DrawItem += h,
                h => mi.DrawItem -= h);

        /// <summary><see cref="MenuItem.MeasureItem"/> as <see cref="Observable"/></summary>
        public IObservable<MeasureItemEventArgs> MeasureItemAsObservable() =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => mi.MeasureItem += h,
                h => mi.MeasureItem -= h);

        /// <summary><see cref="MenuItem.Popup"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PopupAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Popup += h,
                h => mi.Popup -= h);

        /// <summary><see cref="MenuItem.Select"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Select += h,
                h => mi.Select -= h);
    }
#endif
}
