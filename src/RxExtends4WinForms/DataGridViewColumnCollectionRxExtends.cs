using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridViewColumnCollection"/>.</summary>
public static class DataGridViewColumnCollectionRxExtends
{
    extension(DataGridViewColumnCollection dgvcc)
    {
        /// <summary><see cref="DataGridViewColumnCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => dgvcc.CollectionChanged += h,
                h => dgvcc.CollectionChanged -= h);
    }
}

