package pe.edu.pucp.softproductions.rmi;


import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.mysql.DirectorMySQL;
import pe.edu.pucp.softproductions.mysql.ProductoraMySQL;
import pe.edu.pucp.softproductions.mysql.SerieTelevisionMySQL;

/**
 *
 * @author Rodrigo
 */
public class RMIServer {
    private static String IP = "127.0.0.1";
    private static String puerto = "1234";
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname",IP);
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            //Objetos Remotos
            DirectorDAO daoDirector = new DirectorMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoDirector", daoDirector);
            
            ProductoraDAO daoProductora = new ProductoraMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoProductora", daoProductora);

            SerieTelevisionDAO daoSerieTelevision = new SerieTelevisionMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoSerieTelevision", daoSerieTelevision);            

            System.out.println("Se ha desplegado el servidor...");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
