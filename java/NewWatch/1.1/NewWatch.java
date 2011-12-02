/*******************************************/
/* Author:    Pedram Soheil				   */
/* Copyright: DigiOz Multimedia			   */
/* Website:   http://www.digioz.com		   */
/* Email:     webmaster@digioz.com		   */
/* Applet:    DigiOz Java Watch Applet     */
/* Version:   1.1						   */
/*******************************************/

import java.awt.*;
import java.util.*;
import java.applet.*;

public class NewWatch extends Applet {
    private Color white = new Color(255, 255, 255);
    private String lastTime = "";
    Color back;

    public void init() {
        String in = getParameter("background");
        back = Color.black;
        if (in != null) {
            try 
            {
                back = Color.decode(in);
            } 
            catch (NumberFormatException e) 
            {
                showStatus("Bad parameter " + in);
            }
        }
        setBackground(back);
    }

    public void paint(Graphics screen) {
        Graphics2D screen2D = (Graphics2D)screen;
        Font type = new Font("Monospaced", Font.BOLD, 12);
        screen2D.setFont(type);
        GregorianCalendar day = new GregorianCalendar();
        String time = day.getTime().toString();
        screen2D.setColor(back);
        screen2D.drawString(lastTime, 5, 25);
        screen2D.setColor(white);
        screen2D.drawString(time, 5, 25);
        
        try 
        {
            Thread.sleep(1000);
        } 
        catch (InterruptedException e) 
        {
            // do nothing
        }
        
        lastTime = time;
        repaint();
    }
}

