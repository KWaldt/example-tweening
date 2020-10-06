using UnityEngine;

namespace KristinaWaldt
{
	[CreateAssetMenu(fileName = "StringArrayData", menuName = "Data/String Array")]
	public class StringArrayData : ScriptableObject
	{
		public string[] strings = new string[0];
	}
}
