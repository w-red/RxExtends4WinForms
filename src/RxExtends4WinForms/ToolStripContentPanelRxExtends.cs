using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripContentPanel"/>.</summary>
public static class ToolStripContentPanelRxExtends
{
    extension(ToolStripContentPanel tscp)
    {
        /// <summary><see cref="ToolStripContentPanel.Load"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LoadAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscp.Load += h,
                h => tscp.Load -= h);

        /// <summary><see cref="ToolStripContentPanel.RendererChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RendererChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscp.RendererChanged += h,
                h => tscp.RendererChanged -= h);
    }
}
