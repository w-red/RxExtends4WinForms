using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="System.Windows.Forms.Timer"/>.</summary>
public static class TimerRxExtends
{
    extension(System.Windows.Forms.Timer t)
    {
        /// <summary><see cref="System.Windows.Forms.Timer.Tick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => t.Tick += h,
                h => t.Tick -= h);
    }
}
