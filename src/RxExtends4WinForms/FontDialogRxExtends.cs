using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="FontDialog"/>.</summary>
public static class FontDialogRxExtends
{
    extension(FontDialog fd)
    {
        /// <summary><see cref="FontDialog.Apply"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ApplyAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => fd.Apply += h,
                h => fd.Apply -= h);
    }
}
