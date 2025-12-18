using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TabControl"/>.</summary>
public static class TabControlRxExtends
{
    extension(TabControl tc)
    {
        /// <summary><see cref="TabControl.Deselected"/> as <see cref="Observable"/></summary>
        public IObservable<TabControlEventArgs> DeselectedAsObservable() =>
            Observable.FromEvent<TabControlEventHandler, TabControlEventArgs>(
                h => (s, e) => h(e),
                h => tc.Deselected += h,
                h => tc.Deselected -= h);

        /// <summary><see cref="TabControl.Deselecting"/> as <see cref="Observable"/></summary>
        public IObservable<TabControlCancelEventArgs> DeselectingAsObservable() =>
            Observable.FromEvent<TabControlCancelEventHandler, TabControlCancelEventArgs>(
                h => (s, e) => h(e),
                h => tc.Deselecting += h,
                h => tc.Deselecting -= h);

        /// <summary><see cref="TabControl.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => tc.DrawItem += h,
                h => tc.DrawItem -= h);

        /// <summary><see cref="TabControl.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tc.RightToLeftLayoutChanged += h,
                h => tc.RightToLeftLayoutChanged -= h);

        /// <summary><see cref="TabControl.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tc.SelectedIndexChanged += h,
                h => tc.SelectedIndexChanged -= h);

        /// <summary><see cref="TabControl.Selected"/> as <see cref="Observable"/></summary>
        public IObservable<TabControlEventArgs> SelectedAsObservable() =>
            Observable.FromEvent<TabControlEventHandler, TabControlEventArgs>(
                h => (s, e) => h(e),
                h => tc.Selected += h,
                h => tc.Selected -= h);

        /// <summary><see cref="TabControl.Selecting"/> as <see cref="Observable"/></summary>
        public IObservable<TabControlCancelEventArgs> SelectingAsObservable() =>
            Observable.FromEvent<TabControlCancelEventHandler, TabControlCancelEventArgs>(
                h => (s, e) => h(e),
                h => tc.Selecting += h,
                h => tc.Selecting -= h);
    }
}
