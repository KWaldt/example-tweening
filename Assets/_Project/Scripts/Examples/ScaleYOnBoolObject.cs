using DG.Tweening;
using KristinaWaldt.ExtensionMethods;

namespace KristinaWaldt.Examples
{
	public class ScaleYOnBoolObject : AnimateOnBoolObjectBase
	{
		protected override void SetToDefault()
		{
			if (boolObject.RuntimeValue == false)
			{
				rectTransform.localScale = rectTransform.localScale.With(y: 0);
			}
		}

		protected override void OpenAnimation()
		{
			rectTransform.localScale = rectTransform.localScale.With(y: 0);
			tween = rectTransform.DOScaleY(1, inDuration).SetEase(easeIn);
		}
		
		protected override void CloseAnimation()
		{
			tween = rectTransform.DOScaleY(0, outDuration).SetEase(easeOut);
		}
	}
}
