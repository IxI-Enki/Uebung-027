/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF
 *------------------------------------------------------------------------------
 *                      Jan Ritt
 *------------------------------------------------------------------------------
 *  Description:  The program reads in a german and english vocable and let's 
 *                a student guess it.
 *------------------------------------------------------------------------------
*/namespace EinfacherVokabeltrainer
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // declare VARIABLES  ////////////////////////////////
      string userInput,     //  Benutzereingabe
             vokabelEng,    //  englischer Vokabel
             vokabelDe;     //  deutscher Vokabel
         int versuchNr;     //  Versuchsnummer
        bool abort = false; //  

      ////  CLEAR SCREEN  &  HEADER  ///////////////////////
      Console.Clear();
      Console.Write("\n  einfacher Vokabel-Trainer  " +
                    "\n=============================");
      ////  USER INPUT  ////////////////////////////////////
      ///  TEACHER
      Console.Write("\n Lehrer-Abschnitt:  " +
                    "\n--------------------" +
                    "\n englisches Wort:   \n");
      userInput = Console.ReadLine();
      vokabelEng = userInput;

      Console.Write("\n deutsche Übersetzung:  " +
                    "\n------------------------\n");
      userInput = Console.ReadLine();
      vokabelDe = userInput;

      ///  STUDENT
      Console.Clear();
      Console.Write("\n  einfacher Vokabel-Trainer  " +
                    "\n=============================" +
                    "\n Schüler-Abschnitt: " +
                    "\n--------------------" +
                    "\n gib die deutsche Übersetzung für " +
                   $"\n  {vokabelEng} ein.  ");
      ////  CALCULATION  ///////////////////////////////////
      for (versuchNr = 0; (versuchNr <= 10) && (abort == false); versuchNr++)
      {
        Console.Write($"\n Versuch {versuchNr + 1}:  ");
        userInput = Console.ReadLine();
        abort = (userInput == vokabelDe) ? true : false;
      }
      if (userInput != vokabelDe)
      {
        Console.Write("\n Das war wohl nichts!");
      }
      switch (versuchNr)
      {
        case 1:
          {
            Console.Write("\n Toll beim ersten Versuch!");
            break;
          }
        case 2:
        case 3:
          {
            Console.Write($"\n Gut gemacht nur {versuchNr} Versuche!");
            break;
          }
        case 4:
        case 5:
          {
            Console.Write("\n Nur noch ein bischen üben!");
            break;
          }
        case 6:
        case 7:
        case 9:
          {
            Console.Write("\n Üben, üben, üben!");
            break;
          }
        default:
          {
            Console.Write("\n Das war wohl nichts!");
            break;
          }
      }
      ////  EXIT PROMPT  ///////////////////////////////////
      Console.Write("\n══════════════════════════════════" +
                    "\n Beenden mit beliebiger Taste ... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}