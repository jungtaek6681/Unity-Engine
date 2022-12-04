using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// ��� ����Ƽ ��ũ��Ʈ�� ����ϴ� �⺻ Ŭ����
	// ������Ʈ, �̺�Ʈ, �ڷ�ƾ�� ����� �����ϰ� ����

	// ������Ʈ : ���ӿ�����Ʈ�� ������ �� �ִ� ��� ���� �⺻ Ŭ����
	public class ScriptComponent : MonoBehaviour
	{
		private void Component()
		{
			/*
			 * ������Ʈ ����
			 * gameObject	: ������Ʈ�� �����Ǿ� �ִ� ���ӿ�����Ʈ, �������� ������Ʈ�� �ݵ�� ���ӿ�����Ʈ�� �����Ǿ� ����
			 * transform	: ������Ʈ�� �����Ǿ� �ִ� ���ӿ�����Ʈ�� Ʈ������
			 * tag			: ������Ʈ�� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �±�
			 */

			// ������Ʈ �Լ�

			// GetComponent<{Ÿ��}>() : ���ӿ�����Ʈ���� ������ Ÿ���� ������Ʈ�� ��ȯ (������� �߰��� ������Ʈ ��ȯ)
			Transform component = GetComponent<Transform>();

			// GetComponents<{Ÿ��}>() : ���ӿ�����Ʈ���� ������ Ÿ���� ��� ������Ʈ���� ��ȯ (���� �߰��� ������� ��ȯ)
			Transform[] components = GetComponents<Transform>();

			// GetComponentInChildren<{Ÿ��}>() : ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ�� ��ȯ (���̿켱 Ž������ ������� �߰��� ������Ʈ ��ȯ)
			component = GetComponentInChildren<Transform>();

			// GetComponentsInChildrend<{Ÿ��}>() : ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ���� ��ȯ (���̿켱 Ž��������� ��ȯ)
			components = GetComponentsInChildren<Transform>();

			// GetComponentInParent<{Ÿ��}>() : ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ�� ��ȯ (������� �߰��� ������Ʈ ��ȯ)
			component = GetComponentInParent<Transform>();

			// GetComponentsInParent<{Ÿ��}>() : ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ���� ��ȯ  (���� �߰��� ������� ��ȯ)
			components = GetComponentsInParent<Transform>();
		}
	}
}
