using KristinaWaldt.ValueObjects;
using TMPro;
using UnityEngine;

namespace KristinaWaldt
{
	public class SetTextToStringObject : MonoBehaviour
	{
		public StringObject stringObject;
		
		private TextMeshProUGUI textMeshProUgui;

		private void Awake()
		{
			textMeshProUgui = GetComponent<TextMeshProUGUI>();
			OnValueChangedTo(stringObject.RuntimeValue);
		}

		private void OnEnable()
		{
			stringObject.ValueChangedTo += OnValueChangedTo;
		}
		
		private void OnDisable()
		{
			stringObject.ValueChangedTo -= OnValueChangedTo;
		}

		private void OnValueChangedTo(string newValue)
		{
			textMeshProUgui.text = newValue;
		}
	}
}
