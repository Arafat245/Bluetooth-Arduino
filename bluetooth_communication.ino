#include <SoftwareSerial.h>
SoftwareSerial myconnection(10,11);

void setup()
{
  myconnection.begin(9600);
}
void loop()
{
  myconnection.println("My name is Arafat");
  delay(600);
}
