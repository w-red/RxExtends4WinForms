using System.Reactive.Linq;

namespace RxExtends4WinForms;
#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ContextMenu"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class ContextMenuRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(ContextMenu cm)
    {
        /// <summary><see cref="ContextMenu.Collapse"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CollapseAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cm.Collapse += h,
                h => cm.Collapse -= h);

        /// <summary><see cref="ContextMenu.Popup"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PopupAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cm.Popup += h,
                h => cm.Popup -= h);
    }
#endif
}
