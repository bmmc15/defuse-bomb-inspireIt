using System;
using Xunit;
using DefuseBomb;

namespace DefuseProgram.Tests
{
    public class DefuseBombTests
    {
        private readonly Bomb defuseBomb = new Bomb();

        [Fact]
        public void Input1_Test()
        {   
            State state = defuseBomb.CutWires(Constants.Input1);
            Assert.Equal(State.Dismantled, state);
        }
        [Fact]
        public void Input2_Test()
        {   
            State state = defuseBomb.CutWires(Constants.Input2);
            Assert.Equal(State.Exploded, state);
        }
        [Fact]
        public void Input3_Test()
        {   
            State state = defuseBomb.CutWires(Constants.Input3);
            Assert.Equal(State.Dismantled, state);
        }
        [Fact]
        public void Input4_Test()
        {   
            State state = defuseBomb.CutWires(Constants.Input4);
            Assert.Equal(State.Exploded, state);
        }

        [Fact]
        public void InvalidInput_CutWires()
        {
            // Arrange
            String Input = "White"; //only cut one wire, which is invalid

            // Act and assert
            Assert.Throws<System.ArgumentException>(() => defuseBomb.CutWires(Input));
        }
    
    }
}
