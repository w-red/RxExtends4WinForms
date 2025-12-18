using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="GroupBox"/>.</summary>
public static class GroupBoxRxExtends
{
    extension(GroupBox gb)
    {
        /// <summary><see cref="GroupBox.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.AutoSizeChanged += h,
                h => gb.AutoSizeChanged -= h);

        /// <summary><see cref="GroupBox.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.Click += h,
                h => gb.Click -= h);

        /// <summary><see cref="GroupBox.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.DoubleClick += h,
                h => gb.DoubleClick -= h);

        /// <summary><see cref="GroupBox.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyDown += h,
                h => gb.KeyDown -= h);

        /// <summary><see cref="GroupBox.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyUp += h,
                h => gb.KeyUp -= h);

        /// <summary><see cref="GroupBox.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<KeyPressEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyPress += h,
                h => gb.KeyPress -= h);

        /// <summary><see cref="GroupBox.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseClick += h,
                h => gb.MouseClick -= h);

        /// <summary><see cref="GroupBox.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDoubleClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseDoubleClick += h,
                h => gb.MouseDoubleClick -= h);

        /// <summary><see cref="GroupBox.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseDown += h,
                h => gb.MouseDown -= h);

        /// <summary><see cref="GroupBox.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseUp += h,
                h => gb.MouseUp -= h);

        /// <summary><see cref="GroupBox.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseEnter += h,
                h => gb.MouseEnter -= h);

        /// <summary><see cref="GroupBox.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseLeave += h,
                h => gb.MouseLeave -= h);

        /// <summary><see cref="GroupBox.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseMove += h,
                h => gb.MouseMove -= h);

        /// <summary><see cref="GroupBox.TabStopChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TabStopChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.TabStopChanged += h,
                h => gb.TabStopChanged -= h);
    }
}
