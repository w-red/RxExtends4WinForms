using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TrackBar"/>.</summary>
public static class TrackBarRxExtends
{
    extension(TrackBar tb)
    {
        /// <summary><see cref="TrackBar.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.AutoSizeChanged += h,
                h => tb.AutoSizeChanged -= h);

        /// <summary><see cref="TrackBar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.RightToLeftLayoutChanged += h,
                h => tb.RightToLeftLayoutChanged -= h);

        /// <summary><see cref="TrackBar.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ScrollAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.Scroll += h,
                h => tb.Scroll -= h);

        /// <summary><see cref="TrackBar.ValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.ValueChanged += h,
                h => tb.ValueChanged -= h);
    }
}
