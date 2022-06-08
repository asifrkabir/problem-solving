public boolean stringE(String str) {
  boolean output = false;
  
  int count = 0;
    
  for(int i = 0; i < str.length(); i++){
    if(str.charAt(i) == 'e') count++;
  }
    
  if(count >= 1 && count <= 3) output = true;
  
  return output;
}