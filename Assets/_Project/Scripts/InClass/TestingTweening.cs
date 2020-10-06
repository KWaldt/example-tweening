using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KristinaWaldt
{
	public class TestingTweening : MonoBehaviour
	{
		public void Open()
		{
			
		}

		public void Close()
		{
			
		}
	}
	
#if UNITY_EDITOR
	[CustomEditor(typeof(TestingTweening), true)]
	public class AnimateOnBoolObjectBaseEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			var t = (TestingTweening) target;

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
