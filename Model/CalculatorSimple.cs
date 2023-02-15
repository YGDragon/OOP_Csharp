class CalculatorSimple
{
    private int[] numberButtons;
    private string[] actionButtons;
    string display;

    public CalculatorSimple()
    {
        numberButtons = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        actionButtons = new string[]{"+", "-", "*", "/"};
        display = "string.Empty";
    }

    public int[] getNumberButtons()
    {
        return numberButtons;
    }

    public string[] getActionButtons() {
        return actionButtons;
    }

    public void setDisplay(float display) {
        this.display = Convert.ToString(display);
    }
    public string getDisplay() {
            return display;
    }
}