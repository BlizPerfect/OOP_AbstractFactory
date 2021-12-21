using System;

class MSIFactory : IGraphicsCardFactory
{
    public IDiscrete createDiscrete()
    {
        return new MSIDiscrete();
    }

    public IIntegrated createIntegrated()
    {
        return new MSIIntegrated();
    }
}

class GIGABYTEFactory : IGraphicsCardFactory
{
    public IDiscrete createDiscrete()
    {
        return new GIGABYTEDiscrete();
    }

    public IIntegrated createIntegrated()
    {
        return new GIGABYTEIntegrated();
    }
}

class ASUSFactory : IGraphicsCardFactory
{
    public IDiscrete createDiscrete()
    {
        return new ASUSDiscrete();
    }

    public IIntegrated createIntegrated()
    {
        return new ASUSIntegrated();
    }
}

class PALITFactory : IGraphicsCardFactory
{
    public IDiscrete createDiscrete()
    {
        return new PALITDiscrete();
    }

    public IIntegrated createIntegrated()
    {
        return new PALITIntegrated();
    }
}


