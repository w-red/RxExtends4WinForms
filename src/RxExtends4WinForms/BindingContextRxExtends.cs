using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

#if !NET7_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindableComponent"/></summary>
#if !NET7_0_OR_GREATER
#pragma warning restore CS1574
#endif
public static class BindingContextRxExtends
{
    extension(BindingContext bc)
    {
        /// <summary><see cref="BindingContext.CollectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<CollectionChangeEventArgs> CollectionChangedAsObservable() =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => bc.CollectionChanged += h,
                h => bc.CollectionChanged -= h);
    }
}
