using UnityEngine;


#region interfaces
public interface IAtacar
{
    public void Atacar();
}

public interface IRecibirDa�o
{
    public void RecibirDa�o(int da�o);
}
//caida de objetos
public interface IDropearItems
{
    public void DropearItems();
}
#endregion


public abstract class Enemigo : MonoBehaviour
{
    //atributo de la clase padre
    #region atributos
    protected string nombre;
    protected int vida;
    protected int da�o; //agregado
    protected int nivel;
    protected bool vivo;
   
    #endregion

    //aplico sobrecarga
    #region constructor
    public Enemigo()
    {
        nombre = "SinNombre";
        vida = 100;
        da�o = 20; //agregado
        nivel = 1;
        vivo = true;
    }

    public Enemigo(string nombre, int vida, int da�o, int nivel, bool vivo)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.da�o = da�o; //agregado
        this.nivel = nivel;
        this.vivo = vivo;
    }
    #endregion

    #region getters y setters


    //metodo especial para aplicar a clases hijas
    public abstract void HabilidadEspecial();

    //M�todos comunes
    public string GetNombre()
    {
        return nombre;
    }

    public int GetVida()
    {
        return vida;
    }
    //agregado
    public int GetDa�o()
    {
        return da�o;
    }
    public int GetNivel()
    {
        return nivel;
    }

    public bool EstaVivo()
    {
        return vivo;
    }

    public void SetVida(int nuevaVida)
    {
        vida = nuevaVida;
    }
    //agregado
    public void SetDa�o(int nuevoDa�o)
    {
        da�o = nuevoDa�o;
    }

    public void SetNivel(int nuevoNivel)
    {
        nivel = nuevoNivel;
    }
    #endregion
}
