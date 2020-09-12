using System;

public class TodayWriter : IDataWriter
{
    private IOutput _output;

    public TodayWriter(IOutput output) {
        _output = output;
    }

    public void writeDate()
    {
        _output.write(DateTime.Today.ToShortDateString());
    }
}