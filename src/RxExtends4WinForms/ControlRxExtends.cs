using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Control"/>.</summary>
public static class ControlRxExtends
{
    extension(Control ctrl)
    {
        /// <summary><see cref="Control.BackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackColorChanged += h,
                h => ctrl.BackColorChanged -= h);

        /// <summary><see cref="Control.ForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ForeColorChanged += h,
                h => ctrl.ForeColorChanged -= h);

        /// <summary><see cref="Control.SystemColorsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SystemColorsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.SystemColorsChanged += h,
                h => ctrl.SystemColorsChanged -= h);

        /// <summary><see cref="Control.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackgroundImageChanged += h,
                h => ctrl.BackgroundImageChanged -= h);

        /// <summary><see cref="Control.BackgroundImageLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundImageLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackgroundImageLayoutChanged += h,
                h => ctrl.BackgroundImageLayoutChanged -= h);

        /// <summary><see cref="Control.BindingContextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BindingContextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BindingContextChanged += h,
                h => ctrl.BindingContextChanged -= h);

        /// <summary><see cref="Control.CausesValidationChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CausesValidationChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.CausesValidationChanged += h,
                h => ctrl.CausesValidationChanged -= h);

        /// <summary><see cref="Control.ChangeUICues"/> as <see cref="Observable"/></summary>
        public IObservable<UICuesEventArgs> ChangeUICuesAsObservable() =>
            Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ChangeUICues += h,
                h => ctrl.ChangeUICues -= h);

        /// <summary><see cref="Control.ClientSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClientSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ClientSizeChanged += h,
                h => ctrl.ClientSizeChanged -= h);

        /// <summary><see cref="Control.ContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ContextMenuStripChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ContextMenuStripChanged += h,
                h => ctrl.ContextMenuStripChanged -= h);

        /// <summary><see cref="Control.ControlAdded"/> as <see cref="Observable"/></summary>
        public IObservable<ControlEventArgs> ControlAddedAsObservable() =>
            Observable.FromEvent<ControlEventHandler, ControlEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ControlAdded += h,
                h => ctrl.ControlAdded -= h);

        /// <summary><see cref="Control.ControlRemoved"/> as <see cref="Observable"/></summary>
        public IObservable<ControlEventArgs> ControlRemovedAsObservable() =>
            Observable.FromEvent<ControlEventHandler, ControlEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ControlRemoved += h,
                h => ctrl.ControlRemoved -= h);

        /// <summary><see cref="Control.CursorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CursorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.CursorChanged += h,
                h => ctrl.CursorChanged -= h);

#if NET7_0_OR_GREATER
        /// <summary><see cref="Control.DataContextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataContextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DataContextChanged += h,
                h => ctrl.DataContextChanged -= h);
