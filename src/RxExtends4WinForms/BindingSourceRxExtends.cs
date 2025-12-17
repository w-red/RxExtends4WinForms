using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindingSource"/></summary>
public static class BindingSourceRxExtends
{
    extension(BindingSource bs)
    {
        /// <summary><see cref="BindingSource.AddingNew"/> as <see cref="Observable"/></summary>
        public IObservable<AddingNewEventArgs> AddingNewAsObservable() =>
            Observable.FromEvent<AddingNewEventHandler, AddingNewEventArgs>(
                h => (s, e) => h(e),
                h => bs.AddingNew += h,
                h => bs.AddingNew -= h);

        /// <summary><see cref="BindingSource.BindingComplete"/> as <see cref="Observable"/></summary>
        public IObservable<BindingCompleteEventArgs> BindingCompleteAsObservable() =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bs.BindingComplete += h,
                h => bs.BindingComplete -= h);

        /// <summary><see cref="BindingSource.CurrentChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bs.CurrentChanged += h,
                h => bs.CurrentChanged -= h);

        /// <summary><see cref="BindingSource.CurrentItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentItemChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bs.CurrentItemChanged += h,
                h => bs.CurrentItemChanged -= h);

        /// <summary><see cref="BindingSource.DataError"/> as <see cref="Observable"/></summary>
        public IObservable<BindingManagerDataErrorEventArgs> DataErrorAsObservable() =>
            Observable.FromEvent<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => bs.DataError += h,
                h => bs.DataError -= h);

        /// <summary><see cref="BindingSource.DataMemberChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataMemberChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bs.DataMemberChanged += h,
                h => bs.DataMemberChanged -= h);

        /// <summary><see cref="BindingSource.DataSourceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataSourceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bs.DataSourceChanged += h,
                h => bs.DataSourceChanged -= h);

        /// <summary><see cref="BindingSource.ListChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ListChangedEventArgs> ListChangedAsObservable() =>
            Observable.FromEvent<ListChangedEventHandler, ListChangedEventArgs>(
                h => (s, e) => h(e),
                h => bs.ListChanged += h,
                h => bs.ListChanged -= h);

        /// <summary><see cref="BindingSource.PositionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PositionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bs.PositionChanged += h,
                h => bs.PositionChanged -= h);
    }
}
