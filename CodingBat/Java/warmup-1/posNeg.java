public boolean posNeg(int a, int b, boolean negative) {
  if(negative){
    if(a < 0 && b < 0) return true;
  }
  else{
    if(a < 0){
      if(b >= 0) return true;
    }
    else{
      if(b < 0) return true;
    }
  }
  return false;
}