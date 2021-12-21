using System;
interface IDiscrete
{

}

interface IIntegrated
{

}

interface IGraphicsCardFactory
{
    IIntegrated createIntegrated();
    IDiscrete createDiscrete();
}

