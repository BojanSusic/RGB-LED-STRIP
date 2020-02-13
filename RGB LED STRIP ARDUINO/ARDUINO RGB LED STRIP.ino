#include <IRremote.h>
int bright;
int Red=5; 
int Green=10;
int Blue=9;
int brightR=255;
int brightG=255;
int brightB=255;
#define FADESPEED 10 
int RECV_PIN = 7;
int color=0;
int brightness=0;
int whiteBrightness=0;
char buff;
String input;
String command;
int blinkState=0;
int i;
IRrecv irrecv(RECV_PIN);
decode_results results;

void setup(){
  irrecv.enableIRIn(); 
  Serial.begin(9600);
  pinMode(Red,OUTPUT);
  pinMode(Green,OUTPUT);
  pinMode(Blue,OUTPUT);
}

/**
 * Decoding signal from remote then calling function 
 * or decode serial input and set color on receive value
 */
void loop() {
  if(irrecv.decode(&results)){
    Serial.println(results.value, HEX);
    command="";
    if (results.value==0xFF629D){
      dim(Red,&brightR);
      color=0;
      brightness=0;
    }
    if (results.value==0xFFE21D){ 
      brighten(Red,&brightR); 
      color=0;
      brightness=0;
    }
    if (results.value==0xFFA857){
      dim(Green,&brightG);
      color=0;
      brightness=0;
    }
    if (results.value==0xFF906F){ 
      brighten(Green,&brightG); 
      color=0;
      brightness=0;
    }
     if (results.value==0xFFA25D){
      dim(Blue,&brightB);
    }
    if (results.value==0xFF22DD){ 
      brighten(Blue,&brightB);
      color=0;
      brightness=0;
    }
    if(results.value==0xFFC23D){
        colorChangingUp();
      }
    if(results.value==0xFF02FD){
      colorChangingDown();
      }
    if (results.value==0xFF42BD){
        white();
        color=0;
      brightness=0;
      }
    if(results.value==0xFF52AD)
    {
        standby(); 
        color=0;
      brightness=0;
      }
    irrecv.resume();
   }
   else{
      read();
    if(command=="FADE00000"){
       fadeEffect();
      }
    else if(command=="RAINBOW00"){
     colorChanging();
    }
    else if(command=="BLINK0000"){
      blinkState++;
      blink();
      }
    else if(command.length()==9){
        stringToRGB();
        analogWrite(Red,brightR);
        analogWrite(Green,brightG);
        analogWrite(Blue,brightB);
     }
   }   
}

/**
 * convert received command from serial port to R G B brightness
 */
void stringToRGB(){
    brightR=(command[0]-48)*100;
    brightR+=(command[1]-48)*10;
    brightR+=(command[2]-48);
     brightG=(command[3]-48)*100;
    brightG+=(command[4]-48)*10;
    brightG+=(command[5]-48);
     brightB=(command[6]-48)*100;
    brightB+=(command[7]-48)*10;
    brightB+=(command[8]-48);
    Serial.println(brightR);
     Serial.println(brightG);
      Serial.println(brightB);
  }
  
/**
 * Read 9 symbols from PC serial input
 * and append to string "command"
 */
void read(){
  buff=Serial.read();
     if(buff>47 && buff<123){
      i++;
      if(i<10){
        input+=buff;
        }
       if(i==9){
       i=0;
       command=input;
        input="";
       }
      }
  }
  
  /**
   * Function for decreasing the brightness by 15
   * get color and brightness of that color
   */
void dim(int color,int *brightness){
  
  if(*brightness==0){ 
      analogWrite(color,*brightness);
    }
    else if (*brightness>=10){
   *brightness=*brightness-15;
    analogWrite(color,*brightness);
  }
    else{
      analogWrite(color, 0);  
    }
  }
  
  /**
   * Function for increasing the brightness by 15
   * get color and brightness of that color
   */
