
package pe.edu.pucp.softproductions.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.model.Productora;

/**
 *
 * @author Rodrigo
 */
public interface ProductoraDAO extends Remote{
        ArrayList<Productora> listarTodas() throws RemoteException;
}
