using System;
using Xamarin.Forms;

namespace Behavior
{
	public class NumericValidationTriggerAction : TriggerAction<Entry>
	{
		protected override void Invoke (Entry entry)
		{
			double result;
			bool isValid = Double.TryParse (entry.Text, out result);
			entry.TextColor = isValid ? Color.Default : Color.Red;
		}
	}

	public class ButtonTrigger: TriggerAction<Button>
	{
		protected override void Invoke (Button sender)
		{
			sender.TextColor = sender.TextColor == Color.Green ? Color.Red : Color.Green;
		}
	}

	public class ImageTrigger : TriggerAction<Image>
	{
		protected override void Invoke (Image sender)
		{
			sender.Opacity = .5;
		}

	}
}

