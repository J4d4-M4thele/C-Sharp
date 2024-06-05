namespace Packt.Shared;

internal class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("DVD player has paused the music.");
    }

    public void Play()
    {
        WriteLine("DVD player is playing music.");
    }
}
