using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindableComponent"/></summary>
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
