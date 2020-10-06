using System;
using DG.Tweening;
using KristinaWaldt.ValueObjects;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KristinaWaldt.Examples
{
	public abstract class AnimateOnBoolObjectBase : MonoBehaviour
	{
		public BoolObject boolObject;
		
		public float inDuration = 0.5f;
		public float outDuration = 0.5f;
		public Ease easeIn = Ease.OutElastic;
		public Ease easeOut = Ease.InOutCubic;

		protected RectTransform rectTransform;
		protected Tween tween;

		public event Action Opened;
		public event Action Closed;

		protected virtual void Awake()
		{
			rectTransform = GetComponent<RectTransform>();
		}

		private void Start()
		{
			if (boolObject != null)
			{
				SetToDefault();
			}
		}

		private void OnEnable()
		{
			if (boolObject != null)
			{
				boolObject.ValueChangedTo += OnValueChangedTo;
			}
		}
		
		private void OnDisable()
		{
			if (boolObject != null)
			{
				boolObject.ValueChangedTo -= OnValueChangedTo;
			}
		}

		private void OnValueChangedTo(bool value)
		{
			if (value)
			{
				Open();
				tween.OnComplete(() => Opened?.Invoke());
			}
			else
			{
				Close();
				tween.OnComplete(() => Closed?.Invoke());
			}
		}

		protected abstract void SetToDefault();

		protected abstract void OpenAnimation();
		
		protected abstract void CloseAnimation();

		public void Open()
		{
			tween.Kill();
			OpenAnimation();
		}
		
		public void Close()
		{
			tween.Kill();
			CloseAnimation();
		}
	}
	
#if UNITY_EDITOR
	[CustomEditor(typeof(AnimateOnBoolObjectBase), true)]
	public class AnimateOnBoolObjectBaseEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			var t = (AnimateOnBoolObjectBase) target;

			GUILayout.Space(10);
			if (GUILayout.Button("Open"))
			{
				t.Open();
			}
			if (GUILayout.Button("Close"))
			{
				t.Close();
			}
		}
	}
#endif
}
