using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridViewRowCollection"/>.</summary>
public static class DataGridViewRowCollectionRxExtends
{
    extension(DataGridViewRowCollection dgvrc)
    {
        /// <summary><see cref="DataGridViewRowCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => dgvrc.CollectionChanged += h,
                h => dgvrc.CollectionChanged -= h);
    }
}
