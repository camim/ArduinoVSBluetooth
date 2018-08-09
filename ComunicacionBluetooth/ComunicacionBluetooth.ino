#include <SoftwareSerial.h>

SoftwareSerial conexion(10,11); //Rx y Tx
const String PRENDER="prender";
const String APAGAR="apagar";
const char DELIMITADOR='-';
String acumulaString="";

void setup() {
  conexion.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {

  if (conexion.available()) {
    char recibido = conexion.read();
    if (recibido == DELIMITADOR){// Se recibe caracter por caracter, si se recibe el delimitador es que ya termino el string
      if (acumulaString == PRENDER){
        digitalWrite(LED_BUILTIN, HIGH);
        conexion.println("LED ON");
      }
      else{
        if (acumulaString == APAGAR){
          digitalWrite(LED_BUILTIN, LOW);
          conexion.println("LED OFF");
        }
      }
      acumulaString="";    
    }  
    else {     
      acumulaString += recibido; //makes the string readString
    }
  }
}
 
