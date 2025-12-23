#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolBar"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class ToolBarRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(ToolBar tb)
    {
        /// <summary><see cref="ToolBar.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.AutoSizeChanged += h,
                h => tb.AutoSizeChanged -= h);

        /// <summary><see cref="ToolBar.ButtonClick"/> as <see cref="Observable"/></summary>
        public IObservable<ToolBarButtonClickEventArgs> ButtonClickAsObservable() =>
            Observable.FromEvent<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                h => (s, e) => h(e),
                h => tb.ButtonClick += h,
                h => tb.ButtonClick -= h);

        /// <summary><see cref="ToolBar.ButtonDropDown"/> as <see cref="Observable"/></summary>
        public IObservable<ToolBarButtonClickEventArgs> ButtonDropDownAsObservable() =>
            Observable.FromEvent<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                h => (s, e) => h(e),
                h => tb.ButtonDropDown += h,
                h => tb.ButtonDropDown -= h);
    }
#endif
}
