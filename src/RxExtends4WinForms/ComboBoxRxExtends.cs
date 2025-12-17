using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ComboBox"/>.</summary>
public static class ComboBoxRxExtends
{
    extension(ComboBox cb)
    {
        /// <summary><see cref="ComboBox.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => cb.DrawItem += h,
                h => cb.DrawItem -= h);

        /// <summary><see cref="ComboBox.DropDownClosed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownClosedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDownClosed += h,
                h => cb.DropDownClosed -= h);

        /// <summary><see cref="ComboBox.DropDownStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDownStyleChanged += h,
                h => cb.DropDownStyleChanged -= h);

        /// <summary><see cref="ComboBox.DropDown"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDown += h,
                h => cb.DropDown -= h);

        /// <summary><see cref="ComboBox.MeasureItem"/> as <see cref="Observable"/></summary>
        public IObservable<MeasureItemEventArgs> MeasureItemAsObservable() =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => cb.MeasureItem += h,
                h => cb.MeasureItem -= h);

        /// <summary><see cref="ComboBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.SelectedIndexChanged += h,
                h => cb.SelectedIndexChanged -= h);

        /// <summary><see cref="ComboBox.SelectionChangeCommitted"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectionChangeCommittedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.SelectionChangeCommitted += h,
                h => cb.SelectionChangeCommitted -= h);

        /// <summary><see cref="ComboBox.TextUpdate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextUpdateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.TextUpdate += h,
                h => cb.TextUpdate -= h);
    }
}
