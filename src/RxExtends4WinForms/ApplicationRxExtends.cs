using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="Application"/></summary>
public static class ApplicationRxExtends
{
    extension(Application app)
    {
        /// <summary>Converts the <see cref="Application.ApplicationExit"/> event as <see cref="Observable"/></summary>
        public static IObservable<EventArgs> ApplicationExitAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.ApplicationExit += h,
                h => Application.ApplicationExit -= h);

        /// <summary>Converts the <see cref="Application.EnterThreadModal"/> event as <see cref="Observable"/></summary>
        public static IObservable<EventArgs> EnterThreadModalAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.EnterThreadModal += h,
                h => Application.EnterThreadModal -= h);

        /// <summary>Converts the <see cref="Application.Idle"/> event as <see cref="Observable"/></summary>
        public static IObservable<EventArgs> IdleAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.Idle += h,
                h => Application.Idle -= h);

        /// <summary>Converts the <see cref="Application.LeaveThreadModal"/> event as <see cref="Observable"/></summary>
        public static IObservable<EventArgs> LeaveThreadModalAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.LeaveThreadModal += h,
                h => Application.LeaveThreadModal -= h);

        /// <summary>Converts the <see cref="Application.ThreadException"/> event as <see cref="Observable"/></summary>
        public static IObservable<ThreadExceptionEventArgs> ThreadExceptionAsObservable() =>
            Observable.FromEvent<ThreadExceptionEventHandler, ThreadExceptionEventArgs>(
                h => (s, e) => h(e),
                h => Application.ThreadException += h,
                h => Application.ThreadException -= h);

        /// <summary>Converts the <see cref="Application.ThreadExit"/> event as <see cref="Observable"/></summary>
        public static IObservable<EventArgs> ThreadExitAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.ThreadExit += h,
                h => Application.ThreadExit -= h);
    }
}
