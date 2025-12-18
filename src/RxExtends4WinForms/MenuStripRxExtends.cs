using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="MenuStrip"/>.</summary>
public static class MenuStripRxExtends
{
    extension(MenuStrip ms)
    {
        /// <summary><see cref="MenuStrip.MenuActivate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MenuActivateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ms.MenuActivate += h,
                h => ms.MenuActivate -= h);

        /// <summary><see cref="MenuStrip.MenuDeactivate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MenuDeactivateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ms.MenuDeactivate += h,
                h => ms.MenuDeactivate -= h);
    }
}
