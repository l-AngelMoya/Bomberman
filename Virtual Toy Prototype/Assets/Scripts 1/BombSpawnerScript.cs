using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawnerScript : MonoBehaviour
{

    public Tilemap tilemapGame;
    public Tilemap tilemapBackGround;

    public GameObject bombPrefab;
    public Tile rock;
    public Tile border;
    public Tile Box;
    public int count=1;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Return the position of the camera.
            Vector3Int cell = tilemapGame.WorldToCell(worldPosition); //Transform the position in a celd //Int because the cell always are int.
            Vector3 cellCenterPosition = tilemapGame.GetCellCenterWorld(cell);
            Vector3Int originCell = tilemapGame.WorldToCell(cellCenterPosition);
            TileBase tileGame = tilemapGame.GetTile<Tile>(cell);
            TileBase tileBack = tilemapBackGround.GetTile<Tile>(cell);

           
            if (tileGame == rock || tileBack == border || tileGame== Box)
            {
                return;
            }
            else
            {
                //if (count == 1)
                //{
                    Instantiate(bombPrefab, cellCenterPosition, Quaternion.identity);
                    //count = Time.deltaTim;
               // }

            }


        }
    }
}
