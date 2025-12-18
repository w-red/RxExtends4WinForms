using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="NotifyIcon"/>.</summary>
public static class NotifyIconRxExtends
{
    extension(NotifyIcon ni)
    {
        /// <summary><see cref="NotifyIcon.BalloonTipClicked"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BalloonTipClickedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ni.BalloonTipClicked += h,
                h => ni.BalloonTipClicked -= h);

        /// <summary><see cref="NotifyIcon.BalloonTipClosed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BalloonTipClosedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ni.BalloonTipClosed += h,
                h => ni.BalloonTipClosed -= h);

        /// <summary><see cref="NotifyIcon.BalloonTipShown"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BalloonTipShownAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ni.BalloonTipShown += h,
                h => ni.BalloonTipShown -= h);

        /// <summary><see cref="NotifyIcon.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ni.Click += h,
                h => ni.Click -= h);

        /// <summary><see cref="NotifyIcon.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ni.DoubleClick += h,
                h => ni.DoubleClick -= h);

        /// <summary><see cref="NotifyIcon.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ni.MouseClick += h,
                h => ni.MouseClick -= h);

        /// <summary><see cref="NotifyIcon.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDoubleClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ni.MouseDoubleClick += h,
                h => ni.MouseDoubleClick -= h);

        /// <summary><see cref="NotifyIcon.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ni.MouseDown += h,
                h => ni.MouseDown -= h);

        /// <summary><see cref="NotifyIcon.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ni.MouseMove += h,
                h => ni.MouseMove -= h);

        /// <summary><see cref="NotifyIcon.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ni.MouseUp += h,
                h => ni.MouseUp -= h);
    }
}
