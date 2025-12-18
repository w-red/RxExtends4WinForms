using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripItem"/>.</summary>
public static class ToolStripItemRxExtends
{
    extension(ToolStripItem tsi)
    {
        /// <summary><see cref="ToolStripItem.AvailableChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AvailableChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.AvailableChanged += h,
                h => tsi.AvailableChanged -= h);

        /// <summary><see cref="ToolStripItem.BackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.BackColorChanged += h,
                h => tsi.BackColorChanged -= h);

        /// <summary><see cref="ToolStripItem.ForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.ForeColorChanged += h,
                h => tsi.ForeColorChanged -= h);

        /// <summary><see cref="ToolStripItem.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.Click += h,
                h => tsi.Click -= h);

        /// <summary><see cref="ToolStripItem.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DoubleClick += h,
                h => tsi.DoubleClick -= h);

#if NET7_0_OR_GREATER
        /// <summary><see cref="ToolStripItem.CommandCanExecuteChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandCanExecuteChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandCanExecuteChanged += h,
                h => tsi.CommandCanExecuteChanged -= h);

        /// <summary><see cref="ToolStripItem.CommandChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandChanged += h,
                h => tsi.CommandChanged -= h);

        /// <summary><see cref="ToolStripItem.CommandParameterChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CommandParameterChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandParameterChanged += h,
                h => tsi.CommandParameterChanged -= h);
#endif

        /// <summary><see cref="ToolStripItem.DisplayStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DisplayStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DisplayStyleChanged += h,
                h => tsi.DisplayStyleChanged -= h);

        /// <summary><see cref="ToolStripItem.DragDrop"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragDropAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragDrop += h,
                h => tsi.DragDrop -= h);

        /// <summary><see cref="ToolStripItem.DragEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragEnterAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragEnter += h,
                h => tsi.DragEnter -= h);

        /// <summary><see cref="ToolStripItem.DragLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DragLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragLeave += h,
                h => tsi.DragLeave -= h);

        /// <summary><see cref="ToolStripItem.DragOver"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragOverAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragOver += h,
                h => tsi.DragOver -= h);

        /// <summary><see cref="ToolStripItem.EnabledChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EnabledChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.EnabledChanged += h,
                h => tsi.EnabledChanged -= h);

        /// <summary><see cref="ToolStripItem.GiveFeedback"/> as <see cref="Observable"/></summary>
        public IObservable<GiveFeedbackEventArgs> GiveFeedbackAsObservable() =>
            Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                h => (s, e) => h(e),
                h => tsi.GiveFeedback += h,
                h => tsi.GiveFeedback -= h);

        /// <summary><see cref="ToolStripItem.LocationChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LocationChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.LocationChanged += h,
                h => tsi.LocationChanged -= h);

        /// <summary><see cref="ToolStripItem.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseDown += h,
                h => tsi.MouseDown -= h);

        /// <summary><see cref="ToolStripItem.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseUp += h,
                h => tsi.MouseUp -= h);

        /// <summary><see cref="ToolStripItem.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseEnter += h,
                h => tsi.MouseEnter -= h);

        /// <summary><see cref="ToolStripItem.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseLeave += h,
                h => tsi.MouseLeave -= h);

        /// <summary><see cref="ToolStripItem.MouseHover"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseHoverAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseHover += h,
                h => tsi.MouseHover -= h);

        /// <summary><see cref="ToolStripItem.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseMove += h,
                h => tsi.MouseMove -= h);

        /// <summary><see cref="ToolStripItem.OwnerChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> OwnerChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.OwnerChanged += h,
                h => tsi.OwnerChanged -= h);

        /// <summary><see cref="ToolStripItem.Paint"/> as <see cref="Observable"/></summary>
        public IObservable<PaintEventArgs> PaintAsObservable() =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => tsi.Paint += h,
                h => tsi.Paint -= h);

        /// <summary><see cref="ToolStripItem.QueryAccessibilityHelp"/> as <see cref="Observable"/></summary>
        public IObservable<QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable() =>
            Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                h => (s, e) => h(e),
                h => tsi.QueryAccessibilityHelp += h,
                h => tsi.QueryAccessibilityHelp -= h);

        /// <summary><see cref="ToolStripItem.QueryContinueDrag"/> as <see cref="Observable"/></summary>
        public IObservable<QueryContinueDragEventArgs> QueryContinueDragAsObservable() =>
            Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.QueryContinueDrag += h,
                h => tsi.QueryContinueDrag -= h);

        /// <summary><see cref="ToolStripItem.RightToLeftChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.RightToLeftChanged += h,
                h => tsi.RightToLeftChanged -= h);

#if NET9_0_OR_GREATER
        /// <summary><see cref="ToolStripItem.SelectedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.SelectedChanged += h,
                h => tsi.SelectedChanged -= h);
#endif

        /// <summary><see cref="ToolStripItem.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.TextChanged += h,
                h => tsi.TextChanged -= h);

        /// <summary><see cref="ToolStripItem.VisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> VisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.VisibleChanged += h,
                h => tsi.VisibleChanged -= h);
    }
}
