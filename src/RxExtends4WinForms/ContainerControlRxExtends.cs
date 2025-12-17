using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ContainerControl"/>.</summary>
public static class ContainerControlRxExtends
{
    extension(ContainerControl cc)
    {
        /// <summary><see cref="ContainerControl.AutoValidateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoValidateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cc.AutoValidateChanged += h,
                h => cc.AutoValidateChanged -= h);
    }
}
