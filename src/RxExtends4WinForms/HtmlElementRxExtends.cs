using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="HtmlElement"/>.</summary>
public static class HtmlElementRxExtends
{
    extension(HtmlElement he)
    {
        /// <summary><see cref="HtmlElement.Click"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> ClickAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Click += h,
                h => he.Click -= h);

        /// <summary><see cref="HtmlElement.DoubleClick"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> DoubleClickAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DoubleClick += h,
                h => he.DoubleClick -= h);

        /// <summary><see cref="HtmlElement.DragEnd"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> DragEndAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragEnd += h,
                h => he.DragEnd -= h);

        /// <summary><see cref="HtmlElement.DragLeave"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> DragLeaveAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragLeave += h,
                h => he.DragLeave -= h);

        /// <summary><see cref="HtmlElement.DragOver"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> DragOverAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragOver += h,
                h => he.DragOver -= h);

        /// <summary><see cref="HtmlElement.Drag"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> DragAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Drag += h,
                h => he.Drag -= h);

        /// <summary><see cref="HtmlElement.Focusing"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> FocusingAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Focusing += h,
                h => he.Focusing -= h);

        /// <summary><see cref="HtmlElement.GotFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> GotFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.GotFocus += h,
                h => he.GotFocus -= h);

        /// <summary><see cref="HtmlElement.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyDown += h,
                h => he.KeyDown -= h);

        /// <summary><see cref="HtmlElement.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyPress += h,
                h => he.KeyPress -= h);

        /// <summary><see cref="HtmlElement.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyUp += h,
                h => he.KeyUp -= h);

        /// <summary><see cref="HtmlElement.LosingFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> LosingFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.LosingFocus += h,
                h => he.LosingFocus -= h);

        /// <summary><see cref="HtmlElement.LostFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> LostFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.LostFocus += h,
                h => he.LostFocus -= h);

        /// <summary><see cref="HtmlElement.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseDown += h,
                h => he.MouseDown -= h);

        /// <summary><see cref="HtmlElement.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseEnter += h,
                h => he.MouseEnter -= h);

        /// <summary><see cref="HtmlElement.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseLeave += h,
                h => he.MouseLeave -= h);

        /// <summary><see cref="HtmlElement.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseMove += h,
                h => he.MouseMove -= h);

        /// <summary><see cref="HtmlElement.MouseOver"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseOverAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseOver += h,
                h => he.MouseOver -= h);

        /// <summary><see cref="HtmlElement.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseUp += h,
                h => he.MouseUp -= h);
    }
}
