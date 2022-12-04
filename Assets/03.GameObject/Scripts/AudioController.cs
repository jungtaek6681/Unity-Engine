using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ScriptGameObject
{
	public class AudioController : MonoBehaviour
	{
		public AudioMixer audioMixer;

		public void SetMasterVolume(float volume)
		{
			audioMixer.SetFloat("MasterVolume", volume);
		}
	}
}
