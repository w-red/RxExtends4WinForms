#if !NETCOREAPP3_1_OR_GREATER
using System.ComponentModel;
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="GridColumnStylesCollection"/>.</summary>
public static class GridColumnStylesCollectionRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(GridColumnStylesCollection gcsc)
    {
        /// <summary><see cref="GridColumnStylesCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => gcsc.CollectionChanged += h,
                h => gcsc.CollectionChanged -= h);
    }
#endif
}
