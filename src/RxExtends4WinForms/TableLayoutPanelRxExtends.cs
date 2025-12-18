using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TableLayoutPanel"/>.</summary>
public static class TableLayoutPanelRxExtends
{
    extension(TableLayoutPanel tlp)
    {
        /// <summary><see cref="TableLayoutPanel.CellPaint"/> as <see cref="Observable"/></summary>
        public IObservable<TableLayoutCellPaintEventArgs> CellPaintAsObservable() =>
            Observable.FromEvent<TableLayoutCellPaintEventHandler, TableLayoutCellPaintEventArgs>(
                h => (s, e) => h(e),
                h => tlp.CellPaint += h,
                h => tlp.CellPaint -= h);
    }
}
