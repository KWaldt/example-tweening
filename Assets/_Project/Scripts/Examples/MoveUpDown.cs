using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
	public class MoveUpDown : MonoBehaviour
	{
		public float amount = 5f;
		public float duration = 0.5f;
		public Ease ease = Ease.Unset;
		
		private void Start()
		{
			GetComponent<RectTransform>().DOAnchorPosY(amount, duration).SetLoops(-1, LoopType.Yoyo).SetEase(ease);
		}
	}
}
