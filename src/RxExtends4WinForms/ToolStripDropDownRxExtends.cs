using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripDropDown"/>.</summary>
public static class ToolStripDropDownRxExtends
{
    extension(ToolStripDropDown tsdd)
    {
        /// <summary><see cref="ToolStripDropDown.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.BackgroundImageChanged += h,
                h => tsdd.BackgroundImageChanged -= h);

        /// <summary><see cref="ToolStripDropDown.BackgroundImageLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.BackgroundImageLayoutChanged += h,
                h => tsdd.BackgroundImageLayoutChanged -= h);

        /// <summary><see cref="ToolStripDropDown.BindingContextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BindingContextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.BindingContextChanged += h,
                h => tsdd.BindingContextChanged -= h);

        /// <summary><see cref="ToolStripDropDown.ChangeUICues"/> as <see cref="Observable"/></summary>
        public IObservable<UICuesEventArgs> ChangeUICuesAsObservable() =>
            Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.ChangeUICues += h,
                h => tsdd.ChangeUICues -= h);

        /// <summary><see cref="ToolStripDropDown.Closed"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripDropDownClosedEventArgs> ClosedAsObservable() =>
            Observable.FromEvent<ToolStripDropDownClosedEventHandler, ToolStripDropDownClosedEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Closed += h,
                h => tsdd.Closed -= h);

        /// <summary><see cref="ToolStripDropDown.Closing"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripDropDownClosingEventArgs> ClosingAsObservable() =>
            Observable.FromEvent<ToolStripDropDownClosingEventHandler, ToolStripDropDownClosingEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Closing += h,
                h => tsdd.Closing -= h);

        /// <summary><see cref="ToolStripDropDown.ContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ContextMenuStripChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.ContextMenuStripChanged += h,
                h => tsdd.ContextMenuStripChanged -= h);

        /// <summary><see cref="ToolStripDropDown.DockChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DockChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.DockChanged += h,
                h => tsdd.DockChanged -= h);

        /// <summary><see cref="ToolStripDropDown.Enter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Enter += h,
                h => tsdd.Enter -= h);

        /// <summary><see cref="ToolStripDropDown.Leave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Leave += h,
                h => tsdd.Leave -= h);

        /// <summary><see cref="ToolStripDropDown.FontChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FontChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.FontChanged += h,
                h => tsdd.FontChanged -= h);

        /// <summary><see cref="ToolStripDropDown.HelpRequested"/> as <see cref="Observable"/></summary>
        public IObservable<HelpEventArgs> HelpRequestedAsObservable() =>
            Observable.FromEvent<HelpEventHandler, HelpEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.HelpRequested += h,
                h => tsdd.HelpRequested -= h);

        /// <summary><see cref="ToolStripDropDown.ImeModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ImeModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.ImeModeChanged += h,
                h => tsdd.ImeModeChanged -= h);

        /// <summary><see cref="ToolStripDropDown.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.KeyDown += h,
                h => tsdd.KeyDown -= h);

        /// <summary><see cref="ToolStripDropDown.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.KeyUp += h,
                h => tsdd.KeyUp -= h);

        /// <summary><see cref="ToolStripDropDown.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<KeyPressEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.KeyPress += h,
                h => tsdd.KeyPress -= h);

        /// <summary><see cref="ToolStripDropDown.Opened"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> OpenedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Opened += h,
                h => tsdd.Opened -= h);

        /// <summary><see cref="ToolStripDropDown.Opening"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> OpeningAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => tsdd.Opening += h,
                h => tsdd.Opening -= h);

        /// <summary><see cref="ToolStripDropDown.RegionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RegionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.RegionChanged += h,
                h => tsdd.RegionChanged -= h);

        /// <summary><see cref="ToolStripDropDown.StyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> StyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsdd.StyleChanged += h,
                h => tsdd.StyleChanged -= h);
    }
}
