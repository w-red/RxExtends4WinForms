#if !NETCOREAPP3_1_OR_GREATER
using System.ComponentModel;
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="GridTableStylesCollection"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
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
