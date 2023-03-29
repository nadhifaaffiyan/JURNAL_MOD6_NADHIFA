using System;
using System.Diagnostics;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo>
	public string title;

	public SayaTubeUser(string judul)
	{
		Random.random = new Random();
		this.id = random.Next(1, 99999);
		Debug.Assert(judul != null);
		Debug.Assert(judul.Length < 200);
		this.title = judul

		uploadedVideos = new List<SayaTubeVideo>();

		if(judul == null
		{
			Console.Error.WriteLine("Tidak Boleh Kosong")
		}
		if(judul length > 200)
		{
			Console.Error.WriteLine("Tidak Boleh Kosong")
		}
	}

	public int GetTotalVideoDetails()
	{
		return uploadVideo.Count;
	}

	public void AddVideo(SayaTubeVideo video)
	{
		Debug.Assert(video != null);
		Debug.Assert(video.GetPlayCount);

		uploadedVideos.Add(video);

	}
	public void PrintAllVideoPlayCount()
	{
		for (int i = 0; i < uploadedVideos.Count; i++)
		{
			Console.WriteLine("video:" + (i + 1) + uploadedVideos[i].GetPlayCount);
		}
	}
}
