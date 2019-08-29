using System;

namespace TestLibrary
{
    internal struct TestStruct
    {
//#pragma warning disable SUPP3662 // Note: This does not work yet: https://gist.github.com/mavasani/fcac17a9581b5c54cef8a689eeec954a#gistcomment-2985503
        public readonly int X;
        public readonly int Y;
    }
}
