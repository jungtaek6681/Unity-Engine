using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	public class CollisionDetector : MonoBehaviour
	{
		// Collision : 물리적인 밀어내기 연산과 충돌 검증

		// OnCollisionEnter : 충돌진입 이벤트 함수
		private void OnCollisionEnter(Collision collision)
		{
			Debug.Log("OnCollisionEnter");
		}

		// OnCollisionStay : 충돌중 이벤트 함수
		private void OnCollisionStay(Collision collision)
		{
			Debug.Log("OnCollisionStay");
		}

		// OnCollisionExit : 충돌해제 이벤트 함수
		private void OnCollisionExit(Collision collision)
		{
			Debug.Log("OnCollisionExit");
		}

		// Trigger : 물리적인 밀어내기 연산 없이 충돌 검증

		// OnTriggerEnter : 트리거진입 이벤트 함수
		private void OnTriggerEnter(Collider other)
		{
			Debug.Log("OnTriggerEnter");
		}

		// OnTriggerStay : 트리거중 이벤트 함수
		private void OnTriggerStay(Collider other)
		{
			Debug.Log("OnTriggerStay");
		}

		// OnTriggerExit : 트리거해제 이벤트 함수
		private void OnTriggerExit(Collider other)
		{
			Debug.Log("OnTriggerExit");
		}
	}
}