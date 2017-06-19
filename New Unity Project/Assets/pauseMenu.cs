using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour {
    GameObject ui;
    Text text;
 
    // Use this for initialization
    void Start () {
        ui = GameObject.FindGameObjectsWithTag("ui")[0].gameObject;
        ui.SetActive(false);
        StartCoroutine(PauseCoroutine());
    }
 
    IEnumerator PauseCoroutine () {
        while(true){
            if(Input.GetKeyDown(KeyCode.Escape)){
                if(Time.timeScale == 0){
                    ui.SetActive(false);
                    Cursor.visible = false;
                    Time.timeScale = 1;
                }else{
                    ui.SetActive(true);
                    Cursor.visible = true;
                    text = ui.transform.Find("Text").gameObject.GetComponent<Text>();
                    text.text = "hello";
                    Time.timeScale = 0;
                }
            }
            yield return null;
        }
    }
 
    public void ButtonClick(){
        text.text = "blah";
    }
}
