package Classes;
import java.util.Date;
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
@Table(name = "TB_Movimento")
public class Movimento {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDMovimento")
    private int idMovimento;
    @Column(name = "Descricao")
    private String descricao;
    @Column(name = "Tipo")
    private String tipo;
    @Column (name = "DataMovimento")
    private Date DataMovimento;
    @Column (name = "Valor")
    private float valor;
    
    //Arrumar o relacionamento
    @Column (name = "IDUsuario")
    private int idUsuario;

    public Movimento() {
    }

    public Movimento(int idMovimento, String descricao, String tipo, Date DataMovimento, float valor, int idUsuario) {
        this.idMovimento = idMovimento;
        this.descricao = descricao;
        this.tipo = tipo;
        this.DataMovimento = DataMovimento;
        this.valor = valor;
        this.idUsuario = idUsuario;
    }

    public int getIdMovimento() {
        return idMovimento;
    }

    public void setIdMovimento(int idMovimento) {
        this.idMovimento = idMovimento;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public Date getDataMovimento() {
        return DataMovimento;
    }

    public void setDataMovimento(Date DataMovimento) {
        this.DataMovimento = DataMovimento;
    }

    public float getValor() {
        return valor;
    }

    public void setValor(float valor) {
        this.valor = valor;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }
    
    
    
    
    
    
    
}
