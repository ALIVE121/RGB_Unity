using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]
public class RazerReflect : MonoBehaviour {
	public LineRenderer line;
	private void Start () {
		line.enabled = true;
	}

	private void Update () {
	laser ();
   }
	void laser(){
		RaycastHit hit;

		if (Physics.Raycast(transform.position, Vector3.forward, out hit, Mathf.Infinity)){
			line.enabled=true;
			line.SetPosition(0,transform.position);
			line.SetPosition(1,hit.transform.position);
			Vector3 pos=Vector3.Reflect(hit.point-this.transform.position,hit.normal);//노멀벡터와 입사각 백터로 반사백터 구함 
			line.SetPosition(2,pos);//반사 백터 라인렌더러 인덱스2에 대입
  }
 }
}
