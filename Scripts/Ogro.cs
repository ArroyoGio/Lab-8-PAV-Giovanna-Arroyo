using UnityEngine;

public class Ogro : Enemigo, IAtacar, IRecibirDaño, IDropearItems
{
    //constructor
    public Ogro(string nombre, int vida, int Edaño, int nivel, bool vivo) : base(nombre, vida, Edaño, nivel, vivo)
    {

    }

    //metodo abstracto creado en la clase padre
    public override void HabilidadEspecial()
    {
        Debug.Log(nombre + " usa golpe de lodo");
    }

    #region metodos
    public void Atacar()
    {
        Debug.Log(nombre + " ataca con fuerza");
    }
    public void RecibirDaño(int daño)
    {
        vida = vida - daño;
        Debug.Log(nombre + " recibió " + daño + " de daño.");

        if (vida <= 0)
        {
            vivo = false;
            Debug.Log(nombre + " ha muerto.");
            DropearItems();
        }
    }

    public void DropearItems()
    {
        Debug.Log(nombre + " ha dejado caer sus items :o");
    }
    #endregion
}
