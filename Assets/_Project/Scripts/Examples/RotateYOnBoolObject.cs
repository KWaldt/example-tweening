using DG.Tweening;
using KristinaWaldt.ExtensionMethods;
using UnityEngine;

namespace KristinaWaldt.Examples
{
	public class RotateYOnBoolObject : AnimateOnBoolObjectBase
	{
		public bool leftAligned = true;
		private float GoalValue => leftAligned ? -90 : 90;

		protected override void SetToDefault()
		{
			if (boolObject.RuntimeValue == false)
			{
				rectTransform.localEulerAngles = rectTransform.localEulerAngles.With(y: GoalValue);
			}
		}

		protected override void OpenAnimation()
		{
			rectTransform.localEulerAngles = rectTransform.localEulerAngles.With(y: GoalValue);
			tween = rectTransform.DORotate(new Vector3(0, 0, 0), inDuration).SetEase(easeIn);
		}

		protected override void CloseAnimation()
		{
			tween = rectTransform.DORotate(new Vector3(0, GoalValue, 0), outDuration).SetEase(easeOut);
		}
	}
}
