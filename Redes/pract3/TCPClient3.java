import java.net.*;
import java.io.*;

/**
 * Write a description of class TCPCient here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class TCPClient3
{
      public static void main(String args[]) {
           try {
               int port = 80;
               String server = "wwww.upv.es";
               Socket s = new Socket(server,port);
               System.out.println("connected again");
               s.close();
            } catch(UnknownHostException e) {
                System.out.println("Unknown server name");
            } catch (ConnectException e) {
                System.out.println("No connection possible");
            } catch(IOException e) {
                System.out.println("ERROR");
            }
      }
}
