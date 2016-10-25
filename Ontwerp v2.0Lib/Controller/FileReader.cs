using Goudkoorts.Model;
using Model;
using Ontwerp_v2._0Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontwerp_v2._0Lib.Controller
{
    class FileReader
    {

        public Board OpenFile()
        {
            Board board = new Board();
            Dictionary<string, Field> fields = new Dictionary<string, Field>();
            StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + "/board_layout.txt");
            string line;
            int y = 0;
            Field currentField;
            
            while ((line = file.ReadLine()) != null)
            {
                char[] chars = line.ToCharArray();

                for (int x = 0; x < line.Length; x++)
                {
                    switch (chars[x])
                    {
                        case '^':
                            fields[x + "," + y] = new Track(Direction.UP);
                            break;
                        case '>':
                            fields[x + "," + y] = new Track(Direction.RIGHT);
                            break;
                        case 'V':
                            fields[x + "," + y] = new Track(Direction.DOWN);
                            break;
                        case '<':
                            fields[x + "," + y] = new Track(Direction.LEFT);
                            break;
                        case '~':
                            fields[x + "," + y] = new SeaRoute();
                            break;
                        case 'B':
                            fields[x + "," + y] = new SeaRoute();
                            //TODO set movableobject
                            break;
                        case 'D':
                            fields[x + "," + y] = new EndTrack();
                            break;
                        case 'F':
                            fields[x + "," + y] = new EndTrack();
                            break;
                        case '.':
                            fields[x + "," + y] = new EmptyField();
                            break;
                        case 'W':
                            fields[x + "," + y] = new Warehouse();
                            break;
                        case 'S':
                            fields[x + "," + y] = new SwitchTrack();
                            break;
                        case '┐':
                            fields[x + "," + y] = new CurvedTrack(Direction.DOWN, Direction.LEFT);
                            break;
                        case '┌':
                            fields[x + "," + y] = new CurvedTrack(Direction.DOWN, Direction.RIGHT);
                            break;
                        case '┘':
                            fields[x + "," + y] = new CurvedTrack(Direction.UP, Direction.LEFT);
                            break;
                        case '└':
                            fields[x + "," + y] = new CurvedTrack(Direction.UP, Direction.RIGHT);
                            break;
                        case 'Y':
                            fields[x + "," + y] = new YardTrack();
                            break;
                        default:
                            throw new InvalidDataException("The char '" + chars[x] + "' is unknown by the FileReader.");
                    }
                }

                y++;
            }

            file.Close();

            for (y = 0; ; y++)
            {
                for (int x = 0; ; x++)
                {
                    if (fields[x + "," + y] == null)
                        break;

                    if (x == 0 && y == 0)
                    {
                        board.OriginField = fields[x + "," + y];
                        continue;
                    }
                }
            }

            return board;
        }
    }
}
