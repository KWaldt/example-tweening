using KristinaWaldt.ValueObjects;
using UnityEngine;

namespace KristinaWaldt.Examples
{
	public class ToggleBoolObjectOnAnimation : MonoBehaviour
	{
		public BoolObject boolObject;
		public AnimateOnBoolObjectBase animator;

		private void OnEnable()
		{
			if (animator == null)
				return;
			
			animator.Opened += TurnOn;
			animator.Closed += TurnOff;
		}

		private void OnDisable()
		{
			if (animator == null)
				return;
			
			animator.Opened -= TurnOn;
			animator.Closed -= TurnOff;
		}
		
		private void TurnOn()
		{
			boolObject.RuntimeValue = true;
		}
		
		private void TurnOff()
		{
			boolObject.RuntimeValue = false;
		}
	}
}
