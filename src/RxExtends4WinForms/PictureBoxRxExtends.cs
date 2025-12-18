using System.ComponentModel;
using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="PictureBox"/>.</summary>
public static class PictureBoxRxExtends
{
    extension(PictureBox pb)
    {
        /// <summary><see cref="PictureBox.LoadCompleted"/> as <see cref="Observable"/></summary>
        public IObservable<AsyncCompletedEventArgs> LoadCompletedAsObservable() =>
            Observable.FromEvent<AsyncCompletedEventHandler, AsyncCompletedEventArgs>(
                h => (s, e) => h(e),
                h => pb.LoadCompleted += h,
                h => pb.LoadCompleted -= h);

        /// <summary><see cref="PictureBox.LoadProgressChanged"/> as <see cref="Observable"/></summary>
        public IObservable<ProgressChangedEventArgs> LoadProgressChangedAsObservable() =>
            Observable.FromEvent<ProgressChangedEventHandler, ProgressChangedEventArgs>(
                h => (s, e) => h(e),
                h => pb.LoadProgressChanged += h,
                h => pb.LoadProgressChanged -= h);

        /// <summary><see cref="PictureBox.SizeModeChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SizeModeChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pb.SizeModeChanged += h,
                h => pb.SizeModeChanged -= h);
    }
}
