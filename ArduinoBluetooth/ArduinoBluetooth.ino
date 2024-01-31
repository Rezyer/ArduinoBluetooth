// Dichiarazione librerie
#include <SoftwareSerial.h>
#include <Servo.h>

// Dichiarazione oggetti
SoftwareSerial BTSerial (10,11);              // Modulo Bluetooth HC-05, pin TX e RX per la comunicazione seriale
Servo Servo1;                                 // Servomotore

// Pins
int pinLEDMagazzino = 2;
int pinLEDPiazzale = 3;
int pinLEDGarage = 5;
int pinLEDServo = 7;
int pinServo = 9; // Pin Servomotore

// Variabili indicatrici
boolean flagMagazzino = true;
boolean flagPiazzale = true;
boolean flagGarage = true;
boolean flagServo = true;

int pos = 180;                                // Posizione iniziale Servo
char carattere;                               // Variabile Carattere trasmesso


void setup() {                                // Questa parte viene eseguita solo una volta all'accensione di Arduino

  // Porte seriali
  Serial.begin(9600);
  BTSerial.begin(9600);

  // Dichiarazione dei pin di Arduino I/O
  pinMode(pinLEDMagazzino, OUTPUT);
  pinMode(pinLEDPiazzale, OUTPUT);
  pinMode(pinLEDGarage, OUTPUT);
  pinMode(pinLEDServo, OUTPUT);

  // Configurazione Servomotore e LED dedicato
  digitalWrite(pinLEDServo, LOW);             // Spegnimento pin Servo
  Servo1.attach(pinServo);                    // Lettura del servo
  Servo1.write(pos);                          // Servo in posizione di partenza (sbarra abbassata)
}

void loop() {
  if (Serial.available()>0) {                 // Controllo attività porta seriale
    carattere = Serial.read();                // Lettura carattere trasmesso dalla porta seriale
    // Controllo Magazzino
    if (carattere == 'M') {                   // Controllo carattere trasmesso
      if (flagMagazzino == true) {            // Controllo stato LED (se acceso)
        digitalWrite(pinLEDMagazzino, HIGH);  // Accensione LED
        flagMagazzino = false;                // Stato LED: acceso
      }
      else                                    // Controllo stato LED (se spento)
      {
        digitalWrite(pinLEDMagazzino, LOW);   // Spegnimento LED
        flagMagazzino = true;                 // Stato LED: spento
      }
    }
    // Controllo Piazzale
    if (carattere == 'P') {
      if (flagPiazzale == true) {
        digitalWrite(pinLEDPiazzale, HIGH);
        flagPiazzale = false;
      }
      else
      {
        digitalWrite(pinLEDPiazzale, LOW);
        flagPiazzale = true;
      }
    }
    // Controllo Garage
    if (carattere == 'G') {
      if (flagGarage == true) {
        digitalWrite(pinLEDGarage, HIGH);
        flagGarage = false;
      }
      else
      {
        digitalWrite(pinLEDGarage, LOW);
        flagGarage = true;
      }
    }
    // Controllo Servomotore
    if (carattere == 'H') {                   // Controllo carattere trasmesso
      if (flagServo == true) {                // Controllo stato Sbarra (se abbassata)
        digitalWrite(pinLEDServo, HIGH);      // Accensione LED Servomotore
        flagServo = false;                    // Stato Sbarra: alzata
        for (pos = 180; pos>=90; pos--) {     // Ciclo per l'apertura della sbarra
          Servo1.write(pos);                  // Azionamento Servomotore
          delay(10);                          // Attesa di 10 ms
        }
      }
      else                                    // Controllo stato Sbarra (se alzata)
      {
        digitalWrite(pinLEDServo, LOW);       // Spegnimento LED Servomotore
        flagServo = true;                     // Stato Sbarra: abbassata
        for (pos = 90; pos<=180; pos++) {     // Ciclo per la chiusura della sbarra
          Servo1.write(pos);
          delay(10);
        }
      }
    }
  }
  else if (BTSerial.available()) {            // Controllo attività modulo Bluetooth
    carattere = BTSerial.read();              // Lettura carattere trasmesso dal modulo Bluetooth
                                              // Il seguente codice è la ripetizione di quello precedente
    if (carattere == 'M') {
      if (flagMagazzino == true) {
        digitalWrite(pinLEDMagazzino, HIGH);
        flagMagazzino = false;
      }
      else
      {
        digitalWrite(pinLEDMagazzino, LOW);
        flagMagazzino = true;
      }
    }
    if (carattere == 'P') {
      if (flagPiazzale == true) {
        digitalWrite(pinLEDPiazzale, HIGH);
        flagPiazzale = false;
      }
      else
      {
        digitalWrite(pinLEDPiazzale, LOW);
        flagPiazzale = true;
      }
    }
    if (carattere == 'G') {
      if (flagGarage == true) {
        digitalWrite(pinLEDGarage, HIGH);
        flagPiazzale = false;
      }
      else
      {
        digitalWrite(pinLEDGarage, LOW);
        flagGarage = true;
      }
    }
    if (carattere == 'H') {
      if (flagServo == true) {
        digitalWrite(pinLEDServo, HIGH);
        flagServo = false;
        for (pos = 180; pos>=90; pos--) {
          Servo1.write(pos);
          delay(10);
        }
      }
      else
      {
        digitalWrite(pinLEDServo, LOW);
        flagServo = true;
        for (pos = 90; pos<=180; pos++) {
          Servo1.write(pos);
          delay(10);
        }
      }
      // Scrittura carattere su monitor seriale
      String tras = String(carattere); 
      Serial.println(tras);
    }
  }
}
