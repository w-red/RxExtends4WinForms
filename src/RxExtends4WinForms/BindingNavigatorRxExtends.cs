using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="BindingNavigator"/></summary>
public static class BindingNavigatorRxExtends
{
    extension(BindingNavigator bn)
    {
        /// <summary><see cref="BindingNavigator.RefreshItems"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RefreshItemsAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bn.RefreshItems += h,
                h => bn.RefreshItems -= h);
    }
}
