using UnityEngine;

public interface IConsumible
{
    public void Consumible(Enemigo enemigo);
}

public interface IAplicarBuffs
{
    public void AplicarBuffs(Enemigo enemigo);
}

public class Item : MonoBehaviour
{
    protected string nombreItem;

    public Item()
    {
        nombreItem = "Item desconocido";
    }

    public Item(string nombre)
    {
        nombreItem = nombre;
    }

    public string GetNombreItem()
    {
        return nombreItem;
    }
}
