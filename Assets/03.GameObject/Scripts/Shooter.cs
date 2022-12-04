using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

namespace ScriptGameObject
{
	public class Shooter : MonoBehaviour
	{
		public GameObject bullet;
		public Transform shootPosition;
		public AudioSource audioSource;
		public CinemachineVirtualCamera cam;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Shoot();
			}

			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				FocuseOn();
			}
			else if (Input.GetKeyUp(KeyCode.LeftShift))
			{
				FocuseOff();
			}
		}

		private void FocuseOn()
		{
			cam.Priority = 30;
		}

		private void FocuseOff()
		{
			cam.Priority = 1;
		}

		public void Shoot()
		{
			// Instantiate : 게임오브젝트 프리팹을 씬에 생성
			Instantiate(bullet, shootPosition.position, shootPosition.rotation);
			audioSource.Play();
		}
	}
}