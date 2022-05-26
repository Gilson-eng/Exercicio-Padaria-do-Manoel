package Implements;

import Classes.UnidadeMedida;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

/**
 *
 * @author Gilson
 */
public class UnidadeMedidaImplements {
    
    public List<UnidadeMedida> getAllUnidadeMedida() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Query query = em.createQuery("from UnidadeMedida");
            return query.getResultList();
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
    public UnidadeMedida getUnidadeMedida(int idUnidadeMedida) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            UnidadeMedida unidadeMedida = em.find(UnidadeMedida.class, idUnidadeMedida);
            return unidadeMedida;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }
    
    
    public void updateUnidadeMedida(UnidadeMedida unidadeMedida) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.merge(unidadeMedida);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } 
    }
    
     public void insertUnidadeMedida(UnidadeMedida unidadeMedida) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(unidadeMedida);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
     
     public void deleteUnidadeMedida(int idUnidadeMedida) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            UnidadeMedida unidadeMedida = em.find(UnidadeMedida.class, idUnidadeMedida);
            if (unidadeMedida == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(unidadeMedida);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
}
