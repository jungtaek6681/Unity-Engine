using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class Bullet : MonoBehaviour
	{
		public GameObject explosionEffect;
		public float moveSpeed;

		private void Start()
		{
			// Destory(오브젝트, 지연시간) : 지연시간 후 게임오브젝트 또는 컴포넌트의 제거 진행
			Destroy(gameObject, 5f);
		}

		private void Update()
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}

		private void OnCollisionEnter(Collision collision)
		{
			// Destory : 게임오브젝트 또는 컴포넌트의 제거 진행
			Instantiate(explosionEffect, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}

