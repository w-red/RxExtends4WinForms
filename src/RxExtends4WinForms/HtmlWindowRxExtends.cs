using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="HtmlWindow"/>.</summary>
public static class HtmlWindowRxExtends
{
    extension(HtmlWindow hw)
    {
        /// <summary><see cref="HtmlWindow.Error"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementErrorEventArgs> ErrorAsObservable() =>
            Observable.FromEvent<HtmlElementErrorEventHandler, HtmlElementErrorEventArgs>(
                h => (s, e) => h(e),
                h => hw.Error += h,
                h => hw.Error -= h);

        /// <summary><see cref="HtmlWindow.GotFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> GotFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.GotFocus += h,
                h => hw.GotFocus -= h);

        /// <summary><see cref="HtmlWindow.Load"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> LoadAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Load += h,
                h => hw.Load -= h);

        /// <summary><see cref="HtmlWindow.LostFocus"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> LostFocusAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.LostFocus += h,
                h => hw.LostFocus -= h);

        /// <summary><see cref="HtmlWindow.Resize"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> ResizeAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Resize += h,
                h => hw.Resize -= h);

        /// <summary><see cref="HtmlWindow.Scroll"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> ScrollAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Scroll += h,
                h => hw.Scroll -= h);

        /// <summary><see cref="HtmlWindow.Unload"/> as <see cref="Observable"/></summary>
        public IObservable<HtmlElementEventArgs> UnloadAsObservable() =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Unload += h,
                h => hw.Unload -= h);
    }
}
