using UnityEngine;

public class PocionNivel : Item, IAplicarBuffs
{
    public PocionNivel() : base()
    {
    }
    public PocionNivel(string nombre) : base(nombre)
    {
    }

    public void AplicarBuffs(Enemigo enemigo)
    {
        enemigo.SetNivel(enemigo.GetNivel() + 1);
        Debug.Log(nombreItem + " usado, " + enemigo.GetNombre() + " subió al nivel " + enemigo.GetNivel() + ".");
    }
}
