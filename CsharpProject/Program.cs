using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------- 0. just testing with IL -----------
            // var test = new Test();
            // test.BoxingAndUnboxing();
            // test.ImmutableString();
            // test.IntermediateLanaguage();

            // ----------- 1. BASIC OPTIMIZATION -----------
            // var test = new AvoidBoxing();
            // var test = new StringConcatenation();
            // var test = new FastCollection();
            // var test = new FastArray2();
            // var test = new Exception();
            // var test = new Exception2();
            // var test = new Exception3();
            // var test = new ForVSForEach();
            // test.Testing();

            // ----------- Exercise
            // var exercise = new Exercise1();
            // var result = exercise.GetCharacterCount("John Doe");


            // ----------- 2. INTERMEDIATE OPTIMIZATION -----------
            //var deleg = new delegateUse();
            //deleg.Testing();
            var factoryClass = new FactoryClass();
            factoryClass.Testing();



            // ----------- 3. ADVANCED OPTIMIZATION -----------

        }
    }
}
