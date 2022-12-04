using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptGameObject
{
	public class SceneChanger : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				SceneManager.LoadScene("GameObjectScene");
			}
		}
	}
}
