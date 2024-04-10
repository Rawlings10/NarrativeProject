using System;

namespace NarrativeProject
{
    internal abstract class Room
    {
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
    }
    internal interface Idetails
    {
        void title();
        void Player_Details();
    }
}
