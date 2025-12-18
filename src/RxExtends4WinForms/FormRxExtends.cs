using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="Form"/></summary>
public static class FormRxExtends
{
    extension(Form frm)
    {
        /// <summary><see cref="Form.Load"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> LoadAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Load += h,
                h => frm.Load -= h);

#if !NET10_0_OR_GREATER
        /// <summary><see cref="Form.Closing"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> ClosingAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => frm.Closing += h,
                h => frm.Closing -= h);

        /// <summary><see cref="Form.Closed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClosedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Closed += h,
                h => frm.Closed -= h);
#endif

#if NET9_0_OR_GREATER
        /// <summary><see cref="Form.FormBorderColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormBorderColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.FormBorderColorChanged += h,
                h => frm.FormBorderColorChanged -= h);

        /// <summary><see cref="Form.FormCaptionBackColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormCaptionBackColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.FormCaptionBackColorChanged += h,
                h => frm.FormCaptionBackColorChanged -= h);

        /// <summary><see cref="Form.FormCaptionTextColorChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormCaptionTextColorChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.FormCaptionTextColorChanged += h,
                h => frm.FormCaptionTextColorChanged -= h);

        /// <summary><see cref="Form.FormCornerPreferenceChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FormCornerPreferenceChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.FormCornerPreferenceChanged += h,
                h => frm.FormCornerPreferenceChanged -= h);
#endif

        /// <summary><see cref="Form.FormClosing"/> as <see cref="Observable"/></summary>
        public IObservable<FormClosingEventArgs> FormClosingAsObservable() =>
            Observable.FromEvent<FormClosingEventHandler, FormClosingEventArgs>(
                h => (s, e) => h(e),
                h => frm.FormClosing += h,
                h => frm.FormClosing -= h);

        /// <summary><see cref="Form.FormClosed"/> as <see cref="Observable"/></summary>
        public IObservable<FormClosedEventArgs> FormClosedAsObservable() =>
            Observable.FromEvent<FormClosedEventHandler, FormClosedEventArgs>(
                h => (s, e) => h(e),
                h => frm.FormClosed += h,
                h => frm.FormClosed -= h);

        /// <summary><see cref="Form.Activated"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ActivatedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Activated += h,
                h => frm.Activated -= h);

        /// <summary><see cref="Form.Deactivate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DeactivateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Deactivate += h,
                h => frm.Deactivate -= h);

        /// <summary><see cref="Form.Shown"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ShownAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Shown += h,
                h => frm.Shown -= h);

        /// <summary><see cref="Form.HelpButtonClicked"/> as <see cref="Observable"/></summary>
        public IObservable<CancelEventArgs> HelpButtonClickedAsObservable() =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => frm.HelpButtonClicked += h,
                h => frm.HelpButtonClicked -= h);

        /// <summary><see cref="Form.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.AutoSizeChanged += h,
                h => frm.AutoSizeChanged -= h);

        /// <summary><see cref="Form.AutoValidateChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AutoValidateChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.AutoValidateChanged += h,
                h => frm.AutoValidateChanged -= h);

        /// <summary><see cref="Form.DpiChanged"/> as <see cref="Observable"/></summary>
        public IObservable<DpiChangedEventArgs> DpiChangedAsObservable() =>
            Observable.FromEvent<DpiChangedEventHandler, DpiChangedEventArgs>(
                h => (s, e) => h(e),
                h => frm.DpiChanged += h,
                h => frm.DpiChanged -= h);

        /// <summary><see cref="Form.InputLanguageChanging"/> as <see cref="Observable"/></summary>
        public IObservable<InputLanguageChangingEventArgs> InputLanguageChangingAsObservable() =>
            Observable.FromEvent<InputLanguageChangingEventHandler, InputLanguageChangingEventArgs>(
                h => (s, e) => h(e),
                h => frm.InputLanguageChanging += h,
                h => frm.InputLanguageChanging -= h);

        /// <summary><see cref="Form.InputLanguageChanged"/> as <see cref="Observable"/></summary>
        public IObservable<InputLanguageChangedEventArgs> InputLanguageChangedAsObservable() =>
            Observable.FromEvent<InputLanguageChangedEventHandler, InputLanguageChangedEventArgs>(
                h => (s, e) => h(e),
                h => frm.InputLanguageChanged += h,
                h => frm.InputLanguageChanged -= h);

        /// <summary><see cref="Form.MaximizedBoundsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MaximizedBoundsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MaximizedBoundsChanged += h,
                h => frm.MaximizedBoundsChanged -= h);

        /// <summary><see cref="Form.MaximumSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MaximumSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MaximumSizeChanged += h,
                h => frm.MaximumSizeChanged -= h);

        /// <summary><see cref="Form.MinimumSizeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MinimumSizeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MinimumSizeChanged += h,
                h => frm.MinimumSizeChanged -= h);

        /// <summary><see cref="Form.MdiChildActivate"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MdiChildActivateAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MdiChildActivate += h,
                h => frm.MdiChildActivate -= h);

        /// <summary><see cref="Form.MenuStart"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MenuStartAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MenuStart += h,
                h => frm.MenuStart -= h);

        /// <summary><see cref="Form.MenuComplete"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MenuCompleteAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MenuComplete += h,
                h => frm.MenuComplete -= h);

        /// <summary><see cref="Form.ResizeBegin"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ResizeBeginAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.ResizeBegin += h,
                h => frm.ResizeBegin -= h);

        /// <summary><see cref="Form.ResizeEnd"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ResizeEndAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.ResizeEnd += h,
                h => frm.ResizeEnd -= h);

        /// <summary><see cref="Form.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RightToLeftLayoutChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.RightToLeftLayoutChanged += h,
                h => frm.RightToLeftLayoutChanged -= h);
    }
}
