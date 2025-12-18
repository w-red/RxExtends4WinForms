using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripPanel"/>.</summary>
public static class ToolStripPanelRxExtends
{
    extension(ToolStripPanel tsp)
    {
        /// <summary><see cref="ToolStripPanel.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsp.AutoSizeChanged += h,
                h => tsp.AutoSizeChanged -= h);

        /// <summary><see cref="ToolStripPanel.RendererChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RendererChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsp.RendererChanged += h,
                h => tsp.RendererChanged -= h);
    }
}
