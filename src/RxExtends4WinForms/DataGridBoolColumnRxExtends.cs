#if !NETCOREAPP3_1_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="DataGridBoolColumn"/>.</summary>
public static class DataGridBoolColumnRxExtends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridBoolColumn dgbc)
    {
        /// <summary><see cref="DataGridBoolColumn.AllowNullChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> AllowNullChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.AllowNullChanged += h,
                h => dgbc.AllowNullChanged -= h);

        /// <summary><see cref="DataGridBoolColumn.FalseValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> FalseValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.FalseValueChanged += h,
                h => dgbc.FalseValueChanged -= h);

        /// <summary><see cref="DataGridBoolColumn.TrueValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TrueValueChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.TrueValueChanged += h,
                h => dgbc.TrueValueChanged -= h);
    }
#endif
}
