public boolean strCopies(String str, String sub, int n) {
  if(str.length() < sub.length()){
    if(n == 0) return true;
    return false;
  }
  
  if(str.substring(0, sub.length()).equals(sub)){
    return true && strCopies(str.substring(1), sub, --n);
  }
  
  return strCopies(str.substring(1), sub, n);
}