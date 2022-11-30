using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// 모든 유니티 스크립트가 상속하는 기본 클래스
	// 컴포넌트, 이벤트, 코루틴의 기능을 포함하고 있음

	// 컴포넌트 : 게임오브젝트에 포함할 수 있는 모든 것의 기본 클래스
	public class ScriptComponent : MonoBehaviour
	{
		private void Component()
		{
			/*
			 * 컴포넌트 변수
			 * gameObject	: 컴포넌트가 부착되어 있는 게임오브젝트, 동작중인 컴포넌트는 반드시 게임오브젝트에 부착되어 있음
			 * transform	: 컴포넌트가 부착되어 있는 게임오브젝트의 트랜스폼
			 * tag			: 컴포넌트가 부착되어 있는 게임오브젝트의 태그
			 */

			// 컴포넌트 함수

			// GetComponent<{타입}>() : 게임오브젝트에서 지정한 타입의 컴포넌트를 반환 (가장먼저 발견한 컴포넌트 반환)
			Transform component = GetComponent<Transform>();

			// GetComponents<{타입}>() : 게임오브젝트에서 지정한 타입의 모든 컴포넌트들을 반환 (먼저 발견한 순서대로 반환)
			Transform[] components = GetComponents<Transform>();

			// GetComponentInChildren<{타입}>() : 게임오브젝트와 자식게임오브젝트들에서 지정한 타입의 컴포넌트를 반환 (깊이우선 탐색으로 가장먼저 발견한 컴포넌트 반환)
			component = GetComponentInChildren<Transform>();

			// GetComponentsInChildrend<{타입}>() : 게임오브젝트와 자식게임오브젝트들에서 지정한 타입의 컴포넌트들을 반환 (깊이우선 탐색순서대로 반환)
			components = GetComponentsInChildren<Transform>();

			// GetComponentInParent<{타입}>() : 게임오브젝트와 부모게임오브젝트들에서 지정한 타입의 컴포넌트를 반환 (가장먼저 발견한 컴포넌트 반환)
			component = GetComponentInParent<Transform>();

			// GetComponentsInParent<{타입}>() : 게임오브젝트와 부모게임오브젝트들에서 지정한 타입의 컴포넌트들을 반환  (먼저 발견한 순서대로 반환)
			components = GetComponentsInParent<Transform>();
		}
	}
}
