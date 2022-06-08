public int triangle(int rows) {
  if(rows == 0 || rows == 1) return rows;
  
  return rows + triangle(--rows);
}