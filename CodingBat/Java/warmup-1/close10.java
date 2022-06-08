public int close10(int a, int b) {
  int distance1, distance2;
  
  distance1 = Math.abs(10 - a);
  distance2 = Math.abs(10 - b);
  
  if(distance1 == distance2) return 0;
  
  if(distance1 < distance2) return a;
  
  return b;
}