// See https://aka.ms/new-console-template for more information
Tracker.Instance.Init(1806546515486);

bool loop = true;
while (loop)
{
    Tracker.Instance.Update();
    ConsoleKeyInfo info = Console.ReadKey(true);
    if (info.Key == ConsoleKey.Escape)
        loop = false;
}
Tracker.Instance.Release();

