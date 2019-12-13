/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author torre
 */
public class PagoService {
    public PagoService(){
        
    }

   public String nuevopago(java.lang.String idReserva, java.lang.String fechapago, java.lang.String banco, java.lang.String cuenta, java.lang.String monto) {
        webservice.Servicios_Service service = new webservice.Servicios_Service();
        webservice.Servicios port = service.getServiciosPort();
        return port.nuevopago(idReserva, fechapago, banco, cuenta, monto);
    }
    
    
}
