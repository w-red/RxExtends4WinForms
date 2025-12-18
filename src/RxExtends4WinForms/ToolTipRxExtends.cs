using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolTip"/>.</summary>
public static class ToolTipRxExtends
{
    extension(ToolTip tt)
    {
        /// <summary><see cref="ToolTip.Draw"/> as <see cref="Observable"/></summary>
        public IObservable<DrawToolTipEventArgs> DrawAsObservable() =>
            Observable.FromEvent<DrawToolTipEventHandler, DrawToolTipEventArgs>(
                h => (s, e) => h(e),
                h => tt.Draw += h,
                h => tt.Draw -= h);

        /// <summary><see cref="ToolTip.Popup"/> as <see cref="Observable"/></summary>
        public IObservable<PopupEventArgs> PopupAsObservable() =>
            Observable.FromEvent<PopupEventHandler, PopupEventArgs>(
                h => (s, e) => h(e),
                h => tt.Popup += h,
                h => tt.Popup -= h);
    }
}
