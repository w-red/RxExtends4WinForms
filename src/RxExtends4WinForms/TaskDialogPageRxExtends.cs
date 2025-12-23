#if NET5_0_OR_GREATER
using System.Reactive.Linq;
#endif

namespace RxExtends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574
#endif
/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="TaskDialogPage"/>.</summary>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574
#endif
public static class TaskDialogPageRxExtends
{
#if NET5_0_OR_GREATER
    extension(TaskDialogPage tdp)
    {
        /// <summary><see cref="TaskDialogPage.Created"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> CreatedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Created += h,
                h => tdp.Created -= h);

        /// <summary><see cref="TaskDialogPage.Destroyed"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> DestroyedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Destroyed += h,
                h => tdp.Destroyed -= h);

        /// <summary><see cref="TaskDialogPage.HelpRequest"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> HelpRequestAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.HelpRequest += h,
                h => tdp.HelpRequest -= h);

#if NET8_0_OR_GREATER
        /// <summary><see cref="TaskDialogPage.LinkClicked"/> as <see cref="Observable"/></summary>
        public IObservable<TaskDialogLinkClickedEventArgs> LinkClickedAsObservable() =>
            Observable.FromEvent<EventHandler<TaskDialogLinkClickedEventArgs>, TaskDialogLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => tdp.LinkClicked += h,
                h => tdp.LinkClicked -= h);
#endif
    }
#endif
}
