package pe.edu.pucp.softproductions.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.model.Director;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "SoftProductionsWS")
public class SoftProductionsWS {

    private String IPServidor = "127.0.0.1";
    private String puerto = "1234";
    private DirectorDAO daoDirector = null;
    private ProductoraDAO daoProductora = null;
    private SerieTelevisionDAO daoSerieTelevision = null;
    
    //Productora
    @WebMethod(operationName = "listarTodasProductoras")
    public ArrayList<Productora> listarTodasProductoras() {
        ArrayList<Productora> productoras = new ArrayList<>();
        try{
        daoProductora = (ProductoraDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoProductora");
        productoras = daoProductora.listarTodas();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productoras;
    }
    
    //Director
    @WebMethod(operationName = "listarDirectoresXNombre")
    public ArrayList<Director> listarDirectoresXNombre(@WebParam(name = "nombre") String nombre){
        ArrayList<Director> directores = new ArrayList<>();
        try{
        daoDirector = (DirectorDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoDirector");
        directores = daoDirector.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return directores;
    }
    
    //Series
        @WebMethod(operationName = "insertarSerie")
    public int insertarSerie(@WebParam(name = "serie") SerieTelevision serie){
        int resultado=0;
        try{
        daoSerieTelevision = (SerieTelevisionDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoSerieTelevision");
        resultado = daoSerieTelevision.insertar(serie);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
        //Director
    @WebMethod(operationName = "listarSeriesXNombre")
    public ArrayList<SerieTelevision> listarSeriesXNombre(@WebParam(name = "nombre") String nombre){
        ArrayList<SerieTelevision> series = new ArrayList<>();
        try{
        daoSerieTelevision = (SerieTelevisionDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoSerieTelevision");
        series = daoSerieTelevision.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return series;
    }
    
}
