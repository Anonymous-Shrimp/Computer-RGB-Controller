

//By Anonymous Shrimp
//https://youtube.com/channel/UCs2Sz1gPlWAdET5qcLcZCJw
//https://github.com/Anonymous-Shrimp


String inputString = ""; 
boolean stringComplete = false;
String commandString = "";
boolean stopBreak = false;

int Red = 11;
int Green = 10;
int Blue = 9;

int RedVal;
  int GreenVal;
  int BlueVal;
  int fade;
  
  int RedVal1;
  int GreenVal1;
  int BlueVal1;
  
  int RedVal2;
  int GreenVal2;
  int BlueVal2;

int relayPin = 4;

boolean isConnected = false;

void setup() {
  
  Serial.begin(9600);
  
  pinMode(Red, OUTPUT);
   pinMode(Green, OUTPUT);
   pinMode(Blue, OUTPUT);
}



void playFade(){
  
  int RedVal = 0;
  int GreenVal = 0;
  int BlueVal = 0;
  
int mode = 1;

analogWrite(Red, RedVal);
   analogWrite(Green, GreenVal);
   analogWrite(Blue, BlueVal);
   RedVal = RedVal2;
   GreenVal = GreenVal2;
   BlueVal = BlueVal2;
while (!stopBreak){
  while(mode == 1){
    Serial.println(BlueVal);
    if(RedVal < RedVal1){
      RedVal ++;
    } else if(RedVal > RedVal1){ 
      RedVal --;                   
    } else if(RedVal == RedVal1){     
      //Do Nothing 
    }
                                     
    if(BlueVal < BlueVal1){
      BlueVal ++;
    } else if(BlueVal > BlueVal1){
      BlueVal --;
    } else if(BlueVal == BlueVal1){
      //Do Nothing
    }
                                     
    if(GreenVal < GreenVal1){
      GreenVal ++;
    } else if (GreenVal > GreenVal1){
      GreenVal --;
    } else if (GreenVal == GreenVal1){
      // Do Nothing
    }
                                     
    analogWrite(Red, RedVal);
    analogWrite(Green, GreenVal);
    analogWrite(Blue, BlueVal);
    delay(fade);                      

    if(RedVal == RedVal1 && GreenVal == GreenVal1 && BlueVal == BlueVal1){ 
      delay(1500);                    
      mode = 2;                       
    }
  }

  while(mode == 2){
    Serial.println(BlueVal);
    if(RedVal < RedVal2){
      RedVal ++;                     
    } else if(RedVal > RedVal2){
      RedVal --;                     
    } else if(RedVal == RedVal2){
    }

    if(BlueVal < BlueVal2){
      BlueVal ++;
    } else if(BlueVal > BlueVal2){
      BlueVal --;
    } else if(BlueVal == BlueVal2){
    }

    if(GreenVal < GreenVal2){
      GreenVal ++;
    } else if (GreenVal > GreenVal2){
      GreenVal --;
    } else if (GreenVal == GreenVal2){
    }

    analogWrite(Red, RedVal);
    analogWrite(Green, GreenVal);
    analogWrite(Blue, BlueVal);
    delay(fade);

    if(RedVal == RedVal2 && GreenVal == GreenVal2 && BlueVal == BlueVal2){
      delay(1500);
      mode = 1;
    }
  }
    }
}
  
  





void loop() {

if(stringComplete)
{
  stringComplete = false;
  getCommand();
  inputString = "";
}

}


void getCommand()
{
  if(!(commandString.substring(1,6).equals("RELAY"))){ 
    commandString = inputString.substring(1,19).toInt();
    RedVal1 = inputString.substring(1,4).toInt();
    GreenVal1 = inputString.substring(4,7).toInt();
    BlueVal1 = inputString.substring(7,10).toInt();
    RedVal2 = inputString.substring(10,13).toInt();
    GreenVal2 = inputString.substring(13,16).toInt();
    BlueVal2 = inputString.substring(16,19).toInt();
    fade = inputString.substring(19,21).toInt();
    
    playFade();
  }
}


void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    inputString += inChar;
    if (inChar == '\n') {
      stringComplete = true;
    }
    
  }
}
