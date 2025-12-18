using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ToolStripRenderer"/>.</summary>
public static class ToolStripRendererRxExtends
{
    extension(ToolStripRenderer tsr)
    {
        /// <summary><see cref="ToolStripRenderer.RenderArrow"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripArrowRenderEventArgs> RenderArrowAsObservable() =>
            Observable.FromEvent<ToolStripArrowRenderEventHandler, ToolStripArrowRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderArrow += h,
                h => tsr.RenderArrow -= h);

        /// <summary><see cref="ToolStripRenderer.RenderButtonBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderButtonBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderButtonBackground += h,
                h => tsr.RenderButtonBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderDropDownButtonBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderDropDownButtonBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderDropDownButtonBackground += h,
                h => tsr.RenderDropDownButtonBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderGrip"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripGripRenderEventArgs> RenderGripAsObservable() =>
            Observable.FromEvent<ToolStripGripRenderEventHandler, ToolStripGripRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderGrip += h,
                h => tsr.RenderGrip -= h);

        /// <summary><see cref="ToolStripRenderer.RenderImageMargin"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripRenderEventArgs> RenderImageMarginAsObservable() =>
            Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderImageMargin += h,
                h => tsr.RenderImageMargin -= h);

        /// <summary><see cref="ToolStripRenderer.RenderItemBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderItemBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderItemBackground += h,
                h => tsr.RenderItemBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderItemCheck"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemImageRenderEventArgs> RenderItemCheckAsObservable() =>
            Observable.FromEvent<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderItemCheck += h,
                h => tsr.RenderItemCheck -= h);

        /// <summary><see cref="ToolStripRenderer.RenderItemImage"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemImageRenderEventArgs> RenderItemImageAsObservable() =>
            Observable.FromEvent<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderItemImage += h,
                h => tsr.RenderItemImage -= h);

        /// <summary><see cref="ToolStripRenderer.RenderItemText"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemTextRenderEventArgs> RenderItemTextAsObservable() =>
            Observable.FromEvent<ToolStripItemTextRenderEventHandler, ToolStripItemTextRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderItemText += h,
                h => tsr.RenderItemText -= h);

        /// <summary><see cref="ToolStripRenderer.RenderLabelBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderLabelBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderLabelBackground += h,
                h => tsr.RenderLabelBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderMenuItemBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderMenuItemBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderMenuItemBackground += h,
                h => tsr.RenderMenuItemBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderOverflowButtonBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderOverflowButtonBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderOverflowButtonBackground += h,
                h => tsr.RenderOverflowButtonBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderSeparator"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripSeparatorRenderEventArgs> RenderSeparatorAsObservable() =>
            Observable.FromEvent<ToolStripSeparatorRenderEventHandler, ToolStripSeparatorRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderSeparator += h,
                h => tsr.RenderSeparator -= h);

        /// <summary><see cref="ToolStripRenderer.RenderSplitButtonBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderSplitButtonBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderSplitButtonBackground += h,
                h => tsr.RenderSplitButtonBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderStatusStripSizingGrip"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripRenderEventArgs> RenderStatusStripSizingGripAsObservable() =>
            Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderStatusStripSizingGrip += h,
                h => tsr.RenderStatusStripSizingGrip -= h);

        /// <summary><see cref="ToolStripRenderer.RenderToolStripBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripRenderEventArgs> RenderToolStripBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderToolStripBackground += h,
                h => tsr.RenderToolStripBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderToolStripBorder"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripRenderEventArgs> RenderToolStripBorderAsObservable() =>
            Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderToolStripBorder += h,
                h => tsr.RenderToolStripBorder -= h);

        /// <summary><see cref="ToolStripRenderer.RenderToolStripContentPanelBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripContentPanelRenderEventArgs> RenderToolStripContentPanelBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripContentPanelRenderEventHandler, ToolStripContentPanelRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderToolStripContentPanelBackground += h,
                h => tsr.RenderToolStripContentPanelBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderToolStripPanelBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripPanelRenderEventArgs> RenderToolStripPanelBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripPanelRenderEventHandler, ToolStripPanelRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderToolStripPanelBackground += h,
                h => tsr.RenderToolStripPanelBackground -= h);

        /// <summary><see cref="ToolStripRenderer.RenderToolStripStatusLabelBackground"/> as <see cref="Observable"/></summary>
        public IObservable<ToolStripItemRenderEventArgs> RenderToolStripStatusLabelBackgroundAsObservable() =>
            Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
                h => (s, e) => h(e),
                h => tsr.RenderToolStripStatusLabelBackground += h,
                h => tsr.RenderToolStripStatusLabelBackground -= h);
    }
}
