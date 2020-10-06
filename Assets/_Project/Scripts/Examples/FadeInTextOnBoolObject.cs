using DG.Tweening;
using TMPro;

namespace KristinaWaldt.Examples
{
	public class FadeInTextOnBoolObject : AnimateOnBoolObjectBase
	{
		private TextMeshProUGUI textMeshPro;
		private float originalAlpha;
		
		protected override void Awake()
		{
			base.Awake();
			textMeshPro = GetComponent<TextMeshProUGUI>();
			originalAlpha = textMeshPro.color.a;
		}

		protected override void SetToDefault()
		{
			if (boolObject.RuntimeValue == false)
			{
				textMeshPro.DOFade(0, 0);
			}
		}

		protected override void OpenAnimation()
		{
			tween = textMeshPro.DOFade(originalAlpha, inDuration).SetEase(easeIn);
		}

		protected override void CloseAnimation()
		{
			tween = textMeshPro.DOFade(0, outDuration).SetEase(easeOut);
		}
	}
}
