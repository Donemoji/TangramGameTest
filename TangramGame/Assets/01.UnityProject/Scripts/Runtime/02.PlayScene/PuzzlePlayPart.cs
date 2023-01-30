using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems; 

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, 
    IPointerUpHandler, IPointerMoveHandler
{

    private bool isClicked = false;

    //눌렀을떄
    public void OnPointerDown(PointerEventData eventData) {
        isClicked= true;
    }


    //마우스를 드래그 중일떄
    public void OnPointerMove(PointerEventData eventData) {
        if(isClicked == true) {
            gameObject.SetLocalPos(eventData.position.x, eventData.position.y, 0f);
            GFunc.Log($"마우스의 포지션은? {eventData.position.x}, {eventData.position.y}");
        }
    }


    //손 땠을때
    public void OnPointerUp(PointerEventData eventData) {

        isClicked = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
