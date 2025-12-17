using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="CheckBox"/>.</summary>
public static class CheckBoxRxExtends
{
    extension(CheckBox cb)
    {
        /// <summary><see cref="CheckBox.AppearanceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AppearanceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.AppearanceChanged += h,
                h => cb.AppearanceChanged -= h);

        /// <summary><see cref="CheckBox.CheckedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.CheckedChanged += h,
                h => cb.CheckedChanged -= h);

        /// <summary><see cref="CheckBox.CheckStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CheckStateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.CheckStateChanged += h,
                h => cb.CheckStateChanged -= h);
    }
}
