using UnityEngine;

public class esqueleto : Enemigo, IAtacar, IRecibirDaño, IDropearItems
{
    #region constructor
    public esqueleto(string nombre, int vida, int nivel)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        vivo = true;
    }
    #endregion

    #region metodos
    public override void HabilidadEspecial()
    {
        Debug.Log(nombre + " lanza su brazo.");
    }
    public void Atacar()
    {
        Debug.Log(nombre + " ataca con sus huesos.");
    }
    public void RecibirDaño(int daño)
    {
        vida = vida - daño;

        if (vida <= 0)
        {
            vivo = false;
            Debug.Log(nombre + " ha muerto.");
        }
        else
        {
            Debug.Log(nombre + " recibió daño. Vida: " + vida);
        }
    }
    public void DropearItems()
    {
        Debug.Log(nombre + " dejó caer un objeto.");
    }
    #endregion
}
