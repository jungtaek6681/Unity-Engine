using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace ScriptGameObject
{
	public class TankController : MonoBehaviour
	{
		public Rigidbody rigid;
		public Space space;
		public float moveSpeed;
		public float turnSpeed;

		private void Update()
		{
			VelocityMove();
			RotateTurn();
		}

		private void VelocityMove()
		{
			if (space == Space.World)
			{
				// 게임월드 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					rigid.velocity = Vector3.forward * moveSpeed;
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					rigid.velocity = Vector3.back * moveSpeed;
				}
			}
			else
			{
				// 게임오브젝트 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					rigid.velocity = transform.forward * moveSpeed;
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					rigid.velocity = -1 * transform.forward * moveSpeed;
				}
			}
		}

		private void ForceMove()
		{
			if (space == Space.World)
			{
				// 게임월드 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					rigid.AddForce(Vector3.forward * moveSpeed * Time.deltaTime, ForceMode.Impulse);
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					rigid.AddForce(Vector3.back * moveSpeed * Time.deltaTime, ForceMode.Impulse);
				}
			}
			else
			{
				// 게임오브젝트 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					rigid.AddRelativeForce(Vector3.forward * moveSpeed * Time.deltaTime, ForceMode.Impulse);
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					rigid.AddRelativeForce(Vector3.back * moveSpeed * Time.deltaTime, ForceMode.Impulse);
				}
			}
		}

		private void TranslateMove()
		{
			if (space == Space.World)
			{
				// 게임월드 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
				}
			}
			else
			{
				// 게임오브젝트 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.Self);
				}
			}
		}

		// Transform을 이용한 이동이 아닐 경우 (외부에서 게임오브젝트를 이동시키는 경우)
		// transform.forward, transform.up, transform.right 와 같은
		// 게임오브젝트 기준의 방향성 백터를 이용하여 연산으로 진행
		private void PositionMove()
		{
			if (space == Space.World)
			{
				// 게임월드 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					transform.position += Vector3.back * moveSpeed * Time.deltaTime;
				}
			}
			else
			{
				// 게임오브젝트 기준 이동
				if (Input.GetKey(KeyCode.UpArrow))
				{
					transform.position += transform.forward * moveSpeed * Time.deltaTime;
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					transform.position -= transform.forward * moveSpeed * Time.deltaTime;
				}
			}
		}

		// transform.Rotate : 3차원 회전은 백터를 기준으로 시계방향으로 회전
		private void RotateTurn()
		{
			if (space == Space.World)
			{
				// 게임월드 기준 회전
				if (Input.GetKey(KeyCode.LeftArrow))
				{
					transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime, Space.World);
				}

				if (Input.GetKey(KeyCode.RightArrow))
				{
					transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime, Space.World);
				}
			}
			else
			{
				// 게임오브젝트 기준 회전
				if (Input.GetKey(KeyCode.LeftArrow))
				{
					transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime, Space.Self);
				}

				if (Input.GetKey(KeyCode.RightArrow))
				{
					transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime, Space.Self);
				}
			}
		}

		// Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
		//				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
		// EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
		//				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
		// 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

		// Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
		// 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
		private void RotationTurn()
		{
			float angle = transform.rotation.eulerAngles.y;
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.rotation = Quaternion.Euler(0, angle - turnSpeed * Time.deltaTime, 0);
			}

			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.rotation = Quaternion.Euler(0, angle + turnSpeed * Time.deltaTime, 0);
			}
		}

		// LookAt 회전 : 각도를 통해 회전이 아닌 목표 위치를 바라보도록 회전시키고 싶을 경우
		private void LookAtTurn()
		{
			Vector3 target = new Vector3(0, 0, 0);
			transform.LookAt(target);
		}
	}
}
