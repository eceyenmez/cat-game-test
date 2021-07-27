using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLanana : MonoBehaviour
{
    [SerializeField] public ItemSlot itemSlot1;

    [SerializeField] public ItemSlot itemSlot2;

    [SerializeField] public ItemSlot itemSlot3;

    GameObject mCanvas;

    private void Start()
    {
        mCanvas = GameObject.Find("Canvas");

    }


    public void TestTest()
    {

        Debug.Log("slot 1: "+itemSlot1.getDroppedObject());
        Debug.Log("slot 2: " + itemSlot2.getDroppedObject());

        Debug.Log("slot 3: " + itemSlot3.getDroppedObject());

        GameObject shapeIngredient = new GameObject("produced ingredient");
        shapeIngredient.AddComponent<ShapeIngredient>();
        shapeIngredient.AddComponent<Image>();

        shapeIngredient.GetComponent<ShapeIngredient>().ingridientName = itemSlot1.getDroppedObject().ingridientName +" "+itemSlot2.getDroppedObject().ingridientName;
        shapeIngredient.GetComponent<Image>().sprite = itemSlot1.getDroppedObject().image;

        Color c = itemSlot2.getDroppedObject().GetComponent<Image>().color;
        shapeIngredient.GetComponent<Image>().color = c;

        shapeIngredient.transform.SetParent(mCanvas.transform);
        shapeIngredient.GetComponent<RectTransform>().anchoredPosition = itemSlot3.GetComponent<RectTransform>().anchoredPosition;



        Debug.Log("position of slot 3: "+itemSlot3.GetComponent<RectTransform>().anchoredPosition);

        Debug.Log("new ingredient: "+ shapeIngredient.GetComponent<ShapeIngredient>().ingridientName);

    }

    public void Clean() {

        Destroy(GameObject.Find("produced ingredient")) ;

    }
}
