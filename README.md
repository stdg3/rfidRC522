# rfidRC522 13,56 MHz
very high code to read rfid card using arduino
components: 
  arduino nano/uno
  rfid-rc522
    speed = 424 kbit/s
    supported: mifare1 S50, mifare1 S70, mifare ultralight, mifare pro and  mifare desfire
 
 Prop:
  voltage = 3,3v
  Freq = 13,56 MHz
  Amperage = 13-26 mA
    sleep metoth: 80 uA
  Communication Protocol: SPI
 
 PinOut Ard Nano+Uno:
  
  SS/SDA  -   10
  SCK     -   13
  MOSI    -   11
  MISO    -   12
  **M-i/o-S-i/o = Master-input/output-Slave-input/output
