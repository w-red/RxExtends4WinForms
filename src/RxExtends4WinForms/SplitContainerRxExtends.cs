using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="SplitContainer"/>.</summary>
public static class SplitContainerRxExtends
{
    extension(SplitContainer sc)
    {
        /// <summary><see cref="SplitContainer.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => sc.BackgroundImageChanged += h,
                h => sc.BackgroundImageChanged -= h);

        /// <summary><see cref="SplitContainer.SplitterMoved"/> as <see cref="Observable"/></summary>
        public IObservable<SplitterEventArgs> SplitterMovedAsObservable() =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => sc.SplitterMoved += h,
                h => sc.SplitterMoved -= h);

        /// <summary><see cref="SplitContainer.SplitterMoving"/> as <see cref="Observable"/></summary>
        public IObservable<SplitterCancelEventArgs> SplitterMovingAsObservable() =>
            Observable.FromEvent<SplitterCancelEventHandler, SplitterCancelEventArgs>(
                h => (s, e) => h(e),
                h => sc.SplitterMoving += h,
                h => sc.SplitterMoving -= h);
    }
}
