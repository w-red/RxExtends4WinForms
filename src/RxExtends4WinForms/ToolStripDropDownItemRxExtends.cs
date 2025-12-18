using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripDropDownItem"/>.</summary>
public static class ToolStripDropDownItemRxExtends
{
    extension(ToolStripDropDownItem tsddi)
    {
        /// <summary><see cref="ToolStripDropDownItem.DropDownOpened"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownOpenedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsddi.DropDownOpened += h,
                h => tsddi.DropDownOpened -= h);

        /// <summary><see cref="ToolStripDropDownItem.DropDownOpening"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownOpeningAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsddi.DropDownOpening += h,
                h => tsddi.DropDownOpening -= h);

        /// <summary><see cref="ToolStripDropDownItem.DropDownClosed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownClosedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsddi.DropDownClosed += h,
                h => tsddi.DropDownClosed -= h);

        /// <summary><see cref="ToolStripDropDownItem.DropDownItemClicked"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemClickedEventArgs> DropDownItemClickedAsObservable() =>
            Observable.FromEvent<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
                h => (s, e) => h(e),
                h => tsddi.DropDownItemClicked += h,
                h => tsddi.DropDownItemClicked -= h);
    }
}
