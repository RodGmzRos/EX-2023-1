package pe.edu.pucp.softproductions.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.model.Director;


/**
 *
 * @author Rodrigo
 */
public class DirectorMySQL extends UnicastRemoteObject
        implements DirectorDAO{
     private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    public DirectorMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public ArrayList<Director> listarPorNombre(String nombre) {
        ArrayList<Director> directores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DIRECTOR_X_NOMBRE(?)}");
            cs.setString("_nombre_apellido", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Director director = new Director();
                director.setIdDirector(rs.getInt("id_director"));
                director.setNacionalidad(rs.getString("nacionalidad"));
                director.setNombreDirector(rs.getString("nombre_director"));
                director.setApellidoDirector(rs.getString("apellido_director"));
               
                directores.add(director);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return directores;
    }
    
}
