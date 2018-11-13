package main.java.services;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Calendar;

public class ConsoleService {

    public static String ReadLine() throws Exception {

        InputStreamReader streamReader = new InputStreamReader(System.in);
        BufferedReader bufferedReader = new BufferedReader(streamReader);

        return bufferedReader.readLine();
    }

    public static void PrintMessage(String message){

        Calendar now = Calendar.getInstance();

        int hours = now.get(Calendar.HOUR_OF_DAY);
        int minutes = now.get(Calendar.MINUTE);
        int seconds = now.get(Calendar.SECOND);

        System.out.println(String.valueOf(hours) + ":" + String.valueOf(minutes) + ":" + String.valueOf(seconds) + " - " + message);
    }
}
