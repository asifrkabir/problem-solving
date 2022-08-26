public boolean old35(int n) {
  if(n % 3 == 0){
    if(n % 5 == 0) return false;
    
    return true;
  }
  else{
    if(n % 5 == 0) return true;
    
    return false;
  }
}