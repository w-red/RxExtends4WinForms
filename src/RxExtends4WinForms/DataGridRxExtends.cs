#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGrid"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class DataGridRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGrid dg)
    {
        /// <summary><see cref="DataGrid.AllowNavigationChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowNavigationChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.AllowNavigationChanged += h,
                h => dg.AllowNavigationChanged -= h);

        /// <summary><see cref="DataGrid.BackButtonClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackButtonClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BackButtonClick += h,
                h => dg.BackButtonClick -= h);

        /// <summary><see cref="DataGrid.BackgroundColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BackgroundColorChanged += h,
                h => dg.BackgroundColorChanged -= h);

        /// <summary><see cref="DataGrid.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BorderStyleChanged += h,
                h => dg.BorderStyleChanged -= h);

        /// <summary><see cref="DataGrid.CaptionVisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CaptionVisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.CaptionVisibleChanged += h,
                h => dg.CaptionVisibleChanged -= h);

        /// <summary><see cref="DataGrid.CurrentCellChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentCellChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.CurrentCellChanged += h,
                h => dg.CurrentCellChanged -= h);

        /// <summary><see cref="DataGrid.DataSourceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataSourceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.DataSourceChanged += h,
                h => dg.DataSourceChanged -= h);

        /// <summary><see cref="DataGrid.FlatModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FlatModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.FlatModeChanged += h,
                h => dg.FlatModeChanged -= h);

        /// <summary><see cref="DataGrid.Navigate"/> as <see cref="Observable"/></summary>
        public IObservable<NavigateEventArgs> NavigateAsObservable() =>
            Observable.FromEvent<NavigateEventHandler, NavigateEventArgs>(
                h => (s, e) => h(e),
                h => dg.Navigate += h,
                h => dg.Navigate -= h);

        /// <summary><see cref="DataGrid.ParentRowsLabelStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ParentRowsLabelStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ParentRowsLabelStyleChanged += h,
                h => dg.ParentRowsLabelStyleChanged -= h);

        /// <summary><see cref="DataGrid.ParentRowsVisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ParentRowsVisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ParentRowsVisibleChanged += h,
                h => dg.ParentRowsVisibleChanged -= h);

        /// <summary><see cref="DataGrid.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ReadOnlyChanged += h,
                h => dg.ReadOnlyChanged -= h);

        /// <summary><see cref="DataGrid.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ScrollAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.Scroll += h,
                h => dg.Scroll -= h);

        /// <summary><see cref="DataGrid.ShowParentDetailsButtonClick"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ShowParentDetailsButtonClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ShowParentDetailsButtonClick += h,
                h => dg.ShowParentDetailsButtonClick -= h);
    }
#endif
}
