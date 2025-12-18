using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStrip"/>.</summary>
public static class ToolStripRxExtends
{
    extension(ToolStrip ts)
    {
        /// <summary><see cref="ToolStrip.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.AutoSizeChanged += h,
                h => ts.AutoSizeChanged -= h);

        /// <summary><see cref="ToolStrip.BeginDrag"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BeginDragAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.BeginDrag += h,
                h => ts.BeginDrag -= h);

        /// <summary><see cref="ToolStrip.EndDrag"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EndDragAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.EndDrag += h,
                h => ts.EndDrag -= h);

        /// <summary><see cref="ToolStrip.CausesValidationChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CausesValidationChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CausesValidationChanged += h,
                h => ts.CausesValidationChanged -= h);

        /// <summary><see cref="ToolStrip.CursorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CursorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CursorChanged += h,
                h => ts.CursorChanged -= h);

        /// <summary><see cref="ToolStrip.ForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.ForeColorChanged += h,
                h => ts.ForeColorChanged -= h);

        /// <summary><see cref="ToolStrip.ItemAdded"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemEventArgs> ItemAddedAsObservable() =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemAdded += h,
                h => ts.ItemAdded -= h);

        /// <summary><see cref="ToolStrip.ItemRemoved"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemEventArgs> ItemRemovedAsObservable() =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemRemoved += h,
                h => ts.ItemRemoved -= h);

        /// <summary><see cref="ToolStrip.ItemClicked"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemClickedEventArgs> ItemClickedAsObservable() =>
            Observable.FromEvent<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemClicked += h,
                h => ts.ItemClicked -= h);

        /// <summary><see cref="ToolStrip.LayoutCompleted"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LayoutCompletedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutCompleted += h,
                h => ts.LayoutCompleted -= h);

        /// <summary><see cref="ToolStrip.LayoutStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LayoutStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutStyleChanged += h,
                h => ts.LayoutStyleChanged -= h);

        /// <summary><see cref="ToolStrip.PaintGrip"/> as <see cref="Observable"/></summary>
        public IObservable<PaintEventArgs> PaintGripAsObservable() =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => ts.PaintGrip += h,
                h => ts.PaintGrip -= h);

        /// <summary><see cref="ToolStrip.RendererChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RendererChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.RendererChanged += h,
                h => ts.RendererChanged -= h);
    }
}
