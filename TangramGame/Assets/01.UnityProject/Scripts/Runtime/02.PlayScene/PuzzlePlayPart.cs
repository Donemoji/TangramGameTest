using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems; 

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, 
    IPointerUpHandler, IDragHandler
{

    private bool isClicked = false;
    private RectTransform objRect = default;
    private PuzzleInitZone puzzleInitZone = default; 

    //��������
    public void OnPointerDown(PointerEventData eventData) {
        isClicked= true;
    }


    //���콺�� �巡�� ���ϋ�
    public void OnDrag(PointerEventData eventData) {
        if(isClicked == true) {
            //���� ��ǥ�� �����ϴ� ���� -> ����� �����Ӥ��� ���� �����ǿ� ���ϴ� �������� ���� 

            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor); 


            
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
        objRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponentMust<PuzzleInitZone>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
