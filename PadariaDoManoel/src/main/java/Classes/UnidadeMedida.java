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
@Table (name = "TB_UnidadeMedida")
public class UnidadeMedida {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name = "IDUnidadeMedida")
    private int idUnidadeMedida;
    @Column (name = "Descricao")
    private String descricao;

    public UnidadeMedida() {
    }

    public UnidadeMedida(int idUnidadeMedida, String descricao) {
        this.idUnidadeMedida = idUnidadeMedida;
        this.descricao = descricao;
    }

    public int getIdUnidadeMedida() {
        return idUnidadeMedida;
    }

    public void setIdUnidadeMedida(int idUnidadeMedida) {
        this.idUnidadeMedida = idUnidadeMedida;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    
    
    
    
}
