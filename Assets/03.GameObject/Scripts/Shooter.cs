using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class Shooter : MonoBehaviour
	{
		public GameObject bullet;
		public Transform shootPosition;
		public AudioSource audioSource;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				// Instantiate : 게임오브젝트 프리팹을 씬에 생성
				Instantiate(bullet, shootPosition.position, shootPosition.rotation);
				audioSource.Play();
			}
		}
	}
}