using KristinaWaldt.ValueObjects;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KristinaWaldt.Examples
{
	public abstract class AnimateOnValueObjectBase : MonoBehaviour
	{
		public ValueObjectBase valueObject;

		protected virtual void OnEnable()
		{
			if (valueObject != null)
			{
				valueObject.ValueChanged += OnValueChanged;
			}
		}

		protected virtual void OnDisable()
		{
			if (valueObject != null)
			{
				valueObject.ValueChanged -= OnValueChanged;
			}
		}

		public void Animate() => OnValueChanged();

		protected abstract void OnValueChanged();
	}
	
#if UNITY_EDITOR
	[CustomEditor(typeof(AnimateOnValueObjectBase), true)]
	public class AnimateOnValueObjectBaseEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			var t = (AnimateOnValueObjectBase) target;

			GUILayout.Space(10);
			if (GUILayout.Button("Animate"))
			{
				t.Animate();
			}
		}
	}
#endif
}
