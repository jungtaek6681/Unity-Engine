using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
				Shoot();
			}
		}

		public void Shoot()
		{
			// Instantiate : ���ӿ�����Ʈ �������� ���� ����
			Instantiate(bullet, shootPosition.position, shootPosition.rotation);
			audioSource.Play();
		}
	}
}