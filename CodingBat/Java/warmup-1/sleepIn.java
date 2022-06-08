public boolean sleepIn(boolean weekday, boolean vacation) {
  if(weekday){
    if(vacation){
      return true;
    }
    else return false;
  }
  else{
    return true;
  }
}