using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="AutoCompleteStringCollection"/></summary>
public static class AutoCompleteStringCollectionRxExtends
{
    extension(AutoCompleteStringCollection acsc)
    {
        /// <summary>Converts the <see cref="AutoCompleteStringCollection.CollectionChanged"/> event as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => acsc.CollectionChanged += h,
                h => acsc.CollectionChanged -= h);
    }
}
