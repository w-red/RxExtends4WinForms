using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="RichTextBox"/>.</summary>
public static class RichTextBoxRxExtends
{
    extension(RichTextBox rtb)
    {
        /// <summary><see cref="RichTextBox.ContentsResized"/> as <see cref="Observable"/></summary>
        public IObservable<ContentsResizedEventArgs> ContentsResizedAsObservable() =>
            Observable.FromEvent<ContentsResizedEventHandler, ContentsResizedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.ContentsResized += h,
                h => rtb.ContentsResized -= h);

        /// <summary><see cref="RichTextBox.DragDrop"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragDropAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragDrop += h,
                h => rtb.DragDrop -= h);

        /// <summary><see cref="RichTextBox.DragEnter"/> as <see cref="Observable"/></summary>
        public IObservable<DragEventArgs> DragEnterAsObservable() =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragEnter += h,
                h => rtb.DragEnter -= h);

        /// <summary><see cref="RichTextBox.HScroll"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HScrollAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.HScroll += h,
                h => rtb.HScroll -= h);

        /// <summary><see cref="RichTextBox.ImeChange"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ImeChangeAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.ImeChange += h,
                h => rtb.ImeChange -= h);

        /// <summary><see cref="RichTextBox.LinkClicked"/> as <see cref="Observable"/></summary>
        public IObservable<LinkClickedEventArgs> LinkClickedAsObservable() =>
            Observable.FromEvent<LinkClickedEventHandler, LinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.LinkClicked += h,
                h => rtb.LinkClicked -= h);

        /// <summary><see cref="RichTextBox.Protected"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ProtectedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.Protected += h,
                h => rtb.Protected -= h);

        /// <summary><see cref="RichTextBox.SelectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.SelectionChanged += h,
                h => rtb.SelectionChanged -= h);

        /// <summary><see cref="RichTextBox.VScroll"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> VScrollAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.VScroll += h,
                h => rtb.VScroll -= h);
    }
}
