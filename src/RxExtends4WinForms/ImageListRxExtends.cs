using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="ImageList"/>.</summary>
public static class ImageListRxExtends
{
    extension(ImageList il)
    {
        /// <summary><see cref="ImageList.RecreateHandle"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> RecreateHandleAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => il.RecreateHandle += h,
                h => il.RecreateHandle -= h);
    }
}
