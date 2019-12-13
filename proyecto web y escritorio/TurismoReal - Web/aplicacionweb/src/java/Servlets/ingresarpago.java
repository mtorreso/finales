package Servlets;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import Modelo.PagoService;
import Modelo.SendMail;

public class ingresarpago extends HttpServlet {

    PagoService pg = new PagoService();

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        request.setCharacterEncoding("UTF-8");
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        try {
            if (request.getParameter("id_reserva") != null && !request.getParameter("id_reserva").isEmpty()
                    && request.getParameter("fechapago") != null && !request.getParameter("fechapago").isEmpty()
                    && request.getParameter("banco") != null && !request.getParameter("banco").isEmpty()
                    && request.getParameter("cuenta") != null && !request.getParameter("cuenta").isEmpty()
                    && request.getParameter("monto") != null && !request.getParameter("monto").isEmpty()) {


                request.setAttribute("msg",
                       pg.nuevopago(
                                request.getParameter("id_reserva"),
                                request.getParameter("fechapago"),
                                request.getParameter("banco"),
                                request.getParameter("cuenta"),
                                request.getParameter("monto")));

                String m = request.getParameter("correo");
                String sub = "Pago ok ";

                String messg = "Estimado "+" \n"
                        + "Se ha ingresado un nuevo pago \n"
                        + "\n"
                        + "Fecha :" + request.getParameter("fechapago") + " \n"
                        + "Banco :" + request.getParameter("banco") + " \n"
                        + "Cuenta :" + request.getParameter("cuenta") + " \n"
                        + "Monto :" + request.getParameter("monto") + " \n"
                        + "\n"
                        + "Gracias por preferir Turismo Real !!";

                SendMail.send(m, sub, messg);

                if (request.getAttribute("msg").toString().contains("correctamente")) {
                    request.getRequestDispatcher("departamentos.jsp").forward(request, response);
                } else {
                    //Redireccionamos a la misma página para que lo vuelva a intentar si algún error ocurre
                    request.setAttribute("error", request.getAttribute("msg"));
                    request.getRequestDispatcher("departamentos.jsp").forward(request, response);
                }
            } else {
                //Si hay campos en blanco, la página se vuelve a cargar
                request.setAttribute("error", "Debe llenar todos los campos");
                request.getRequestDispatcher("departamentos").forward(request, response);
            }
        } catch (Exception ex) {
            request.setAttribute("error", "Error :" + ex.toString());
            request.getRequestDispatcher("departamentos.jsp").forward(request, response);
        } finally {
            out.close();
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
