class Solution {
    public String multiply(String num1, String num2) {
        if (num1.equals("0") || num2.equals("0")) {
            return "0";
        }

        StringBuilder result = new StringBuilder();

        for (int i = num2.length() - 1, extraZero = 0; i >= 0; i--, extraZero++) {
            StringBuilder currentProduct = new StringBuilder();

            for (int j = 0; j < extraZero; j++) {
                currentProduct.append('0');
            }

            int multiplier = Character.getNumericValue(num2.charAt(i));
            boolean remainder = false;
            int remainderAmount = 0;

            for (int j = num1.length() - 1; j >= 0; j--) {
                int multiplicand = Character.getNumericValue(num1.charAt(j));
                int product = multiplier * multiplicand;

                if (remainder) {
                    product += remainderAmount;
                }

                String productString = Integer.toString(product);

                if (productString.length() > 1) {
                    remainder = true;
                    currentProduct.append(productString.charAt(1));
                    remainderAmount = Character.getNumericValue(productString.charAt(0));
                } else {
                    remainder = false;
                    currentProduct.append(productString.charAt(0));
                }
            }

            if (remainder) {
                currentProduct.append(remainderAmount);
            }

            currentProduct.reverse();

            if (result.isEmpty()) {
                result.append(currentProduct);
            } else {
                remainder = false;

                for (int j = result.length() - 1, k = currentProduct.length() - 1; j >= 0; j--, k--) {
                    int sum = Character.getNumericValue(result.charAt(j))
                            + Character.getNumericValue(currentProduct.charAt(k));

                    if (remainder) {
                        sum++;
                    }

                    String sumString = Integer.toString(sum);

                    if (sumString.length() > 1) {
                        remainder = true;
                        result.setCharAt(j, sumString.charAt(1));
                    } else {
                        remainder = false;
                        result.setCharAt(j, sumString.charAt(0));
                    }
                }

                int difference = currentProduct.length() - result.length();

                if (difference != 0) {
                    int remainingPortion = Integer.parseInt(currentProduct.substring(0, difference));

                    if (remainder) {
                        int sum = remainingPortion + 1;
                        result.insert(0, sum);
                    } else {
                        result.insert(0, remainingPortion);
                    }
                } else {
                    if (remainder) {
                        result.insert(0, 1);
                    }
                }
            }
        }

        return result.toString();
    }
}