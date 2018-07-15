using System;
namespace example {


 public class Barbara {

//VARIABLES
    public string mastersName; //name of user playing
    public int sanity;
    public int indiv;

//constructor
    public Barbara(string name) {
      mastersName = name;
      sanity = 10;
      indiv = 10;
    }


public void makeChoice(int input){
    if(input == 1){ // allowing barbie to make her own choices
      this.indiv++;
    }
    else if(input == 2){ //forcing choices onto barbie
      this.indiv--;
    }
    else if(input == 3){ //handling her clack of individuality badly
      this.sanity--;
    }
    else if(input == 4){ //talk w barbie & allowing her to speak her mind
      this.sanity++;
    }


}//end of make choice

    static void Main(){
      Console.WriteLine("What's your name?");
      Barbara Barbara = new Barbara( Console.ReadLine() );
      //Console.WriteLine("Nice to meet you, " + Barbara.mastersName + "!");
      //Barbara.makeChoice(2);
      //Console.WriteLine(Barbara.indiv);
      DateTime dat = DateTime.Now;
      Console.WriteLine("Barbara wakes up on a sunny "+  dat.ToString("dddd")
      + " morning to her bedazzled uPhone buzzing with a text from Kenneth. Her kitten, Mittens, is chirping.");


    Choice1:
      Console.WriteLine("1: Read Kenneth's Text 2: Go to Mittens");
      String choice = Console.ReadLine();

      switch( choice )
      {
        case "1" : Console.WriteLine("Read Kenneth's Text"); break;
        case "2" : Console.WriteLine("Go to Mittens"); break;
        default: Console.WriteLine("Not an option"); goto Choice1; //break; 
      }


    }//end of main

  }//end of class

}//end of namespace