void brighten(int out, int *bright){
    if(*bright==255){
      analogWrite(out,*bright);
      *bright=*bright+15;
    }
    else if (*bright<=240){    
    analogWrite(out,*bright);
    *bright=*bright+15;
  }
    else {
      analogWrite(out,255);
      }
  }
  
  /**
   * Blink Red then Green and then Blue
   * and then turn off all leds
   */
void standby(){
  digitalWrite(Red,LOW);
        digitalWrite(Green,LOW);
        digitalWrite(Blue,LOW);
    for (int i=0; i<2;i++){
        digitalWrite(Red,HIGH);
        delay(250);
        digitalWrite(Red,LOW);
        delay(250);
    }
    for (int i=0; i<2;i++){
        digitalWrite(Green,HIGH);
        delay(250);
        digitalWrite(Green,LOW);
        delay(250);  
      }
    for (int i=0; i<2;i++){
        digitalWrite(Blue,HIGH);
        delay(250);
        digitalWrite(Blue,LOW);
        delay(250); 
      }
  }
  
/**
 * Changing all colors from down to up
 * 
 */
void colorChangingUp(){
    if(color==0){
    digitalWrite(Red,LOW);
    digitalWrite(Green,LOW);
    digitalWrite(Blue,HIGH);}
    brightR=0;
    brightG=0;
    brightB=0;
    if(color==0 && brightness<=240){
      brightness=brightness+15;
      analogWrite(Red,brightness);
      if(brightness==255)
        color=1;
    }
    if(color==1 && brightness>=15){
        brightness=brightness-15;
        analogWrite(Blue, brightness);
        if(brightness==0)
          color=2;
      }
     if(color==2 && brightness<=240){
       brightness=brightness+15;
      analogWrite(Green,brightness);
      if(brightness==255)
        color=3;
      }
    if(color==3 && brightness>=15){
        brightness=brightness-15;
        analogWrite(Red, brightness);
        if(brightness==0)
          color=4;
      }
      if(color==4 && brightness<=240){
       brightness=brightness+15;
      analogWrite(Blue,brightness);
      if(brightness==255)
        color=5;
      }
      if(color==5 && brightness>=15){
        brightness=brightness-15;
        analogWrite(Green, brightness);
        if(brightness==0)
          color=0;
      }
  }
  
  /** 
   * Changing all colors from up to down
   * 
   */
void colorChangingDown(){
  if(color==0 && brightness==0){
    digitalWrite(Red,LOW);
    digitalWrite(Green,LOW);
    digitalWrite(Blue,HIGH);}
    brightR=0;
    brightG=0;
    brightB=0;
    if(color==0 && brightness==0)
      color=5;
   if(color==0 && brightness>=15){
      brightness=brightness-15;
      analogWrite(Red,brightness);
      if(brightness==0)
        color=5;
    }
    if(color==1 && brightness<=240){
        brightness=brightness+15;
        analogWrite(Blue, brightness);
        if(brightness==255)
          color=0;
      }
     if(color==2 && brightness>=15){
       brightness=brightness-15;
      analogWrite(Green,brightness);
      if(brightness==0)
        color=1;
      }
    if(color==3 && brightness<=240){
        brightness=brightness+15;
        analogWrite(Red, brightness);
        if(brightness==255)
          color=2;
      }
      if(color==4 && brightness>=15){
       brightness=brightness-15;
      analogWrite(Blue,brightness);
      if(brightness==0)
        color=3;
      }
      if(color==5 && brightness<=240){
        brightness=brightness+15;
        analogWrite(Green, brightness);
        if(brightness==255)
          color=4;
      }
  }
  
