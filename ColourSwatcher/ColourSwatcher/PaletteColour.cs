using System.Windows.Media.Color;

public class PaletteColor 
{
	private Color color;
	private bool favorite;
	private PaletteColor (Color color)
	{
		this.color = color;
	}
	
	public static PaletteColor parse(string parse)
	{
		try 
		{
			if(parse.contains(","))
			{
				int R = 0;
				int G = 0; 
				int B = 0;

				parse.replace(" ","");
				parse.split(",");
				R = int.Parse(parse[0]);
				G = int.Parse(parse[1]);
				B = int.Parse(parse[2]);
				return new PaletteColor(Color.fromRGB(R, G, B));
			}
			else
			{
				Color color = (Color)ColorConverter.ConvertFromString(parse);
				return new PaletteColor(color);
			}
			
		}
		catch 
		{
			throw new Exception("Eorror");
		}
		
	}
	public void setFavorite (bool favorite)
	{
		this.favorite = favorite;
	}
	public bool isFavorite ()
	{
		return favorite;
	}
	public Color getColor ()
	{
		return color;
	}
}