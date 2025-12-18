using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TextBox"/>.</summary>
public static class TextBoxRxExtends
{
    extension(TextBox tb)
    {
        /// <summary><see cref="TextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextAlignChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.TextAlignChanged += h,
                h => tb.TextAlignChanged -= h);
    }
}
