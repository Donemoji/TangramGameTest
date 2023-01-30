using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems; 

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, 
    IPointerUpHandler, IPointerMoveHandler
{

    private bool isClicked = false;

    //��������
    public void OnPointerDown(PointerEventData eventData) {
        isClicked= true;
    }


    //���콺�� �巡�� ���ϋ�
    public void OnPointerMove(PointerEventData eventData) {
        if(isClicked == true) {
            gameObject.SetLocalPos(eventData.position.x, eventData.position.y, 0f);
            GFunc.Log($"���콺�� ��������? {eventData.position.x}, {eventData.position.y}");
        }
    }


    //�� ������
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
