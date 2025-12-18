using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="MaskedTextBox"/>.</summary>
public static class MaskedTextBoxRxExtends
{
    extension(MaskedTextBox mtb)
    {
        /// <summary><see cref="MaskedTextBox.IsOverwriteModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> IsOverwriteModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.IsOverwriteModeChanged += h,
                h => mtb.IsOverwriteModeChanged -= h);

        /// <summary><see cref="MaskedTextBox.MaskChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MaskChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.MaskChanged += h,
                h => mtb.MaskChanged -= h);

        /// <summary><see cref="MaskedTextBox.MaskInputRejected"/> as <see cref="Observable"/></summary>
        public IObservable<MaskInputRejectedEventArgs> MaskInputRejectedAsObservable() =>
            Observable.FromEvent<MaskInputRejectedEventHandler, MaskInputRejectedEventArgs>(
                h => (s, e) => h(e),
                h => mtb.MaskInputRejected += h,
                h => mtb.MaskInputRejected -= h);

        /// <summary><see cref="MaskedTextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextAlignChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.TextAlignChanged += h,
                h => mtb.TextAlignChanged -= h);

        /// <summary><see cref="MaskedTextBox.TypeValidationCompleted"/> as <see cref="Observable"/></summary>
        public IObservable<TypeValidationEventArgs> TypeValidationCompletedAsObservable() =>
            Observable.FromEvent<TypeValidationEventHandler, TypeValidationEventArgs>(
                h => (s, e) => h(e),
                h => mtb.TypeValidationCompleted += h,
                h => mtb.TypeValidationCompleted -= h);
    }
}
