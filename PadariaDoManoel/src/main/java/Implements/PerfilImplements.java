package Implements;

import Classes.Perfil;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.persistence.Query;

/**
 *
 * @author Gilson
 */
public class PerfilImplements {
    
    public Perfil getPerfil(int idPerfil) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Perfil perfil = em.find(Perfil.class, idPerfil);
            return perfil;
        } catch (Exception e) {
            return null;
        } finally {
            emf.close();
            em.close();

        }
    }
    
    
    public void updatePerfil(Perfil categoria) {
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
    
    
    public void insertPerfil(Perfil perfil) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            em.persist(perfil);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
    public void deletePerfil(int idPerfil) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("padaria");
        EntityManager em = emf.createEntityManager();
        try {
            Perfil perfil = em.find(Perfil.class, idPerfil);
            if (perfil == null) {
                return;
            }
            em.getTransaction().begin();
            em.remove(perfil);
            em.getTransaction().commit();
        } catch (Exception ex) {
            em.getTransaction().rollback();
        } finally {
            emf.close();
            em.close();
        }
    }
    
    
}
