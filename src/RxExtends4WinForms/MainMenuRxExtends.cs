#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="MainMenu"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class MainMenuRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(MainMenu mm)
    {
        /// <summary><see cref="MainMenu.Collapse"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CollapseAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mm.Collapse += h,
                h => mm.Collapse -= h);
    }
#endif
}
