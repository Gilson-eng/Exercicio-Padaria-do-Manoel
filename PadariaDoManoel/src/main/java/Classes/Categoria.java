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

@Entity //Padrão
@Table(name = "TB_Categoria") //Nome igual no banco

public class Categoria {
    
    @Id //Padrão
    @GeneratedValue(strategy = GenerationType.IDENTITY) //Padrão relacionado ao ID
    @Column(name = "IDCategoria") //Nome da coluna no banco
    private int idCategoria;
    @Column(name = "Descricao") //Nome da coluna no banco
    private String descricao;
    
    public Categoria() {
    }

    public Categoria(int idCategoria, String descricao) {
        this.idCategoria = idCategoria;
        this.descricao = descricao;
    }

    public int getIdCategoria() {
        return idCategoria;
    }

    public void setIdCategoria(int idCategoria) {
        this.idCategoria = idCategoria;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    
    
    
    
    
    
    
}
