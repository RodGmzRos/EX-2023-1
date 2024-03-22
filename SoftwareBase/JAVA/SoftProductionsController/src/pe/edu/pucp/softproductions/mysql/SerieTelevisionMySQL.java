package pe.edu.pucp.softproductions.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author Rodrigo
 */
public class SerieTelevisionMySQL extends UnicastRemoteObject
        implements SerieTelevisionDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    public SerieTelevisionMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public int insertar(SerieTelevision serieTelevision) throws RemoteException{
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
    cs = con.prepareCall("{ call INSERTAR_SERIE_TELEVISION(?,?,?,?,?,?,?,?,?) }");
    cs.registerOutParameter("_id_serie_television", 
            java.sql.Types.INTEGER);
        cs.setInt("_fid_productora", serieTelevision.getProductora().getIdProductora());
        cs.setString("_fid_idioma_original", String.valueOf(serieTelevision.getIdioma()));
        cs.setString("_nombre_serie", serieTelevision.getNombreSerie());
        cs.setInt("_temporada", serieTelevision.getTemporada());
        cs.setDate("_fecha_emision", new java.sql.Date(serieTelevision.getFechaEmision().getTime()));
        cs.setDouble("_costo_produccion", serieTelevision.getCostoProduccion());  
        cs.setString("_sipnosis", serieTelevision.getSipnosis());
        cs.setBytes("_portada", serieTelevision.getPortada());
            resultado = cs.executeUpdate();
            serieTelevision.setIdSerieTelevision(cs.getInt("_id_serie_television"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public ArrayList<SerieTelevision> listarPorNombre(String nombre) throws RemoteException{
        ArrayList<SerieTelevision> series = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SERIES_TELEVISION_X_NOMBRE(?)}");
            cs.setString("_nombre_serie", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                SerieTelevision serie = new SerieTelevision();
                serie.setIdSerieTelevision(rs.getInt("id_serie_television"));
                serie.setNombreSerie(rs.getString("nombre_serie"));
                serie.setTemporada(rs.getInt("temporada"));
                cs.setDate("_fecha_emision", new java.sql.Date(serie.getFechaEmision().getTime()));
                serie.setCostoProduccion(rs.getDouble("costo_produccion"));
                serie.setSipnosis(rs.getString("sipnosis"));
                serie.setPortada(rs.getBytes("portada"));
                //Productora
                serie.setProductora(new Productora());
                serie.getProductora().setIdProductora(rs.getInt("id_productora"));
                serie.getProductora().setNombreProductora(rs.getString("nombre_productora"));
                serie.getProductora().setLogo(rs.getBytes("logo"));
                serie.getProductora().setR(rs.getInt("R"));
                serie.getProductora().setR(rs.getInt("G"));
                serie.getProductora().setR(rs.getInt("B"));
                //Idigoma
                serie.setIdioma(rs.getString("id_idioma").charAt(0));
               
                series.add(serie);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return series;
    }

}
