using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="CheckedListBox"/>.</summary>
public static class CheckedListBoxRxExtends
{
    extension(CheckedListBox clb)
    {
        /// <summary><see cref="CheckedListBox.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => clb.Click += h,
                h => clb.Click -= h);

        /// <summary><see cref="CheckedListBox.ItemCheck"/> as <see cref="Observable"/></summary>
        public IObservable<ItemCheckEventArgs> ItemCheckAsObservable() =>
            Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(
                h => (s, e) => h(e),
                h => clb.ItemCheck += h,
                h => clb.ItemCheck -= h);

        /// <summary><see cref="CheckedListBox.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => clb.MouseClick += h,
                h => clb.MouseClick -= h);
    }
}
