using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="UpDownBase"/>.</summary>
public static class UpDownBaseRxExtends
{
    extension(UpDownBase udb)
    {
        /// <summary><see cref="UpDownBase.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.AutoSizeChanged += h,
                h => udb.AutoSizeChanged -= h);

        /// <summary><see cref="UpDownBase.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.BackgroundImageChanged += h,
                h => udb.BackgroundImageChanged -= h);

        /// <summary><see cref="UpDownBase.BackgroundImageLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.BackgroundImageLayoutChanged += h,
                h => udb.BackgroundImageLayoutChanged -= h);

        /// <summary><see cref="UpDownBase.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseEnter += h,
                h => udb.MouseEnter -= h);

        /// <summary><see cref="UpDownBase.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseLeave += h,
                h => udb.MouseLeave -= h);

        /// <summary><see cref="UpDownBase.MouseHover"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseHoverAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseHover += h,
                h => udb.MouseHover -= h);

        /// <summary><see cref="UpDownBase.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseMove += h,
                h => udb.MouseMove -= h);
    }
}
