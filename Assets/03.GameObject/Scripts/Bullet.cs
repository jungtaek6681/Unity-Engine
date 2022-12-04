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
			// Destory(������Ʈ, �����ð�) : �����ð� �� ���ӿ�����Ʈ �Ǵ� ������Ʈ�� ���� ����
			Destroy(gameObject, 5f);
		}

		private void Update()
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}

		private void OnCollisionEnter(Collision collision)
		{
			// Destory : ���ӿ�����Ʈ �Ǵ� ������Ʈ�� ���� ����
			Instantiate(explosionEffect, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}

