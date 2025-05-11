using UnityEngine;

public class PocionVida : Item, IConsumible
{
    public PocionVida() : base()
    {

    }
    public PocionVida(string nombre) : base(nombre)
    {

    }

    public void Consumible(Enemigo enemigo)
    {
        enemigo.SetVida(enemigo.GetVida() + 30);
        Debug.Log(nombreItem + " consumida, " + enemigo.GetNombre() + " ahora tiene " + enemigo.GetVida() + " de vida.");
    }
}
