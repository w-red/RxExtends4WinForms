using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ListView"/>.</summary>
public static class ListViewRxExtends
{
    extension(ListView lv)
    {
        /// <summary><see cref="ListView.BeforeLabelEdit"/> as <see cref="Observable"/></summary>
        public IObservable<LabelEditEventArgs> BeforeLabelEditAsObservable() =>
            Observable.FromEvent<LabelEditEventHandler, LabelEditEventArgs>(
                h => (s, e) => h(e),
                h => lv.BeforeLabelEdit += h,
                h => lv.BeforeLabelEdit -= h);

        /// <summary><see cref="ListView.AfterLabelEdit"/> as <see cref="Observable"/></summary>
        public IObservable<LabelEditEventArgs> AfterLabelEditAsObservable() =>
            Observable.FromEvent<LabelEditEventHandler, LabelEditEventArgs>(
                h => (s, e) => h(e),
                h => lv.AfterLabelEdit += h,
                h => lv.AfterLabelEdit -= h);

        /// <summary><see cref="ListView.SearchForVirtualItem"/> as <see cref="Observable"/></summary>
        public IObservable<SearchForVirtualItemEventArgs> SearchForVirtualItemAsObservable() =>
            Observable.FromEvent<SearchForVirtualItemEventHandler, SearchForVirtualItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.SearchForVirtualItem += h,
                h => lv.SearchForVirtualItem -= h);

        /// <summary><see cref="ListView.CacheVirtualItems"/> as <see cref="Observable"/></summary>
        public IObservable<CacheVirtualItemsEventArgs> CacheVirtualItemsAsObservable() =>
            Observable.FromEvent<CacheVirtualItemsEventHandler, CacheVirtualItemsEventArgs>(
                h => (s, e) => h(e),
                h => lv.CacheVirtualItems += h,
                h => lv.CacheVirtualItems -= h);

        /// <summary><see cref="ListView.RetrieveVirtualItem"/> as <see cref="Observable"/></summary>
        public IObservable<RetrieveVirtualItemEventArgs> RetrieveVirtualItemAsObservable() =>
            Observable.FromEvent<RetrieveVirtualItemEventHandler, RetrieveVirtualItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.RetrieveVirtualItem += h,
                h => lv.RetrieveVirtualItem -= h);

        /// <summary><see cref="ListView.ColumnClick"/> as <see cref="Observable"/></summary>
        public IObservable<ColumnClickEventArgs> ColumnClickAsObservable() =>
            Observable.FromEvent<ColumnClickEventHandler, ColumnClickEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnClick += h,
                h => lv.ColumnClick -= h);

        /// <summary><see cref="ListView.ColumnReordered"/> as <see cref="Observable"/></summary>
        public IObservable<ColumnReorderedEventArgs> ColumnReorderedAsObservable() =>
            Observable.FromEvent<ColumnReorderedEventHandler, ColumnReorderedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnReordered += h,
                h => lv.ColumnReordered -= h);

        /// <summary><see cref="ListView.ColumnWidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ColumnWidthChangedEventArgs> ColumnWidthChangedAsObservable() =>
            Observable.FromEvent<ColumnWidthChangedEventHandler, ColumnWidthChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnWidthChanged += h,
                h => lv.ColumnWidthChanged -= h);

        /// <summary><see cref="ListView.ColumnWidthChanging"/> as <see cref="Observable"/></summary>
        public IObservable<ColumnWidthChangingEventArgs> ColumnWidthChangingAsObservable() =>
            Observable.FromEvent<ColumnWidthChangingEventHandler, ColumnWidthChangingEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnWidthChanging += h,
                h => lv.ColumnWidthChanging -= h);

        /// <summary><see cref="ListView.DrawColumnHeader"/> as <see cref="Observable"/></summary>
        public IObservable<DrawListViewColumnHeaderEventArgs> DrawColumnHeaderAsObservable() =>
            Observable.FromEvent<DrawListViewColumnHeaderEventHandler, DrawListViewColumnHeaderEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawColumnHeader += h,
                h => lv.DrawColumnHeader -= h);

        /// <summary><see cref="ListView.DrawItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawListViewItemEventArgs> DrawItemAsObservable() =>
            Observable.FromEvent<DrawListViewItemEventHandler, DrawListViewItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawItem += h,
                h => lv.DrawItem -= h);

        /// <summary><see cref="ListView.DrawSubItem"/> as <see cref="Observable"/></summary>
        public IObservable<DrawListViewSubItemEventArgs> DrawSubItemAsObservable() =>
            Observable.FromEvent<DrawListViewSubItemEventHandler, DrawListViewSubItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawSubItem += h,
                h => lv.DrawSubItem -= h);

