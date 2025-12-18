using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripManager"/>.</summary>
/// <remarks>
/// <see cref="ToolStripManager"/> cannot support extension methods,<br />
/// so use the static methods of <see cref="ToolStripManagerRxExtends"/>.
/// </remarks>
public static class ToolStripManagerRxExtends
{
    /// <summary><see cref="ToolStripManager.RendererChanged"/> as <see cref="Observable"/></summary>
    /// <example><code>
    /// ToolStripManagerR3Extends
    ///     .RendererChangedAsObservable()
    ///     .Subscribe(e =&gt;
    ///         {
    ///             Console.WriteLine("RendererChanged event occurred.");
    ///         }
    ///     );
    /// </code></example>
    public static IObservable<EventArgs> RendererChangedAsObservable() =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ToolStripManager.RendererChanged += h,
            h => ToolStripManager.RendererChanged -= h);
}
