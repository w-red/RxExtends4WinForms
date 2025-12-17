using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="ApplicationContext"/></summary>
public static class ApplicationContextRxExtends
{
    extension(ApplicationContext ac)
    {
        /// <summary>Converts the <see cref="ApplicationContext.ThreadExit"/> event to an observable sequence</summary>
        public IObservable<EventArgs> ThreadExitAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ac.ThreadExit += h,
                h => ac.ThreadExit -= h);
    }
}
