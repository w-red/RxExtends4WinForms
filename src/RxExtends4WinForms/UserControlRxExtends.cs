using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="UserControl"/>.</summary>
public static class UserControlRxExtends
{
    extension(UserControl uc)
    {
        /// <summary><see cref="UserControl.Load"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LoadAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.Load += h,
                h => uc.Load -= h);

        /// <summary><see cref="UserControl.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.AutoValidateChanged += h,
                h => uc.AutoValidateChanged -= h);

        /// <summary><see cref="UserControl.AutoValidateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoValidateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.AutoValidateChanged += h,
                h => uc.AutoValidateChanged -= h);

        /// <summary><see cref="UserControl.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.TextChanged += h,
                h => uc.TextChanged -= h);
    }
}
