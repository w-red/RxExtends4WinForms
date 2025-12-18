using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ListBox"/>.</summary>
public static class ListBoxRxExtends
{
    extension(ListBox lb)
    {
        /// <summary><see cref="ListBox.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.Click += h,
                h => lb.Click -= h);

        /// <summary><see cref="ListBox.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => lb.DrawItem += h,
                h => lb.DrawItem -= h);

        /// <summary><see cref="ListBox.MeasureItem"/> as <see cref="Observable"/></summary>
        public IObservable<MeasureItemEventArgs> MeasureItemAsObservable() =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => lb.MeasureItem += h,
                h => lb.MeasureItem -= h);

        /// <summary><see cref="ListBox.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => lb.MouseClick += h,
                h => lb.MouseClick -= h);

        /// <summary><see cref="ListBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.SelectedIndexChanged += h,
                h => lb.SelectedIndexChanged -= h);

        /// <summary><see cref="ListBox.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.TextChanged += h,
                h => lb.TextChanged -= h);
    }
}
