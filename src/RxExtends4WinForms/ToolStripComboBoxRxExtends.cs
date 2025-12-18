using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripComboBox"/>.</summary>
public static class ToolStripComboBoxRxExtends
{
    extension(ToolStripComboBox tscb)
    {
        /// <summary><see cref="ToolStripComboBox.DropDown"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDown += h,
                h => tscb.DropDown -= h);

        /// <summary><see cref="ToolStripComboBox.DropDownClosed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownClosedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDownClosed += h,
                h => tscb.DropDownClosed -= h);

        /// <summary><see cref="ToolStripComboBox.DropDownStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DropDownStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDownStyleChanged += h,
                h => tscb.DropDownStyleChanged -= h);

        /// <summary><see cref="ToolStripComboBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.SelectedIndexChanged += h,
                h => tscb.SelectedIndexChanged -= h);

        /// <summary><see cref="ToolStripComboBox.TextUpdate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextUpdateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.TextUpdate += h,
                h => tscb.TextUpdate -= h);
    }
}
