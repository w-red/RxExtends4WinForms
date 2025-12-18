using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="WebBrowser"/>.</summary>
public static class WebBrowserRxExtends
{
    extension(WebBrowser wb)
    {
        /// <summary><see cref="WebBrowser.CanGoBackChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CanGoBackChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.CanGoBackChanged += h,
                h => wb.CanGoBackChanged -= h);

        /// <summary><see cref="WebBrowser.CanGoForwardChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CanGoForwardChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.CanGoForwardChanged += h,
                h => wb.CanGoForwardChanged -= h);

        /// <summary><see cref="WebBrowser.DocumentCompleted"/> as <see cref="Observable"/></summary>
        public IObservable<WebBrowserDocumentCompletedEventArgs> DocumentCompletedAsObservable() =>
            Observable.FromEvent<WebBrowserDocumentCompletedEventHandler, WebBrowserDocumentCompletedEventArgs>(
                h => (s, e) => h(e),
                h => wb.DocumentCompleted += h,
                h => wb.DocumentCompleted -= h);

        /// <summary><see cref="WebBrowser.DocumentTitleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DocumentTitleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.DocumentTitleChanged += h,
                h => wb.DocumentTitleChanged -= h);

        /// <summary><see cref="WebBrowser.EncryptionLevelChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> EncryptionLevelChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.EncryptionLevelChanged += h,
                h => wb.EncryptionLevelChanged -= h);

        /// <summary><see cref="WebBrowser.FileDownload"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FileDownloadAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.FileDownload += h,
                h => wb.FileDownload -= h);

        /// <summary><see cref="WebBrowser.Navigated"/> as <see cref="Observable"/></summary>
        public IObservable<WebBrowserNavigatedEventArgs> NavigatedAsObservable() =>
            Observable.FromEvent<WebBrowserNavigatedEventHandler, WebBrowserNavigatedEventArgs>(
                h => (s, e) => h(e),
                h => wb.Navigated += h,
                h => wb.Navigated -= h);

        /// <summary><see cref="WebBrowser.Navigating"/> as <see cref="Observable"/></summary>
        public IObservable<WebBrowserNavigatingEventArgs> NavigatingAsObservable() =>
            Observable.FromEvent<WebBrowserNavigatingEventHandler, WebBrowserNavigatingEventArgs>(
                h => (s, e) => h(e),
                h => wb.Navigating += h,
                h => wb.Navigating -= h);

        /// <summary><see cref="WebBrowser.NewWindow"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> NewWindowAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => wb.NewWindow += h,
                h => wb.NewWindow -= h);

        /// <summary><see cref="WebBrowser.ProgressChanged"/> as <see cref="Observable"/></summary>
        public IObservable<WebBrowserProgressChangedEventArgs> ProgressChangedAsObservable() =>
            Observable.FromEvent<WebBrowserProgressChangedEventHandler, WebBrowserProgressChangedEventArgs>(
                h => (s, e) => h(e),
                h => wb.ProgressChanged += h,
                h => wb.ProgressChanged -= h);

        /// <summary><see cref="WebBrowser.StatusTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> StatusTextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.StatusTextChanged += h,
                h => wb.StatusTextChanged -= h);
    }
}
