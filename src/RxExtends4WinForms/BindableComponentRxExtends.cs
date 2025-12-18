#if NET7_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindableComponent"/></summary>
public static class BindableComponentRxExtends
{
#if NET7_0_OR_GREATER
    extension(BindableComponent bc)
    {
        /// <summary><see cref="BindableComponent.BindingContextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BindingContextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bc.BindingContextChanged += h,
                h => bc.BindingContextChanged -= h);
    }
#endif
}
