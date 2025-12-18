using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="PrintPreviewControl"/>.</summary>
public static class PrintPreviewControlRxExtends
{
    extension(PrintPreviewControl ppc)
    {
        /// <summary><see cref="PrintPreviewControl.StartPageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> StartPageChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ppc.StartPageChanged += h,
                h => ppc.StartPageChanged -= h);
    }
}
