

//By Anonymous Shrimp
//https://youtube.com/channel/UCs2Sz1gPlWAdET5qcLcZCJw
//https://github.com/Anonymous-Shrimp

/*
const int Read = 9;
const int Grean = 10;
const int Bleu = 11;

int displayTime = 10;
int redIntensity;
int greenIntensity;
int blueIntensity;


void setup()
{
  pinMode(Read, OUTPUT);
  pinMode(Grean, OUTPUT);
  pinMode(Bleu, OUTPUT);
}


void loop()
{
  int x;

  for (x = 0; x < 768; x++)
  {
    showRGB(x);
    delay(displayTime);
  }


}

void showRGB(int color)
{
  if (color <= 255)
  {
    redIntensity = 255 - color;
    greenIntensity = color;
    blueIntensity = 0;
  }
  else if (color <= 511)
  {
    redIntensity = 0;
    greenIntensity = 255 - (color - 256);
    blueIntensity = (color - 256);
  }
  else
  {
    redIntensity = (color - 512);
    greenIntensity = 0;
    blueIntensity = 255 - (color - 512);
  }




  analogWrite(Read, redIntensity);
  analogWrite(Bleu, blueIntensity);
  analogWrite(Grean, greenIntensity);
}*/

#define ledPin 9
int state = 0;
void setup() {
  pinMode(ledPin, OUTPUT);
  digitalWrite(ledPin, LOW);
  Serial.begin(38400); // Default communication rate of the Bluetooth module
}
void loop() {
  if(Serial.available() > 0){ // Checks whether data is comming from the serial port
    state = Serial.read(); // Reads the data from the serial port
 }
 if (state == '0') {
  digitalWrite(ledPin, LOW); // Turn LED OFF
  Serial.println("LED: OFF"); // Send back, to the phone, the String "LED: ON"
  state = 0;
 }
 else if (state == '1') {
  digitalWrite(ledPin, HIGH);
  Serial.println("LED: ON");;
  state = 0;
 } 
}

