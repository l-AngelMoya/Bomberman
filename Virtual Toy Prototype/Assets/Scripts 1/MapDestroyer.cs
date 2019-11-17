using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class MapDestroyer : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile wallTile;
    public Tile destructibleTile;

    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell= tilemap.WorldToCell(worldPos);
        ExplodeCell(originCell);
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
    }
}
