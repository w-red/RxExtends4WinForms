using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="GridColumnStylesCollection"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
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
