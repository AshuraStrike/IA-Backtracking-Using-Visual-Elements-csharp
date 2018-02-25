using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IA_Backtracking_Using_Visual_Elements
{
    public class Reader
    {
        String route;
        StreamReader reader;

        public Reader()
        {
            route = "-1";
        }

        public Reader(String routeIn)
        {
            route = routeIn;
        }

        // Gets a map reference and fills it with data
        public bool fillMap(ref Map map)
        {
            // Return variable, if true read successful
            bool success = true;
            try
            {
                // Opens file stream
                reader = new StreamReader(route);

                // Inits regular expression for character validations
                Regex regex = new Regex(@"^(,?[0-9])+$",RegexOptions.Singleline);

                // Inits row number
                int columnNumber = 1;

                // Reads first line
                string lineToParse = reader.ReadLine();

                // Value buffer
                string tempValue;

                // Checks first line
                if (regex.IsMatch(lineToParse)) {
                    // Sets column number
                    for (int i = 0; i < lineToParse.Length; i++)
                    {
                        if (lineToParse[i]==',')
                        {
                            columnNumber++;
                        }
                    }

                    // Goes back to file's beginning
                    reader.DiscardBufferedData();
                    reader.BaseStream.Seek(0,System.IO.SeekOrigin.Begin);

                    // Read file's lines
                    do
                    {
                        // Gets a line to parse
                        lineToParse = reader.ReadLine();
                        // Buffer epties
                        tempValue = "";
                        // New empty row
                        List<Cell> row = new List<Cell>();
                        // Check regex matching
                        if (regex.IsMatch(lineToParse))
                        {
                            // Get numeric values from string
                            for (int i = 0; i < lineToParse.Length; i++)
                            {
                                // if it finds a comma
                                if (lineToParse[i].Equals(','))
                                {
                                    // Uses buffer for adding a new Cell to row
                                    row.Add(new Cell(int.Parse(tempValue)));
                                    tempValue = "";
                                }
                                else
                                {
                                    // Adds digit to buffer
                                    tempValue += lineToParse[i];
                                }
                            }

                            // Adds last buffer value to row
                            row.Add(new Cell(int.Parse(tempValue)));

                            // If row has a different number of columns or more than 15
                            if (row.Count != columnNumber || row.Count > 15)
                            {
                                // Fails and breaks loop
                                System.Diagnostics.Debug.WriteLine("No. of columns un-even or more than 15");
                                success = false;
                                break;
                            }
                            else
                            {
                                // Ads row to map
                                map.Add(row);
                                // Checks rows are less than 15
                                if (map.Count > 15){
                                    System.Diagnostics.Debug.WriteLine("Row number more than 15");
                                    success = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            // Sets failure
                            success = false;
                        }
                    // While file isn't over
                    }while (!reader.EndOfStream);
                    // File closes
                    reader.Close();
                }
                else
                {
                    // Sets failure
                    success = false;
                }

            }
            // Catches file not found exception
            catch (FileNotFoundException exeption)
            {
                // Prints exception on console and sets failure
                System.Diagnostics.Debug.WriteLine(exeption);
                success = false;
            }
            // Returns success variable
            return success;
        }
    }
}
