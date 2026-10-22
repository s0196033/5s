namespace Pi31_2_Dyadchenko_Kite.NeuroNet
{
    internal class OutputLayer : Layer
    {
        public OutputLayer(int non, int nopn, NeuronType nt, string type) : base(non, nopn, nt, type) {}

        public override void Recognize(Network net, Layer nextLayer)
        {

        }
    }
}
