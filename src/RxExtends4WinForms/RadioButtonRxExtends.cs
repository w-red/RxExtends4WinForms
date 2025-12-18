using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="RadioButton"/>.</summary>
public static class RadioButtonRxExtends
{
    extension(RadioButton rb)
    {
        /// <summary><see cref="RadioButton.AppearanceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AppearanceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rb.AppearanceChanged += h,
                h => rb.AppearanceChanged -= h);

        /// <summary><see cref="RadioButton.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rb.CheckedChanged += h,
                h => rb.CheckedChanged -= h);
    }
}