#endif

        /// <summary><see cref="Control.DockChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DockChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DockChanged += h,
                h => ctrl.DockChanged -= h);

        /// <summary><see cref="Control.DpiChangedAfterParent"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DpiChangedAfterParentAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DpiChangedAfterParent += h,
                h => ctrl.DpiChangedAfterParent -= h);

        /// <summary><see cref="Control.DpiChangedBeforeParent"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DpiChangedBeforeParentAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DpiChangedBeforeParent += h,
                h => ctrl.DpiChangedBeforeParent -= h);

        /// <summary><see cref="Control.DragDrop"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragDropAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragDrop += h,
                h => ctrl.DragDrop -= h);

        /// <summary><see cref="Control.DragEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragEnterAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragEnter += h,
                h => ctrl.DragEnter -= h);

        /// <summary><see cref="Control.DragOver"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragOverAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragOver += h,
                h => ctrl.DragOver -= h);

        /// <summary><see cref="Control.DragLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DragLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragLeave += h,
                h => ctrl.DragLeave -= h);

        /// <summary><see cref="Control.GiveFeedback"/> as <see cref="Observable"/></summary>
        public IObservable<GiveFeedbackEventArgs> GiveFeedbackAsObservable() =>
            Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.GiveFeedback += h,
                h => ctrl.GiveFeedback -= h);

        /// <summary><see cref="Control.EnabledChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EnabledChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.EnabledChanged += h,
                h => ctrl.EnabledChanged -= h);

        /// <summary><see cref="Control.FontChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FontChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.FontChanged += h,
                h => ctrl.FontChanged -= h);

        /// <summary><see cref="Control.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Click += h,
                h => ctrl.Click -= h);

        /// <summary><see cref="Control.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DoubleClick += h,
                h => ctrl.DoubleClick -= h);

        /// <summary><see cref="Control.Enter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Enter += h,
                h => ctrl.Enter -= h);

        /// <summary><see cref="Control.Leave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Leave += h,
                h => ctrl.Leave -= h);

        /// <summary><see cref="Control.GotFocus"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> GotFocusAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.GotFocus += h,
                h => ctrl.GotFocus -= h);

        /// <summary><see cref="Control.LostFocus"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LostFocusAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.LostFocus += h,
                h => ctrl.LostFocus -= h);

        /// <summary><see cref="Control.HandleCreated"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HandleCreatedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HandleCreated += h,
                h => ctrl.HandleCreated -= h);

        /// <summary><see cref="Control.HandleDestroyed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HandleDestroyedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HandleDestroyed += h,
                h => ctrl.HandleDestroyed -= h);

        /// <summary><see cref="Control.HelpRequested"/> as <see cref="Observable"/></summary>
        public IObservable<HelpEventArgs> HelpRequestedAsObservable() =>
            Observable.FromEvent<HelpEventHandler, HelpEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HelpRequested += h,
                h => ctrl.HelpRequested -= h);

        /// <summary><see cref="Control.ImeModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ImeModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ImeModeChanged += h,
                h => ctrl.ImeModeChanged -= h);

        /// <summary><see cref="Control.RightToLeftChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.RightToLeftChanged += h,
                h => ctrl.RightToLeftChanged -= h);

        /// <summary><see cref="Control.Invalidated"/> as <see cref="Observable"/></summary>
        public IObservable<InvalidateEventArgs> InvalidatedAsObservable() =>
            Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Invalidated += h,
                h => ctrl.Invalidated -= h);

        /// <summary><see cref="Control.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyDown += h,
                h => ctrl.KeyDown -= h);

        /// <summary><see cref="Control.PreviewKeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<PreviewKeyDownEventArgs> PreviewKeyDownAsObservable() =>
            Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.PreviewKeyDown += h,
                h => ctrl.PreviewKeyDown -= h);

        /// <summary><see cref="Control.QueryAccessibilityHelp"/> as <see cref="Observable"/></summary>
        public IObservable<QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable() =>
            Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.QueryAccessibilityHelp += h,
                h => ctrl.QueryAccessibilityHelp -= h);

        /// <summary><see cref="Control.QueryContinueDrag"/> as <see cref="Observable"/></summary>
        public IObservable<QueryContinueDragEventArgs> QueryContinueDragAsObservable() =>
            Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.QueryContinueDrag += h,
                h => ctrl.QueryContinueDrag -= h);

        /// <summary><see cref="Control.RegionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RegionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.RegionChanged += h,
                h => ctrl.RegionChanged -= h);

        /// <summary><see cref="Control.Resize"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ResizeAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Resize += h,
                h => ctrl.Resize -= h);

        /// <summary><see cref="Control.SizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.SizeChanged += h,
                h => ctrl.SizeChanged -= h);

        /// <summary><see cref="Control.StyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> StyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.StyleChanged += h,
                h => ctrl.StyleChanged -= h);

        /// <summary><see cref="Control.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyUp += h,
                h => ctrl.KeyUp -= h);

        /// <summary><see cref="Control.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<KeyPressEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyPress += h,
                h => ctrl.KeyPress -= h);

        /// <summary><see cref="Control.ParentChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ParentChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ParentChanged += h,
                h => ctrl.ParentChanged -= h);

        /// <summary><see cref="Control.Layout"/> as <see cref="Observable"/></summary>
        public IObservable<LayoutEventArgs> LayoutAsObservable() =>
            Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Layout += h,
                h => ctrl.Layout -= h);

        /// <summary><see cref="Control.LocationChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LocationChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.LocationChanged += h,
                h => ctrl.LocationChanged -= h);

        /// <summary><see cref="Control.MarginChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MarginChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MarginChanged += h,
                h => ctrl.MarginChanged -= h);

        /// <summary><see cref="Control.PaddingChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PaddingChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.PaddingChanged += h,
                h => ctrl.PaddingChanged -= h);

        /// <summary><see cref="Control.Paint"/> as <see cref="Observable"/></summary>
        public IObservable<PaintEventArgs> PaintAsObservable() =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Paint += h,
                h => ctrl.Paint -= h);

        /// <summary><see cref="Control.TabIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TabIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TabIndexChanged += h,
                h => ctrl.TabIndexChanged -= h);

        /// <summary><see cref="Control.TabStopChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TabStopChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TabStopChanged += h,
                h => ctrl.TabStopChanged -= h);

        /// <summary><see cref="Control.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TextChanged += h,
                h => ctrl.TextChanged -= h);

        /// <summary><see cref="Control.Validated"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValidatedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Validated += h,
                h => ctrl.Validated -= h);

        /// <summary><see cref="Control.Validating"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> ValidatingAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Validating += h,
                h => ctrl.Validating -= h);

        /// <summary><see cref="Control.VisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> VisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.VisibleChanged += h,
                h => ctrl.VisibleChanged -= h);

        /// <summary><see cref="Control.MouseCaptureChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseCaptureChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseCaptureChanged += h,
                h => ctrl.MouseCaptureChanged -= h);

        /// <summary><see cref="Control.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseClick += h,
                h => ctrl.MouseClick -= h);

        /// <summary><see cref="Control.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDoubleClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseDoubleClick += h,
                h => ctrl.MouseDoubleClick -= h);

        /// <summary><see cref="Control.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseDown += h,
                h => ctrl.MouseDown -= h);

        /// <summary><see cref="Control.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseUp += h,
                h => ctrl.MouseUp -= h);

        /// <summary><see cref="Control.MouseWheel"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseWheelAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseWheel += h,
                h => ctrl.MouseWheel -= h);

        /// <summary><see cref="Control.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseMove += h,
                h => ctrl.MouseMove -= h);

        /// <summary><see cref="Control.MouseHover"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseHoverAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseHover += h,
                h => ctrl.MouseHover -= h);

        /// <summary><see cref="Control.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseEnter += h,
                h => ctrl.MouseEnter -= h);

        /// <summary><see cref="Control.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseLeave += h,
                h => ctrl.MouseLeave -= h);

        /// <summary><see cref="Control.Move"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MoveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Move += h,
                h => ctrl.Move -= h);
    }
}

