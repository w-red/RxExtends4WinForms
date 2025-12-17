using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="CommonDialog"/>.</summary>
public static class CommonDialogRxExtends
{
    extension(CommonDialog cd)
    {
        /// <summary><see cref="CommonDialog.HelpRequest"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HelpRequestAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cd.HelpRequest += h,
                h => cd.HelpRequest -= h);
    }
}
