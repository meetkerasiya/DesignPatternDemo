
using ChainOfRespnsibilityDemo;

RequestHandler rh1 = new Handler();
RequestHandler rh2 = new BiggerHandler();
RequestHandler rh3 = new BiggestHandler();

rh1.SetSuccessor(rh2);
rh2.SetSuccessor(rh3);

int[] requests = { 12, 8, 6, 22, 18, 44, 35 };

foreach(int request in requests)
{
    rh1.HandleRequest(request);
}