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
 */
@Entity
@Table (name = "TB_Produtos")


public class Produto {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name = "IDProduto")
    private int idProduto;
    @Column (name = "Descricao")
    private String descricao;
    // Arrumar
    @Column (name = "IDUnidadeMedida")
    private int idUnidadeMedida;
    @Column (name = "IDCategoria")
    private int idCategoria;
    @Column (name = "CodigoDeBarras")
    private String codigoDeBarras;
    @Column (name = "Quantidade")
    private float quantidade;
    @Column (name = "QuantidadeMinima")
    private float quantidadeMinima;
    @Column (name = "ValorUnitario")
    private float valorUnitario;

    public Produto() {
    }

    public Produto(int idProduto, String descricao, int idUnidadeMedida, int idCategoria, String codigoDeBarras, 
            float quantidade, float quantidadeMinima, float valorUnitario) {
        this.idProduto = idProduto;
        this.descricao = descricao;
        this.idUnidadeMedida = idUnidadeMedida;
        this.idCategoria = idCategoria;
        this.codigoDeBarras = codigoDeBarras;
        this.quantidade = quantidade;
        this.quantidadeMinima = quantidadeMinima;
        this.valorUnitario = valorUnitario;
    }
    
    
    
    
    
    
}
