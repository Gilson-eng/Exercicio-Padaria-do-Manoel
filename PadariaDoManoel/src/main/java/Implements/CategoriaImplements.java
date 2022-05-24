package Implements;


import Classes.Categoria;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

public class CategoriaImplements {

    public CategoriaImplements() {
    }   
        public List<Categoria> getAllCategorias() {
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

  
    public Categoria getCategoria(int idCategoria) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Categoria cat = em.find(Categoria.class, idCategoria);
            return cat;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }

  
    public static List<Categoria> getCategoria(String descricaoCategoria) {
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
    }

    
    public void updateCategoria(Categoria categoria) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.merge(categoria);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } 
    }

 
    public void insertCategoria(Categoria categoria) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(categoria);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }

   
    public void deleteCategoria(int idCategoria) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Categoria cat = em.find(Categoria.class, idCategoria);
            if (cat == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(cat);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }

}