public interface IOpticalDisc
{
    void SpinDisc();
    void ReadData();
    void WriteData(string key, string value);
}