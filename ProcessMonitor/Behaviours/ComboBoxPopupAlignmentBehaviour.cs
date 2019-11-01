using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace ProcessMonitor.Behaviours
{
    public enum PopupAlignment
    {
        BottomRigth
    }

    public class ComboBoxPopupAlignmentBehaviour:Behavior<ComboBox>
    {

        Popup pop = null;
        public PopupAlignment PopupAlignment
        {
            get { return (PopupAlignment)GetValue(PopupAlignmentProperty); }
            set { SetValue(PopupAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PopupAlignmentProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PopupAlignmentProperty =
            DependencyProperty.Register("PopupAlignment", typeof(PopupAlignment), typeof(ComboBoxPopupAlignmentBehaviour), new PropertyMetadata(PopupAlignment.BottomRigth));


        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += AssociatedObject_Loaded;
            base.OnAttached();
        }

        private void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            pop = VisualTreeHelperEx.GetChildObject<Popup>(this.AssociatedObject);
            if(pop != null)
            {
                pop.Placement =  PlacementMode.Right;
                pop.Opened += Pop_Opened;
                pop.SizeChanged += Pop_SizeChanged;

            }
        }

        private void Pop_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
        }

        private void Pop_Opened(object sender, EventArgs e)
        {
            switch (PopupAlignment)
            {
                case PopupAlignment.BottomRigth:
                    {
                        pop.VerticalOffset = this.AssociatedObject.ActualHeight +10 ;
                        pop.HorizontalOffset = -(pop.ActualWidth);
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void OnDetaching()
        {
            if(pop != null)
            {
                pop.Opened -= Pop_Opened;
            }
            this.AssociatedObject.Loaded -= AssociatedObject_Loaded;
            base.OnDetaching();
        }
    }
}
