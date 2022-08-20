public String alarmClock(int day, boolean vacation) {
  if(vacation){
    if(day == 6 || day == 0) return "off";
    
    return "10:00";
  }
  else{
    if(day == 6 || day == 0) return "10:00";
    
    return "7:00";
  }
}