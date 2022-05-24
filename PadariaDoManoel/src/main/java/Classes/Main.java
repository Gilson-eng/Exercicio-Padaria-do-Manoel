package Classes;
import Implements.*; 
import java.util.Date;
/**
 *
 * @author Gilson
 */
public class Main {

    public static void main(String[] args) {
       
   Categoria cat = new Categoria();
   cat.setDescricao("CACHORRO Quente");
   CategoriaImplements catInsert = new CategoriaImplements();
   catInsert.insertCategoria(cat); 
   
   /*Comanda comanda = new Comanda();
   ComandaImplements comandaInsert = new ComandaImplements();
   comanda = comandaInsert.getComanda(27);
   System.out.println(comanda.getDataComanda());*/
   
   
   
   
   
   
    }
}
