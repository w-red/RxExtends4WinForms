using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="Button"/>.</summary>
public static class ButtonRxExtends
{
    extension(Button b)
    {
        /// <summary><see cref="Button.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => b.DoubleClick += h,
                h => b.DoubleClick -= h);

        /// <summary><see cref="Button.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDoubleClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => b.MouseDoubleClick += h,
                h => b.MouseDoubleClick -= h);
    }
}
