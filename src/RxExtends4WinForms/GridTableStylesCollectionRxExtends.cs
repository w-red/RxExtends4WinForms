#if !NETCOREAPP3_1_OR_GREATER
using System.ComponentModel;
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="GridTableStylesCollection"/>.</summary>
public static class GridTableStylesCollectionRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(GridTableStylesCollection gtsc)
    {
        /// <summary><see cref="GridTableStylesCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => gtsc.CollectionChanged += h,
                h => gtsc.CollectionChanged -= h);
    }
#endif
}
