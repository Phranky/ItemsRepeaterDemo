using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace ItemsRepeaterDemo.Controls
{
    public sealed class SubListControl : Control
    {
        public SubListControl()
        {
            this.DefaultStyleKey = typeof(SubListControl);
        }

        #region dependency properties

        #region ItemsSource

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(SubListControl), new PropertyMetadata(null));

        public object ItemsSource
        {
            get => (object)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        #endregion

        #region ItemTemplate

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register(nameof(ItemTemplate), typeof(DataTemplate), typeof(SubListControl), new PropertyMetadata(null));

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        #endregion

        #region Header

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(nameof(Header), typeof(object), typeof(SubListControl), new PropertyMetadata(null));

        public object Header
        {
            get => (object)GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }

        #endregion

        #region HeaderTemplate

        public static readonly DependencyProperty HeaderTemplateProperty = DependencyProperty.Register(nameof(HeaderTemplate), typeof(DataTemplate), typeof(SubListControl), new PropertyMetadata(null));

        public DataTemplate HeaderTemplate
        {
            get => (DataTemplate)GetValue(HeaderTemplateProperty);
            set => SetValue(HeaderTemplateProperty, value);
        }

        #endregion

        #region HeaderTransitions

        public static readonly DependencyProperty HeaderTransitionsProperty = DependencyProperty.Register(nameof(HeaderTransitions), typeof(TransitionCollection), typeof(SubListControl), new PropertyMetadata(null));

        public TransitionCollection HeaderTransitions
        {
            get => (TransitionCollection)GetValue(HeaderTransitionsProperty);
            set => SetValue(HeaderTransitionsProperty, value);
        }

        #endregion

        #region Footer

        public static readonly DependencyProperty FooterProperty = DependencyProperty.Register(nameof(Footer), typeof(object), typeof(SubListControl), new PropertyMetadata(null));

        public object Footer
        {
            get => (object)GetValue(FooterProperty);
            set => SetValue(FooterProperty, value);
        }

        #endregion

        #region FooterTemplate

        public static readonly DependencyProperty FooterTemplateProperty = DependencyProperty.Register(nameof(FooterTemplate), typeof(DataTemplate), typeof(SubListControl), new PropertyMetadata(null));

        public DataTemplate FooterTemplate
        {
            get => (DataTemplate)GetValue(FooterTemplateProperty);
            set => SetValue(FooterTemplateProperty, value);
        }

        #endregion

        #region FooterTransitions

        public static readonly DependencyProperty FooterTransitionsProperty = DependencyProperty.Register(nameof(FooterTransitions), typeof(TransitionCollection), typeof(SubListControl), new PropertyMetadata(null));

        public TransitionCollection FooterTransitions
        {
            get => (TransitionCollection)GetValue(FooterTransitionsProperty);
            set => SetValue(FooterTransitionsProperty, value);
        }

        #endregion

        #region FooterStyle

        public static readonly DependencyProperty FooterStyleProperty = DependencyProperty.Register(nameof(FooterStyle), typeof(Style), typeof(SubListControl), new PropertyMetadata(null));

        public Style FooterStyle
        {
            get => (Style)GetValue(FooterStyleProperty);
            set => SetValue(FooterStyleProperty, value);
        }

        #endregion

        #endregion

    }
}
