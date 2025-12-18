using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridView"/>.</summary>
public static class DataGridViewRxExtends
{
    extension(DataGridView dgv)
    {
        /// <summary><see cref="DataGridView.AllowUserToAddRowsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowUserToAddRowsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToAddRowsChanged += h,
                h => dgv.AllowUserToAddRowsChanged -= h);

        /// <summary><see cref="DataGridView.AllowUserToDeleteRowsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowUserToDeleteRowsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToDeleteRowsChanged += h,
                h => dgv.AllowUserToDeleteRowsChanged -= h);

        /// <summary><see cref="DataGridView.AllowUserToOrderColumnsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowUserToOrderColumnsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToOrderColumnsChanged += h,
                h => dgv.AllowUserToOrderColumnsChanged -= h);

        /// <summary><see cref="DataGridView.AllowUserToResizeColumnsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowUserToResizeColumnsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeColumnsChanged += h,
                h => dgv.AllowUserToResizeColumnsChanged -= h);

        /// <summary><see cref="DataGridView.AllowUserToResizeRowsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowUserToResizeRowsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeRowsChanged += h,
                h => dgv.AllowUserToResizeRowsChanged -= h);

        /// <summary><see cref="DataGridView.AlternatingRowsDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AlternatingRowsDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AlternatingRowsDefaultCellStyleChanged += h,
                h => dgv.AlternatingRowsDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.AutoGenerateColumnsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoGenerateColumnsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoGenerateColumnsChanged += h,
                h => dgv.AutoGenerateColumnsChanged -= h);

        /// <summary><see cref="DataGridView.AutoSizeColumnModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewAutoSizeColumnModeEventArgs> AutoSizeColumnModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewAutoSizeColumnModeEventHandler, DataGridViewAutoSizeColumnModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnModeChanged += h,
                h => dgv.AutoSizeColumnModeChanged -= h);

        /// <summary><see cref="DataGridView.AutoSizeColumnsModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewAutoSizeColumnsModeEventArgs> AutoSizeColumnsModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewAutoSizeColumnsModeEventHandler, DataGridViewAutoSizeColumnsModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnsModeChanged += h,
                h => dgv.AutoSizeColumnsModeChanged -= h);

        /// <summary><see cref="DataGridView.AutoSizeRowsModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewAutoSizeModeEventArgs> AutoSizeRowsModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeRowsModeChanged += h,
                h => dgv.AutoSizeRowsModeChanged -= h);

        /// <summary><see cref="DataGridView.BackgroundColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BackgroundColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BackgroundColorChanged += h,
                h => dgv.BackgroundColorChanged -= h);

        /// <summary><see cref="DataGridView.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BorderStyleChanged += h,
                h => dgv.BorderStyleChanged -= h);

        /// <summary><see cref="DataGridView.CancelRowEdit"/> as <see cref="Observable"/></summary>
        public IObservable<QuestionEventArgs> CancelRowEditAsObservable() =>
            Observable.FromEvent<QuestionEventHandler, QuestionEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CancelRowEdit += h,
                h => dgv.CancelRowEdit -= h);

        /// <summary><see cref="DataGridView.CellBeginEdit"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellCancelEventArgs> CellBeginEditAsObservable() =>
            Observable.FromEvent<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBeginEdit += h,
                h => dgv.CellBeginEdit -= h);

        /// <summary><see cref="DataGridView.CellBorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CellBorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBorderStyleChanged += h,
                h => dgv.CellBorderStyleChanged -= h);

        /// <summary><see cref="DataGridView.CellClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellClick += h,
                h => dgv.CellClick -= h);

        /// <summary><see cref="DataGridView.CellContentClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellContentClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentClick += h,
                h => dgv.CellContentClick -= h);

        /// <summary><see cref="DataGridView.CellContentDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellContentDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentDoubleClick += h,
                h => dgv.CellContentDoubleClick -= h);

        /// <summary><see cref="DataGridView.CellContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellContextMenuStripChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripChanged += h,
                h => dgv.CellContextMenuStripChanged -= h);

        /// <summary><see cref="DataGridView.CellContextMenuStripNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellContextMenuStripNeededEventArgs> CellContextMenuStripNeededAsObservable() =>
            Observable.FromEvent<DataGridViewCellContextMenuStripNeededEventHandler, DataGridViewCellContextMenuStripNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripNeeded += h,
                h => dgv.CellContextMenuStripNeeded -= h);

        /// <summary><see cref="DataGridView.CellDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellDoubleClick += h,
                h => dgv.CellDoubleClick -= h);

        /// <summary><see cref="DataGridView.CellEndEdit"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellEndEditAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEndEdit += h,
                h => dgv.CellEndEdit -= h);

        /// <summary><see cref="DataGridView.CellEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellEnterAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEnter += h,
                h => dgv.CellEnter -= h);

        /// <summary><see cref="DataGridView.CellErrorTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellErrorTextChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextChanged += h,
                h => dgv.CellErrorTextChanged -= h);

        /// <summary><see cref="DataGridView.CellErrorTextNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellErrorTextNeededEventArgs> CellErrorTextNeededAsObservable() =>
            Observable.FromEvent<DataGridViewCellErrorTextNeededEventHandler, DataGridViewCellErrorTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextNeeded += h,
                h => dgv.CellErrorTextNeeded -= h);

        /// <summary><see cref="DataGridView.CellFormatting"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellFormattingEventArgs> CellFormattingAsObservable() =>
            Observable.FromEvent<DataGridViewCellFormattingEventHandler, DataGridViewCellFormattingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellFormatting += h,
                h => dgv.CellFormatting -= h);

        /// <summary><see cref="DataGridView.CellLeave"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellLeaveAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellLeave += h,
                h => dgv.CellLeave -= h);

        /// <summary><see cref="DataGridView.CellMouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> CellMouseClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseClick += h,
                h => dgv.CellMouseClick -= h);

        /// <summary><see cref="DataGridView.CellMouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> CellMouseDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDoubleClick += h,
                h => dgv.CellMouseDoubleClick -= h);

        /// <summary><see cref="DataGridView.CellMouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> CellMouseDownAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDown += h,
                h => dgv.CellMouseDown -= h);

        /// <summary><see cref="DataGridView.CellMouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellMouseEnterAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseEnter += h,
                h => dgv.CellMouseEnter -= h);

        /// <summary><see cref="DataGridView.CellMouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellMouseLeaveAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseLeave += h,
                h => dgv.CellMouseLeave -= h);

        /// <summary><see cref="DataGridView.CellMouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> CellMouseMoveAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseMove += h,
                h => dgv.CellMouseMove -= h);

        /// <summary><see cref="DataGridView.CellMouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> CellMouseUpAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseUp += h,
                h => dgv.CellMouseUp -= h);

        /// <summary><see cref="DataGridView.CellPainting"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellPaintingEventArgs> CellPaintingAsObservable() =>
            Observable.FromEvent<DataGridViewCellPaintingEventHandler, DataGridViewCellPaintingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellPainting += h,
                h => dgv.CellPainting -= h);

        /// <summary><see cref="DataGridView.CellParsing"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellParsingEventArgs> CellParsingAsObservable() =>
            Observable.FromEvent<DataGridViewCellParsingEventHandler, DataGridViewCellParsingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellParsing += h,
                h => dgv.CellParsing -= h);

        /// <summary><see cref="DataGridView.CellStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellStateChangedEventArgs> CellStateChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellStateChangedEventHandler, DataGridViewCellStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStateChanged += h,
                h => dgv.CellStateChanged -= h);

        /// <summary><see cref="DataGridView.CellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellStyleChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleChanged += h,
                h => dgv.CellStyleChanged -= h);

        /// <summary><see cref="DataGridView.CellStyleContentChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellStyleContentChangedEventArgs> CellStyleContentChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellStyleContentChangedEventHandler, DataGridViewCellStyleContentChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleContentChanged += h,
                h => dgv.CellStyleContentChanged -= h);

        /// <summary><see cref="DataGridView.CellToolTipTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellToolTipTextChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextChanged += h,
                h => dgv.CellToolTipTextChanged -= h);

        /// <summary><see cref="DataGridView.CellToolTipTextNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellToolTipTextNeededEventArgs> CellToolTipTextNeededAsObservable() =>
            Observable.FromEvent<DataGridViewCellToolTipTextNeededEventHandler, DataGridViewCellToolTipTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextNeeded += h,
                h => dgv.CellToolTipTextNeeded -= h);

        /// <summary><see cref="DataGridView.CellValidated"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellValidatedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidated += h,
                h => dgv.CellValidated -= h);

        /// <summary><see cref="DataGridView.CellValidating"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellValidatingEventArgs> CellValidatingAsObservable() =>
            Observable.FromEvent<DataGridViewCellValidatingEventHandler, DataGridViewCellValidatingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidating += h,
                h => dgv.CellValidating -= h);

        /// <summary><see cref="DataGridView.CellValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> CellValueChangedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueChanged += h,
                h => dgv.CellValueChanged -= h);

        /// <summary><see cref="DataGridView.CellValueNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellValueEventArgs> CellValueNeededAsObservable() =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueNeeded += h,
                h => dgv.CellValueNeeded -= h);

        /// <summary><see cref="DataGridView.CellValuePushed"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellValueEventArgs> CellValuePushedAsObservable() =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValuePushed += h,
                h => dgv.CellValuePushed -= h);

        /// <summary><see cref="DataGridView.ColumnAdded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnAddedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnAdded += h,
                h => dgv.ColumnAdded -= h);

        /// <summary><see cref="DataGridView.ColumnContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnContextMenuStripChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnContextMenuStripChanged += h,
                h => dgv.ColumnContextMenuStripChanged -= h);

        /// <summary><see cref="DataGridView.ColumnDataPropertyNameChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnDataPropertyNameChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDataPropertyNameChanged += h,
                h => dgv.ColumnDataPropertyNameChanged -= h);

        /// <summary><see cref="DataGridView.ColumnDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDefaultCellStyleChanged += h,
                h => dgv.ColumnDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.ColumnDisplayIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnDisplayIndexChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDisplayIndexChanged += h,
                h => dgv.ColumnDisplayIndexChanged -= h);

        /// <summary><see cref="DataGridView.ColumnDividerDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnDividerDoubleClickEventArgs> ColumnDividerDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewColumnDividerDoubleClickEventHandler, DataGridViewColumnDividerDoubleClickEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerDoubleClick += h,
                h => dgv.ColumnDividerDoubleClick -= h);

        /// <summary><see cref="DataGridView.ColumnDividerWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnDividerWidthChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerWidthChanged += h,
                h => dgv.ColumnDividerWidthChanged -= h);

        /// <summary><see cref="DataGridView.ColumnHeaderCellChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnHeaderCellChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderCellChanged += h,
                h => dgv.ColumnHeaderCellChanged -= h);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseClick += h,
                h => dgv.ColumnHeaderMouseClick -= h);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseDoubleClick += h,
                h => dgv.ColumnHeaderMouseDoubleClick -= h);

        /// <summary><see cref="DataGridView.ColumnHeadersBorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ColumnHeadersBorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersBorderStyleChanged += h,
                h => dgv.ColumnHeadersBorderStyleChanged -= h);

        /// <summary><see cref="DataGridView.ColumnHeadersDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ColumnHeadersDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersDefaultCellStyleChanged += h,
                h => dgv.ColumnHeadersDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ColumnHeadersHeightChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightChanged += h,
                h => dgv.ColumnHeadersHeightChanged -= h);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightSizeModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewAutoSizeModeEventArgs> ColumnHeadersHeightSizeModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightSizeModeChanged += h,
                h => dgv.ColumnHeadersHeightSizeModeChanged -= h);

        /// <summary><see cref="DataGridView.ColumnMinimumWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnMinimumWidthChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnMinimumWidthChanged += h,
                h => dgv.ColumnMinimumWidthChanged -= h);

        /// <summary><see cref="DataGridView.ColumnNameChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnNameChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnNameChanged += h,
                h => dgv.ColumnNameChanged -= h);

        /// <summary><see cref="DataGridView.ColumnRemoved"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnRemovedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnRemoved += h,
                h => dgv.ColumnRemoved -= h);

        /// <summary><see cref="DataGridView.ColumnSortModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnSortModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnSortModeChanged += h,
                h => dgv.ColumnSortModeChanged -= h);

        /// <summary><see cref="DataGridView.ColumnStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnStateChangedEventArgs> ColumnStateChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnStateChangedEventHandler, DataGridViewColumnStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnStateChanged += h,
                h => dgv.ColumnStateChanged -= h);

        /// <summary><see cref="DataGridView.ColumnToolTipTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnToolTipTextChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnToolTipTextChanged += h,
                h => dgv.ColumnToolTipTextChanged -= h);

        /// <summary><see cref="DataGridView.ColumnWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewColumnEventArgs> ColumnWidthChangedAsObservable() =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnWidthChanged += h,
                h => dgv.ColumnWidthChanged -= h);

        /// <summary><see cref="DataGridView.CurrentCellChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentCellChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellChanged += h,
                h => dgv.CurrentCellChanged -= h);

        /// <summary><see cref="DataGridView.CurrentCellDirtyStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CurrentCellDirtyStateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellDirtyStateChanged += h,
                h => dgv.CurrentCellDirtyStateChanged -= h);

        /// <summary><see cref="DataGridView.DataBindingComplete"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewBindingCompleteEventArgs> DataBindingCompleteAsObservable() =>
            Observable.FromEvent<DataGridViewBindingCompleteEventHandler, DataGridViewBindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataBindingComplete += h,
                h => dgv.DataBindingComplete -= h);

        /// <summary><see cref="DataGridView.DataError"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewDataErrorEventArgs> DataErrorAsObservable() =>
            Observable.FromEvent<DataGridViewDataErrorEventHandler, DataGridViewDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataError += h,
                h => dgv.DataError -= h);

        /// <summary><see cref="DataGridView.DataMemberChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataMemberChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataMemberChanged += h,
                h => dgv.DataMemberChanged -= h);

        /// <summary><see cref="DataGridView.DataSourceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DataSourceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataSourceChanged += h,
                h => dgv.DataSourceChanged -= h);

        /// <summary><see cref="DataGridView.DefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DefaultCellStyleChanged += h,
                h => dgv.DefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.DefaultValuesNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> DefaultValuesNeededAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DefaultValuesNeeded += h,
                h => dgv.DefaultValuesNeeded -= h);

        /// <summary><see cref="DataGridView.EditingControlShowing"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewEditingControlShowingEventArgs> EditingControlShowingAsObservable() =>
            Observable.FromEvent<DataGridViewEditingControlShowingEventHandler, DataGridViewEditingControlShowingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.EditingControlShowing += h,
                h => dgv.EditingControlShowing -= h);

        /// <summary><see cref="DataGridView.EditModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EditModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.EditModeChanged += h,
                h => dgv.EditModeChanged -= h);

        /// <summary><see cref="DataGridView.FontChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FontChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.FontChanged += h,
                h => dgv.FontChanged -= h);

        /// <summary><see cref="DataGridView.ForeColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ForeColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ForeColorChanged += h,
                h => dgv.ForeColorChanged -= h);

        /// <summary><see cref="DataGridView.GridColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> GridColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.GridColorChanged += h,
                h => dgv.GridColorChanged -= h);

        /// <summary><see cref="DataGridView.MultiSelectChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MultiSelectChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.MultiSelectChanged += h,
                h => dgv.MultiSelectChanged -= h);

        /// <summary><see cref="DataGridView.NewRowNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> NewRowNeededAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.NewRowNeeded += h,
                h => dgv.NewRowNeeded -= h);

        /// <summary><see cref="DataGridView.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ReadOnlyChanged += h,
                h => dgv.ReadOnlyChanged -= h);

        /// <summary><see cref="DataGridView.RowContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowContextMenuStripChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowContextMenuStripChanged += h,
                h => dgv.RowContextMenuStripChanged -= h);

        /// <summary><see cref="DataGridView.RowContextMenuStripNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowContextMenuStripNeededEventArgs> RowContextMenuStripNeededAsObservable() =>
            Observable.FromEvent<DataGridViewRowContextMenuStripNeededEventHandler, DataGridViewRowContextMenuStripNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowContextMenuStripNeeded += h,
                h => dgv.RowContextMenuStripNeeded -= h);

        /// <summary><see cref="DataGridView.RowDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDefaultCellStyleChanged += h,
                h => dgv.RowDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.RowDirtyStateNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<QuestionEventArgs> RowDirtyStateNeededAsObservable() =>
            Observable.FromEvent<QuestionEventHandler, QuestionEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDirtyStateNeeded += h,
                h => dgv.RowDirtyStateNeeded -= h);

        /// <summary><see cref="DataGridView.RowDividerDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowDividerDoubleClickEventArgs> RowDividerDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewRowDividerDoubleClickEventHandler, DataGridViewRowDividerDoubleClickEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDividerDoubleClick += h,
                h => dgv.RowDividerDoubleClick -= h);

        /// <summary><see cref="DataGridView.RowDividerHeightChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowDividerHeightChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDividerHeightChanged += h,
                h => dgv.RowDividerHeightChanged -= h);

        /// <summary><see cref="DataGridView.RowEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> RowEnterAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowEnter += h,
                h => dgv.RowEnter -= h);

        /// <summary><see cref="DataGridView.RowErrorTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowErrorTextChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowErrorTextChanged += h,
                h => dgv.RowErrorTextChanged -= h);

        /// <summary><see cref="DataGridView.RowErrorTextNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowErrorTextNeededEventArgs> RowErrorTextNeededAsObservable() =>
            Observable.FromEvent<DataGridViewRowErrorTextNeededEventHandler, DataGridViewRowErrorTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowErrorTextNeeded += h,
                h => dgv.RowErrorTextNeeded -= h);

        /// <summary><see cref="DataGridView.RowHeaderCellChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowHeaderCellChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderCellChanged += h,
                h => dgv.RowHeaderCellChanged -= h);

        /// <summary><see cref="DataGridView.RowHeaderMouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> RowHeaderMouseClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderMouseClick += h,
                h => dgv.RowHeaderMouseClick -= h);

        /// <summary><see cref="DataGridView.RowHeaderMouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellMouseEventArgs> RowHeaderMouseDoubleClickAsObservable() =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderMouseDoubleClick += h,
                h => dgv.RowHeaderMouseDoubleClick -= h);

        /// <summary><see cref="DataGridView.RowHeadersBorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowHeadersBorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersBorderStyleChanged += h,
                h => dgv.RowHeadersBorderStyleChanged -= h);

        /// <summary><see cref="DataGridView.RowHeadersDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowHeadersDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersDefaultCellStyleChanged += h,
                h => dgv.RowHeadersDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.RowHeadersWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowHeadersWidthChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersWidthChanged += h,
                h => dgv.RowHeadersWidthChanged -= h);

        /// <summary><see cref="DataGridView.RowHeadersWidthSizeModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewAutoSizeModeEventArgs> RowHeadersWidthSizeModeChangedAsObservable() =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersWidthSizeModeChanged += h,
                h => dgv.RowHeadersWidthSizeModeChanged -= h);

        /// <summary><see cref="DataGridView.RowHeightChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowHeightChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightChanged += h,
                h => dgv.RowHeightChanged -= h);

        /// <summary><see cref="DataGridView.RowHeightInfoNeeded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowHeightInfoNeededEventArgs> RowHeightInfoNeededAsObservable() =>
            Observable.FromEvent<DataGridViewRowHeightInfoNeededEventHandler, DataGridViewRowHeightInfoNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightInfoNeeded += h,
                h => dgv.RowHeightInfoNeeded -= h);

        /// <summary><see cref="DataGridView.RowHeightInfoPushed"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowHeightInfoPushedEventArgs> RowHeightInfoPushedAsObservable() =>
            Observable.FromEvent<DataGridViewRowHeightInfoPushedEventHandler, DataGridViewRowHeightInfoPushedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightInfoPushed += h,
                h => dgv.RowHeightInfoPushed -= h);

        /// <summary><see cref="DataGridView.RowLeave"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> RowLeaveAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowLeave += h,
                h => dgv.RowLeave -= h);

        /// <summary><see cref="DataGridView.RowMinimumHeightChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowMinimumHeightChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowMinimumHeightChanged += h,
                h => dgv.RowMinimumHeightChanged -= h);

        /// <summary><see cref="DataGridView.RowPostPaint"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowPostPaintEventArgs> RowPostPaintAsObservable() =>
            Observable.FromEvent<DataGridViewRowPostPaintEventHandler, DataGridViewRowPostPaintEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowPostPaint += h,
                h => dgv.RowPostPaint -= h);

        /// <summary><see cref="DataGridView.RowPrePaint"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowPrePaintEventArgs> RowPrePaintAsObservable() =>
            Observable.FromEvent<DataGridViewRowPrePaintEventHandler, DataGridViewRowPrePaintEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowPrePaint += h,
                h => dgv.RowPrePaint -= h);

        /// <summary><see cref="DataGridView.RowsAdded"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowsAddedEventArgs> RowsAddedAsObservable() =>
            Observable.FromEvent<DataGridViewRowsAddedEventHandler, DataGridViewRowsAddedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsAdded += h,
                h => dgv.RowsAdded -= h);

        /// <summary><see cref="DataGridView.RowsDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RowsDefaultCellStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsDefaultCellStyleChanged += h,
                h => dgv.RowsDefaultCellStyleChanged -= h);

        /// <summary><see cref="DataGridView.RowsRemoved"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowsRemovedEventArgs> RowsRemovedAsObservable() =>
            Observable.FromEvent<DataGridViewRowsRemovedEventHandler, DataGridViewRowsRemovedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsRemoved += h,
                h => dgv.RowsRemoved -= h);

        /// <summary><see cref="DataGridView.RowStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowStateChangedEventArgs> RowStateChangedAsObservable() =>
            Observable.FromEvent<DataGridViewRowStateChangedEventHandler, DataGridViewRowStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowStateChanged += h,
                h => dgv.RowStateChanged -= h);

        /// <summary><see cref="DataGridView.RowUnshared"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> RowUnsharedAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowUnshared += h,
                h => dgv.RowUnshared -= h);

        /// <summary><see cref="DataGridView.RowValidated"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellEventArgs> RowValidatedAsObservable() =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowValidated += h,
                h => dgv.RowValidated -= h);

        /// <summary><see cref="DataGridView.RowValidating"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewCellCancelEventArgs> RowValidatingAsObservable() =>
            Observable.FromEvent<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowValidating += h,
                h => dgv.RowValidating -= h);

        /// <summary><see cref="DataGridView.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<ScrollEventArgs> ScrollAsObservable() =>
            Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
                h => (s, e) => h(e),
                h => dgv.Scroll += h,
                h => dgv.Scroll -= h);

        /// <summary><see cref="DataGridView.SelectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.SelectionChanged += h,
                h => dgv.SelectionChanged -= h);

        /// <summary><see cref="DataGridView.SortCompare"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewSortCompareEventArgs> SortCompareAsObservable() =>
            Observable.FromEvent<DataGridViewSortCompareEventHandler, DataGridViewSortCompareEventArgs>(
                h => (s, e) => h(e),
                h => dgv.SortCompare += h,
                h => dgv.SortCompare -= h);

        /// <summary><see cref="DataGridView.Sorted"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SortedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.Sorted += h,
                h => dgv.Sorted -= h);

        /// <summary><see cref="DataGridView.UserAddedRow"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> UserAddedRowAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserAddedRow += h,
                h => dgv.UserAddedRow -= h);

        /// <summary><see cref="DataGridView.UserDeletedRow"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowEventArgs> UserDeletedRowAsObservable() =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserDeletedRow += h,
                h => dgv.UserDeletedRow -= h);

        /// <summary><see cref="DataGridView.UserDeletingRow"/> as <see cref="Observable"/></summary>
        public IObservable<DataGridViewRowCancelEventArgs> UserDeletingRowAsObservable() =>
            Observable.FromEvent<DataGridViewRowCancelEventHandler, DataGridViewRowCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserDeletingRow += h,
                h => dgv.UserDeletingRow -= h);
    }
}
