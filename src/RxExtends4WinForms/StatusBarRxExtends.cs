#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="StatusBar"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class StatusBarRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(StatusBar sb)
    {
        /// <summary><see cref="StatusBar.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<StatusBarDrawItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<StatusBarDrawItemEventHandler, StatusBarDrawItemEventArgs>(
                h => (s, e) => h(e),
                h => sb.DrawItem += h,
                h => sb.DrawItem -= h);

        /// <summary><see cref="StatusBar.PanelClick"/> as <see cref="Observable"/></summary>
        public IObservable<StatusBarPanelClickEventArgs> PanelClickAsObservable() =>
            Observable.FromEvent<StatusBarPanelClickEventHandler, StatusBarPanelClickEventArgs>(
                h => (s, e) => h(e),
                h => sb.PanelClick += h,
                h => sb.PanelClick -= h);
    }
#endif
}
