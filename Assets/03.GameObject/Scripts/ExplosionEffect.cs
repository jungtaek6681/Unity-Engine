using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class ExplosionEffect : MonoBehaviour
	{
		private void Start()
		{
			Destroy(gameObject, 5f);
		}
	}
}