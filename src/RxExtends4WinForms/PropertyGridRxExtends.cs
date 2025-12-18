using System.Reactive.Linq;

namespace RxExtends4WinForms;

/// <summary><see cref="System.Reactive"/>'s Extends for <see cref="PropertyGrid"/>.</summary>
public static class PropertyGridRxExtends
{
    /// <summary><see cref="PropertyGrid"/> extension methods.</summary>
    extension(PropertyGrid pg)
    {
        /// <summary><see cref="PropertyGrid.KeyDown"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyDownAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyDown += h,
                h => pg.KeyDown -= h);

        /// <summary><see cref="PropertyGrid.KeyPress"/> as <see cref="Observable"/></summary>
        public IObservable<KeyPressEventArgs> KeyPressAsObservable() =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyPress += h,
                h => pg.KeyPress -= h);

        /// <summary><see cref="PropertyGrid.KeyUp"/> as <see cref="Observable"/></summary>
        public IObservable<KeyEventArgs> KeyUpAsObservable() =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyUp += h,
                h => pg.KeyUp -= h);

        /// <summary><see cref="PropertyGrid.MouseDown"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseDownAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseDown += h,
                h => pg.MouseDown -= h);

        /// <summary><see cref="PropertyGrid.MouseEnter"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseEnterAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseEnter += h,
                h => pg.MouseEnter -= h);

        /// <summary><see cref="PropertyGrid.MouseLeave"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> MouseLeaveAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseLeave += h,
                h => pg.MouseLeave -= h);

        /// <summary><see cref="PropertyGrid.MouseMove"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseMoveAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseMove += h,
                h => pg.MouseMove -= h);

        /// <summary><see cref="PropertyGrid.MouseUp"/> as <see cref="Observable"/></summary>
        public IObservable<MouseEventArgs> MouseUpAsObservable() =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseUp += h,
                h => pg.MouseUp -= h);

        /// <summary><see cref="PropertyGrid.PropertySortChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> PropertySortChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertySortChanged += h,
                h => pg.PropertySortChanged -= h);

        /// <summary><see cref="PropertyGrid.PropertyTabChanged"/> as <see cref="Observable"/></summary>
        public IObservable<PropertyTabChangedEventArgs> PropertyTabChangedAsObservable() =>
            Observable.FromEvent<PropertyTabChangedEventHandler, PropertyTabChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertyTabChanged += h,
                h => pg.PropertyTabChanged -= h);

        /// <summary><see cref="PropertyGrid.PropertyValueChanged"/> as <see cref="Observable"/></summary>
        public IObservable<PropertyValueChangedEventArgs> PropertyValueChangedAsObservable() =>
            Observable.FromEvent<PropertyValueChangedEventHandler, PropertyValueChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertyValueChanged += h,
                h => pg.PropertyValueChanged -= h);

        /// <summary><see cref="PropertyGrid.SelectedGridItemChanged"/> as <see cref="Observable"/></summary>
        public IObservable<SelectedGridItemChangedEventArgs> SelectedGridItemChangedAsObservable() =>
            Observable.FromEvent<SelectedGridItemChangedEventHandler, SelectedGridItemChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.SelectedGridItemChanged += h,
                h => pg.SelectedGridItemChanged -= h);

        /// <summary><see cref="PropertyGrid.SelectedObjectsChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> SelectedObjectsChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.SelectedObjectsChanged += h,
                h => pg.SelectedObjectsChanged -= h);

        /// <summary><see cref="PropertyGrid.TextChanged"/> as <see cref="Observable"/></summary>
        public IObservable<EventArgs> TextChangedAsObservable() =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.TextChanged += h,
                h => pg.TextChanged -= h);
    }
}
