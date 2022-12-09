#include <SPI.h>
#include <MFRC522.h>
#include <EEPROM.h>

#define RST_PIN 9
#define SS_PIN 10
#define ledPin 13

string incomeMessage = "";

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
  Serial.print(rfid);

  while(Serial.available()) {
  incomeMessage= Serial.readString();
  }
  if(incomeMessage == "klu"){
    digitalWrite(ledPin, HIGH);
    delay(3000);
    digitalWrite(ledPin, LOW);
    incomeMessage = "";
  }
  delay(200);
}
