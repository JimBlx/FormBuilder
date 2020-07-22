using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TBuilderControls
{
	/// <summary>
	/// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	///
	/// Step 1a) Using this custom control in a XAML file that exists in the current project.
	/// Add this XmlNamespace attribute to the root element of the markup file where it is 
	/// to be used:
	///
	///     xmlns:MyNamespace="clr-namespace:TBuilderControls"
	///
	///
	/// Step 1b) Using this custom control in a XAML file that exists in a different project.
	/// Add this XmlNamespace attribute to the root element of the markup file where it is 
	/// to be used:
	///
	///     xmlns:MyNamespace="clr-namespace:TBuilderControls;assembly=TBuilderControls"
	///
	/// You will also need to add a project reference from the project where the XAML file lives
	/// to this project and Rebuild to avoid compilation errors:
	///
	///     Right click on the target project in the Solution Explorer and
	///     "Add Reference"->"Projects"->[Browse to and select this project]
	///
	///
	/// Step 2)
	/// Go ahead and use your control in the XAML file.
	///
	///     <MyNamespace:TbSectionControl/>
	///
	/// </summary>
	public class TbSectionControl : Control
	{
		#region STATIC factory members.
		static TbSectionControl()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TbSectionControl), new FrameworkPropertyMetadata(typeof(TbSectionControl)));
		}

		/// <summary>
		/// Define and register JoeSection property for this class of control.
		/// </summary>
		public static readonly DependencyProperty JoeSectionProperty = DependencyProperty.Register("JoeSection", typeof(string), typeof(TbSectionControl), new PropertyMetadata(""));
		private static void OnJoeSectionChanged(DependencyObject d,
												DependencyPropertyChangedEventArgs e)
		{
			TbSectionControl secControl = d as TbSectionControl;
			secControl.OnJoeSectionChanged(e);
		}

		public static readonly DependencyProperty RickerBooleanProperty = DependencyProperty.Register("RickerBoolean", typeof(bool?), typeof(TbSectionControl), new PropertyMetadata(""));
		private static void OnRickerBooleanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			TbSectionControl secControl = d as TbSectionControl;
			secControl.OnRickerBooleanChanged(e);
		}

		private bool? _rickerBoolean = false;
		private void OnRickerBooleanChanged(DependencyPropertyChangedEventArgs e)
		{
			_rickerBoolean = (e.NewValue) as bool?;
		}

		#endregion STATIC factory members.

		#region INSTANCE members
//		private Button refButton;

		public string ElementName { get { return "Section"; } }

		private string _joeSectionString = string.Empty;

		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
		}

		/// <summary>
		/// GET and SET for an instance of this control.
		/// </summary>
		public string JoeSection
		{
			get {  return (GetValue(JoeSectionProperty) as string); }
			set { SetValue(JoeSectionProperty, value); }
		}

		private void OnJoeSectionChanged(DependencyPropertyChangedEventArgs e)
		{
			_joeSectionString = e.NewValue.ToString();
		}
		#endregion
	}
}
