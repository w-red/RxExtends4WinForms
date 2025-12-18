using System.Reactive.Linq;

namespace RxExtends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridTableStyle"/>.</summary>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574
#endif
public static class DataGridTableStyleRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridTableStyle dgts)
    {
        /// <summary><see cref="DataGridTableStyle.AllowSortingChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowSortingChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.AllowSortingChanged += h,
                h => dgts.AllowSortingChanged -= h);

        /// <summary><see cref="DataGridTableStyle.AlternatingBackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AlternatingBackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.AlternatingBackColorChanged += h,
                h => dgts.AlternatingBackColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.BackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.BackColorChanged += h,
                h => dgts.BackColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.ColumnHeadersVisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ColumnHeadersVisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ColumnHeadersVisibleChanged += h,
                h => dgts.ColumnHeadersVisibleChanged -= h);

        /// <summary><see cref="DataGridTableStyle.ForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ForeColorChanged += h,
                h => dgts.ForeColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.GridLineColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> GridLineColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.GridLineColorChanged += h,
                h => dgts.GridLineColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.GridLineStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> GridLineStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.GridLineStyleChanged += h,
                h => dgts.GridLineStyleChanged -= h);

        /// <summary><see cref="DataGridTableStyle.HeaderBackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HeaderBackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderBackColorChanged += h,
                h => dgts.HeaderBackColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.HeaderFontChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HeaderFontChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderFontChanged += h,
                h => dgts.HeaderFontChanged -= h);

        /// <summary><see cref="DataGridTableStyle.HeaderForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HeaderForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderForeColorChanged += h,
                h => dgts.HeaderForeColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.LinkColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LinkColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.LinkColorChanged += h,
                h => dgts.LinkColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.LinkHoverColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LinkHoverColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.LinkHoverColorChanged += h,
                h => dgts.LinkHoverColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.MappingNameChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MappingNameChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.MappingNameChanged += h,
                h => dgts.MappingNameChanged -= h);

        /// <summary><see cref="DataGridTableStyle.PreferredColumnWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PreferredColumnWidthChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.PreferredColumnWidthChanged += h,
                h => dgts.PreferredColumnWidthChanged -= h);

        /// <summary><see cref="DataGridTableStyle.PreferredRowHeightChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PreferredRowHeightChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.PreferredRowHeightChanged += h,
                h => dgts.PreferredRowHeightChanged -= h);

        /// <summary><see cref="DataGridTableStyle.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ReadOnlyChanged += h,
                h => dgts.ReadOnlyChanged -= h);

        /// <summary><see cref="DataGridTableStyle.RowHeadersVisibleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowHeadersVisibleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.RowHeadersVisibleChanged += h,
                h => dgts.RowHeadersVisibleChanged -= h);

        /// <summary><see cref="DataGridTableStyle.RowHeaderWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowHeaderWidthChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.RowHeaderWidthChanged += h,
                h => dgts.RowHeaderWidthChanged -= h);

        /// <summary><see cref="DataGridTableStyle.SelectionBackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectionBackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.SelectionBackColorChanged += h,
                h => dgts.SelectionBackColorChanged -= h);

        /// <summary><see cref="DataGridTableStyle.SelectionForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectionForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.SelectionForeColorChanged += h,
                h => dgts.SelectionForeColorChanged -= h);
    }
#endif
}
