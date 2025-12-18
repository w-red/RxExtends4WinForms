using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ErrorProvider"/>.</summary>
public static class ErrorProviderRxExtends
{
    extension(ErrorProvider ep)
    {
        /// <summary><see cref="ErrorProvider.RightToLeftChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ep.RightToLeftChanged += h,
                h => ep.RightToLeftChanged -= h);
    }
}
