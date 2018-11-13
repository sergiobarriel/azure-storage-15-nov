package main.java.services;

import main.java.constants.SkynetTargetConstants;
import java.io.FileInputStream;
import java.util.Properties;

public class ConfigurationService {

    public static Properties LoadProperties() throws Exception {
        String path = Thread.currentThread().getContextClassLoader().getResource("").getPath()
                + SkynetTargetConstants.PATH_FIX;
        String configurationPath = path + SkynetTargetConstants.CONFIG_FILE_NAME;

        Properties properties = new Properties();
        properties.load(new FileInputStream(configurationPath));

        return properties;
    }
}
