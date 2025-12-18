#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ContextMenu"/>.</summary>
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
