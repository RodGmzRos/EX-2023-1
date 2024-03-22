package pe.edu.pucp.softproductions.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.model.Director;


/**
 *
 * @author Rodrigo
 */
public interface DirectorDAO extends Remote {
    ArrayList<Director> listarPorNombre(String nombre) throws RemoteException;
}
