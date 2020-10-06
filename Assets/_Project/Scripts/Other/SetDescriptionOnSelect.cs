using System;
using KristinaWaldt.ValueObjects;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

namespace KristinaWaldt
{
	public class SetDescriptionOnSelect : MonoBehaviour, IPointerEnterHandler
	{
		[TextArea]
		public string description;
		public StringArrayData randomDescriptions;
		public StringObject descriptionObject;

		private bool HasDescription => !String.IsNullOrEmpty(description);

		public void OnPointerEnter(PointerEventData eventData)
		{
			SetDescription();
		}

		public void SetDescription()
		{
			if (HasDescription)
			{
				descriptionObject.RuntimeValue = description;
			}
			else if (descriptionObject != null)
			{
				AssignRandomDescription();
			}
		}

		private void AssignRandomDescription()
		{
			descriptionObject.RuntimeValue = randomDescriptions.strings[Random.Range(0, randomDescriptions.strings.Length)];
		}
	}
}
