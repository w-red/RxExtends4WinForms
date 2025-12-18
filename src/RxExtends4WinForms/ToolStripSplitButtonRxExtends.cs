using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripSplitButton"/>.</summary>
public static class ToolStripSplitButtonRxExtends
{
    extension(ToolStripSplitButton tssb)
    {
        /// <summary><see cref="ToolStripSplitButton.ButtonClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ButtonClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.ButtonClick += h,
                h => tssb.ButtonClick -= h);

        /// <summary><see cref="ToolStripSplitButton.ButtonDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ButtonDoubleClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.ButtonDoubleClick += h,
                h => tssb.ButtonDoubleClick -= h);

        /// <summary><see cref="ToolStripSplitButton.DefaultItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DefaultItemChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.DefaultItemChanged += h,
                h => tssb.DefaultItemChanged -= h);
    }
}
