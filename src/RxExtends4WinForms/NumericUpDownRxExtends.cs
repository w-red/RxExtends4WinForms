using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="NumericUpDown"/>.</summary>
public static class NumericUpDownRxExtends
{
    extension(NumericUpDown nud)
    {
        /// <summary><see cref="NumericUpDown.ValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => nud.ValueChanged += h,
                h => nud.ValueChanged -= h);

        /// <summary><see cref="NumericUpDown.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => nud.TextChanged += h,
                h => nud.TextChanged -= h);
    }
}
