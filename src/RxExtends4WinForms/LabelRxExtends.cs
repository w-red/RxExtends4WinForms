using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Label"/>.</summary>
public static class LabelRxExtends
{
    extension(Label lbl)
    {
        /// <summary><see cref="Label.TextAlignChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextAlignChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lbl.TextAlignChanged += h,
                h => lbl.TextAlignChanged -= h);

        /// <summary><see cref="Label.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lbl.AutoSizeChanged += h,
                h => lbl.AutoSizeChanged -= h);
    }
}
