using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="BindingsCollection"/>.</summary>
public static class BindingsCollectionRxExtends
{
    extension(BindingsCollection bc)
    {
        /// <summary><see cref="BindingsCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => bc.CollectionChanged += h,
                h => bc.CollectionChanged -= h);

        /// <summary><see cref="BindingsCollection.CollectionChanging"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangingAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => bc.CollectionChanging += h,
                h => bc.CollectionChanging -= h);
    }
}

