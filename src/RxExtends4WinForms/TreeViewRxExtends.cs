using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TreeView"/>.</summary>
public static class TreeViewRxExtends
{
    extension(TreeView tv)
    {
        /// <summary><see cref="TreeView.AfterCheck"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewEventArgs> AfterCheckAsObservable() =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterCheck += h,
                h => tv.AfterCheck -= h);

        /// <summary><see cref="TreeView.AfterCollapse"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewEventArgs> AfterCollapseAsObservable() =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterCollapse += h,
                h => tv.AfterCollapse -= h);

        /// <summary><see cref="TreeView.AfterExpand"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewEventArgs> AfterExpandAsObservable() =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterExpand += h,
                h => tv.AfterExpand -= h);

        /// <summary><see cref="TreeView.AfterLabelEdit"/> as <see cref="Observable"/></summary>
        public IObservable<NodeLabelEditEventArgs> AfterLabelEditAsObservable() =>
            Observable.FromEvent<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterLabelEdit += h,
                h => tv.AfterLabelEdit -= h);

        /// <summary><see cref="TreeView.AfterSelect"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewEventArgs> AfterSelectAsObservable() =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterSelect += h,
                h => tv.AfterSelect -= h);

        /// <summary><see cref="TreeView.BeforeCheck"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewCancelEventArgs> BeforeCheckAsObservable() =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeCheck += h,
                h => tv.BeforeCheck -= h);

        /// <summary><see cref="TreeView.BeforeCollapse"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewCancelEventArgs> BeforeCollapseAsObservable() =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeCollapse += h,
                h => tv.BeforeCollapse -= h);

        /// <summary><see cref="TreeView.BeforeExpand"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewCancelEventArgs> BeforeExpandAsObservable() =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeExpand += h,
                h => tv.BeforeExpand -= h);

        /// <summary><see cref="TreeView.BeforeLabelEdit"/> as <see cref="Observable"/></summary>
        public IObservable<NodeLabelEditEventArgs> BeforeLabelEditAsObservable() =>
            Observable.FromEvent<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeLabelEdit += h,
                h => tv.BeforeLabelEdit -= h);

        /// <summary><see cref="TreeView.BeforeSelect"/> as <see cref="Observable"/></summary>
        public IObservable<TreeViewCancelEventArgs> BeforeSelectAsObservable() =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeSelect += h,
                h => tv.BeforeSelect -= h);

        /// <summary><see cref="TreeView.DrawNode"/> as <see cref="Observable"/></summary>
        public IObservable<DrawTreeNodeEventArgs> DrawNodeAsObservable() =>
            Observable.FromEvent<DrawTreeNodeEventHandler, DrawTreeNodeEventArgs>(
                h => (s, e) => h(e),
                h => tv.DrawNode += h,
                h => tv.DrawNode -= h);

        /// <summary><see cref="TreeView.ItemDrag"/> as <see cref="Observable"/></summary>
        public IObservable<ItemDragEventArgs> ItemDragAsObservable() =>
            Observable.FromEvent<ItemDragEventHandler, ItemDragEventArgs>(
                h => (s, e) => h(e),
                h => tv.ItemDrag += h,
                h => tv.ItemDrag -= h);

        /// <summary><see cref="TreeView.NodeMouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<TreeNodeMouseClickEventArgs> NodeMouseClickAsObservable() =>
            Observable.FromEvent<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseClick += h,
                h => tv.NodeMouseClick -= h);

        /// <summary><see cref="TreeView.NodeMouseDoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<TreeNodeMouseClickEventArgs> NodeMouseDoubleClickAsObservable() =>
            Observable.FromEvent<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseDoubleClick += h,
                h => tv.NodeMouseDoubleClick -= h);

        /// <summary><see cref="TreeView.NodeMouseHover"/> as <see cref="Observable"/></summary>
        public IObservable<TreeNodeMouseHoverEventArgs> NodeMouseHoverAsObservable() =>
            Observable.FromEvent<TreeNodeMouseHoverEventHandler, TreeNodeMouseHoverEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseHover += h,
                h => tv.NodeMouseHover -= h);

        /// <summary><see cref="TreeView.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tv.RightToLeftLayoutChanged += h,
                h => tv.RightToLeftLayoutChanged -= h);
    }
}
