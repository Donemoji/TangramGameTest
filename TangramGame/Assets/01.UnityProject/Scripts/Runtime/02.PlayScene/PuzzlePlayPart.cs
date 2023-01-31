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

    //눌렀을떄
    public void OnPointerDown(PointerEventData eventData) {
        isClicked= true;
    }


    //마우스를 드래그 중일떄
    public void OnDrag(PointerEventData eventData) {
        if(isClicked == true) {
            //절대 좌표를 설정하는 로직 -> 상대적 움직임ㅁ을 현재 포지션에 더하는 로직으로 수정 

            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor); 


            
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
        objRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponentMust<PuzzleInitZone>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
