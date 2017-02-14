﻿using FatturaElettronica.FatturaElettronicaHeader.CedentePrestatore;
using FatturaElettronica.Tabelle;
using FluentValidation;

namespace FatturaElettronica.Validators
{
    public class IscrizioneREAValidator : AbstractValidator<IscrizioneREA>
    {
        public IscrizioneREAValidator()
        {
            RuleFor(x => x.Ufficio).NotEmpty().SetValidator(new IsValidValidator<Provincia>());
            RuleFor(x => x.NumeroREA).NotEmpty().Length(1, 20);
            RuleFor(x => x.SocioUnico).SetValidator(new IsValidValidator<SocioUnico>()).Unless(x => string.IsNullOrEmpty(x.SocioUnico));
            RuleFor(x => x.StatoLiquidazione).SetValidator(new IsValidValidator<StatoLiquidazione>());
        }
    }
}
