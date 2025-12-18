using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DateTimePicker"/>.</summary>
public static class DateTimePickerRxExtends
{
    extension(DateTimePicker dtp)
    {
        /// <summary><see cref="DateTimePicker.CloseUp"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CloseUpAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.CloseUp += h,
                h => dtp.CloseUp -= h);

        /// <summary><see cref="DateTimePicker.DropDown"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.DropDown += h,
                h => dtp.DropDown -= h);

        /// <summary><see cref="DateTimePicker.FormatChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormatChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.FormatChanged += h,
                h => dtp.FormatChanged -= h);

        /// <summary><see cref="DateTimePicker.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.RightToLeftLayoutChanged += h,
                h => dtp.RightToLeftLayoutChanged -= h);

        /// <summary><see cref="DateTimePicker.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.TextChanged += h,
                h => dtp.TextChanged -= h);

        /// <summary><see cref="DateTimePicker.ValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dtp.ValueChanged += h,
                h => dtp.ValueChanged -= h);
    }
}
