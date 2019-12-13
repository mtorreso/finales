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
public class Pago {
    int idpago;
    String id_reserva;
    String fecha_pago;
    String banco;
    String cuenta;
    String monto;
    
    public Pago(){
        
    }

    public Pago(int idpago, String id_reserva, String fecha_pago, String banco, String cuenta, String monto) {
        this.idpago = idpago;
        this.id_reserva = id_reserva;
        this.fecha_pago = fecha_pago;
        this.banco = banco;
        this.cuenta = cuenta;
        this.monto = monto;
    }

    public int getIdpago() {
        return idpago;
    }

    public void setIdpago(int idpago) {
        this.idpago = idpago;
    }

    public String getId_reserva() {
        return id_reserva;
    }

    public void setId_reserva(String id_reserva) {
        this.id_reserva = id_reserva;
    }

    public String getFecha_pago() {
        return fecha_pago;
    }

    public void setFecha_pago(String fecha_pago) {
        this.fecha_pago = fecha_pago;
    }

    public String getBanco() {
        return banco;
    }

    public void setBanco(String banco) {
        this.banco = banco;
    }

    public String getCuenta() {
        return cuenta;
    }

    public void setCuenta(String cuenta) {
        this.cuenta = cuenta;
    }

    public String getMonto() {
        return monto;
    }

    public void setMonto(String monto) {
        this.monto = monto;
    }
    
    
    
}
