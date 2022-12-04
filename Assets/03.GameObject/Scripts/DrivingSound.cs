using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class DrivingSound : MonoBehaviour
	{
		public AudioSource audioSource;
		public AudioClip idle;
		public AudioClip driving;

		public Rigidbody rigid;

		private void Update()
		{
			if (rigid.velocity.magnitude > 0.1f && audioSource.clip != driving)
			{
				audioSource.Stop();
				audioSource.clip = driving;
				audioSource.Play();
			}
			else if (rigid.velocity.magnitude <= 0.1f && audioSource.clip != idle)
			{
				audioSource.Stop();
				audioSource.clip = idle;
				audioSource.Play();
			}
		}
	}
}
