using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="LinkLabel"/>.</summary>
public static class LinkLabelRxExtends
{
    extension(LinkLabel ll)
    {
        /// <summary><see cref="LinkLabel.LinkClicked"/> as <see cref="Observable"/></summary>
        public IObservable<LinkLabelLinkClickedEventArgs> LinkClickedAsObservable() =>
            Observable.FromEvent<LinkLabelLinkClickedEventHandler, LinkLabelLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => ll.LinkClicked += h,
                h => ll.LinkClicked -= h);

        /// <summary><see cref="LinkLabel.TabStopChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TabStopChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ll.TabStopChanged += h,
                h => ll.TabStopChanged -= h);
    }
}
