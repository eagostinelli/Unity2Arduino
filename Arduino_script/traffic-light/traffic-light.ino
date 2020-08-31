int gLed = 8;
int yLed = 7;
int rLed = 6;
char myCol[20];

void setup() {
  Serial.begin(9600);
  pinMode(gLed, OUTPUT);
  pinMode(yLed, OUTPUT);
  pinMode(rLed, OUTPUT);

  digitalWrite(gLed, LOW);
  digitalWrite(yLed, LOW);
  digitalWrite(rLed, LOW);

}

void loop() {

  int lf = 10;
  Serial.readBytesUntil(lf, myCol, 1);
    if(strcmp(myCol, "r")==0){
        digitalWrite(gLed, LOW);
        digitalWrite(yLed, LOW);
        digitalWrite(rLed, HIGH);
        
      }
    if(strcmp(myCol, "y")==0){
        digitalWrite(gLed, LOW);
        digitalWrite(yLed, HIGH);
        digitalWrite(rLed, LOW);

      }
    if(strcmp(myCol, "g")==0){
        digitalWrite(gLed, HIGH);
        digitalWrite(yLed, LOW);
        digitalWrite(rLed, LOW);

      }

}
