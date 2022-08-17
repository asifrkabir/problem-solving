public int caughtSpeeding(int speed, boolean isBirthday) {
  if(!isBirthday){
    if(speed <= 60) return 0;
    
    if(speed >= 61 && speed <= 80) return 1;
  }
  else{
    if(speed <= 65) return 0;
    
    if(speed >= 66 && speed <= 85) return 1;
  }
  
  return 2;
}