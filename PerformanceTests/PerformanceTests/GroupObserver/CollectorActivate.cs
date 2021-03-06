using Entitas;

public class CollectorActivate : IPerformanceTest {

    const int n = 10000;
    Collector _collector;

    public void Before() {
        var context = Helper.CreateContext();
        var group = context.GetGroup(Matcher.AllOf(new [] { CP.ComponentA }));
        _collector = group.CreateCollector();
    }

    public void Run() {
        for(int i = 0; i < n; i++) {
            _collector.Activate();
        }
    }
}
