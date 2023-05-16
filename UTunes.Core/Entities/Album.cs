using System;
namespace UTunes.Core.Entities
{
	public class Album
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Artist { get; set; }

		public string Review { get; set; }

		public ICollection<Song> Songs { get; set; }

		public int PriceAlbum { get; set; }

		public int Rating { get; set; }

		public int TotalVotes { get; set; }
	}
}

