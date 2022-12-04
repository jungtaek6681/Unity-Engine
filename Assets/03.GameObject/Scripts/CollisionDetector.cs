using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class CollisionDetector : MonoBehaviour
	{
		// Collision : �������� �о�� ����� �浹 ����

		// OnCollisionEnter : �浹���� �̺�Ʈ �Լ�
		private void OnCollisionEnter(Collision collision)
		{
			Debug.Log("OnCollisionEnter");
		}

		// OnCollisionStay : �浹�� �̺�Ʈ �Լ�
		private void OnCollisionStay(Collision collision)
		{
			Debug.Log("OnCollisionStay");
		}

		// OnCollisionExit : �浹���� �̺�Ʈ �Լ�
		private void OnCollisionExit(Collision collision)
		{
			Debug.Log("OnCollisionExit");
		}

		// Trigger : �������� �о�� ���� ���� �浹 ����

		// OnTriggerEnter : Ʈ�������� �̺�Ʈ �Լ�
		private void OnTriggerEnter(Collider other)
		{
			Debug.Log("OnTriggerEnter");
		}

		// OnTriggerStay : Ʈ������ �̺�Ʈ �Լ�
		private void OnTriggerStay(Collider other)
		{
			Debug.Log("OnTriggerStay");
		}

		// OnTriggerExit : Ʈ�������� �̺�Ʈ �Լ�
		private void OnTriggerExit(Collider other)
		{
			Debug.Log("OnTriggerExit");
		}
	}
}