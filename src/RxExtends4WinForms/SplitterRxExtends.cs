using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Splitter"/>.</summary>
public static class SplitterRxExtends
{
    extension(Splitter s)
    {
        /// <summary><see cref="Splitter.SplitterMoved"/> as <see cref="Observable"/></summary>
        public IObservable<SplitterEventArgs> SplitterMovedAsObservable() =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => s.SplitterMoved += h,
                h => s.SplitterMoved -= h);

        /// <summary><see cref="Splitter.SplitterMoving"/> as <see cref="Observable"/></summary>
        public IObservable<SplitterEventArgs> SplitterMovingAsObservable() =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => s.SplitterMoving += h,
                h => s.SplitterMoving -= h);
    }
}
