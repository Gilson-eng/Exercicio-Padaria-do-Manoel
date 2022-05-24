package Implements;

import Classes.Comanda;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

/**
 *
 * @author Gilson
 */
public class ComandaImplements {
    
    public ComandaImplements() {
    }   
        public List<Comanda> getAllComandas() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Query query = em.createQuery("from Comanda");
            return query.getResultList();
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();
        }
    }
        
        public Comanda getComanda(int idComanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Comanda comanda = em.find(Comanda.class, idComanda);
            return comanda;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }
    
   
        public void updateComanda(Comanda comanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.merge(comanda);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } 
    }
    
    
    public void insertComanda(Comanda comanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(comanda);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
      public void deleteComanda(int idComanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Comanda comanda = em.find(Comanda.class, idComanda);
            if (comanda == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(comanda);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
        
}
