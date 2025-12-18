using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="MonthCalendar"/>.</summary>
public static class MonthCalendarRxExtends
{
    extension(MonthCalendar mc)
    {
        /// <summary><see cref="MonthCalendar.DateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DateRangeEventArgs> DateChangedAsObservable() =>
            Observable.FromEvent<DateRangeEventHandler, DateRangeEventArgs>(
                h => (s, e) => h(e),
                h => mc.DateChanged += h,
                h => mc.DateChanged -= h);

        /// <summary><see cref="MonthCalendar.DateSelected"/> as <see cref="Observable"/></summary>
        public IObservable<DateRangeEventArgs> DateSelectedAsObservable() =>
            Observable.FromEvent<DateRangeEventHandler, DateRangeEventArgs>(
                h => (s, e) => h(e),
                h => mc.DateSelected += h,
                h => mc.DateSelected -= h);

        /// <summary><see cref="MonthCalendar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mc.RightToLeftLayoutChanged += h,
                h => mc.RightToLeftLayoutChanged -= h);
    }
}
