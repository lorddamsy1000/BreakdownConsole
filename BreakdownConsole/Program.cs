using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BreakdownConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩1stAspect.txt");
            //SecondBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩2ndAspectBreakdown.txt");
            //FindClass("org.jhotdraw.app", "org.jhotdraw.gui", @"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\TotalClassBreakdown.txt");
            //Console.WriteLine("Hello World!");
            //GenerateGraph(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopSpecificClassbreakdown.txt");

            FullBreakdown();

            //VSFourthBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\eshopClassAspectBreakdown3.txt");

            //VSSixthBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\eshopPackageAspectBreakdown.txt");
            //VSSeventhBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\eshopMethodAspectBreakdown2withoutargs.txt");
            //VSFindClass("Microsoft.eShopWeb.Web", "Microsoft.eShopWeb", @"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopMethodAspectDivision.txt");
        }

        public static void FullBreakdown()
        {
            //VSFirstBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStorenlog.log");
            //VSSecondBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2.txt");
            //VSThirdBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2withoutargs.txt");
            //VSfifthBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestClassAspectBreakdown3.txt");
            //VSFourthBreakdown(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\BankPackageAspectBreakdown.txt");
            //ChooseBasePackage(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestPackageAspectBreakdownPercentage.txt", 3);
            GenerateModel(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestPackageAspectBreakdownPercentage.txt",
                            @"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestMethodAspectBreakdown2withoutargs.txt");
        }

        public static void VSFirstBreakdown(string value)
        {
            int counter = 0;
            string line;



            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains('|'))
                {
                    if(line.Split("|").Length == 2)
                    {
                        string[] firstBreakwords = line.Split("|");

                        string state = "";

                        if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 6) == "Failed")
                        {
                            state = "Failed.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 7) == "Yielded")
                        {
                            state = "Yielded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Starting")
                        {
                            state = "Starting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Awaiting")
                        {
                            state = "Awaiting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 9) == "Succeeded")
                        {
                            state = "Succeeded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 11) == "Enumerating")
                        {
                            state = "Enumerating.";
                        }


                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown1.txt", true))
                        {
                            writeFile.Write(" " + state);
                        }

                        
                    }
                    else if (line.Split("|").Length == 4)
                    {

                    }
                    else 
                    {
                        string[] firstBreakwords = line.Split("|");
                        string classValue = firstBreakwords[2];

                        string state = "";


                        if (firstBreakwords[firstBreakwords.Length - 1].Length < 6)
                        {
                            
                            if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 6) == "Failed")
                            {
                                state = "Failed.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 7) == "Yielded")
                            {
                                state = "Yielded.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 8) == "Starting")
                            {
                                state = "Starting.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 8) == "Awaiting")
                            {
                                state = "Awaiting.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 9) == "Succeeded")
                            {
                                state = "Succeeded.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 11) == "Enumerating")
                            {
                                state = "Enumerating.";
                            }
                            else
                            {

                            }
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 6) == "Failed")
                        {
                            state = "Failed.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 7) == "Yielded")
                        {
                            state = "Yielded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Starting")
                        {
                            state = "Starting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Awaiting")
                        {
                            state = "Awaiting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 9) == "Succeeded")
                        {
                            state = "Succeeded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 11) == "Enumerating")
                        {
                            state = "Enumerating.";
                        }


                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown1.txt", true))
                        {
                            writeFile.WriteLine(classValue + " " + state);
                        }

                        counter++;
                    }
                    
                }
                
            }

            int counterss = 0;
            string liness;



            System.IO.StreamReader filess = new System.IO.StreamReader(value);
            while ((liness = filess.ReadLine()) != null)
            {
                if (liness.Contains('|'))
                {
                    if (liness.Split("|").Length == 2)
                    {
                        string[] firstBreakwords = liness.Split("|");

                        string state = "";

                        if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 6) == "Failed")
                        {
                            state = "Failed.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 7) == "Yielded")
                        {
                            state = "Yielded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Starting")
                        {
                            state = "Starting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Awaiting")
                        {
                            state = "Awaiting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 9) == "Succeeded")
                        {
                            state = "Succeeded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 11) == "Enumerating")
                        {
                            state = "Enumerating.";
                        }


                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown1.txt", true))
                        {
                            writeFile.Write(" £ " + state);
                        }


                    }
                    else if (liness.Split("|").Length == 4)
                    {

                    }
                    else
                    {
                        string[] firstBreakwords = liness.Split("|");

                        string classValue = "";

                        if (firstBreakwords.Length > 3)
                        {
                            classValue = firstBreakwords[2] + "." + firstBreakwords[3].Split(".")[1];
                        }

                        

                        string state = "";


                        if (firstBreakwords[firstBreakwords.Length - 1].Length < 6)
                        {

                            if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 6) == "Failed")
                            {
                                state = "Failed.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 7) == "Yielded")
                            {
                                state = "Yielded.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 8) == "Starting")
                            {
                                state = "Starting.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 8) == "Awaiting")
                            {
                                state = "Awaiting.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 9) == "Succeeded")
                            {
                                state = "Succeeded.";
                            }
                            else if (firstBreakwords[firstBreakwords.Length - 3].Substring(0, 11) == "Enumerating")
                            {
                                state = "Enumerating.";
                            }
                            else
                            {

                            }
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 6) == "Failed")
                        {
                            state = "Failed.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 7) == "Yielded")
                        {
                            state = "Yielded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Starting")
                        {
                            state = "Starting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 8) == "Awaiting")
                        {
                            state = "Awaiting.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 9) == "Succeeded")
                        {
                            state = "Succeeded.";
                        }
                        else if (firstBreakwords[firstBreakwords.Length - 1].Substring(0, 11) == "Enumerating")
                        {
                            state = "Enumerating.";
                        }


                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown1.txt", true))
                        {
                            writeFile.WriteLine(classValue + " £ " + state);
                        }

                        counterss++;
                    }

                    
                }
                
            }

            Stack values = new Stack();
            int counters = 0;
            string lines;
            System.IO.StreamReader files = new System.IO.StreamReader(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown1.txt");

            while((lines = files.ReadLine()) != null)
            {
                string[] breakWords = lines.Split(" ");
                if(breakWords[1] == "Starting.")
                {
                    if(values.Count == 0)
                    {
                        values.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = values.Pop().ToString();
                        values.Push(caller);
                        values.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine( caller + "->" + breakWords[0]);
                            
                        }


                    }
                    
                }
                else if (breakWords[1] == "Succeeded.")
                {
                    values.Pop();
                }
                else if (breakWords[1] == "Enumerating.")
                {
                    if (values.Count == 0)
                    {
                        values.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = values.Pop().ToString();
                        values.Push(caller);
                        values.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine(caller + "->" + breakWords[0]);

                        }


                    }
                }
                else if (breakWords[1] == "Awaiting.")
                {
                    if (values.Count == 0)
                    {
                        values.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = values.Pop().ToString();
                        values.Push(caller);
                        values.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine(caller + "->" + breakWords[0]);

                        }


                    }
                }
                else if(breakWords[1] == "Yielded.")
                {
                    values.Pop();
                }
                else if (breakWords[1] == "Failed.")
                {
                    values.Pop();
                }

                counters++;
            }


            Stack valuess = new Stack();
            int countersss = 0;
            string linesss;
            System.IO.StreamReader filesss = new System.IO.StreamReader(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown1.txt");

            while ((linesss = filesss.ReadLine()) != null)
            {
                string[] breakWords = linesss.Split(" £ ");
                if (breakWords[1] == "Starting.")
                {
                    if (valuess.Count == 0)
                    {
                        valuess.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = valuess.Pop().ToString();
                        valuess.Push(caller);
                        valuess.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine(caller + "->" + breakWords[0]);

                        }


                    }

                }
                else if (breakWords[1] == "Succeeded.")
                {
                    valuess.Pop();
                }
                else if (breakWords[1] == "Enumerating.")
                {
                    if (valuess.Count == 0)
                    {
                        valuess.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = valuess.Pop().ToString();
                        valuess.Push(caller);
                        valuess.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine(caller + "->" + breakWords[0]);

                        }


                    }

                }
                else if (breakWords[1] == "Awaiting.")
                {
                    if (valuess.Count == 0)
                    {
                        valuess.Push(breakWords[0]);
                    }
                    else
                    {
                        string caller = valuess.Pop().ToString();
                        valuess.Push(caller);
                        valuess.Push(breakWords[0]);

                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2.txt", true))
                        {
                            writeFile.WriteLine(caller + "->" + breakWords[0]);

                        }


                    }

                }
                else if (breakWords[1] == "Yielded.")
                {
                    values.Pop();
                }
                else if (breakWords[1] == "Failed.")
                {
                    values.Pop();
                }

                countersss++;
            }

        }

        
        public static void VSSecondBreakdown(string value)
        {
            int counter = 0;
            string line;

            Dictionary<string, int> collectiveValue = new Dictionary<string, int>();
            string sendto = "";

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split("->");
                string[] delimiterChars = { "(",  ")" };

                string[] secondBreakwords1 = firstBreakwords[0].Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
                string[] secondBreakwords2 = firstBreakwords[1].Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);


                if (secondBreakwords1.Length == 0 && secondBreakwords2.Length == 0)
                {

                }
                else if(secondBreakwords1.Length == 0)
                {
                    string liness = sendto + "()" + " -> " + secondBreakwords2[0] + "()";

                    if (collectiveValue.ContainsKey(liness))
                    {
                        collectiveValue[liness] = collectiveValue[liness] + 1;
                    }
                    else
                    {
                        collectiveValue.Add(liness, 1);
                    }
                    counter++;
                }
                else if(secondBreakwords2.Length == 0)
                {
                   
                    counter++;
                    sendto = secondBreakwords1[0];
                }
                else
                {
                    string liness = secondBreakwords1[0] + "()" + " -> " + secondBreakwords2[0] + "()";

                    if (collectiveValue.ContainsKey(liness))
                    {
                        collectiveValue[liness] = collectiveValue[liness] + 1;
                    }
                    else
                    {
                        collectiveValue.Add(liness, 1);
                    }
                    counter++;
                    sendto = secondBreakwords1[0];
                }

                
            }



            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreMethodAspectBreakdown2withoutargs.txt", true))
            {
                foreach (string val in collectiveValue.Keys)
                {
                    writeFile.WriteLine(val);
                }

            }
        }


        public static void VSThirdBreakdown(string value)
        {
            int counter = 0;
            string line;

            Dictionary<string, int> collectiveValue = new Dictionary<string, int>();

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split("->");

                string secondBreakwords1 = "";
                string secondBreakwords2 = "";

                for (int i = 0; i < firstBreakwords[0].Split(".").Length-1; i++)
                {
                    if (!secondBreakwords1.Equals(""))
                    {
                        secondBreakwords1 = secondBreakwords1 + "." + firstBreakwords[0].Split(".")[i];
                    }
                    else
                    {
                        secondBreakwords1 = firstBreakwords[0].Split(".")[i];
                    }
                        

                }

                for (int i = 0; i < firstBreakwords[1].Split(".").Length - 1; i++)
                {
                    if (!secondBreakwords2.Equals(""))
                    {
                        secondBreakwords2 = secondBreakwords2 + "." + firstBreakwords[1].Split(".")[i];
                    }
                    else
                    {
                        secondBreakwords2 =  firstBreakwords[1].Split(".")[i];
                    }

                }



                string liness = secondBreakwords1 +  " -> " + secondBreakwords2 ;

                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStoreClassAspectBreakdown3.txt", true))
                {
                    writeFile.WriteLine(liness);
                }

                counter++;
            }
        }

        public static void VSFourthBreakdown(string value)
        {
            int counter = 0;
            string line;
            //string lines;

            Dictionary<string, int> collectiveClassCaller = new Dictionary<string, int>();
            Dictionary<string, int> collectiveClassCallee = new Dictionary<string, int>();
            Dictionary<string, int> collectiveClassInteraction = new Dictionary<string, int>();
            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split(" -> ");

                if (collectiveClassCaller.ContainsKey(firstBreakwords[0]))
                {
                    collectiveClassCaller[firstBreakwords[0]] = collectiveClassCaller[firstBreakwords[0]] + 1;
                }
                else
                {
                    collectiveClassCaller.Add(firstBreakwords[0], 1);
                }

                if (collectiveClassCallee.ContainsKey(firstBreakwords[1]))
                {
                    collectiveClassCallee[firstBreakwords[1]] = collectiveClassCallee[firstBreakwords[1]] + 1;
                }
                else
                {
                    collectiveClassCallee.Add(firstBreakwords[1], 1);
                }

                if (collectiveClassInteraction.ContainsKey(line))
                {
                    collectiveClassInteraction[line] = collectiveClassInteraction[line] + 1;
                }
                else
                {
                    collectiveClassInteraction.Add(line, 1);
                }

                counter++;

            }

            foreach (string val in collectiveClassInteraction.Keys)
            {
                string[] firstBreakwords = val.Split(" -> ");
                float caller = ((float)collectiveClassInteraction[val] / (float)collectiveClassCaller[firstBreakwords[0]]) * 100;
                float callee = ((float)collectiveClassInteraction[val] / (float)collectiveClassCallee[firstBreakwords[1]]) * 100;

                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\BankPackageAspectBreakdownPercentage.txt", true))
                {
                    writeFile.WriteLine(val + " " + caller + " " + callee);

                }
            }

            foreach (string val in collectiveClassInteraction.Keys)
            {
                string[] firstBreakwords = val.Split(" -> ");
                float caller = ((float)collectiveClassInteraction[val] / (float)collectiveClassCaller[firstBreakwords[0]]) * 100;
                float callee = ((float)collectiveClassInteraction[val] / (float)collectiveClassCallee[firstBreakwords[1]]) * 100;

                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\BankPackageAspectGraphVizBreakdownPercentage.txt", true))
                {
                    writeFile.WriteLine(val.Replace(".","") + " " + "[taillabel=\"" + caller + "            \", headlabel=\"               " + callee + "\"]");

                }
            }

        }


        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");


        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");


        //        if (firstwords.Length >= 6)
        //        {

        //            string firstCompare2 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3] + "." + firstwords[4];

        //            if (firstCompare2.Equals("BankSystem.Web.Areas.MoneyTransfers.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3] + "." + firstwords[4] +"."+ firstwords[5];
        //            }
        //            else if (firstCompare2.Equals("BankSystem.Web.Areas.Cards.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3] + "." + firstwords[4] +"."+ firstwords[5];
        //            }
        //            else if (firstCompare2.Equals("BankSystem.Web.Areas.Administration.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3] +"."+ firstwords[4] +"."+ firstwords[5];
        //            }
        //            else
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //        }
        //        else if (firstwords.Length >= 4)
        //        {
        //            string firstCompare = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];

        //            if (firstCompare1.Equals("DemoShop.Web.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Web.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Services.Implementations"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("DemoShop.Services.Implementations"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("CentralApi.Services.Implementations"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Web.Api"))
        //            {
        //                if (!firstCompare.Equals("BankSystem.Web.Api.Models"))
        //                {
        //                    firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //                }
                        
        //            }
        //            else
        //            {
        //                firstBreakwords[0] = "";
        //            }

        //        }
                
        //        else
        //        {
        //            firstBreakwords[0] = "";
        //        }


        //        if(secondwords.Length >= 6)
        //        {
        //            string secondCompare2 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3] + "." + secondwords[4];

        //            if (secondCompare2.Equals("BankSystem.Web.Areas.MoneyTransfers.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3] +"." + secondwords[4]+"." + secondwords[5];
        //            }
        //            else if (secondCompare2.Equals("BankSystem.Web.Areas.Cards.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3] +"."+ secondwords[4] +"."+ secondwords[5];
        //            }
        //            else if (secondCompare2.Equals("BankSystem.Web.Areas.Administration.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3] + "." + secondwords[4] + "." + secondwords[5];
        //            }
        //            else
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //        }
        //        else if (secondwords.Length >= 4)
        //        {
        //            string secondCompare = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];
                    

        //            if (secondCompare1.Equals("DemoShop.Web.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Web.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Services.Implementations"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("DemoShop.Services.Implementations"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("CentralApi.Services.Implementations"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Web.Api"))
        //            {
        //                if (!secondCompare.Equals("BankSystem.Web.Api.Models"))
        //                {
        //                    firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //                }

        //            }
        //            else
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //        }
        //        else
        //        {
        //            firstBreakwords[1] = "";
        //        }








        //        string liness = firstBreakwords[0] + " -> " + firstBreakwords[1];

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\BankPackageAspectBreakdown.txt", true))
        //        {
        //            if (firstBreakwords[0].Equals(""))
        //            {

        //            }
        //            else
        //            {
        //                if (firstBreakwords[1].Equals(""))
        //                {

        //                }
        //                else
        //                {
        //                    writeFile.WriteLine(liness);
        //                }
        //            }
        //        }

        //        counter++;
        //    }
        //}
        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");


        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");

        //        if (firstwords.Length >= 4)
        //        {
        //            string firstCompare = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];

        //            if (firstCompare.Equals("SmartStore.Web.Framework.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3] + "." + firstwords[4];
        //            }
        //            else if (firstCompare1.Equals("SmartStore.Web.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("SmartStore.Admin.Controllers"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }

        //            else
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //        }
        //        else
        //        {
        //            firstBreakwords[0] = "";
        //        }

        //        if (secondwords.Length >= 4)
        //        {
        //            string secondCompare = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];

        //            if (secondCompare.Equals("SmartStore.Web.Framework.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3] + "." + secondwords[4];
        //            }
        //            else if (secondCompare1.Equals("SmartStore.Web.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("SmartStore.Admin.Controllers"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //        }
        //        else
        //        {
        //            firstBreakwords[1] = "";
        //        }








        //        string liness = firstBreakwords[0] + " -> " + firstBreakwords[1];

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SmartStorePackageAspectBreakdown.txt", true))
        //        {
        //            if (firstBreakwords[0].Equals(""))
        //            {

        //            }
        //            else
        //            {
        //                if (firstBreakwords[1].Equals(""))
        //                {

        //                }
        //                else
        //                {
        //                    writeFile.WriteLine(liness);
        //                }
        //            }
        //        }

        //        counter++;
        //    }
        //}

        //eShoponWeb Specific VSfifthBreakdown
        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");


        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");

        //        if (firstwords.Length >= 2)
        //        {
        //            string firstCompare = firstwords[0] + "." + firstwords[1] ;

        //            if (firstCompare.Equals("coderush.Startup"))
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //            else if (firstCompare.Equals("coderush.Controllers"))
        //            {
        //                string firstCompare1 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] ;
        //                if (firstCompare1.Equals("coderush.Controllers.Api"))
        //                {
        //                    firstBreakwords[0] = "coderush.Controllers.Api" + "." + firstwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[0] = "";
        //                }

        //            }
        //            else if (firstCompare.Equals("coderush.Services"))
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //            else if (firstCompare.Equals("coderush.Data"))
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //            else if (firstCompare.Equals("coderush.Models"))
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //            else if (firstCompare.Equals("coderush.Program"))
        //            {
        //                firstBreakwords[0] = "";
        //            }

        //            else
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //        }

        //        if (secondwords.Length >= 2)
        //        {
        //            string secondCompare = secondwords[0] + "." + secondwords[1];
        //            if (secondCompare.Equals("coderush.Startup"))
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //            else if (secondCompare.Equals("coderush.Controllers"))
        //            {
        //                string secondCompare1 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] ;
        //                if (secondCompare1.Equals("coderush.Controllers.Api"))
        //                {
        //                    firstBreakwords[1] = "coderush.Controllers.Api" + "." + secondwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[1] = "";
        //                }
        //            }
        //            else if (secondCompare.Equals("coderush.Services"))
        //            {
        //                firstBreakwords[1] = "" ;
        //            }
        //            else if (secondCompare.Equals("coderush.Data"))
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //            else if (secondCompare.Equals("coderush.Models"))
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //            else if (secondCompare.Equals("coderush.Program"))
        //            {
        //                firstBreakwords[1] = "";
        //            }

        //            else
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //        }








        //        string liness = firstBreakwords[0] + " -> " + firstBreakwords[1];

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\CodeRushPackageAspectBreakdown.txt", true))
        //        {
        //            if (firstBreakwords[0].Equals(""))
        //            {

        //            }
        //            else
        //            {
        //                if (firstBreakwords[1].Equals(""))
        //                {

        //                }
        //                else
        //                {
        //                    writeFile.WriteLine(liness);
        //                }
        //            }
        //        }

        //        counter++;
        //    }
        //}


        //SimplCommerce Specific Breakdown
        public static void VSfifthBreakdown(string value)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split(" -> ");
                string secondBreakwords1 = "";
                string secondBreakwords2 = "";

                firstBreakwords[1] = firstBreakwords[1].Trim();

                string[] firstwords = firstBreakwords[0].Split(".");
                string[] secondwords = firstBreakwords[1].Split(".");

                if (firstwords.Length >= 3)
                {
                    string firstCompare1 = firstwords[0] + "." + firstwords[1];
                    string firstCompare = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];

                    if (firstCompare1.Equals("SimplCommerce.WebHost"))
                    {
                        firstBreakwords[0] = "SimplCommerce.WebHost" + "." + firstwords[2];
                    }
                    else if (firstCompare1.Equals("SimplCommerce.Infrastructure"))
                    {
                        firstBreakwords[0] = "SimplCommerce.Infrastructure" + "." + firstwords[2]; ;
                    }
                    else if (firstCompare1.Equals("SimplCommerce.Module"))
                    {
                        firstBreakwords[0] = firstCompare + "." + firstwords[3];
                    }


                }

                if (secondwords.Length >= 3)
                {
                    string secondCompare1 = secondwords[0] + "." + secondwords[1];
                    string secondCompare = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];

                    if (secondCompare1.Equals("SimplCommerce.WebHost"))
                    {
                        firstBreakwords[1] = "SimplCommerce.WebHost" + "." + secondwords[2];
                    }
                    else if (secondCompare1.Equals("SimplCommerce.Infrastructure"))
                    {
                        firstBreakwords[1] = "SimplCommerce.Infrastructure" + "." + secondwords[2];
                    }
                    else if (secondCompare1.Equals("SimplCommerce.Module"))
                    {
                        firstBreakwords[1] = secondCompare + "." + secondwords[3];
                    }
                }




                for (int i = 0; i < firstBreakwords[0].Split(".").Length - 1; i++)
                {
                    if (!secondBreakwords1.Equals(""))
                    {
                        secondBreakwords1 = secondBreakwords1 + "." + firstBreakwords[0].Split(".")[i];
                    }
                    else
                    {
                        secondBreakwords1 = firstBreakwords[0].Split(".")[i];
                    }


                }

                for (int i = 0; i < firstBreakwords[1].Split(".").Length - 1; i++)
                {
                    if (!secondBreakwords2.Equals(""))
                    {
                        secondBreakwords2 = secondBreakwords2 + "." + firstBreakwords[1].Split(".")[i];
                    }
                    else
                    {
                        secondBreakwords2 = firstBreakwords[1].Split(".")[i];
                    }

                }



                string liness = secondBreakwords1 + " -> " + secondBreakwords2;

                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestPackageAspectBreakdown.txt", true))
                {
                    writeFile.WriteLine(liness);
                }

                counter++;
            }
        }


        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");
        //        string secondBreakwords1 = "";
        //        string secondBreakwords2 = "";

        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");

        //        if(firstwords.Length <= 2)
        //        {
        //            firstBreakwords[0] = firstwords[0] + "." + firstwords[1];
        //        }
        //        else if (firstwords.Length >= 3)
        //        {
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1];
        //            string firstCompare = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];

        //            if (firstCompare1.Equals("BankSystem.Common"))
        //            {
        //                firstBreakwords[0] = "BankSystem.Common" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Data"))
        //            {
        //                firstBreakwords[0] = "BankSystem.Data" + "." + firstwords[2]; ;
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Models"))
        //            {
        //                firstBreakwords[0] = "BankSystem.Models" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("CentralApi.Data"))
        //            {
        //                firstBreakwords[0] = "CentralApi.Data" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("CentralApi.Models"))
        //            {
        //                firstBreakwords[0] = "CentralApi.Models" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("DemoShop.Data"))
        //            {
        //                firstBreakwords[0] = "DemoShop.Data" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("DemoShop.Models"))
        //            {
        //                firstBreakwords[0] = "DemoShop.Models" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("DemoShop.Services"))
        //            {
        //                if (firstCompare1.Equals("DemoShop.Services") && firstwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[0] = "DemoShop.Services.Models" + "." + firstwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[0] = "DemoShop.Services" + "." + firstwords[2];
        //                }

        //            }
        //            else if (firstCompare1.Equals("DemoShop.Web"))
        //            {
        //                firstBreakwords[0] = "DemoShop.Web" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Web"))
        //            {
        //                firstBreakwords[0] = "BankSystem.Web" + "." + firstwords[2];
        //            }
        //            else if (firstCompare1.Equals("BankSystem.Services"))
        //            {
        //                if (firstCompare1.Equals("BankSystem.Services") && firstwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[0] = "BankSystem.Services.Models" + "." + firstwords[3];
        //                }
        //                else if (firstCompare1.Equals("BankSystem.Services") && firstwords[2].Equals("Tests"))
        //                {
        //                    firstBreakwords[0] = "BankSystem.Services.Tests" + "." + firstwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[0] = "BankSystem.Services" + "." + firstwords[2];
        //                }

        //            }
        //            else if (firstCompare1.Equals("CentralApi.Services"))
        //            {
        //                if (firstCompare1.Equals("CentralApi.Services") && firstwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[0] = "CentralApi.Services.Models" + "." + firstwords[3];
        //                }
        //                else if (firstCompare1.Equals("CentralApi.Services") && firstwords[2].Equals("Tests"))
        //                {
        //                    firstBreakwords[0] = "CentralApi.Services.Tests" + "." + firstwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[0] = "CentralApi.Services" + "." + firstwords[2];
        //                }

        //            }
        //            else if (firstwords[0].Equals("RSAKeyGenerator"))
        //            {
        //                firstBreakwords[0] = firstCompare;
        //            }
        //            else if (firstwords[0].Equals("CentralApi"))
        //            {
        //                firstBreakwords[0] = firstCompare;
        //            }

        //        }

        //        if (secondwords.Length <= 2)
        //        {
        //            firstBreakwords[1] = secondwords[0] + "." + secondwords[1];
        //        }
        //        else if (secondwords.Length >= 3)
        //        {
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1];
        //            string secondCompare = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];

        //            if (secondCompare1.Equals("BankSystem.Common"))
        //            {
        //                firstBreakwords[1] = "BankSystem.Common" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Data"))
        //            {
        //                firstBreakwords[1] = "BankSystem.Data" + "." + secondwords[2]; ;
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Models"))
        //            {
        //                firstBreakwords[1] = "BankSystem.Models" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("CentralApi.Data"))
        //            {
        //                firstBreakwords[1] = "CentralApi.Data" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("CentralApi.Models"))
        //            {
        //                firstBreakwords[1] = "CentralApi.Models" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("DemoShop.Data"))
        //            {
        //                firstBreakwords[1] = "DemoShop.Data" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("DemoShop.Models"))
        //            {
        //                firstBreakwords[1] = "DemoShop.Models" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("DemoShop.Services"))
        //            {
        //                if (secondCompare1.Equals("DemoShop.Services") && secondwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[1] = "DemoShop.Services.Models" + "." + secondwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[1] = "DemoShop.Services" + "." + secondwords[2];
        //                }

        //            }
        //            else if (secondCompare1.Equals("DemoShop.Web"))
        //            {
        //                firstBreakwords[1] = "DemoShop.Web" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Web"))
        //            {
        //                firstBreakwords[1] = "BankSystem.Web" + "." + secondwords[2];
        //            }
        //            else if (secondCompare1.Equals("BankSystem.Services"))
        //            {
        //                if (secondCompare1.Equals("BankSystem.Services") && secondwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[1] = "BankSystem.Services.Models" + "." + secondwords[3];
        //                }
        //                else if (secondCompare1.Equals("BankSystem.Services") && secondwords[2].Equals("Tests"))
        //                {
        //                    firstBreakwords[1] = "BankSystem.Services.Tests" + "." + secondwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[1] = "BankSystem.Services" + "." + secondwords[2];
        //                }

        //            }
        //            else if (secondCompare1.Equals("CentralApi.Services"))
        //            {
        //                if (secondCompare1.Equals("CentralApi.Services") && secondwords[2].Equals("Models"))
        //                {
        //                    firstBreakwords[1] = "CentralApi.Services.Models" + "." + secondwords[3];
        //                }
        //                else if (secondCompare1.Equals("CentralApi.Services") && secondwords[2].Equals("Tests"))
        //                {
        //                    firstBreakwords[1] = "CentralApi.Services.Tests" + "." + secondwords[3];
        //                }
        //                else
        //                {
        //                    firstBreakwords[1] = "CentralApi.Services" + "." + secondwords[2];
        //                }

        //            }
        //            else if (secondwords[0].Equals("RSAKeyGenerator"))
        //            {
        //                firstBreakwords[1] = secondCompare;
        //            }
        //            else if (secondwords[0].Equals("CentralApi"))
        //            {
        //                firstBreakwords[1] = secondCompare;
        //            }
        //        }




        //        for (int i = 0; i < firstBreakwords[0].Split(".").Length - 1; i++)
        //        {
        //            if (!secondBreakwords1.Equals(""))
        //            {
        //                secondBreakwords1 = secondBreakwords1 + "." + firstBreakwords[0].Split(".")[i];
        //            }
        //            else
        //            {
        //                secondBreakwords1 = firstBreakwords[0].Split(".")[i];
        //            }


        //        }

        //        for (int i = 0; i < firstBreakwords[1].Split(".").Length - 1; i++)
        //        {
        //            if (!secondBreakwords2.Equals(""))
        //            {
        //                secondBreakwords2 = secondBreakwords2 + "." + firstBreakwords[1].Split(".")[i];
        //            }
        //            else
        //            {
        //                secondBreakwords2 = firstBreakwords[1].Split(".")[i];
        //            }

        //        }



        //        string liness = secondBreakwords1 + " -> " + secondBreakwords2;

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\BankPackageAspectBreakdown.txt", true))
        //        {
        //            writeFile.WriteLine(liness);
        //        }

        //        counter++;
        //    }
        //}


        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");


        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");

        //        if (firstwords.Length >= 4)
        //        {
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];


        //            if (firstCompare1.Equals("coderush.Controllers.Api"))
        //            {
        //                firstBreakwords[0] = "coderush.Controllers.Api";
        //            }
        //            else if (firstCompare1.Equals("coderush.Models.AccountViewModels"))
        //            {
        //                firstBreakwords[0] = "coderush.Models.AccountViewModels";
        //            }
        //            else if (firstCompare1.Equals("coderush.Models.ManageViewModels"))
        //            {
        //                firstBreakwords[0] = "coderush.Models.ManageViewModels";
        //            }
        //            else if (firstCompare1.Equals("coderush.Models.SyncfusionViewModels"))
        //            {
        //                firstBreakwords[0] = "coderush.Models.SyncfusionViewModels";
        //            }

        //        }
        //        else if (firstwords.Length >= 3)
        //        {
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1];


        //            firstBreakwords[0] = firstCompare1;
        //        }
        //        else if (firstwords.Length >= 2)
        //        {
        //            string firstCompare1 = firstwords[0];


        //            firstBreakwords[0] = firstCompare1;
        //        }

        //        if (secondwords.Length >= 4)
        //        {
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];


        //            if (secondCompare1.Equals("coderush.Controllers.Api"))
        //            {
        //                firstBreakwords[1] = "coderush.Controllers.Api";
        //            }
        //            else if (secondCompare1.Equals("coderush.Models.AccountViewModels"))
        //            {
        //                firstBreakwords[1] = "coderush.Models.AccountViewModels";
        //            }
        //            else if (secondCompare1.Equals("coderush.Models.ManageViewModels"))
        //            {
        //                firstBreakwords[1] = "coderush.Models.ManageViewModels";
        //            }
        //            else if (secondCompare1.Equals("coderush.Models.SyncfusionViewModels"))
        //            {
        //                firstBreakwords[1] = "coderush.Models.SyncfusionViewModels";
        //            }

        //        }
        //        else if (secondwords.Length >= 3)
        //        {
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1];


        //            firstBreakwords[1] = secondCompare1;
        //        }
        //        else if (secondwords.Length >= 2)
        //        {
        //            string secondCompare1 = secondwords[0];


        //            firstBreakwords[1] = secondCompare1;
        //        }

        //        string liness = firstBreakwords[0] + " -> " + firstBreakwords[1];

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\CRPackageAspectBreakdown.txt", true))
        //        {
        //            writeFile.WriteLine(liness);
        //        }

        //        counter++;
        //    }
        //}


        //public static void VSfifthBreakdown(string value)
        //{
        //    int counter = 0;
        //    string line;

        //    System.IO.StreamReader file = new System.IO.StreamReader(value);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        string[] firstBreakwords = line.Split(" -> ");


        //        firstBreakwords[1] = firstBreakwords[1].Trim();

        //        string[] firstwords = firstBreakwords[0].Split(".");
        //        string[] secondwords = firstBreakwords[1].Split(".");

        //        if (firstwords.Length >= 4)
        //        {
        //            string firstCompare1 = firstwords[0] + "." + firstwords[1] + "." + firstwords[2];
        //            string firstCompare2 = firstwords[0] + "." + firstwords[1];


        //            if (firstCompare1.Equals("Blogifier.Core.Services"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare1.Equals("Blogifier.Core.Api"))
        //            {
        //                firstBreakwords[0] = firstwords[0] + "." + firstwords[1] + "." + firstwords[2] + "." + firstwords[3];
        //            }
        //            else if (firstCompare2.Equals("Blogifier.Core"))
        //            {
        //                firstBreakwords[0] = "";
        //            }
        //            else
        //            {
        //                firstBreakwords[0] = "";
        //            }



        //        }
        //        else if (firstwords.Length >= 3)
        //        {
        //            string firstCompare1 = firstwords[0];


        //            firstBreakwords[0] = "";
        //        }
        //        else if (firstwords.Length >= 2)
        //        {
        //            string firstCompare1 = firstwords[0];


        //            firstBreakwords[0] = "";
        //        }
        //        else
        //        {
        //            firstBreakwords[0] = "";
        //        }

        //        if (secondwords.Length >= 4)
        //        {
        //            string secondCompare1 = secondwords[0] + "." + secondwords[1] + "." + secondwords[2];


        //            if (secondCompare1.Equals("Blogifier.Core.Services"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("Blogifier.Core.Api"))
        //            {
        //                firstBreakwords[1] = secondwords[0] + "." + secondwords[1] + "." + secondwords[2] + "." + secondwords[3];
        //            }
        //            else if (secondCompare1.Equals("Blogifier.Core"))
        //            {
        //                firstBreakwords[1] = "";
        //            }
        //            else
        //            {
        //                firstBreakwords[1] = "";
        //            }


        //        }
        //        else if (secondwords.Length >= 3)
        //        {
        //            string secondCompare1 = secondwords[0];


        //            firstBreakwords[1] = "";

        //        }
        //        else if (secondwords.Length >= 2)
        //        {
        //            string secondCompare1 = secondwords[0];


        //            firstBreakwords[1] = "";
        //        }
        //        else
        //        {
        //            firstBreakwords[1] = "";
        //        }



        //        string liness = firstBreakwords[0] + " -> " + firstBreakwords[1];

        //        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\blogifierPackageAspectBreakdown.txt", true))
        //        {
        //            if (firstBreakwords[0].Equals(""))
        //            {

        //            }
        //            else
        //            {
        //                if (firstBreakwords[1].Equals(""))
        //                {

        //                }
        //                else
        //                {
        //                    writeFile.WriteLine(liness);
        //                }
        //            }

        //        }

        //        counter++;
        //    }
        //}


        public static void VSSixthBreakdown(string value)
        {
            int counter = 0;
            string line;

            Dictionary<string, int> collectiveClass = new Dictionary<string, int>();

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split(" -> ");
                firstBreakwords[1] = firstBreakwords[1].Trim();

                if (collectiveClass.ContainsKey(firstBreakwords[0]))
                {
                    collectiveClass[firstBreakwords[0]] = collectiveClass[firstBreakwords[0]] + 1;
                }
                else
                {
                    collectiveClass.Add(firstBreakwords[0], 1);
                }

                if (collectiveClass.ContainsKey(firstBreakwords[1]))
                {
                    collectiveClass[firstBreakwords[1]] = collectiveClass[firstBreakwords[1]] + 1;
                }
                else
                {
                    collectiveClass.Add(firstBreakwords[1], 1);
                }
                counter++;
            }

            foreach (string val in collectiveClass.Keys)
            {
                

                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestPackageAspectList.txt", true))
                {
                    writeFile.WriteLine(val);

                }
            }
        }


        public static void VSSeventhBreakdown (string value)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                string[] firstBreakwords = line.Split(" -> ");

                

                string[] firstWords = firstBreakwords[0].Split(".");

                string firstMethod = "";

                string firstPackage = "";

                string firstOne = firstWords[0] + "." + firstWords[1] + "." + firstWords[2] + "." + firstWords[3];

                string firstTwo = firstWords[0] + "." + firstWords[1] + "." + firstWords[2];

                string firstThree = firstWords[0] + "." + firstWords[1];

                if (firstOne.Equals("Microsoft.eShopWeb.ApplicationCore.Specifications"))
                {
                    firstPackage = "Microsoft.eShopWeb.ApplicationCore.Specifications";

                    for(int i = 4; i<=firstWords.Length-1; i++)
                    {
                        if(i == 4)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if(firstOne.Equals("Microsoft.eShopWeb.ApplicationCore.Services"))
                {
                    firstPackage = "Microsoft.eShopWeb.ApplicationCore.Services";

                    for (int i = 4; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstOne.Equals("Microsoft.eShopWeb.Web.Services"))
                {
                    firstPackage = "Microsoft.eShopWeb.Web.Services";

                    for (int i = 4; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstOne.Equals("Microsoft.eShopWeb.Infrastructure.Data"))
                {
                    firstPackage = "Microsoft.eShopWeb.Infrastructure.Data";

                    for (int i = 4; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstOne.Equals("Microsoft.eShopWeb.Infrastructure.Logging"))
                {
                    firstPackage = "Microsoft.eShopWeb.Infrastructure.Logging";

                    for (int i = 4; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstTwo.Equals("Microsoft.eShopWeb.ApplicationCore"))
                {
                    firstPackage = "Microsoft.eShopWeb.ApplicationCore";

                    for (int i = 3; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstTwo.Equals("Microsoft.eShopWeb.Web"))
                {
                    firstPackage = "Microsoft.eShopWeb.Web";

                    for (int i = 3; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstTwo.Equals("Microsoft.AspNetCore.Mvc"))
                {
                    firstPackage = "Microsoft.AspNetCore.Mvc";

                    for (int i = 3; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstThree.Equals("Microsoft.eShopWeb"))
                {
                    firstPackage = "Microsoft.eShopWeb";

                    for (int i = 2; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 2)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }
                else if (firstThree.Equals("Ardalis.GuardClauses"))
                {
                    firstPackage = "Ardalis.GuardClauses";

                    for (int i = 2; i <= firstWords.Length - 1; i++)
                    {
                        if (i == 2)
                        {
                            firstMethod = firstWords[i];
                        }
                        else
                        {
                            firstMethod = firstMethod + "." + firstWords[i];
                        }
                    }
                }

                string[] secondWords = firstBreakwords[1].Split(".");

                string secondMethod = "";

                string secondPackage = "";

                string secondOne = secondWords[0] + "." + secondWords[1] + "." + secondWords[2] + "." + secondWords[3];

                string secondTwo = secondWords[0] + "." + secondWords[1] + "." + secondWords[2];

                string secondThree = secondWords[0] + "." + secondWords[1];

                if (secondOne.Equals("Microsoft.eShopWeb.ApplicationCore.Specifications"))
                {
                    secondPackage = "Microsoft.eShopWeb.ApplicationCore.Specifications";

                    for (int i = 4; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondOne.Equals("Microsoft.eShopWeb.ApplicationCore.Services"))
                {
                    firstPackage = "Microsoft.eShopWeb.ApplicationCore.Services";

                    for (int i = 4; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondOne.Equals("Microsoft.eShopWeb.Web.Services"))
                {
                    firstPackage = "Microsoft.eshopWeb.Web.Services";

                    for (int i = 4; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondOne.Equals("Microsoft.eShopWeb.Infrastructure.Data"))
                {
                    secondPackage = "Microsoft.eShopWeb.Infrastructure.Data";

                    for (int i = 4; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondOne.Equals("Microsoft.eShopWeb.Infrastructure.Logging"))
                {
                    secondPackage = "Microsoft.eShopWeb.Infrastructure.Logging";

                    for (int i = 4; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 4)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondTwo.Equals("Microsoft.eShopWeb.ApplicationCore"))
                {
                    secondPackage = "Microsoft.eShopWeb.ApplicationCore";

                    for (int i = 3; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondTwo.Equals("Microsoft.eShopWeb.Web"))
                {
                    secondPackage = "Microsoft.eShopWeb.Web";

                    for (int i = 3; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondTwo.Equals("Microsoft.AspNetCore.Mvc"))
                {
                    secondPackage = "Microsoft.AspNetCore.Mvc";

                    for (int i = 3; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 3)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondThree.Equals("Microsoft.eShopWeb"))
                {
                    secondPackage = "Microsoft.eShopWeb";

                    for (int i = 2; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 2)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }
                else if (secondThree.Equals("Ardalis.GuardClauses"))
                {
                    secondPackage = "Ardalis.GuardClauses";

                    for (int i = 2; i <= secondWords.Length - 1; i++)
                    {
                        if (i == 2)
                        {
                            secondMethod = secondWords[i];
                        }
                        else
                        {
                            secondMethod = secondMethod + "." + secondWords[i];
                        }
                    }
                }


                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopMethodAspectDivision.txt", true))
                {
                    writeFile.WriteLine(firstPackage + " " + firstMethod + " " + secondPackage + " " + secondMethod);
                }

                counter++;
            }
        }

        public static void FirstBreakdown(string value)
        {
            int counter = 0;
            string line;

            


            System.IO.StreamReader file =  new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                //line = "execution(org.jdominion.CardPile(Class, int)) -> call(void org.jdominion.CardList.add(Card))";

                string[] firstBreakwords = line.Split("->");
                string[] delimiterChars = { "execution(", "call(",", "," ", "))" };
                string[] secondBreakwords1 = firstBreakwords[0].Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
                string[] secondBreakwords2 = firstBreakwords[1].Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

                if(secondBreakwords1.Length > 2 && secondBreakwords1[0].Substring(0,3) != "org" )
                {
                    for(int i = 2; i < secondBreakwords1.Length; i++)
                    {
                        secondBreakwords1[1] = secondBreakwords1[1] + ", " + secondBreakwords1[i];
                    }
                }
                else if (secondBreakwords1.Length > 2 && secondBreakwords1[0].Substring(0, 3) == "org")
                {
                    for (int i = 1; i < secondBreakwords1.Length; i++)
                    {
                        secondBreakwords1[0] = secondBreakwords1[0] + ", " + secondBreakwords1[i];
                    }
                }
                else if (secondBreakwords1.Length == 2 && secondBreakwords1[0].Substring(0, 3) == "org")
                {
                    secondBreakwords1[0] = secondBreakwords1[0] + ", " + secondBreakwords1[1];
                }

                if (secondBreakwords2.Length > 2 && secondBreakwords2[0].Substring(0, 3) != "org")
                {
                    for (int i = 2; i < secondBreakwords2.Length; i++)
                    {
                        secondBreakwords2[1] = secondBreakwords2[1] + ", " + secondBreakwords2[i];
                    }
                }
                else if (secondBreakwords2.Length > 2 && secondBreakwords2[0].Substring(0, 3) == "org")
                {
                    for (int i = 1; i < secondBreakwords2.Length; i++)
                    {
                        secondBreakwords2[0] = secondBreakwords2[0] + ", " + secondBreakwords2[i];
                    }
                }
                else if (secondBreakwords2.Length == 2 && secondBreakwords2[0].Substring(0, 3) == "org")
                {
                    secondBreakwords2[0] = secondBreakwords2[0] + ", " + secondBreakwords2[1];
                }

                //secondBreakwords1[1] = secondBreakwords1[1] + ")";
                //secondBreakwords2[1] = secondBreakwords2[1] + ")";

                string[] thirdBreakwords1;

                if (secondBreakwords1.Length > 2 && secondBreakwords1[0].Substring(0, 3) != "org")
                {
                    secondBreakwords1[1] = secondBreakwords1[1] + ")";
                    thirdBreakwords1 = secondBreakwords1[1].Split(".");
                }
                else if (secondBreakwords1.Length > 2 && secondBreakwords1[0].Substring(0, 3) == "org")
                {
                    secondBreakwords1[0] = secondBreakwords1[0] + ")";
                    thirdBreakwords1 = secondBreakwords1[0].Split(".");
                }
                else if (secondBreakwords1.Length == 2 && secondBreakwords1[0].Substring(0, 3) == "org")
                {
                    secondBreakwords1[0] = secondBreakwords1[0] + ")"; 
                    thirdBreakwords1 = secondBreakwords1[0].Split(".");
                }
                else
                {
                    secondBreakwords1[secondBreakwords1.Length - 1] = secondBreakwords1[secondBreakwords1.Length - 1] + ")";
                    thirdBreakwords1 = secondBreakwords1[secondBreakwords1.Length - 1].Split(".");
                }


                string[] thirdBreakwords2;

                if (secondBreakwords2.Length > 2 && secondBreakwords2[0].Substring(0, 3) != "org")
                {
                    secondBreakwords2[1] = secondBreakwords2[1] + ")";
                    thirdBreakwords2 = secondBreakwords2[1].Split(".");
                }
                else if (secondBreakwords2.Length > 2 && secondBreakwords2[0].Substring(0, 3) == "org")
                {
                    secondBreakwords2[0] = secondBreakwords2[0] + ")";
                    thirdBreakwords2 = secondBreakwords2[0].Split(".");
                }
                else if (secondBreakwords2.Length == 2 && secondBreakwords2[0].Substring(0, 3) == "org")
                {
                    secondBreakwords2[0] = secondBreakwords2[0] + ")";
                    thirdBreakwords2 = secondBreakwords2[0].Split(".");
                }
                else
                {
                    secondBreakwords2[secondBreakwords2.Length - 1] = secondBreakwords2[secondBreakwords2.Length - 1] + ")";
                    thirdBreakwords2 = secondBreakwords2[secondBreakwords2.Length - 1].Split(".");
                }
                
                

                string firstVal = "";
                string secondVal = "";
                string thirdVal = "";
                string fourthVal = "";

                if (thirdBreakwords1.Length == 7)
                {
                    firstVal = thirdBreakwords1[0] + "." + thirdBreakwords1[1] + "." + thirdBreakwords1[2] + "." + thirdBreakwords1[3] + "." + thirdBreakwords1[4];
                    secondVal = thirdBreakwords1[5] + "." + thirdBreakwords1[6];
                }
                else if (thirdBreakwords1.Length == 6)
                {
                    firstVal = thirdBreakwords1[0] + "." + thirdBreakwords1[1] + "." + thirdBreakwords1[2] + "." + thirdBreakwords1[3];
                    secondVal = thirdBreakwords1[4] + "." + thirdBreakwords1[5];
                }
                else if (thirdBreakwords1.Length == 5)
                {
                    firstVal = thirdBreakwords1[0] + "." + thirdBreakwords1[1] + "." + thirdBreakwords1[2];
                    secondVal = thirdBreakwords1[3] + "." + thirdBreakwords1[4];
                }
                else if (thirdBreakwords1.Length == 4)
                {
                    firstVal = thirdBreakwords1[0] + "." + thirdBreakwords1[1];
                    secondVal = thirdBreakwords1[2] + "." + thirdBreakwords1[3];
                }
                else if (thirdBreakwords1.Length == 3)
                {
                    firstVal = thirdBreakwords1[0] + "." + thirdBreakwords1[1];
                    secondVal = thirdBreakwords1[2];
                }


                if (thirdBreakwords2.Length == 7)
                {
                    thirdVal = thirdBreakwords2[0] + "." + thirdBreakwords2[1] + "." + thirdBreakwords2[2] + "." + thirdBreakwords2[3] + "." + thirdBreakwords2[4];
                    fourthVal = thirdBreakwords2[5] + "." + thirdBreakwords2[6];
                }
                else if (thirdBreakwords2.Length == 6)
                {
                    thirdVal = thirdBreakwords2[0] + "." + thirdBreakwords2[1] + "." + thirdBreakwords2[2] + "." + thirdBreakwords2[3];
                    fourthVal = thirdBreakwords2[4] + "." + thirdBreakwords2[5];
                }
                else if (thirdBreakwords2.Length == 5)
                {
                    thirdVal = thirdBreakwords2[0] + "." + thirdBreakwords2[1] + "." + thirdBreakwords2[2];
                    fourthVal = thirdBreakwords2[3] + "." + thirdBreakwords2[4];
                }
                else if (thirdBreakwords2.Length == 4)
                {
                    thirdVal = thirdBreakwords2[0] + "." + thirdBreakwords2[1];
                    fourthVal = thirdBreakwords2[2] + "." + thirdBreakwords2[3];
                }
                else if (thirdBreakwords2.Length == 3)
                {
                    thirdVal = thirdBreakwords2[0] + "." + thirdBreakwords2[1];
                    fourthVal = thirdBreakwords2[2];
                }

                //Console.WriteLine(firstVal + " " + secondVal + " " + thirdVal + " " + fourthVal);

                using (System.IO.StreamWriter writeFile  = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩2ndAspectBreakdown2.txt", true))
                {
                    writeFile.WriteLine(firstVal + " " + secondVal + " " + thirdVal + " " + fourthVal);
                }

                counter++;
            }

            
        }


        public static void VSFindClass(string one, string two, string classBreakdown)
        {
            int counter = 0;
            string line;
            
            System.IO.StreamReader file = new System.IO.StreamReader(classBreakdown);
            while ((line = file.ReadLine()) != null)
            {
                string[] breakdownWords = line.Split(" ");

                if (breakdownWords[0].Equals(one))
                {
                    if (breakdownWords[2].Equals(two))
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopSpecificMethodbreakdown.txt", true))
                        {
                            writeFile.WriteLine(breakdownWords[0]+"."+breakdownWords[1] + " " + breakdownWords[2] + "." + breakdownWords[3]);
                        }

                        

                    }
                }

            }

            VSGetClass(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopSpecificMethodbreakdown.txt");
        }

        public static void VSGetClass(string value)
        {
            string line;
            List<string> totalValue = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(value);

            while((line = file.ReadLine()) != null)
            {
                
                
                string[] breakdownWords = line.Split(" ");

                string[] firstWord = breakdownWords[0].Split(".");

                string[] secondWord = breakdownWords[1].Split(".");

                string classFrom = "";

                string classTo = "";

                for (int i = 0; i <= firstWord.Length - 2; i++)
                {
                    if (i == 0)
                    {
                        classFrom = firstWord[i];
                    }
                    else
                    {
                        classFrom = classFrom + "." + firstWord[i];
                    }
                }

                for (int i = 0; i <= secondWord.Length - 2; i++)
                {
                    if (i == 0)
                    {
                        classTo = secondWord[i];
                    }
                    else
                    {
                        classTo = classTo + "." + secondWord[i];
                    }
                }
                if (!totalValue.Contains(classFrom + " " + classTo))
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopSpecificClassbreakdown.txt", true))
                    {
                        writeFile.WriteLine(classFrom + " " + classTo);
                    }
                    totalValue.Add(classFrom + " " + classTo);
                }
                    

                    
                

                
            }
        }

        public static void SecondBreakdown(string value)
        {
            int counter = 0;
            string line;

            Dictionary<string, int> collectiveValue = new Dictionary<string, int>(); 

            System.IO.StreamReader file = new System.IO.StreamReader(value);
            while ((line = file.ReadLine()) != null)
            {
                if (collectiveValue.ContainsKey(line))
                {
                    collectiveValue[line] = collectiveValue[line] + 1;
                }
                else
                {
                    collectiveValue.Add(line, 1);
                }
                counter++; 
            }

            

            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩eshopAspectBreakdown1.txt", true))
            {
                foreach (string val in collectiveValue.Keys)
                {
                    writeFile.WriteLine(val);
                }
                
            }
        }

        public static void FindClass(string one, string two, string classBreakdown)
        {
            int counter = 0;
            string line;
            List<string> totalValue = new List<string>();
            



            System.IO.StreamReader file = new System.IO.StreamReader(classBreakdown);
            while ((line = file.ReadLine()) != null)
            {
                string[] breakdownWords = line.Split(" ");
                string[] first = breakdownWords[0].Split(".");
                string[] second = breakdownWords[1].Split(".");
                if(first[0] == one.Split(".")[0] && first[1] == one.Split(".")[1] && first[2] == one.Split(".")[2])
                {
                    if(second[0] == two.Split(".")[0] && second[1] == two.Split(".")[1] && second[2] == two.Split(".")[2])
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩SpecificClassBreakdown5.txt", true))
                        {
                            writeFile.WriteLine(breakdownWords[0]+ " " + breakdownWords[1]);
                        }

                        if (!totalValue.Contains(breakdownWords[1]))
                        {
                            ExtraClass(breakdownWords[1], classBreakdown);
                            totalValue.Add(breakdownWords[1]);
                        }
                        
                    }
                }
                
            }
        }

        //Use this for the getting all the links
        //add to a list every new class
        //Check if they call other classes
        //check until all classes in the list have been exhausted
        public static void FindAllClass(string one, string two, string classBreakdown)
        {

        }

        public static void ExtraClass(string val, string classBreakdown)
        {
            string lines;

            System.IO.StreamReader file = new System.IO.StreamReader(classBreakdown);
            while ((lines = file.ReadLine()) != null)
            {
                string[] secondbreakdown = lines.Split(" ");
                if (secondbreakdown[0] == val)
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                    {
                        writeFile.WriteLine(secondbreakdown[0] + " " + secondbreakdown[1]);
                    }
                }
            }
        }

        public static void GenerateGraph(string classBreakdown)
        {
            string lines;
            int counter = 0;
            Dictionary<string, int> collectiveValue = new Dictionary<string, int>();

            System.IO.StreamReader file = new System.IO.StreamReader(classBreakdown);
            while ((lines = file.ReadLine()) != null)
            {
                if(collectiveValue.ContainsKey(lines.Split(" ")[0]))
                {

                    if(collectiveValue.ContainsKey(lines.Split(" ")[1]))
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                        {
                            writeFile.WriteLine(collectiveValue[lines.Split(" ")[0]] + " " + collectiveValue[lines.Split(" ")[1]]);
                        }
                    }
                    else
                    {
                        collectiveValue.Add(lines.Split(" ")[1], counter);
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                        {
                            writeFile.WriteLine(collectiveValue[lines.Split(" ")[0]] + " " + collectiveValue[lines.Split(" ")[1]]);
                        }
                        counter++;
                    }
                }
                else
                {
                    collectiveValue.Add(lines.Split(" ")[0], counter);
                    counter++;
                    if (collectiveValue.ContainsKey(lines.Split(" ")[1]))
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                        {
                            writeFile.WriteLine(collectiveValue[lines.Split(" ")[0]] + " " + collectiveValue[lines.Split(" ")[1]]);
                        }
                    }
                    else
                    {
                        collectiveValue.Add(lines.Split(" ")[1], counter);
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                        {
                            writeFile.WriteLine(collectiveValue[lines.Split(" ")[0]] + " " + collectiveValue[lines.Split(" ")[1]]);
                        }
                        counter++;
                    }
                }
            }

            foreach(string s in collectiveValue.Keys)
            {
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\⁩⁩blogifierGraphClassBreakdown.txt", true))
                {
                    writeFile.WriteLine(s + " " + collectiveValue[s]);
                }
            }
        }

        public static void ChooseBasePackage(string classpercentage, int noOfPackage)
        {
            string lines;
            int counter = 0;

            
            Dictionary<string, int[]> totalCalled = new Dictionary<string, int[]>();

            System.IO.StreamReader file = new System.IO.StreamReader(classpercentage);
            while ((lines = file.ReadLine()) != null)
            {
                if(totalCalled.ContainsKey(lines.Split(" ")[0]))
                {
                    int caller = totalCalled[lines.Split(" ")[0]][0] + 1;

                    totalCalled[lines.Split(" ")[0]] = new int[] {caller, totalCalled[lines.Split(" ")[0]][1] };
                }
                else
                {
                    totalCalled.Add(lines.Split(" ")[0], new int[] { 1, 0});
                }

                if (totalCalled.ContainsKey(lines.Split(" ")[2]))
                {
                    int called = totalCalled[lines.Split(" ")[2]][1] + 1;

                    totalCalled[lines.Split(" ")[2]] = new int[] { totalCalled[lines.Split(" ")[2]][0], called };
                }
                else
                {
                    totalCalled.Add(lines.Split(" ")[2], new int[] { 0, 1 });
                }

                
                
            }
            foreach (string s in totalCalled.Keys)
            {
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestBasePackage.txt", true))
                {
                    writeFile.WriteLine(s + " " + totalCalled[s][0] + " " + totalCalled[s][1]);
                }
                counter++;
            }
            Dictionary<string, float> callAverage = new Dictionary<string, float>();
            foreach (string s in totalCalled.Keys)
            {
                callAverage.Add(s, ( totalCalled[s][0] + totalCalled[s][1] ) / 2);
            }

            List<string> basePackage = new List<string>();
            int noofpa = 0;
            foreach (KeyValuePair<string, float> item in callAverage.OrderByDescending(val => val.Value))
            {
                if(!noofpa.Equals(noOfPackage))
                {
                    if (0.25 * item.Value < totalCalled[item.Key][0])
                    {
                        basePackage.Add(item.Key);
                    }
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestActualBasePackage.txt", true))
                    {
                        writeFile.WriteLine(item.Key + " " + totalCalled[item.Key][0] + " " + totalCalled[item.Key][1] + " " + item.Value);
                    }
                    noofpa++;
                }
                else
                {
                    break;
                }
                
            }

            

            string liness;
            Dictionary<string, float[]> percentageValues = new Dictionary<string, float[]>();
            Dictionary<string, List<string[]>> finalbreakdown = new Dictionary<string, List<string[]>>();
            System.IO.StreamReader files = new System.IO.StreamReader(classpercentage);
            while ((liness = files.ReadLine()) != null)
            {
                percentageValues.Add($"{liness.Split(" ")[0]} {liness.Split(" ")[1]} {liness.Split(" ")[2]}", new float[] {float.Parse(liness.Split(" ")[3]), float.Parse(liness.Split(" ")[4]) });
            }



            //Method for all rule 1 Connections 
            Dictionary<string, List<string[]>> ruleDict = new Dictionary<string, List<string[]>>();
            foreach(string s in percentageValues.Keys)
            {
                if(percentageValues[s][1] >= 70 && percentageValues[s][1] < 100)
                {
                    if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                    {
                        if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                        {
                            if (ruleDict.ContainsKey(s.Split(" ")[0]))
                            {
                                List<string[]> val = new List<string[]>();
                                val = ruleDict[s.Split(" ")[0]];

                                List<string> tempoList = new List<string>();
                                if (ruleDict.ContainsKey(s.Split(" ")[2]))
                                {
                                    foreach (string[] vla in ruleDict[s.Split(" ")[2]])
                                    {
                                        tempoList.Add(vla[0]);
                                    }
                                }
                                
                                if (!tempoList.Contains(s.Split(" ")[0]))
                                {
                                    val.Add(new string[] { s.Split(" ")[2], $"Rule 1" });
                                }
                                ruleDict[s.Split(" ")[0]] = val;
                            }
                            else
                            {
                                List<string[]> val = new List<string[]>();
                                val.Add(new string[] { s.Split(" ")[2], $"Rule 1" });
                                ruleDict.Add(s.Split(" ")[0], val);
                            }
                        }
                        
                    }
                    
                }
            }

            foreach (string s in percentageValues.Keys)
            {
                if (percentageValues[s][0] > 70 && percentageValues[s][1] > 70)
                {
                    if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                    {
                        if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                        {
                            if (ruleDict.ContainsKey(s.Split(" ")[0]))
                            {
                                List<string[]> val = new List<string[]>();
                                val = ruleDict[s.Split(" ")[0]];

                                List<string> tempList = new List<string>();
                                foreach (string[] vla in ruleDict[s.Split(" ")[0]])
                                {
                                    tempList.Add(vla[0]);
                                }
                                if (!tempList.Contains(s.Split(" ")[2]))
                                {
                                    //Make sure only one direction of connection is picked
                                    List<string> tempoList = new List<string>();
                                    foreach (string[] vla in ruleDict[s.Split(" ")[2]])
                                    {
                                        tempoList.Add(vla[0]);
                                    }
                                    if (!tempoList.Contains(s.Split(" ")[0]))
                                    {
                                        val.Add(new string[] { s.Split(" ")[2], $"Rule 1" });
                                    }
                                    ruleDict[s.Split(" ")[0]] = val;
                                }

                            }
                            else
                            {
                                List<string[]> val = new List<string[]>();
                                val.Add(new string[] { s.Split(" ")[2], $"Rule 1" });
                                ruleDict.Add(s.Split(" ")[0], val);
                            }
                        }

                        
                    }
                }
            }

            //Method for all rule 2 Connection
            Dictionary<string, Dictionary<string, float>> rule2 = new Dictionary<string, Dictionary<string, float>>();
            foreach (string s in percentageValues.Keys)
            {
                if(percentageValues[s][1] >= 30 && percentageValues[s][1] < 70)
                {
                    if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                    {
                        if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                        {
                            if (rule2.ContainsKey(s.Split(" ")[2]))
                            {
                                Dictionary<string, float> tempVal = new Dictionary<string, float>();
                                tempVal = rule2[s.Split(" ")[2]];
                                tempVal.Add(s.Split(" ")[0], percentageValues[s][1]);

                                rule2[s.Split(" ")[2]] = tempVal;
                            }
                            else
                            {
                                Dictionary<string, float> tempVal = new Dictionary<string, float>();
                                tempVal.Add(s.Split(" ")[0], percentageValues[s][1]);

                                rule2.Add(s.Split(" ")[2], tempVal);
                            }
                        }
                    }
                    
                    
                }
            }
            foreach(string s in rule2.Keys)
            {
                if (rule2[s].Count > 1)
                {
                    foreach(string k in rule2[s].Keys)
                    {
                        if (ruleDict.ContainsKey(k))
                        {
                            List<string[]> valueOf = new List<string[]>();
                            valueOf = ruleDict[k];
                            valueOf.Add(new string[] { s, $"Rule 2"});

                            ruleDict[k] = valueOf;
                        }
                        else
                        {
                            List<string[]> valueOf = new List<string[]>();
                            valueOf.Add(new string[] { s, $"Rule 2" });

                            ruleDict.Add(k, valueOf);
                        }
                    }
                }
                else
                {
                    Dictionary<string, float> tempvak = rule2[s];
                    string k = tempvak.Keys.FirstOrDefault();
                    if (ruleDict.ContainsKey(k))
                    {
                        List<string[]> valueOf = new List<string[]>();
                        valueOf = ruleDict[k];
                        valueOf.Add(new string[] { s, $"Rule 3" });

                        ruleDict[k] = valueOf;
                    }
                    else
                    {
                        List<string[]> valueOf = new List<string[]>();
                        valueOf.Add(new string[] { s, $"Rule 3" });

                        ruleDict.Add(k, valueOf);
                    }

                }
            }


            //Method for all rule 3 Connection
            Dictionary<string, Dictionary<string, float>> rule3 = new Dictionary<string, Dictionary<string, float>>();
            foreach (string s in percentageValues.Keys)
            {
                if (percentageValues[s][1] >= 25 && percentageValues[s][1] < 32)
                {
                    if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                    {
                        if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                        {
                            if (rule3.ContainsKey(s.Split(" ")[2]))
                            {
                                Dictionary<string, float> tempVal = new Dictionary<string, float>();
                                tempVal = rule3[s.Split(" ")[2]];
                                tempVal.Add(s.Split(" ")[0], percentageValues[s][1]);

                                rule3[s.Split(" ")[2]] = tempVal;
                            }
                            else
                            {
                                Dictionary<string, float> tempVal = new Dictionary<string, float>();
                                tempVal.Add(s.Split(" ")[0], percentageValues[s][1]);

                                rule3.Add(s.Split(" ")[2], tempVal);
                            }
                        }
                    }
                    

                }
            }
            foreach (string s in rule3.Keys)
            {
                
                foreach (string k in rule3[s].Keys)
                {
                    if (ruleDict.ContainsKey(k))
                    {
                        List<string[]> valueOf = new List<string[]>();
                        valueOf = ruleDict[k];
                        valueOf.Add(new string[] { s, $"Rule 3" });

                        ruleDict[k] = valueOf;
                    }
                    else
                    {
                        List<string[]> valueOf = new List<string[]>();
                        valueOf.Add(new string[] { s, $"Rule 3" });

                        ruleDict.Add(k, valueOf);
                    }
                }
                
            }

            //Method for rule 4 connections
            foreach (string s in percentageValues.Keys)
            {
                if (percentageValues[s][0] <= 20 && percentageValues[s][1] == 100)
                {
                    if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                    {
                        if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                        {
                            if (ruleDict.ContainsKey(s.Split(" ")[0]))
                            {
                                List<string[]> val = new List<string[]>();
                                val = ruleDict[s.Split(" ")[0]];

                                List<string> tempList = new List<string>();
                                foreach (string[] vla in ruleDict[s.Split(" ")[0]])
                                {
                                    tempList.Add(vla[0]);
                                }
                                if (!tempList.Contains(s.Split(" ")[2]))
                                {
                                    //Make sure only one direction of connection is picked
                                    List<string> tempoList = new List<string>();
                                    if(ruleDict.ContainsKey(s.Split(" ")[2]))
                                    {
                                        foreach (string[] vla in ruleDict[s.Split(" ")[2]])
                                        {
                                            tempoList.Add(vla[0]);
                                        }

                                    }
                                    
                                    if (!tempoList.Contains(s.Split(" ")[0]))
                                    {
                                        val.Add(new string[] { s.Split(" ")[2], $"Rule 4" });
                                    }
                                    ruleDict[s.Split(" ")[0]] = val;
                                }

                            }
                            else
                            {
                                List<string[]> val = new List<string[]>();
                                val.Add(new string[] { s.Split(" ")[2], $"Rule 4" });
                                ruleDict.Add(s.Split(" ")[0], val);
                            }
                        }


                    }
                }
            }

            //Method for all Rule 5 & Rule 7 Connections
            foreach (string s in percentageValues.Keys)
                {
                    if (!s.Split(" ")[0].Equals(s.Split(" ")[2]))
                    {
                        if (!(basePackage.Contains(s.Split(" ")[0]) && basePackage.Contains(s.Split(" ")[2])))
                        {
                            //if (!ruleDict.ContainsKey(s.Split(" ")[0]))
                            //{
                            //    List<string[]> valueOf = new List<string[]>();
                            //    valueOf.Add(new string[] { s.Split(" ")[2], $"Rule 7" });

                            //    ruleDict.Add(s.Split(" ")[0], valueOf);
                            //}
                            //else
                            //{
                            //    List<string> tempList = new List<string>();
                            //    foreach (string[] vla in ruleDict[s.Split(" ")[0]])
                            //    {
                            //        tempList.Add(vla[0]);
                            //    }
                            //    if (!tempList.Contains(s.Split(" ")[2]))
                            //    {
                            //        List<string[]> valueOf = new List<string[]>();
                            //        valueOf = ruleDict[s.Split(" ")[0]];
                            //        valueOf.Add(new string[] { s.Split(" ")[2], $"Rule 7" });

                            //        ruleDict[s.Split(" ")[0]] = valueOf;
                            //    }
                            //}
                    }
                        else
                        {
                            if (!ruleDict.ContainsKey(s.Split(" ")[0]))
                            {
                                List<string[]> valueOf = new List<string[]>();
                                valueOf.Add(new string[] { s.Split(" ")[2], $"Rule 5" });

                                ruleDict.Add(s.Split(" ")[0], valueOf);
                            }
                            else
                            {
                                List<string> tempList = new List<string>();
                                foreach (string[] vla in ruleDict[s.Split(" ")[0]])
                                {
                                    tempList.Add(vla[0]);
                                }
                                if (!tempList.Contains(s.Split(" ")[2]))
                                {
                                    List<string[]> valueOf = new List<string[]>();
                                    valueOf = ruleDict[s.Split(" ")[0]];
                                    valueOf.Add(new string[] { s.Split(" ")[2], $"Rule 5" });

                                    ruleDict[s.Split(" ")[0]] = valueOf;
                                }
                            }
                        }

                    }

                }
            Dictionary<string, Dictionary<string, List<string[]>>> totalfinalbreakdown = new Dictionary<string, Dictionary<string, List<string[]>>>();
            foreach (string s in basePackage)
            {
                finalbreakdown.Clear();
                List<string> temp = new List<string>();
                finalbreakdown = GetBreakdown(s, ruleDict, temp, finalbreakdown);
                totalfinalbreakdown.Add(s, finalbreakdown);
            }

            int counted = 0;
            foreach(string s in totalfinalbreakdown.Keys)
            {
                counted = counted+1;
                List<string> testVal = new List<string>();
                //Add values to dict 
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                {
                    writeFile.WriteLine("Microservice " + counted);
                }
                Dictionary<string, List<string[]>> finVal = totalfinalbreakdown[s];
                if (finVal.Keys.Contains(s))
                {
                    List<string[]> tempVal = finVal[s];
                    
                    foreach (string[] calc in tempVal)
                    {
                        if(!testVal.Contains(s + " " + "->" + " " + calc[0]))
                        {
                            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                            {
                                testVal.Add(s + " " + "->" + " " + calc[0]);
                                //writeFile.WriteLine(s + " " + calc[0] + " " + calc[1]);
                                writeFile.WriteLine(s.Replace(".", "") + " " + "->" + " " + calc[0].Replace(".", "") + " " + "[label=\"" + calc[1] + "\"]");
                            }
                        }


                        string valCalcul = calc[0];
                        if (ruleDict.Keys.Contains(calc[0]))
                        {
                            List<string[]> newVal = ruleDict[calc[0]];
                            foreach (string[] valCalc in newVal)
                            {
                                if(valCalc[1]=="Rule 1" || valCalc[1] == "Rule  2" || valCalc[1] == "Rule 3" || valCalc[1] == "Rule 4")
                                {
                                    if (!testVal.Contains(calc[0] + " " + "->" + " " + valCalc[0]))
                                    {
                                        if (!totalfinalbreakdown.Keys.Contains(valCalc[0]) && !totalfinalbreakdown.Keys.Contains(calc[0]))
                                        {
                                            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                                            {
                                                testVal.Add(calc[0] + " " + "->" + " " + valCalc[0]);
                                                //writeFile.WriteLine(s + " " + calc[0] + " " + calc[1]);
                                                writeFile.WriteLine(calc[0].Replace(".", "") + " " + "->" + " " + valCalc[0].Replace(".", "") + " " + "[label=\"" + valCalc[1] + "\"]");
                                            }
                                        }
                                        
                                    }
                                }
                                

                            }
                        }

                        if (ruleDict.Keys.Contains(s))
                        {
                            List<string[]> newVal = ruleDict[s];
                            foreach (string[] valCalc in newVal)
                            {
                                if (valCalc[1] == "Rule 1" || valCalc[1] == "Rule  2" || valCalc[1] == "Rule 3" || valCalc[1] == "Rule 4")
                                {
                                    if (!testVal.Contains(s + " " + "->" + " " + valCalc[0]))
                                    {
                                        if (!totalfinalbreakdown.Keys.Contains(valCalc[0]) )
                                        {
                                            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                                            {
                                                testVal.Add(s + " " + "->" + " " + valCalc[0]);
                                                //writeFile.WriteLine(s + " " + calc[0] + " " + calc[1]);
                                                writeFile.WriteLine(s.Replace(".", "") + " " + "->" + " " + valCalc[0].Replace(".", "") + " " + "[label=\"" + valCalc[1] + "\"]");
                                            }
                                        }

                                    }
                                }


                            }
                        }



                    }
                }
                else
                {
                    foreach(string so in ruleDict.Keys)
                    {
                        foreach (string[] soa in ruleDict[so])
                        {
                            if(so.Equals(s) || soa[0].Equals(s))
                            {
                                if (!testVal.Contains(so + " " + "->" + " " + soa[0]))
                                {
                                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                                    {
                                        testVal.Add(so + " " + "->" + " " + soa[0]);
                                        //writeFile.WriteLine(so + " " + soa[0] + " " + soa[1]);
                                        writeFile.WriteLine(so.Replace(".", "") + " " + "->" + " " + soa[0].Replace(".", "") + " " + "[label=\"" + soa[1] + "\"]");
                                    }

                                    
                                }
                                
                            }

                            if (so.Equals(s))
                            {
                                string valCalcul = soa[0];
                                if (ruleDict.Keys.Contains(soa[0]))
                                {
                                    List<string[]> newVal = ruleDict[soa[0]];
                                    foreach (string[] valCalc in newVal)
                                    {
                                        if(valCalc[1]=="Rule 1" || valCalc[1] == "Rule  2" || valCalc[1] == "Rule 3" || valCalc[1] == "Rule 4")
                                        {
                                            if (!testVal.Contains(soa[0] + " " + "->" + " " + valCalc[0]))
                                            {
                                                if (!totalfinalbreakdown.Keys.Contains(valCalc[0]) && !totalfinalbreakdown.Keys.Contains(soa[0]))
                                                {
                                                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                                                    {
                                                        testVal.Add(soa[0] + " " + "->" + " " + valCalc[0]);
                                                        //writeFile.WriteLine(s + " " + calc[0] + " " + calc[1]);
                                                        writeFile.WriteLine(soa[0].Replace(".", "") + " " + "->" + " " + valCalc[0].Replace(".", "") + " " + "[label=\"" + valCalc[1] + "\"]");
                                                    }
                                                }
                                                

                                            }
                                        }
                                        

                                    }
                                }
                            }

                            if (ruleDict.Keys.Contains(s))
                            {
                                List<string[]> newVal = ruleDict[s];
                                foreach (string[] valCalc in newVal)
                                {
                                    if (valCalc[1] == "Rule 1" || valCalc[1] == "Rule  2" || valCalc[1] == "Rule 3" || valCalc[1] == "Rule 4")
                                    {
                                        if (!testVal.Contains(s + " " + "->" + " " + valCalc[0]))
                                        {
                                            if (!totalfinalbreakdown.Keys.Contains(valCalc[0]))
                                            {
                                                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimplTestFinalBreakdownBasePackage.txt", true))
                                                {
                                                    testVal.Add(s + " " + "->" + " " + valCalc[0]);
                                                    //writeFile.WriteLine(s + " " + calc[0] + " " + calc[1]);
                                                    writeFile.WriteLine(s.Replace(".", "") + " " + "->" + " " + valCalc[0].Replace(".", "") + " " + "[label=\"" + valCalc[1] + "\"]");
                                                }
                                            }

                                        }
                                    }


                                }
                            }


                        }
                    }
                }


            }
        }

        public static Dictionary<string,List< string[]>> GetBreakdown(string s, Dictionary<string, List<string[]>> ruleDict, List<string> tempVal, Dictionary<string, List<string[]>> finalBreadown)
        {
            //List<string> tempVal = new List<string>();
            tempVal.Add(s);
            
            if (ruleDict.ContainsKey(s))
            {
                foreach (string[] sdrop in ruleDict[s])
                {
                    if (!tempVal.Contains(sdrop[0]))
                    {
                        if (ruleDict[s].Count >= 1)
                        {
                            if (finalBreadown.ContainsKey(s))
                            {
                                tempVal.Add(sdrop[0]);
                                List<string[]> joval = finalBreadown[s];
                                joval.Add(new string[] { sdrop[0], sdrop[1] });
                                finalBreadown[s] = joval;

                            }
                            else
                            {
                                tempVal.Add(sdrop[0]);
                                List<string[]> joval = new List<string[]>();
                                joval.Add(new string[] { sdrop[0], sdrop[1] });
                                finalBreadown.Add(s, joval);
                            }

                            List<string> recVal = new List<string>();

                            foreach (string[] k in ruleDict[s])
                            {
                                recVal.Add(k[0]);
                            }
                            foreach (string rec in recVal)
                            {
                                GetBreakdown(rec, ruleDict, tempVal, finalBreadown);
                            }
                        }
                        else
                        {
                            return finalBreadown;
                        }
                    }

                }
            }
            
            return finalBreadown;
        }

        public static void GenerateModel(string val, string val1)
        {
            int counter = 0;
            string line;

            Dictionary<string, List<string>> collectiveValue = new Dictionary<string, List<string>>();

            System.IO.StreamReader file = new System.IO.StreamReader(val);
            while ((line = file.ReadLine()) != null)
            {
                string[] breakdownWords = line.Split(" ");
                if (!breakdownWords[0].Equals(breakdownWords[2]))
                {
                    if (collectiveValue.ContainsKey(breakdownWords[0]))
                    {
                        bool check = false;
                        foreach (string s in collectiveValue[breakdownWords[0]])
                        {
                            if (collectiveValue.ContainsKey(breakdownWords[2]))
                            {
                                if (s.Equals(collectiveValue[breakdownWords[2]]))
                                {
                                    check = true;

                                }
                            }

                        }

                        if (check == false)
                        {
                            if (collectiveValue.ContainsKey(breakdownWords[2]))
                            {
                                bool check1 = false;
                                foreach (string s in collectiveValue[breakdownWords[2]])
                                {
                                    if (collectiveValue.ContainsKey(breakdownWords[0]))
                                    {
                                        if (s.Equals(collectiveValue[breakdownWords[0]]))
                                        {
                                            check1 = true;
                                        }
                                    }

                                }

                                if (check == false && check1 == false)
                                {
                                    List<string> stringVal = collectiveValue[breakdownWords[0]];
                                    stringVal.Add(breakdownWords[2]);
                                    collectiveValue[breakdownWords[0]] = stringVal;
                                }
                            }
                            else
                            {
                                if (collectiveValue.ContainsKey(breakdownWords[0]))
                                {
                                    List<string> stringVal = collectiveValue[breakdownWords[0]];
                                    stringVal.Add(breakdownWords[2]);
                                    collectiveValue[breakdownWords[0]] = stringVal;
                                }
                                else
                                {
                                    List<string> stringVal = new List<string>();
                                    stringVal.Add(breakdownWords[2]);
                                    collectiveValue.Add(breakdownWords[0], stringVal);
                                }

                            }
                        }
                    }
                    else
                    {
                        if (collectiveValue.ContainsKey(breakdownWords[2]))
                        {
                            bool check1 = false;
                            foreach (string s in collectiveValue[breakdownWords[2]])
                            {
                                if (collectiveValue.ContainsKey(breakdownWords[0]))
                                {
                                    if (s.Equals(collectiveValue[breakdownWords[0]]))
                                    {
                                        check1 = true;
                                    }
                                }

                            }

                            if (check1 == false)
                            {
                                if (collectiveValue.ContainsKey(breakdownWords[0]))
                                {
                                    List<string> stringVal = collectiveValue[breakdownWords[0]];
                                    stringVal.Add(breakdownWords[2]);
                                    collectiveValue[breakdownWords[0]] = stringVal;
                                }
                                else
                                {
                                    List<string> stringVal = new List<string>();
                                    stringVal.Add(breakdownWords[2]);
                                    collectiveValue.Add(breakdownWords[0], stringVal);
                                }
                            }
                        }
                        else
                        {
                            if (collectiveValue.ContainsKey(breakdownWords[0]))
                            {
                                List<string> stringVal = collectiveValue[breakdownWords[0]];
                                stringVal.Add(breakdownWords[2]);
                                collectiveValue[breakdownWords[0]] = stringVal;
                            }
                            else
                            {
                                List<string> stringVal = new List<string>();
                                stringVal.Add(breakdownWords[2]);
                                collectiveValue.Add(breakdownWords[0], stringVal);
                            }
                        }
                    }

                }
                
                counter++;
            }

            System.IO.StreamReader files = new System.IO.StreamReader(val);
            List<string> packList = new List<string>();
            while ((line = files.ReadLine()) != null)
            {
                string[] breakdownWords = line.Split(" ");
                if (!packList.Contains(breakdownWords[0]))
                {
                    packList.Add(breakdownWords[0]);
                }

                if (!packList.Contains(breakdownWords[2]))
                {
                    packList.Add(breakdownWords[2]);
                }
            }



            Dictionary<string, List<string>> collectiveValues = new Dictionary<string, List<string>>();
            System.IO.StreamReader filess = new System.IO.StreamReader(val1);
            while ((line = filess.ReadLine()) != null)
            {
                string[] breakdownWords = line.Split(" ");
                string[] breakdown = breakdownWords[0].Split(".");
                string[] breakdown1 = breakdownWords[2].Split(".");

                string breakdown0 = "";
                string breakdown2 = "";

                if (breakdown[0].Equals("SimplCommerce"))
                {
                    if(breakdown[1].Equals("Infrastructure") || breakdown[1].Equals("WebHost"))
                    {
                        breakdown0 = breakdown[0] + "." + breakdown[1] ;
                    }
                    else
                    {
                        breakdown0 = breakdown[0] + "." + breakdown[1] + "." + breakdown[2] ;
                    }
                }
                else
                {
                    for (int i = 0; i < breakdown.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            breakdown0 = breakdown[i];
                        }
                        else
                        {
                            breakdown0 = breakdown0 + "." + breakdown[i];
                        }
                    }
                }


                if (breakdown1[0].Equals("SimplCommerce"))
                {
                    if (breakdown1[1].Equals("Infrastructure") || breakdown1[1].Equals("WebHost"))
                    {
                        breakdown2 = breakdown1[0] + "." + breakdown1[1] ;
                    }
                    else
                    {
                        breakdown2 = breakdown1[0] + "." + breakdown1[1] + "." + breakdown1[2] ;
                    }
                }
                else
                {
                    for (int i = 0; i < breakdown1.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            breakdown2 = breakdown1[i];
                        }
                        else
                        {
                            breakdown2 = breakdown2 + "." + breakdown1[i];
                        }
                    }
                }

                

                if (packList.Contains(breakdown0))
                {
                    

                    if (!collectiveValues.ContainsKey(breakdown0))
                    {
                        List<string> valsT = new List<string>();
                        if (breakdown[0].Equals("SimplCommerce"))
                        {
                            if (breakdown[1].Equals("Infrastructure") || breakdown[1].Equals("WebHost"))
                            {
                                valsT.Add(breakdown[2]);
                                collectiveValues.Add(breakdown0, valsT);
                            }
                            else
                            {
                                valsT.Add(breakdown[3]);
                                collectiveValues.Add(breakdown0, valsT);
                            }
                            
                        }
                        else
                        {
                            if (!breakdown[breakdown.Length - 1].Equals("()"))
                            {
                                valsT.Add(breakdown[breakdown.Length - 1]);
                                collectiveValues.Add(breakdown0, valsT);
                            }
                        }
                        
                            
                    }
                    else
                    {
                        if (breakdown[0].Equals("SimplCommerce"))
                        {
                            if (breakdown[1].Equals("Infrastructure") || breakdown[1].Equals("WebHost"))
                            {
                                if (!collectiveValues[breakdown0].Contains(breakdown[2]))
                                {
                                    List<string> vs = collectiveValues[breakdown0];
                                    vs.Add(breakdown[2]);
                                    collectiveValues[breakdown0] = vs;
                                }
                            }
                            else
                            {
                                if (!collectiveValues[breakdown0].Contains(breakdown[3]))
                                {
                                    List<string> vs = collectiveValues[breakdown0];
                                    vs.Add(breakdown[3]);
                                    collectiveValues[breakdown0] = vs;
                                }
                            }
                        }
                        else
                        {
                            if (!collectiveValues[breakdown0].Contains(breakdown[breakdown.Length - 1]))
                            {
                                List<string> vs = collectiveValues[breakdown0];
                                if (!breakdown[breakdown.Length - 1].Equals("()"))
                                {
                                    vs.Add(breakdown[breakdown.Length - 1]);
                                    collectiveValues[breakdown0] = vs;
                                }

                            }
                        }
                        
                    }

                }

                if (packList.Contains(breakdown2))
                {


                    if (!collectiveValues.ContainsKey(breakdown2))
                    {
                        List<string> valsT = new List<string>();
                        if (breakdown1[0].Equals("SimplCommerce"))
                        {
                            if (breakdown1[1].Equals("Infrastructure") || breakdown1[1].Equals("WebHost"))
                            {
                                valsT.Add(breakdown1[2]);
                                collectiveValues.Add(breakdown2, valsT);
                            }
                            else
                            {
                                valsT.Add(breakdown1[3]);
                                collectiveValues.Add(breakdown2, valsT);
                            }

                        }
                        else
                        {
                            if (!breakdown1[breakdown1.Length - 1].Equals("()"))
                            {
                                valsT.Add(breakdown1[breakdown1.Length - 1]);
                                collectiveValues.Add(breakdown2, valsT);
                            }
                        }

                    }
                    else
                    {
                        if (breakdown1[0].Equals("SimplCommerce"))
                        {
                            if (breakdown1[1].Equals("Infrastructure") || breakdown1[1].Equals("WebHost"))
                            {
                                if (!collectiveValues[breakdown2].Contains(breakdown1[2]))
                                {
                                    List<string> vs = collectiveValues[breakdown2];
                                    vs.Add(breakdown1[2]);
                                    collectiveValues[breakdown2] = vs;
                                }
                            }
                            else
                            {
                                if (!collectiveValues[breakdown2].Contains(breakdown1[3]))
                                {
                                    List<string> vs = collectiveValues[breakdown2];
                                    vs.Add(breakdown1[3]);
                                    collectiveValues[breakdown2] = vs;
                                }
                            }
                        }
                        else
                        {
                            if (!collectiveValues[breakdown2].Contains(breakdown1[breakdown1.Length - 1]))
                            {
                                List<string> vs = collectiveValues[breakdown2];
                                if (!breakdown1[breakdown1.Length - 1].Equals("()"))
                                {
                                    vs.Add(breakdown1[breakdown1.Length - 1]);
                                    collectiveValues[breakdown2] = vs;
                                }

                            }
                        }
                    }

                }
            }


            Dictionary<string, decimal> collectiveValuess = new Dictionary<string, decimal>();
            foreach(string s in collectiveValues.Keys)
            {
                int count = 0;
                foreach(string so in collectiveValues[s])
                {
                    if (!collectiveValuess.ContainsKey(so))
                    {
                        foreach (string ss in collectiveValues.Keys)
                        {
                            List<string> vs = collectiveValues[ss];
                            foreach(string st in collectiveValue.Keys)
                            {
                                List<string> vt = collectiveValue[st];
                                if (vs.Contains(so) && vt.Contains(ss))
                                {
                                    count++;
                                }
                            }
                            


                        }

                        decimal decval = (count / collectiveValues.Keys.Count) * 100;
                        collectiveValuess.Add($"{s+"."+so}", decval);
                    }
                }
            }

            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
            {
                writeFile.WriteLine("{");
                writeFile.WriteLine("\"name\": \"Simpl Commerce\",");
                writeFile.WriteLine("\"entities\": [");
            }

            foreach(string name in collectiveValues.Keys)
            {
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
                {
                    writeFile.WriteLine("{");
                    writeFile.WriteLine($"\"name\": \"{name.Replace(".", "")}\"");
                    writeFile.WriteLine(",");
                    writeFile.WriteLine("\"nanoentities\": [");
                }
                foreach (string nanoE in collectiveValues[name])
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
                    {
                        writeFile.WriteLine($"\"{nanoE}\"");
                        writeFile.WriteLine(",");
                    }
                }
                var lines = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt");
                System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", lines.Take(lines.Length - 1).ToArray());
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
                {
                    

                    writeFile.WriteLine("]");
                    writeFile.WriteLine("}");
                    writeFile.WriteLine(",");
                }
                
            }
            var liness = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt");
            System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", liness.Take(liness.Length - 1).ToArray());
            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
            {
                writeFile.WriteLine("]");
                writeFile.WriteLine(",");
                writeFile.WriteLine("\"relations\": [");
            }

            foreach(string origin in collectiveValue.Keys)
            {
                foreach(string destination in collectiveValue[origin])
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
                    {
                        writeFile.WriteLine("{");
                        writeFile.WriteLine($"\"origin\": \"{origin.Replace(".","")}\",");
                        writeFile.WriteLine($"\"destination\": \"{destination.Replace(".","")}\",");
                        writeFile.WriteLine($"\"type\": \"AGGREGATION\"");
                        writeFile.WriteLine("}");
                        writeFile.WriteLine(",");
                    }
                }
                
            }
            var linesss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt");
            System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", linesss.Take(linesss.Length - 1).ToArray());

            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestModel.txt", true))
            {
                writeFile.WriteLine("]");
                writeFile.WriteLine("}");
            }

            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
            {
                writeFile.WriteLine("{");
                writeFile.WriteLine("\"useCases\": ");
                writeFile.WriteLine(" [");
            }

            foreach(string s in collectiveValue.Keys)
            {
                if (s.Split(".")[0].Equals("SimplCommerce"))
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine("{");
                    }
                    string[] name = s.Split(".");

                    if (name[1].Equals("Infrastructure")||name[1].Equals("WebHost"))
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                        {
                            writeFile.WriteLine($"\"name\": \"{name[name.Length - 1]}\",");
                        }
                    }
                    else
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                        {
                            writeFile.WriteLine($"\"name\": \"{name[name.Length - 1]}\",");
                        }
                    }
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"\"nanoentitiesRead\": [ ");
                    }
                    if (collectiveValues.ContainsKey(s))
                    {
                        foreach (string so in collectiveValues[s])
                        {
                            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                            {
                                writeFile.WriteLine($"\"{s.Replace(".", "") + "." + so}\"");
                                writeFile.WriteLine(",");
                            }
                        }
                    }
                    var linessss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
                    System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linessss.Take(linessss.Length - 1).ToArray());
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"]");
                        writeFile.WriteLine(",");
                    }

                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"\"nanoentitiesWritten\": [ ");
                    }

                    foreach (string ss in collectiveValue[s])
                    {
                        if (collectiveValues.ContainsKey(ss))
                        {
                            foreach (string so in collectiveValues[ss])
                            {
                                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                                {
                                    writeFile.WriteLine($"\"{ss.Replace(".", "") + "." + so}\"");
                                    writeFile.WriteLine(",");
                                }
                            }
                        }
                    }
                    var linesssss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
                    System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linesssss.Take(linesssss.Length - 1).ToArray());
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"]");
                    }

                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine("}");

                        writeFile.WriteLine(",");
                    }
                }
                else
                {
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine("{");
                    }
                    string[] name = s.Split(".");

                    if (name[name.Length - 1].Substring(name[name.Length - 1].Length - 10).Equals("Controller"))
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                        {
                            writeFile.WriteLine($"\"name\": \"{name[name.Length - 1].Substring(0, name[name.Length - 1].Length - 10)}\",");
                        }
                    }
                    else
                    {
                        using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                        {
                            writeFile.WriteLine($"\"name\": \"{name[name.Length - 1]}\",");
                        }
                    }
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"\"nanoentitiesRead\": [ ");
                    }
                    if (collectiveValues.ContainsKey(s))
                    {
                        foreach (string so in collectiveValues[s])
                        {
                            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                            {
                                writeFile.WriteLine($"\"{s.Replace(".", "") + "." + so}\"");
                                writeFile.WriteLine(",");
                            }
                        }
                    }
                    var linessss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
                    System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linessss.Take(linessss.Length - 1).ToArray());
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"]");
                        writeFile.WriteLine(",");
                    }

                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"\"nanoentitiesWritten\": [ ");
                    }

                    foreach (string ss in collectiveValue[s])
                    {
                        if (collectiveValues.ContainsKey(ss))
                        {
                            foreach (string so in collectiveValues[ss])
                            {
                                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                                {
                                    writeFile.WriteLine($"\"{ss.Replace(".", "") + "." + so}\"");
                                    writeFile.WriteLine(",");
                                }
                            }
                        }
                    }
                    var linesssss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
                    System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linesssss.Take(linesssss.Length - 1).ToArray());
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"]");
                    }

                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine("}");

                        writeFile.WriteLine(",");
                    }
                }
                
            }
            var linessssss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
            System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linessssss.Take(linessssss.Length - 1).ToArray());
            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
            {
                writeFile.WriteLine($"]");

                writeFile.WriteLine(",");
            }

            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
            {
                writeFile.WriteLine("\"compatibilities\": ");
                writeFile.WriteLine(" {");
                writeFile.WriteLine("\"structuralVolatility\": ");
                writeFile.WriteLine(" [");
                writeFile.WriteLine(" {");
                writeFile.WriteLine("\"characteristic\": \"Often\",");
                writeFile.WriteLine("\"nanoentities\": [");

            }

            foreach(string s in collectiveValuess.Keys)
            {
                if(collectiveValuess[s] >= 300)
                {
                    string[] breakdown = s.Split(".");

                    string breakdown0 = "";

                    for (int i = 0; i < breakdown.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            breakdown0 = breakdown[i];
                        }
                        else
                        {
                            breakdown0 = breakdown0 + "." + breakdown[i];
                        }
                    }
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
                    {
                        writeFile.WriteLine($"\"{breakdown0.Replace(".", "") +"."+s.Split(".")[s.Split(".").Length-1]}\"");
                        writeFile.WriteLine(",");
                    }
                }
            }
            var linesssssss = System.IO.File.ReadAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt");
            System.IO.File.WriteAllLines(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", linesssssss.Take(linesssssss.Length - 1).ToArray());



            using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter(@"C:\Users\fola-dami\source\repos\BreakdownConsole\BreakdownConsole\SimpleTestUserRep.txt", true))
            {
                writeFile.WriteLine($"]");
                writeFile.WriteLine("}");
                writeFile.WriteLine("]");
                writeFile.WriteLine("}");
                writeFile.WriteLine("}");
            }

            string values = "";

        }

    }
}
