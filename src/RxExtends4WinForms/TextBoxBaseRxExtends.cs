using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TextBoxBase"/>.</summary>
public static class TextBoxBaseRxExtends
{
    extension(TextBoxBase tbb)
    {
        /// <summary><see cref="TextBoxBase.AcceptsTabChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AcceptsTabChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.AcceptsTabChanged += h,
                h => tbb.AcceptsTabChanged -= h);

        /// <summary><see cref="TextBoxBase.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> BorderStyleChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.BorderStyleChanged += h,
                h => tbb.BorderStyleChanged -= h);

        /// <summary><see cref="TextBoxBase.Click"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ClickAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.Click += h,
                h => tbb.Click -= h);

        /// <summary><see cref="TextBoxBase.MouseClick"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseClickAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tbb.MouseClick += h,
                h => tbb.MouseClick -= h);

        /// <summary><see cref="TextBoxBase.HideSelectionChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HideSelectionChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.HideSelectionChanged += h,
                h => tbb.HideSelectionChanged -= h);

        /// <summary><see cref="TextBoxBase.ModifiedChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ModifiedChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.ModifiedChanged += h,
                h => tbb.ModifiedChanged -= h);

        /// <summary><see cref="TextBoxBase.MultilineChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MultilineChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.MultilineChanged += h,
                h => tbb.MultilineChanged -= h);

        /// <summary><see cref="TextBoxBase.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.ReadOnlyChanged += h,
                h => tbb.ReadOnlyChanged -= h);
    }
}
