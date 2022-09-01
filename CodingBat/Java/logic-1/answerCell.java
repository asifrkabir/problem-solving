public boolean answerCell(boolean isMorning, boolean isMom, boolean isAsleep) {
  if(!isAsleep){
    if(isMorning){
      if(isMom) return true;
    }
    else return true;
  }
  
  return false;
}