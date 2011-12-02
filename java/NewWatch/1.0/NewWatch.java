/*******************************************/
/* Program Created by DigiOz Multimedia    */
/* On 12-12-2004 - Please visit our site   */
/* by going to www.digioz.com . Feel free  */
/* to send us feedback by emailing us at   */
/* webmaster@digioz.com.                   */
/*******************************************/

import java.awt.*;
import java.util.*;

public class NewWatch extends javax.swing.JApplet {
    private Color white = new Color(255, 255, 255);
    private String lastTime = "";
    Color back;

    public void init() {
        String in = getParameter("background");
        back = Color.black;
        if (in != null) {
            try {
                back = Color.decode(in);
            } catch (NumberFormatException e) {
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
        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            // do nothing
        }
        lastTime = time;
        repaint();
    }
}

