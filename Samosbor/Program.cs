using Samosbor;
using Samosbor.Rooms;
using Buffer = Samosbor.Buffer;

char[,] field = new char[,] { 
	{'.', ',' } ,
{'.', ',' } ,
{'.', '!' } };


var room = new Room(new RoomGenerator());



var game = new Game(room.RoomBuffer);
game.Run();

/*while (true)
{
    await WriteField(Field);
}
async Task WriteField (char[,] field)
{
	var sb = new StringBuilder();
	for (int i = 0; i < field.GetLength(0); i++)
	{
		for (int j = 0; j < field.GetLength(1); j++)
		{
			sb.Append(field[i, j]);
			//Console.Write(field[i, j]);
		}
			sb.Append('\n');
		//Console.Write("\n");
	}
	Console.Clear();
	Console.WriteLine(sb.ToString());
	Thread.Sleep(1000);
}*/




