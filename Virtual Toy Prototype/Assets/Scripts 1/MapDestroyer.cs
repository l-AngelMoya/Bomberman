using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class MapDestroyer : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile wallTile;
    public Tile destructibleTile;

    public GameObject explosionPrefab;

    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell= tilemap.WorldToCell(worldPos);
        ExplodeCell(originCell);
        ExplodeCell(originCell + new Vector3Int(1, 0, 0));
        //ExplodeCell(originCell + new Vector3Int(2, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, 1, 0));
        //ExplodeCell(originCell + new Vector3Int(0, 2, 0));
        ExplodeCell(originCell + new Vector3Int(-1, 0, 0));
        //ExplodeCell(originCell + new Vector3Int(-2, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, -1, 0));
        //ExplodeCell(originCell + new Vector3Int(0, -2, 0));
    }

    void ExplodeCell(Vector3Int cell)
    {
        TileBase tile= tilemap.GetTile<Tile>(cell);
        if (tile == wallTile)
        {
            return;
        }
        if (tile==destructibleTile)//Remove the tile
        {
            tilemap.SetTile(cell, null);
        }

        //create a explosion
        Vector3 pos= tilemap.GetCellCenterWorld(cell);
        Instantiate(explosionPrefab, pos, Quaternion.identity); 
        
    }
}
