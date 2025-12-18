#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridColumnStyle"/>.</summary>
public static class DataGridColumnStyleRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridColumnStyle dgcs)
    {
        /// <summary><see cref="DataGridColumnStyle.AlignmentChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AlignmentChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.AlignmentChanged += h,
                h => dgcs.AlignmentChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.FontChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FontChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.FontChanged += h,
                h => dgcs.FontChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.HeaderTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HeaderTextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.HeaderTextChanged += h,
                h => dgcs.HeaderTextChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.MappingNameChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MappingNameChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.MappingNameChanged += h,
                h => dgcs.MappingNameChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.NullTextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> NullTextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.NullTextChanged += h,
                h => dgcs.NullTextChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> ReadOnlyChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.ReadOnlyChanged += h,
                h => dgcs.ReadOnlyChanged -= h);

        /// <summary><see cref="DataGridColumnStyle.WidthChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> WidthChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.WidthChanged += h,
                h => dgcs.WidthChanged -= h);
    }
#endif
}
