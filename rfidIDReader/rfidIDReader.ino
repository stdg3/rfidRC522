#include <SPI.h> 
#include <MFRC522.h> 
#include <EEPROM.h> 
 
#define RST_PIN 9 
#define SS_PIN 10 
#define ledPin 6 
 
int incomeMessage = 0; 
 
MFRC522 mfrc522(SS_PIN, RST_PIN); 
 
String lastRfid = ""; 
 int j =0; 
 
MFRC522::MIFARE_Key key; 
void setup() 
{ 
  Serial.begin(9600); 
  SPI.begin(); 
  mfrc522.PCD_Init(); 
  pinMode(ledPin, OUTPUT); 
} 
 
void loop() 
{ 
  //incomeMessage = 0; 
  //Serial.begin(9600); 
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  { 
    return; 
  } 
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  { 
    return; 
  } 
  String rfid = ""; 
  for (byte i = 0; i < mfrc522.uid.size ; i++) //mfrc522.uid.size 
  { 
    rfid += mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "; 
    rfid += String(mfrc522.uid.uidByte[i], HEX); 
  } 
  rfid.trim(); 
  rfid.toUpperCase(); 
  Serial.println(rfid); 
  //incomeMessage = 0; 
  //Serial.read();
  while(Serial.available()) { 
    incomeMessage = 0; 
  incomeMessage= Serial.read(); 
  } 
  //Serial.end();
  //Serial.begin(9600);
  //Serial.print(incomeMessage);
  if(incomeMessage == '1'){ 
    digitalWrite(ledPin, HIGH); 
    delay(3000); 
    digitalWrite(ledPin, LOW); 
    incomeMessage = 0; 
  } 
  //Serial.flush();
  Serial.read();
  delay(200); 
}