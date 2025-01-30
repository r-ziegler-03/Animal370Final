namespace Cpsc370Final;

public class Hangman
{
    public string DrawHangman(int remainingAttemps)
    {
        switch (remainingAttemps)
        {
            case 0 :
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|       / \\\n\t|\n\t|\n________|_________";
            case 1 :
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|       / \n\t|\n\t|\n________|_________";
            case 2:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|        \n\t|\n\t|\n________|_________";
            case 3:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 4:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 5:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 6:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 7:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_ )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 8:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x  )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 9:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (   )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 10:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      \n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
        }

        return "Not a valid number";
    }
}