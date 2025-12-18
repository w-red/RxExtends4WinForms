using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ListControl"/>.</summary>
public static class ListControlRxExtends
{
    extension(ListControl lc)
    {
        /// <summary><see cref="ListControl.DataSourceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataSourceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.DataSourceChanged += h,
                h => lc.DataSourceChanged -= h);

        /// <summary><see cref="ListControl.DisplayMemberChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DisplayMemberChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.DisplayMemberChanged += h,
                h => lc.DisplayMemberChanged -= h);

        /// <summary><see cref="ListControl.FormatInfoChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormatInfoChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormatInfoChanged += h,
                h => lc.FormatInfoChanged -= h);

        /// <summary><see cref="ListControl.FormatStringChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormatStringChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormatStringChanged += h,
                h => lc.FormatStringChanged -= h);

        /// <summary><see cref="ListControl.FormattingEnabledChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormattingEnabledChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormattingEnabledChanged += h,
                h => lc.FormattingEnabledChanged -= h);

        /// <summary><see cref="ListControl.Format"/> as <see cref="Observable"/></summary>
        public IObservable<ListControlConvertEventArgs> FormatAsObservable() =>
            Observable.FromEvent<ListControlConvertEventHandler, ListControlConvertEventArgs>(
                h => (s, e) => h(e),
                h => lc.Format += h,
                h => lc.Format -= h);

        /// <summary><see cref="ListControl.SelectedValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.SelectedValueChanged += h,
                h => lc.SelectedValueChanged -= h);

        /// <summary><see cref="ListControl.ValueMemberChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValueMemberChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.ValueMemberChanged += h,
                h => lc.ValueMemberChanged -= h);
    }
}
