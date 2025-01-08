﻿namespace CashFlow.Exception.ExcepetionBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Errors { get; set; }

    public ErrorOnValidationException(List<string> errorMessage)
    {
        Errors = errorMessage;
    }
}