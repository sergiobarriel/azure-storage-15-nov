package main.java;

import main.java.services.ConsoleService;
import main.java.services.StorageService;
import main.java.services.ConfigurationService;

public class SkynetTarget {

    public static void main(String[] args) {

        try {

            ConsoleService.PrintMessage("Welcome to Skynet Target Management System.\r\n");

            StorageService storageService = new StorageService(ConfigurationService.LoadProperties());

            while(true) {

                ConsoleService.PrintMessage("Enter target name:");

                String target = ConsoleService.ReadLine();

                storageService.SendMessage(target);
            }
        }
        catch(Exception ex){

        }
    }
}

