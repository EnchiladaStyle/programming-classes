class fraction {
    private int topNum;
    private int bottomNum;

    public void noParam()
    {
        topNum = 1;
        bottomNum = 1;
    }

    public void topOnly(int top)
    {
        topNum = top;
        bottomNum = 1;
    }

    public void topAndBottom(int top, int bottom)
    {
        topNum = top;
        bottomNum = bottom;
    }

    public string finishThat()
    {
        return $"{topNum}/{bottomNum}";
    }

    public decimal getDecimalValue()
    {
        return Decimal.Divide(topNum, bottomNum);
    }
}