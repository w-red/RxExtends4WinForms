using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripTextBox"/>.</summary>
public static class ToolStripTextBoxRxExtends
{
    extension(ToolStripTextBox tstb)
    {
        /// <summary><see cref="ToolStripTextBox.AcceptsTabChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AcceptsTabChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.AcceptsTabChanged += h,
                h => tstb.AcceptsTabChanged -= h);

        /// <summary><see cref="ToolStripTextBox.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.BorderStyleChanged += h,
                h => tstb.BorderStyleChanged -= h);

        /// <summary><see cref="ToolStripTextBox.HideSelectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HideSelectionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.HideSelectionChanged += h,
                h => tstb.HideSelectionChanged -= h);

        /// <summary><see cref="ToolStripTextBox.ModifiedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ModifiedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.ModifiedChanged += h,
                h => tstb.ModifiedChanged -= h);

        /// <summary><see cref="ToolStripTextBox.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.ReadOnlyChanged += h,
                h => tstb.ReadOnlyChanged -= h);

        /// <summary><see cref="ToolStripTextBox.TextBoxTextAlignChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextBoxTextAlignChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.TextBoxTextAlignChanged += h,
                h => tstb.TextBoxTextAlignChanged -= h);
    }
}
