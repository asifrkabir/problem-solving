public int max1020(int a, int b) {
  if((a >= 10 && a <= 20)){
    if((b >= 10 && b <= 20)) return Math.max(a, b);
    else return a;
  }
  else if((b >= 10 && b <= 20)) return b;
  
  return 0;
}