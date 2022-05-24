package Implements;

import Classes.ItemComanda;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

/**
 *
 * @author Gilson
 */
public class ItemComandaImplements {
    
    public ItemComandaImplements() {
    }   
        public List<ItemComanda> getAllItemComanda() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Query query = em.createQuery("from Categoria");
            return query.getResultList();
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();
        }
    }
    
     public ItemComanda getItemComanda(int idItemComanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            ItemComanda item = em.find(ItemComanda.class, idItemComanda);
            return item;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }
    
     /* Arrumar
     public static List<ItemComanda> getItemComanda(String descricaoCategoria) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Query query = em.createQuery("from Categoria c where c.descricaoCategoria like :dsc");
            query.setParameter("dsc", "%" + descricaoCategoria + "%");
            return query.getResultList();
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();
        }
    }*/
    
    
     public void updateItemComanda(ItemComanda item) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.merge(item);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } 
    }
     
     public void insertItemComanda(ItemComanda item) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(item);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }

    public void deleteItemComanda(int idItemComanda) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            ItemComanda item = em.find(ItemComanda.class, idItemComanda);
            if (item == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(item);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
     
     
     
     
    
}
