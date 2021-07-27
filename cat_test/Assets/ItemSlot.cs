using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler 
{
    private ShapeIngredient droppedObject;

    public ShapeIngredient getDroppedObject() {
        return this.droppedObject;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            this.droppedObject = eventData.pointerDrag.GetComponent<ShapeIngredient>();
            Debug.Log("helloo: "+ droppedObject);
        }
    }


}
