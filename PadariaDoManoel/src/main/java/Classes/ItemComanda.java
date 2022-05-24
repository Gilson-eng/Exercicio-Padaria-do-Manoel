package Classes;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 *
 * @author Gilson
 *  */
@Entity
@Table (name = "TB_Item_Comanda")
public class ItemComanda {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name = "IDItemComanda")
    private int idItemComanda;
    @Column (name = "Quantidade")
    private float quantidade;
    @Column (name = "ValorUnitario")
    private float valorUnitario;
    @Column (name = "IDComanda")
    private int idComanda;
    @Column (name = "IDProduto")
    private int idProduto;

    public ItemComanda() {
    }

    public ItemComanda(int idItemComanda, float quantidade, float valorUnitario, int idComanda, int idProduto) {
        this.idItemComanda = idItemComanda;
        this.quantidade = quantidade;
        this.valorUnitario = valorUnitario;
        this.idComanda = idComanda;
        this.idProduto = idProduto;
    }

    public int getIdItemComanda() {
        return idItemComanda;
    }

    public void setIdItemComanda(int idItemComanda) {
        this.idItemComanda = idItemComanda;
    }

    public float getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(float quantidade) {
        this.quantidade = quantidade;
    }

    public float getValorUnitario() {
        return valorUnitario;
    }

    public void setValorUnitario(float valorUnitario) {
        this.valorUnitario = valorUnitario;
    }

    public int getIdComanda() {
        return idComanda;
    }

    public void setIdComanda(int idComanda) {
        this.idComanda = idComanda;
    }

    public int getIdProduto() {
        return idProduto;
    }

    public void setIdProduto(int idProduto) {
        this.idProduto = idProduto;
    }
    
    
    
}
