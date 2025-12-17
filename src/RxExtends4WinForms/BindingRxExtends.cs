using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s extensions for <see cref="Binding"/></summary>
public static class BindingRxExtends
{
    extension(Binding bg)
    {
        /// <summary><see cref="Binding.BindingComplete"/> as <see cref="Observable"/></summary>
        public IObservable<BindingCompleteEventArgs> BindingCompleteAsObservable() =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bg.BindingComplete += h,
                h => bg.BindingComplete -= h);

        /// <summary><see cref="Binding.Format"/> as <see cref="Observable"/></summary>
        public IObservable<ConvertEventArgs> FormatAsObservable() =>
            Observable.FromEvent<ConvertEventHandler, ConvertEventArgs>(
                h => (s, e) => h(e),
                h => bg.Format += h,
                h => bg.Format -= h);

        /// <summary><see cref="Binding.Parse"/> as <see cref="Observable"/></summary>
        public IObservable<ConvertEventArgs> ParseAsObservable() =>
            Observable.FromEvent<ConvertEventHandler, ConvertEventArgs>(
                h => (s, e) => h(e),
                h => bg.Parse += h,
                h => bg.Parse -= h);
    }
}

