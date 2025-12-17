using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="ButtonBase"/></summary>
public static class ButtonBaseRxExtends
{
    extension(ButtonBase bb)
    {
        /// <summary><see cref="ButtonBase.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bb.AutoSizeChanged += h,
                h => bb.AutoSizeChanged -= h);

#if NET7_0_OR_GREATER
        /// <summary><see cref="ButtonBase.CommandCanExecuteChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandCanExecuteChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bb.CommandCanExecuteChanged += h,
                h => bb.CommandCanExecuteChanged -= h);

        /// <summary><see cref="ButtonBase.CommandChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bb.CommandChanged += h,
                h => bb.CommandChanged -= h);

        /// <summary><see cref="ButtonBase.CommandParameterChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandParameterChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bb.CommandParameterChanged += h,
                h => bb.CommandParameterChanged -= h);
#endif
    }
}
