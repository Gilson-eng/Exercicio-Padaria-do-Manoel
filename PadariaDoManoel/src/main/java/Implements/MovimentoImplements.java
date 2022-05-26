package Implements;

import Classes.Movimento;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

/**
 *
 * @author Gilson
 */
public class MovimentoImplements {
    
    
    
    public Movimento getMovimento(int idMovimento) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Movimento movimento = em.find(Movimento.class, idMovimento);
            return movimento;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }
   
    public static List<Movimento> getMovimento(String movimento) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Query query = em.createQuery("from Movimento c where c.descricaoMovimento like :dsc");
            query.setParameter("dsc", "%" + movimento + "%");
            return query.getResultList();
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
    public void updateMovimento(Movimento movimento) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.merge(movimento);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } 
    }
    
    public void insertCategoria(Movimento movimento) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(movimento);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
     public void deleteMovimento(int idMovimento) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Movimento movimento = em.find(Movimento.class, idMovimento);
            if (movimento == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(movimento);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
