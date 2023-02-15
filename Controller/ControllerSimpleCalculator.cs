class CalculatorSimpleController
{
    CalculatorSimple model = new CalculatorSimple();
    ViewCalculatorSimple view = new ViewCalculatorSimple();

    public void calculation() {
        view.inputPanel();
        view.resultDisplay(
                takeAction(
                        view.enterNumber(), view.enterAction(), view.enterNumber()
                )
        );
    }

    public String takeAction(float firstNumber, string action, float secondNumber) {
        switch (action) {
            case "+" :
            model.setDisplay(firstNumber + secondNumber);
            break;
            case "-" :
            model.setDisplay(firstNumber - secondNumber);
            break;
            case "*" :
            model.setDisplay(firstNumber * secondNumber);
            break;
            case "/" :
            model.setDisplay(firstNumber / secondNumber);
            break;
        }
        return model.getDisplay();
    }
}