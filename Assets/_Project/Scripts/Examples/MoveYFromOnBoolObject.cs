using DG.Tweening;
using KristinaWaldt.ExtensionMethods;

namespace KristinaWaldt.Examples
{
	public class MoveYFromOnBoolObject : AnimateOnBoolObjectBase
	{
		public float fromPosY = 0;
		private float originalPos;

		protected override void Awake()
		{
			base.Awake();
			originalPos = rectTransform.localPosition.y;
		}

		protected override void SetToDefault()
		{
			if (boolObject.RuntimeValue == false)
			{
				rectTransform.localPosition = rectTransform.localPosition.With(y: fromPosY);
			}
		}

		protected override void OpenAnimation()
		{
			rectTransform.localPosition = rectTransform.localPosition.With(y: fromPosY);
			tween = rectTransform.DOLocalMoveY(originalPos, inDuration).SetEase(easeIn);
		}
		
		protected override void CloseAnimation()
		{
			tween = rectTransform.DOLocalMoveY(fromPosY, outDuration).SetEase(easeOut);
		}
	}
}
