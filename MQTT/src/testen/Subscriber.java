package testen;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.nio.file.Files;

import de.dobermai.eclipsemagazin.paho.client.util.Utils;
import org.eclipse.paho.client.mqttv3.MqttClient;
import org.eclipse.paho.client.mqttv3.MqttException;

/**
 * @author Dominik Obermaier
 * @author Christian Götz
 */
public class Subscriber {

    //We have to generate a unique Client id.
    String clientId = Utils.getMacAddress() + "-sub";
    private MqttClient mqttClient;

    public Subscriber() {

        try {
        	mqttClient = new MqttClient("tcp://0.0.0.0:1883", clientId); //initiliaze MQTTClient


        } catch (MqttException e) {
            e.printStackTrace();
            System.exit(1);
        }
    }

    //The subscriber start to receive
    public void start(int test, String topic) throws IOException {
        try {
            mqttClient.setCallback(new SubscribeCallback()); //Check if there is something new
            mqttClient.connect();
            File f = new File("logData.txt"); //Define our outputfile
            //Subscribe to a subtopic
            mqttClient.subscribe(topic);
            Publisher publisher = new Publisher();
            //If a subscriber subscribes later, he gets all the previous data that the publisher published before the subscription
            //It's done only the first time he comes in this function. The test variable secures this
            if ((topic == "home/#")&&(test == 0)){
            	File fT = publisher.getTemperatureFile();
            	File fB = publisher.getBrightnessFile();
            	Files.copy(fB.toPath(), f.toPath());
                InputStream in = new FileInputStream(fT);
                OutputStream out = new FileOutputStream(f,true);
                byte[] buf = new byte[1024];
                int len;
                while ((len = in.read(buf)) > 0){
                    out.write(buf, 0, len);
                }
                in.close();
                out.close();
            }
            else if ((topic == "home/temperature")&&(test == 0)){
            	File fTemp = publisher.getTemperatureFile();
            	Files.copy(fTemp.toPath(), f.toPath());
            }
            else if ((topic == "home/brightness")&&(test == 0)){
            	File fBright = publisher.getBrightnessFile();
            	Files.copy(fBright.toPath(), f.toPath());
            }
            else{
            	System.out.println("ILLEGAL TOPIC!!");
            }
            test = 1; //test is 1 so it will pass the if-statement

            System.out.println("Subscriber is now listening to "+topic);

        } catch (MqttException e) {
            e.printStackTrace();
            System.exit(1);
        }
    }

    public static void main(String... args) throws IOException {
    	int test = 0;
    	String topic = "home/#"; //choose between "home/#", "home/brightness" and "home/temperature"
        final Subscriber subscriber = new Subscriber();
        subscriber.start(test,topic);
    }

}