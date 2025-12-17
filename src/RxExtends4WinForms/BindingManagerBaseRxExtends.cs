using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindingManagerBase"/></summary>
public static class BindingManagerBaseRxExtends
{
    extension(BindingManagerBase bmb)
    {
        /// <summary><see cref="BindingManagerBase.BindingComplete"/> as <see cref="Observable"/></summary>
        public IObservable<BindingCompleteEventArgs> BindingCompleteAsObservable() =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bmb.BindingComplete += h,
                h => bmb.BindingComplete -= h);

        /// <summary><see cref="BindingManagerBase.CurrentChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentChanged += h,
                h => bmb.CurrentChanged -= h);

        /// <summary><see cref="BindingManagerBase.CurrentItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentItemChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentItemChanged += h,
                h => bmb.CurrentItemChanged -= h);

        /// <summary><see cref="BindingManagerBase.DataError"/> as <see cref="Observable"/></summary>
        public IObservable<BindingManagerDataErrorEventArgs> DataErrorAsObservable() =>
            Observable.FromEvent<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => bmb.DataError += h,
                h => bmb.DataError -= h);

        /// <summary><see cref="BindingManagerBase.PositionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PositionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.PositionChanged += h,
                h => bmb.PositionChanged -= h);
    }
}
