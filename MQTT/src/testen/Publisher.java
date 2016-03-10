package testen;

import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import deleteFiles.*;
import org.eclipse.paho.client.mqttv3.*;
import de.dobermai.eclipsemagazin.paho.client.util.Utils;

/**
 * @author Dominik Obermaier
 * @author Christian Götz
 */

public class Publisher {
    public static File tempFile =new File("Temperature.txt");
    public static File BrightFile =new File("Brightness.txt");
    public static final String TOPIC_BRIGHTNESS = "home/brightness";
    public static final String TOPIC_TEMPERATURE = "home/temperature";

    private MqttClient client;

    public Publisher() {}

    //Get the file of the temperature
    public File getTemperatureFile()
    {
    	return tempFile;
    }
    
    //Get the file of the brightness
    public File getBrightnessFile()
    {
    	return BrightFile;
    }
    
    //The publisher starts
    private void start() {
    	 String clientId = Utils.getMacAddress() + "-pub";	//get unique ID


         try {
         	client = new MqttClient("tcp://0.0.0.0:1883", clientId); //initiliaze MQTTClient

         } catch (MqttException e) {
             e.printStackTrace();
             System.exit(1);
         }
        try {
            MqttConnectOptions options = new MqttConnectOptions();
            options.setCleanSession(false);
            options.setWill(client.getTopic("home/LWT"), "I'm gone :(".getBytes(), 0, false);
            //Sets the "Last Will and Testament" (LWT) for the connection. 
            //In the event that this client unexpectedly loses its connection to the server, the server will publish a message to itself using the supplied details.
            client.connect(options);	//connect to client
            
            //Publish data forever
            while (true) {

                publishBrightness();

                Thread.sleep(500);

                publishTemperature();

                Thread.sleep(5000);
            }
        } catch (MqttException e) {
            e.printStackTrace();
            System.exit(1);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    //Generate a random value for the temperature and publish it
    private void publishTemperature() throws MqttException {
        final MqttTopic temperatureTopic = client.getTopic(TOPIC_TEMPERATURE); //Set topic

        final int temperatureNumber = Utils.createRandomNumberBetween(20, 30);
        final String temperature = temperatureNumber + "°C";

        temperatureTopic.publish(new MqttMessage(temperature.getBytes()));
        
        String messag = temperature.toString() + "\n";
        try {
            Files.write(Paths.get("Temperature.txt"), messag.getBytes(), StandardOpenOption.APPEND); //Write to the file
        }catch (IOException e) {
        	e.printStackTrace();
        }

        System.out.println("Published data. Topic: " + temperatureTopic.getName() + "  Message: " + temperature);
    }

    //Generate a random value for the brightness and publish it
    private void publishBrightness() throws MqttException {
        final MqttTopic brightnessTopic = client.getTopic(TOPIC_BRIGHTNESS); //Set topic

        final int brightnessNumber = Utils.createRandomNumberBetween(0, 100);
        final String brigthness = brightnessNumber + "%";

        brightnessTopic.publish(new MqttMessage(brigthness.getBytes()));

        String messag = brigthness.toString() + "\n";
        try {
            Files.write(Paths.get("Brightness.txt"), messag.getBytes(), StandardOpenOption.APPEND); //Write to the file
        }catch (IOException e) {
        	e.printStackTrace();
        }
        
        System.out.println("Published data. Topic: " + brightnessTopic.getName() + "   Message: " + brigthness);
    }
    
    public static void main(String... args) throws IOException {
    	//Delete files before startup
    	File directory = new File("Temperature.txt");
    	CrunchifyDeleteFiles.deleteThisFile(directory);
   		directory = new File("Brightness.txt");
   		CrunchifyDeleteFiles.deleteThisFile(directory);
    	PrintWriter writer = new PrintWriter(tempFile, "UTF-8");
    	PrintWriter writer2 = new PrintWriter(BrightFile, "UTF-8");
        final Publisher publisher = new Publisher();
        publisher.start();
        writer.close();
        writer2.close();
    }
}