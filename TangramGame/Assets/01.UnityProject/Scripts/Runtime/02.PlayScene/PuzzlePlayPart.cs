using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler,
    IPointerUpHandler, IDragHandler
{

    private bool isClicked = false;
    private RectTransform objRect = default;
    private PuzzleInitZone puzzleInitZone = default;


    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;

        objRect = gameObject.GetRect();

        puzzleInitZone = transform.parent.
            gameObject.GetComponent<PuzzleInitZone>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //! 마우스 버튼을 눌렀을 때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;

    }   // OnPointerDown()

    //! 마우스 버튼에서 손을 땠을 때 동작하는 함수
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;

    }   // OnPointerUp()

    //! 마우스를 드래그 중일 때 동작하는 함수
    public void OnDrag(PointerEventData eventData)
    {
        if (isClicked == true)
        {
            // 절대 좌표를 설정하는 로직 ->
            // 상대적 움직임을 현재 포지션에 더하는 로직으로 수정
            // eventData.delta

            // 캔버스 scaleFactor 만큼 발생하는 오차를 수정하는 로직
            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanves.scaleFactor);
        }

    }   // OnPointerMove()

}
