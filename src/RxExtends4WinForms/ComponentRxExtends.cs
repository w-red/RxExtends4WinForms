using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Component"/>.</summary>
public static class ComponentRxExtends
{
    extension(Component c)
    {
        /// <summary><see cref="Component.Disposed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DisposedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => c.Disposed += h,
                h => c.Disposed -= h);
    }
}
