using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="HtmlDocument"/>.</summary>
public static class HtmlDocumentRxExtends
{
    extension(HtmlDocument hd)
    {
        /// <summary><see cref="HtmlDocument.Click"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> ClickAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Click += h,
                h => hd.Click -= h);

        /// <summary><see cref="HtmlDocument.ContextMenuShowing"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> ContextMenuShowingAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.ContextMenuShowing += h,
                h => hd.ContextMenuShowing -= h);

        /// <summary><see cref="HtmlDocument.Focusing"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> FocusingAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Focusing += h,
                h => hd.Focusing -= h);

        /// <summary><see cref="HtmlDocument.LosingFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> LosingFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.LosingFocus += h,
                h => hd.LosingFocus -= h);

        /// <summary><see cref="HtmlDocument.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseDown += h,
                h => hd.MouseDown -= h);

        /// <summary><see cref="HtmlDocument.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseLeave += h,
                h => hd.MouseLeave -= h);

        /// <summary><see cref="HtmlDocument.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseMove += h,
                h => hd.MouseMove -= h);

        /// <summary><see cref="HtmlDocument.MouseOver"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseOverAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseOver += h,
                h => hd.MouseOver -= h);

        /// <summary><see cref="HtmlDocument.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseUp += h,
                h => hd.MouseUp -= h);

        /// <summary><see cref="HtmlDocument.Stop"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> StopAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Stop += h,
                h => hd.Stop -= h);
    }
}
