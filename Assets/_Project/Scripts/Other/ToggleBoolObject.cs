using KristinaWaldt.ValueObjects;
using UnityEngine;

namespace KristinaWaldt
{
	public class ToggleBoolObject : MonoBehaviour
	{
		public void Toggle(BoolObject boolObject)
		{
			boolObject.RuntimeValue = !boolObject.RuntimeValue;
		}
	}
}
