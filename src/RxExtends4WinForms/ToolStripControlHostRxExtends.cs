using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripControlHost"/>.</summary>
public static class ToolStripControlHostRxExtends
{
    extension(ToolStripControlHost tsch)
    {
        /// <summary><see cref="ToolStripControlHost.Enter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Enter += h,
                h => tsch.Enter -= h);

        /// <summary><see cref="ToolStripControlHost.Leave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Leave += h,
                h => tsch.Leave -= h);

        /// <summary><see cref="ToolStripControlHost.GotFocus"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> GotFocusAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.GotFocus += h,
                h => tsch.GotFocus -= h);

        /// <summary><see cref="ToolStripControlHost.LostFocus"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LostFocusAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.LostFocus += h,
                h => tsch.LostFocus -= h);

        /// <summary><see cref="ToolStripControlHost.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyDown += h,
                h => tsch.KeyDown -= h);

        /// <summary><see cref="ToolStripControlHost.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyUp += h,
                h => tsch.KeyUp -= h);

        /// <summary><see cref="ToolStripControlHost.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<KeyPressEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyPress += h,
                h => tsch.KeyPress -= h);

        /// <summary><see cref="ToolStripControlHost.Validated"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValidatedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Validated += h,
                h => tsch.Validated -= h);

        /// <summary><see cref="ToolStripControlHost.Validating"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> ValidatingAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => tsch.Validating += h,
                h => tsch.Validating -= h);
    }
}
