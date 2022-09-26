using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelections : MonoBehaviour
{
    public List<GameObject> Units = new List<GameObject>();
    public List<GameObject> UnitsSelected = new List<GameObject>();

    public static UnitSelections Instance { get; private set; }
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void ClickSelect(GameObject unit)
    {
        DeselectAll();
        UnitsSelected.Add(unit);
        unit.GetComponent<UnitMovement>().enabled = true;
    }

    public void DragSelect(GameObject unit)
    {
        if (!UnitsSelected.Contains(unit))
        {
            UnitsSelected.Add(unit);
            //unit.transform.GetChild(0).gameObject.SetActive(true);
            unit.GetComponent<UnitMovement>().enabled = true;
        }
    }

    public void DeselectAll()
    {
        foreach (var unit in UnitsSelected)
        {
            unit.GetComponent<UnitMovement>().enabled = false;
        }
        UnitsSelected.Clear();
    }

    public void Deselect(GameObject unit)
    {

    }
}
