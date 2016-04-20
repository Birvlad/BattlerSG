 using UnityEngine;
 using System.Collections;
 //using UnityEngine.EventSystems;
 
 public class LoadLevelByClick : MonoBehaviour
	{
		public string sLevelName="";
		void Start(){}
		
		void OnMouseDown() {
			if (sLevelName==""){
            Debug.Log("Error! Level name is empty!");
				return;
			}
			//if (EventSystem.current.IsPointerOverGameObject()) return;
			Debug.Log ("Try to load level:");
			Application.LoadLevel (""+sLevelName); 
	    }
	}