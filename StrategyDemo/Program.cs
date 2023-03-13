using StrategyDemo;

var chainTasks = new Log().Append(new Transaction()).Append(new Add(15));

chainTasks.Append(new Transaction()).Append(new Add(32));
chainTasks.Do(5);
