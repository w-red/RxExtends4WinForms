using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="StatusStrip"/>.</summary>
public static class StatusStripRxExtends
{
    extension(StatusStrip ss)
    {
        /// <summary><see cref="StatusStrip.PaddingChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PaddingChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ss.PaddingChanged += h,
                h => ss.PaddingChanged -= h);
    }
}
