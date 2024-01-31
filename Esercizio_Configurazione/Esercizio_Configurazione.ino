#include <SoftwareSerial.h>       // Inclusione libreria di gestione modulo HC-05

SoftwareSerial BTSerial(10, 11);  // RX | TX
int pinEN = 12;                   // Pin per la modalità AT

void setup()
{
  pinMode(pinEN, OUTPUT);         // Dichiarazione funzione pinEN
  digitalWrite(pinEN, HIGH);      // Attivazione modalità AT tramite alimentazione del pin EN
  Serial.begin(9600);             // Inizializzazione seriale
  while (!Serial) {}              // Attendo l'inizializzazione
  BTSerial.begin(38400);          // Inizializzazione canale seriale alla velocità di default in AT Mode
  Serial.println("Configurazione pronta!");
}

void loop()
{
  // Se la BTSerial ha dati disponibili, li scrive sulla Serial
  if (BTSerial.available())
    Serial.write(BTSerial.read());

  // Se la Serial ha dati disponibili, li scrive sulla BTSerial
  if (Serial.available())
    BTSerial.write(Serial.read());
}
