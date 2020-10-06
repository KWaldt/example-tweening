using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
	public class PunchOnValueObject : AnimateOnValueObjectBase
	{
		[SerializeField] private Vector3 punchAmount = new Vector3(0.2f, 0.7f, 0);
		[SerializeField] private float duration = 0.2f;
		[SerializeField] private int vibrato = 1;
		[SerializeField] private float elasticity = 1f;

		private RectTransform rectTransform;
		private bool isAnimating;

		private void Awake()
		{
			rectTransform = GetComponent<RectTransform>();
		}
		
		protected override void OnValueChanged()
		{
			if (isAnimating)
				return;
			
			isAnimating = true;
			rectTransform.DOPunchScale(punchAmount, duration, vibrato, elasticity).OnComplete(() => isAnimating = false);
		}
	}
}
