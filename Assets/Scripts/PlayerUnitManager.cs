using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitManager : MonoBehaviour
{
    public List<MarineBehaviour> Units => _units;
    private List<MarineBehaviour> _units;

    [SerializeField] private MarineBehaviour marine;
    public static PlayerUnitManager Instance { get; private set; }

    void Awake()
    {
        _units = new List<MarineBehaviour>();
        //_units.Add(new MarineBehaviour());
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(marine, new Vector3(0, 0, 0), Quaternion.identity);
            _units.Add(marine);
        }
    }

    public void Register(MarineBehaviour unit)
    {
        if (_units.Contains(unit)) return;
        _units.Add(unit);
        //unit.OnKilled += () => Deregister(unit);
    }

    public void Deregister(MarineBehaviour unit)
    {
        if (!_units.Contains(unit)) return;
        _units.Remove(unit);
    }
}
