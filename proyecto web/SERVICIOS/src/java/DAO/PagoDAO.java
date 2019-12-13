/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Modelo.Conexion;
import Modelo.Pago;
import Modelo.Pagos;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author torre
 */
public class PagoDAO {

    PreparedStatement ps;
    ResultSet rs;
    Connection con;
    Conexion conex = new Conexion();
    int res;
    String msj;
    Pago p = new Pago();

    public String nuevopago(String id_reserva, String fechapago, String banco, String cuenta, String monto) {
        String sql = "insert into pago(id_reserva,fechapago,banco,cuenta,monto)values(?,?,?,?,?)";
        try {
            con = conex.getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, id_reserva);
            ps.setString(2, fechapago);
            ps.setString(3, banco);
            ps.setString(4, cuenta);
            ps.setString(5, monto);
            res = ps.executeUpdate();
            if (res == 1) {
                msj = "Pago registrado correctamente ";
            } else {
                msj = "Error en el registro del pago";
            }
        } catch (Exception e) {
        }
        return msj;
    }

    public List listarpagosporfechas(String fechainicial, String fechafinal) {
        System.out.println("fechainiicial" + fechainicial);
        System.out.println("fechafinal" + fechafinal);
        List<Pagos> datos = new ArrayList<>();
        String sql = "select r.id_reserva , r.fecha_reserva,r.cantidad_personas,r.fecha_salida,r.rut,r.id_departamento,"
                + "u.id_usuario,u.nombre,u.rut as cedula,d.nombre as residencia , d.ubicacion,d.banos,d.habitaciones,"
                + "d.valorarriendo,d.descripcion,d.fecha from reserva r inner join usuario u on r.rut=u.rut"
                + " inner join pago p on p.id_reserva=r.id_reserva"
                + "inner join departamento d on d.id=r.id_departamento where p.fechapago between '" + fechainicial + "' and '" + fechafinal + "'";
        try {
            con = conex.getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            while (rs.next()) {
                Pagos pg = new Pagos();
//                pg.setId_reserva(rs.getInt("id_reserva"));
//                pg.setIdpago(rs.getInt("idpago"));
//                pg.setFechapago(rs.getString("fechapago"));
//                pg.setRut(rs.getString("rut"));
//                pg.setNombre(rs.getString("nombre"));
//                pg.setBanco(rs.getString("banco"));
//                pg.setCuenta(rs.getString("cuenta"));
//                pg.setMonto(rs.getString("monto"));
                pg.setId_reserva(rs.getInt("id_reserva"));
//                re2.setFecha_reserva(rs.getString("fecha_reserva"));
//                re2.setCantidad_personas(rs.getString("cantidad_personas"));
//                re2.setFecha_salida(rs.getString("fecha_salida"));
//                re2.setRut(rs.getString("rut"));
//                re2.setId_departamento(rs.getString("id_departamento"));
//                re2.setCedula(rs.getString("rut"));
//                re2.setNombre(rs.getString("nombre"));
//                re2.setNombre_1(rs.getString("residencia"));
//                re2.setUbicacion(rs.getString("ubicacion"));
//                re2.setValorarriendo(rs.getString("valorarriendo"));
                datos.add(pg);
            }
        } catch (Exception e) {
            System.err.println("ERROR AL LISTAR PAGOS POR FECHAS" + e.getMessage());
        }
        System.out.println("datos" + datos.toString());
        return datos;

    }

}
