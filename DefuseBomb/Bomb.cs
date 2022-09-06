using System;
using System.Collections.Generic;
using Rules;

namespace DefuseBomb
{
    public class Bomb
    {
        private readonly Dictionary<string, IWireRule> _dic;

        public Bomb(){
            _dic = new Dictionary<string, IWireRule>();
            AddRules();
        }

                /**
            @desc - Adds all the business rules, "Rules Designed Pattern" applied
        */
        private void AddRules()
        {
            _dic.Add("White", new WhiteWireRule());
            _dic.Add("Red", new RedWireRule());
            _dic.Add("Black", new BlackWireRule());
            _dic.Add("Orange", new OrangeWireRule());
            _dic.Add("Green", new GreenWireRule());
            _dic.Add("Purple", new PurpleWireRule());
        }


        /**
            @desc - this method represents, the action of cutting wires to deactived the bomb
            @param - Receives multiple Strings, as Input
            @returns - the state of the bomb
            @throws - ArgumentException when invalid input is passed to the method
        */
        public State CutWires(params String[] wires)
        {
            if (wires.Length < 2)
            {
               throw new ArgumentException("The input must be greater than 2");
            }
            string
                previous = wires[0],
                curr;
            State state;
            for (int i = 1; i < wires.Length; i++)
            {
                curr = wires[i];
                if (_dic[previous].CanCutWire(curr))
                {
                    Console.WriteLine("The bomb is still active! Cut another wire");
                    state = State.Active;
                }
                else
                {
                    Console.WriteLine("The bomb exploded!");
                    state =  State.Exploded;
                    return state;
                    
                }
                previous = curr;
            }

            Console.WriteLine("Very good! Bomb disarmed. At last...");
            state =  State.Dismantled;

            return state;
        }
    }
}