#if NET5_0_OR_GREATER
        /// <summary><see cref="ListView.GroupCollapsedStateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ListViewGroupEventArgs> GroupCollapsedStateChangedAsObservable() =>
            Observable.FromEvent<EventHandler<ListViewGroupEventArgs>, ListViewGroupEventArgs>(
                h => (s, e) => h(e),
                h => lv.GroupCollapsedStateChanged += h,
                h => lv.GroupCollapsedStateChanged -= h);

        /// <summary><see cref="ListView.GroupTaskLinkClick"/> as <see cref="Observable"/></summary>
        public IObservable<ListViewGroupEventArgs> GroupTaskLinkClickAsObservable() =>
            Observable.FromEvent<EventHandler<ListViewGroupEventArgs>, ListViewGroupEventArgs>(
                h => (s, e) => h(e),
                h => lv.GroupTaskLinkClick += h,
                h => lv.GroupTaskLinkClick -= h);
#endif

        /// <summary><see cref="ListView.ItemActivate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ItemActivateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemActivate += h,
                h => lv.ItemActivate -= h);

        /// <summary><see cref="ListView.ItemChecked"/> as <see cref="Observable"/></summary>
        public IObservable<ItemCheckedEventArgs> ItemCheckedAsObservable() =>
            Observable.FromEvent<ItemCheckedEventHandler, ItemCheckedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemChecked += h,
                h => lv.ItemChecked -= h);

        /// <summary><see cref="ListView.ItemCheck"/> as <see cref="Observable"/></summary>
        public IObservable<ItemCheckEventArgs> ItemCheckAsObservable() =>
            Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemCheck += h,
                h => lv.ItemCheck -= h);

        /// <summary><see cref="ListView.ItemDrag"/> as <see cref="Observable"/></summary>
        public IObservable<ItemDragEventArgs> ItemDragAsObservable() =>
            Observable.FromEvent<ItemDragEventHandler, ItemDragEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemDrag += h,
                h => lv.ItemDrag -= h);

        /// <summary><see cref="ListView.ItemMouseHover"/> as <see cref="Observable"/></summary>
        public IObservable<ListViewItemMouseHoverEventArgs> ItemMouseHoverAsObservable() =>
            Observable.FromEvent<ListViewItemMouseHoverEventHandler, ListViewItemMouseHoverEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemMouseHover += h,
                h => lv.ItemMouseHover -= h);

        /// <summary><see cref="ListView.ItemSelectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ListViewItemSelectionChangedEventArgs> ItemSelectionChangedAsObservable() =>
            Observable.FromEvent<ListViewItemSelectionChangedEventHandler, ListViewItemSelectionChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemSelectionChanged += h,
                h => lv.ItemSelectionChanged -= h);

        /// <summary><see cref="ListView.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.RightToLeftLayoutChanged += h,
                h => lv.RightToLeftLayoutChanged -= h);

        /// <summary><see cref="ListView.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedIndexChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.SelectedIndexChanged += h,
                h => lv.SelectedIndexChanged -= h);

        /// <summary><see cref="ListView.VirtualItemsSelectionRangeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ListViewVirtualItemsSelectionRangeChangedEventArgs> VirtualItemsSelectionRangeChangedAsObservable() =>
            Observable.FromEvent<ListViewVirtualItemsSelectionRangeChangedEventHandler, ListViewVirtualItemsSelectionRangeChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.VirtualItemsSelectionRangeChanged += h,
                h => lv.VirtualItemsSelectionRangeChanged -= h);
    }
}