/**
 * Changing white color from 0% to 100%
 */
  void white(){
      if(whiteBrightness<17){
        whiteBrightness++;
        analogWrite(Red,whiteBrightness*15);
        analogWrite(Green,whiteBrightness*15);
        analogWrite(Blue,whiteBrightness*15);
        if(whiteBrightness==17)
          whiteBrightness=0;
      }
    }
    int stateCC=0;

    /**
     * Changing all colors
     */
 void colorChanging(){
  
     if(brightR<=255 && stateCC==0) { 
    analogWrite(Red,brightR);
    delay(FADESPEED);
    brightR++;
    if(brightR==256){stateCC=1;brightR--;}
  } 
  if(brightB>=0 && stateCC==1) { 
    analogWrite(Blue,brightB);
    delay(FADESPEED);
    brightB--;
    if(brightB==-1){stateCC=2;brightB++;}
  }
  if(brightG<=255 && stateCC==2) { 
    analogWrite(Green,brightG);
    delay(FADESPEED);
    brightG++;
    if(brightG==256){stateCC=3;brightG--;}
  } 
  if(brightR>=0 && stateCC==3) { 
    analogWrite(Red,brightR);
    delay(FADESPEED);
    brightR--;
    if(brightR==-1){stateCC=4;brightR++;}
  }
  if(brightB<=255 && stateCC==4) { 
    analogWrite(Blue,brightB);
    delay(FADESPEED);
    brightB++;
    if(brightB==256){stateCC=5;brightB--;}
  } 
  if(brightG>=0 && stateCC==5) { 
    analogWrite(Green,brightG);
    delay(FADESPEED);
    brightG--;
    if(brightG==-1){stateCC=0;brightG++;}
  }
}

/**
 * Turning on and off all leds ( R,G,B)
 */
void blink(){  
    if(blinkState==1){
        analogWrite(Red,255);
        delay(1000);
      }
     if(blinkState==2){
        analogWrite(Red,0);
        delay(1000);
      }
      if(blinkState==3){
        analogWrite(Green,255);
        delay(1000);
      }
      if(blinkState==4){
        analogWrite(Green,0);
        delay(1000);
      }
      if(blinkState==5){
        analogWrite(Blue,255);
        delay(1000);
      }
      if(blinkState==6){
        analogWrite(Blue,0);
        delay(1000);
        blinkState=0;
      }
  }

int state=0;
/**
 * Fade from 100% R brightness to 0% 
 * then green from 0% to 100% and again to 0%
 * and blue 0% to 100% and again to 0%
 */
 void fadeEffect(){  
     if(brightR<=255 && state==0) { 
    analogWrite(Red,brightR);
    analogWrite(Green,0);
    analogWrite(Blue,0);
    delay(FADESPEED);
    brightR++;
    if(brightR==256){state=1;brightR--;}
  } 
  if(brightR>=0 && state==1) { 
    analogWrite(Red,brightR);
    analogWrite(Green,0);
    analogWrite(Blue,0);
    delay(FADESPEED);
    brightR--;
    if(brightR==-1){state=2;brightR++;}
  }
  if(brightB<=255 && state==2) { 
    analogWrite(Blue,brightB);
    analogWrite(Red,0);
    analogWrite(Green,0);
    delay(FADESPEED);
    brightB++;
    if(brightB==256){state=3;brightB--;}
  } 
  if(brightB>=0 && state==3) { 
    analogWrite(Blue,brightB);
    analogWrite(Red,0);
    analogWrite(Green,0);
    delay(FADESPEED);
    brightB--;
    if(brightB==-1){state=4;brightB++;}
  }
if(brightG<=255 && state==4) { 
    analogWrite(Green,brightG);
    analogWrite(Red,0);
    analogWrite(Blue,0);
    delay(FADESPEED);
    brightG++;
    if(brightG==256){state=5;brightG--;}
  } 
  if(brightG>=0 && state==5) { 
    analogWrite(Green,brightG);
    analogWrite(Red,0);
    analogWrite(Blue,0);
    delay(FADESPEED);
    brightG--;
    if(brightG==-1){state=0;brightG++;}
  }
 }
