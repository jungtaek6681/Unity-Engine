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
				// ���ӿ��� ���� �̵�
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
				// ���ӿ�����Ʈ ���� �̵�
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
				// ���ӿ��� ���� �̵�
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
				// ���ӿ�����Ʈ ���� �̵�
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
				// ���ӿ��� ���� �̵�
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
				// ���ӿ�����Ʈ ���� �̵�
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

		// Transform�� �̿��� �̵��� �ƴ� ��� (�ܺο��� ���ӿ�����Ʈ�� �̵���Ű�� ���)
		// transform.forward, transform.up, transform.right �� ����
		// ���ӿ�����Ʈ ������ ���⼺ ���͸� �̿��Ͽ� �������� ����
		private void PositionMove()
		{
			if (space == Space.World)
			{
				// ���ӿ��� ���� �̵�
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
				// ���ӿ�����Ʈ ���� �̵�
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

		// transform.Rotate : 3���� ȸ���� ���͸� �������� �ð�������� ȸ��
		private void RotateTurn()
		{
			if (space == Space.World)
			{
				// ���ӿ��� ���� ȸ��
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
				// ���ӿ�����Ʈ ���� ȸ��
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

		// Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
		//				  �������� ȸ������ ������ ������ �߻����� ����
		// EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
		//				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
		// ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

		// Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
		// ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
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

		// LookAt ȸ�� : ������ ���� ȸ���� �ƴ� ��ǥ ��ġ�� �ٶ󺸵��� ȸ����Ű�� ���� ���
		private void LookAtTurn()
		{
			Vector3 target = new Vector3(0, 0, 0);
			transform.LookAt(target);
		}
	}
}
