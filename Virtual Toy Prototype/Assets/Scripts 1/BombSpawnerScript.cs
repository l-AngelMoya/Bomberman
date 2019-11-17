using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawnerScript : MonoBehaviour
{

    public Tilemap tilemap;
    public GameObject bombPrefab;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition= Camera.main.ScreenToWorldPoint(Input.mousePosition); //Return the position of the camera.
            Vector3Int cell= tilemap.WorldToCell(worldPosition); //Transform the position in a celd //Int because the cell always are int.
            Vector3 cellCenterPosition= tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPosition, Quaternion.identity);
        } 
    }
}
