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
@Table(name = "TB_Comanda")
public class Comanda {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name = "IDComanda")
    private int idComanda;
    @Column (name = "DataComanda")
    private Date dataComanda;

    public Comanda() {
    }

    public Comanda(int idComanda, Date dataComanda) {
        this.idComanda = idComanda;
        this.dataComanda = dataComanda;
    }

    public int getIdComanda() {
        return idComanda;
    }

    public void setIdComanda(int idComanda) {
        this.idComanda = idComanda;
    }

    public Date getDataComanda() {
        return dataComanda;
    }

    public void setDataComanda(Date dataComanda) {
        this.dataComanda = dataComanda;
    }
     
    
    
    
}
