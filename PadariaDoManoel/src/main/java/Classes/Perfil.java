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
@Table (name = "TB_Perfil")


public class Perfil {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPerfil")
    private int idPerfil;
    @Column (name = "Descricao")
    private String descricao;

    public Perfil() {
    }

    public Perfil(int idPerfil, String descricao) {
        this.idPerfil = idPerfil;
        this.descricao = descricao;
    }

    public int getIdPerfil() {
        return idPerfil;
    }

    public void setIdPerfil(int idPerfil) {
        this.idPerfil = idPerfil;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
}
