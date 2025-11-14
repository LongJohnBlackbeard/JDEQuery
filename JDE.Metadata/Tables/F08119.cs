using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08119 - .
/// </summary>
public class F08119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGACAR.
        /// </summary>
        public const string AGACAR = "AGACAR";

        /// <summary>
        /// AGRPYR.
        /// </summary>
        public const string AGRPYR = "AGRPYR";

        /// <summary>
        /// AGTAXX.
        /// </summary>
        public const string AGTAXX = "AGTAXX";

        /// <summary>
        /// AGAN8.
        /// </summary>
        public const string AGAN8 = "AGAN8";

        /// <summary>
        /// AGRCK5.
        /// </summary>
        public const string AGRCK5 = "AGRCK5";

        /// <summary>
        /// AGHMCO.
        /// </summary>
        public const string AGHMCO = "AGHMCO";

        /// <summary>
        /// AGPLAN.
        /// </summary>
        public const string AGPLAN = "AGPLAN";

        /// <summary>
        /// AGAOPT.
        /// </summary>
        public const string AGAOPT = "AGAOPT";

        /// <summary>
        /// AGPDBA.
        /// </summary>
        public const string AGPDBA = "AGPDBA";

        /// <summary>
        /// AGUN.
        /// </summary>
        public const string AGUN = "AGUN";

        /// <summary>
        /// AGADE.
        /// </summary>
        public const string AGADE = "AGADE";

        /// <summary>
        /// AGEFTE.
        /// </summary>
        public const string AGEFTE = "AGEFTE";

        /// <summary>
        /// AGARCC.
        /// </summary>
        public const string AGARCC = "AGARCC";

        /// <summary>
        /// AGSRED.
        /// </summary>
        public const string AGSRED = "AGSRED";

        /// <summary>
        /// AGPRRF.
        /// </summary>
        public const string AGPRRF = "AGPRRF";

        /// <summary>
        /// AGAIRI.
        /// </summary>
        public const string AGAIRI = "AGAIRI";

        /// <summary>
        /// AGUKID.
        /// </summary>
        public const string AGUKID = "AGUKID";

        /// <summary>
        /// AGRECP.
        /// </summary>
        public const string AGRECP = "AGRECP";

        /// <summary>
        /// AGGNNM.
        /// </summary>
        public const string AGGNNM = "AGGNNM";

        /// <summary>
        /// AGMDNM.
        /// </summary>
        public const string AGMDNM = "AGMDNM";

        /// <summary>
        /// AGSRNM.
        /// </summary>
        public const string AGSRNM = "AGSRNM";

        /// <summary>
        /// AGSSN.
        /// </summary>
        public const string AGSSN = "AGSSN";

        /// <summary>
        /// AGDST.
        /// </summary>
        public const string AGDST = "AGDST";

        /// <summary>
        /// AGDT.
        /// </summary>
        public const string AGDT = "AGDT";

        /// <summary>
        /// AGARCI.
        /// </summary>
        public const string AGARCI = "AGARCI";

        /// <summary>
        /// AGBORC.
        /// </summary>
        public const string AGBORC = "AGBORC";

        /// <summary>
        /// AGARVD.
        /// </summary>
        public const string AGARVD = "AGARVD";

        /// <summary>
        /// AGEPSC.
        /// </summary>
        public const string AGEPSC = "AGEPSC";

        /// <summary>
        /// AGPSMO.
        /// </summary>
        public const string AGPSMO = "AGPSMO";

        /// <summary>
        /// AGLF00.
        /// </summary>
        public const string AGLF00 = "AGLF00";

        /// <summary>
        /// AGLF01.
        /// </summary>
        public const string AGLF01 = "AGLF01";

        /// <summary>
        /// AGLF02.
        /// </summary>
        public const string AGLF02 = "AGLF02";

        /// <summary>
        /// AGLF03.
        /// </summary>
        public const string AGLF03 = "AGLF03";

        /// <summary>
        /// AGLF04.
        /// </summary>
        public const string AGLF04 = "AGLF04";

        /// <summary>
        /// AGLF05.
        /// </summary>
        public const string AGLF05 = "AGLF05";

        /// <summary>
        /// AGLF06.
        /// </summary>
        public const string AGLF06 = "AGLF06";

        /// <summary>
        /// AGLF07.
        /// </summary>
        public const string AGLF07 = "AGLF07";

        /// <summary>
        /// AGLF08.
        /// </summary>
        public const string AGLF08 = "AGLF08";

        /// <summary>
        /// AGLF09.
        /// </summary>
        public const string AGLF09 = "AGLF09";

        /// <summary>
        /// AGLF10.
        /// </summary>
        public const string AGLF10 = "AGLF10";

        /// <summary>
        /// AGLF11.
        /// </summary>
        public const string AGLF11 = "AGLF11";

        /// <summary>
        /// AGLF12.
        /// </summary>
        public const string AGLF12 = "AGLF12";

        /// <summary>
        /// AGMV00.
        /// </summary>
        public const string AGMV00 = "AGMV00";

        /// <summary>
        /// AGMV01.
        /// </summary>
        public const string AGMV01 = "AGMV01";

        /// <summary>
        /// AGMV02.
        /// </summary>
        public const string AGMV02 = "AGMV02";

        /// <summary>
        /// AGMV03.
        /// </summary>
        public const string AGMV03 = "AGMV03";

        /// <summary>
        /// AGMV04.
        /// </summary>
        public const string AGMV04 = "AGMV04";

        /// <summary>
        /// AGMV05.
        /// </summary>
        public const string AGMV05 = "AGMV05";

        /// <summary>
        /// AGMV06.
        /// </summary>
        public const string AGMV06 = "AGMV06";

        /// <summary>
        /// AGMV07.
        /// </summary>
        public const string AGMV07 = "AGMV07";

        /// <summary>
        /// AGMV08.
        /// </summary>
        public const string AGMV08 = "AGMV08";

        /// <summary>
        /// AGMV09.
        /// </summary>
        public const string AGMV09 = "AGMV09";

        /// <summary>
        /// AGMV10.
        /// </summary>
        public const string AGMV10 = "AGMV10";

        /// <summary>
        /// AGMV11.
        /// </summary>
        public const string AGMV11 = "AGMV11";

        /// <summary>
        /// AGMV12.
        /// </summary>
        public const string AGMV12 = "AGMV12";

        /// <summary>
        /// AGHB00.
        /// </summary>
        public const string AGHB00 = "AGHB00";

        /// <summary>
        /// AGHB01.
        /// </summary>
        public const string AGHB01 = "AGHB01";

        /// <summary>
        /// AGHB02.
        /// </summary>
        public const string AGHB02 = "AGHB02";

        /// <summary>
        /// AGHB03.
        /// </summary>
        public const string AGHB03 = "AGHB03";

        /// <summary>
        /// AGHB04.
        /// </summary>
        public const string AGHB04 = "AGHB04";

        /// <summary>
        /// AGHB05.
        /// </summary>
        public const string AGHB05 = "AGHB05";

        /// <summary>
        /// AGHB06.
        /// </summary>
        public const string AGHB06 = "AGHB06";

        /// <summary>
        /// AGHB07.
        /// </summary>
        public const string AGHB07 = "AGHB07";

        /// <summary>
        /// AGHB08.
        /// </summary>
        public const string AGHB08 = "AGHB08";

        /// <summary>
        /// AGHB09.
        /// </summary>
        public const string AGHB09 = "AGHB09";

        /// <summary>
        /// AGHB10.
        /// </summary>
        public const string AGHB10 = "AGHB10";

        /// <summary>
        /// AGHB11.
        /// </summary>
        public const string AGHB11 = "AGHB11";

        /// <summary>
        /// AGHB12.
        /// </summary>
        public const string AGHB12 = "AGHB12";

        /// <summary>
        /// AGZP00.
        /// </summary>
        public const string AGZP00 = "AGZP00";

        /// <summary>
        /// AGZP01.
        /// </summary>
        public const string AGZP01 = "AGZP01";

        /// <summary>
        /// AGZP02.
        /// </summary>
        public const string AGZP02 = "AGZP02";

        /// <summary>
        /// AGZP03.
        /// </summary>
        public const string AGZP03 = "AGZP03";

        /// <summary>
        /// AGZP04.
        /// </summary>
        public const string AGZP04 = "AGZP04";

        /// <summary>
        /// AGZP05.
        /// </summary>
        public const string AGZP05 = "AGZP05";

        /// <summary>
        /// AGZP06.
        /// </summary>
        public const string AGZP06 = "AGZP06";

        /// <summary>
        /// AGZP07.
        /// </summary>
        public const string AGZP07 = "AGZP07";

        /// <summary>
        /// AGZP08.
        /// </summary>
        public const string AGZP08 = "AGZP08";

        /// <summary>
        /// AGZP09.
        /// </summary>
        public const string AGZP09 = "AGZP09";

        /// <summary>
        /// AGZP10.
        /// </summary>
        public const string AGZP10 = "AGZP10";

        /// <summary>
        /// AGZP11.
        /// </summary>
        public const string AGZP11 = "AGZP11";

        /// <summary>
        /// AGZP12.
        /// </summary>
        public const string AGZP12 = "AGZP12";

        /// <summary>
        /// AGSPASUSH1.
        /// </summary>
        public const string AGSPASUSH1 = "AGSPASUSH1";

        /// <summary>
        /// AGSPASUSH2.
        /// </summary>
        public const string AGSPASUSH2 = "AGSPASUSH2";

        /// <summary>
        /// AGSPASUSH3.
        /// </summary>
        public const string AGSPASUSH3 = "AGSPASUSH3";

        /// <summary>
        /// AGSPASUSH4.
        /// </summary>
        public const string AGSPASUSH4 = "AGSPASUSH4";

        /// <summary>
        /// AGSPASUSH5.
        /// </summary>
        public const string AGSPASUSH5 = "AGSPASUSH5";

        /// <summary>
        /// AGSPASUSH6.
        /// </summary>
        public const string AGSPASUSH6 = "AGSPASUSH6";

        /// <summary>
        /// AGSPASUSH7.
        /// </summary>
        public const string AGSPASUSH7 = "AGSPASUSH7";

        /// <summary>
        /// AGSPASUSH8.
        /// </summary>
        public const string AGSPASUSH8 = "AGSPASUSH8";

        /// <summary>
        /// AGSPANUSH1.
        /// </summary>
        public const string AGSPANUSH1 = "AGSPANUSH1";

        /// <summary>
        /// AGSPANUSH2.
        /// </summary>
        public const string AGSPANUSH2 = "AGSPANUSH2";

        /// <summary>
        /// AGSPANUSH3.
        /// </summary>
        public const string AGSPANUSH3 = "AGSPANUSH3";

        /// <summary>
        /// AGSPANUSH4.
        /// </summary>
        public const string AGSPANUSH4 = "AGSPANUSH4";

        /// <summary>
        /// AGSPADUSH1.
        /// </summary>
        public const string AGSPADUSH1 = "AGSPADUSH1";

        /// <summary>
        /// AGSPADUSH2.
        /// </summary>
        public const string AGSPADUSH2 = "AGSPADUSH2";

        /// <summary>
        /// AGSPADUSH3.
        /// </summary>
        public const string AGSPADUSH3 = "AGSPADUSH3";

        /// <summary>
        /// AGSPADUSH4.
        /// </summary>
        public const string AGSPADUSH4 = "AGSPADUSH4";

        /// <summary>
        /// AGSPACUSH1.
        /// </summary>
        public const string AGSPACUSH1 = "AGSPACUSH1";

        /// <summary>
        /// AGSPACUSH2.
        /// </summary>
        public const string AGSPACUSH2 = "AGSPACUSH2";

        /// <summary>
        /// AGSPACUSH3.
        /// </summary>
        public const string AGSPACUSH3 = "AGSPACUSH3";

        /// <summary>
        /// AGSPACUSH4.
        /// </summary>
        public const string AGSPACUSH4 = "AGSPACUSH4";

        /// <summary>
        /// AGBTPG.
        /// </summary>
        public const string AGBTPG = "AGBTPG";

        /// <summary>
        /// AGBTVR.
        /// </summary>
        public const string AGBTVR = "AGBTVR";

        /// <summary>
        /// AGRVST.
        /// </summary>
        public const string AGRVST = "AGRVST";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGACAR", "AGACAR", JdeDataType.String, 2, true, true),
        new JdeField("AGRPYR", "AGRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AGTAXX", "AGTAXX", JdeDataType.String, 40, true, true),
        new JdeField("AGAN8", "AGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AGRCK5", "AGRCK5", JdeDataType.Numeric, null, true, true),
        new JdeField("AGHMCO", "AGHMCO", JdeDataType.String, 10, true, true),
        new JdeField("AGPLAN", "AGPLAN", JdeDataType.String, 16, true, true),
        new JdeField("AGAOPT", "AGAOPT", JdeDataType.String, 6, true, true),
        new JdeField("AGPDBA", "AGPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("AGUN", "AGUN", JdeDataType.String, 12, true, true),
        new JdeField("AGADE", "AGADE", JdeDataType.Numeric, null, true, true),
        new JdeField("AGEFTE", "AGEFTE", JdeDataType.Numeric),
        new JdeField("AGARCC", "AGARCC", JdeDataType.String, 2),
        new JdeField("AGSRED", "AGSRED", JdeDataType.String, 4),
        new JdeField("AGPRRF", "AGPRRF", JdeDataType.String, 2),
        new JdeField("AGAIRI", "AGAIRI", JdeDataType.String, 20),
        new JdeField("AGUKID", "AGUKID", JdeDataType.Numeric),
        new JdeField("AGRECP", "AGRECP", JdeDataType.String, 10),
        new JdeField("AGGNNM", "AGGNNM", JdeDataType.String, 50),
        new JdeField("AGMDNM", "AGMDNM", JdeDataType.String, 50),
        new JdeField("AGSRNM", "AGSRNM", JdeDataType.String, 50),
        new JdeField("AGSSN", "AGSSN", JdeDataType.String, 40),
        new JdeField("AGDST", "AGDST", JdeDataType.Numeric),
        new JdeField("AGDT", "AGDT", JdeDataType.Numeric),
        new JdeField("AGARCI", "AGARCI", JdeDataType.Numeric),
        new JdeField("AGBORC", "AGBORC", JdeDataType.Numeric),
        new JdeField("AGARVD", "AGARVD", JdeDataType.String, 2),
        new JdeField("AGEPSC", "AGEPSC", JdeDataType.String, 2),
        new JdeField("AGPSMO", "AGPSMO", JdeDataType.Numeric),
        new JdeField("AGLF00", "AGLF00", JdeDataType.String, 8),
        new JdeField("AGLF01", "AGLF01", JdeDataType.String, 8),
        new JdeField("AGLF02", "AGLF02", JdeDataType.String, 8),
        new JdeField("AGLF03", "AGLF03", JdeDataType.String, 8),
        new JdeField("AGLF04", "AGLF04", JdeDataType.String, 8),
        new JdeField("AGLF05", "AGLF05", JdeDataType.String, 8),
        new JdeField("AGLF06", "AGLF06", JdeDataType.String, 8),
        new JdeField("AGLF07", "AGLF07", JdeDataType.String, 8),
        new JdeField("AGLF08", "AGLF08", JdeDataType.String, 8),
        new JdeField("AGLF09", "AGLF09", JdeDataType.String, 8),
        new JdeField("AGLF10", "AGLF10", JdeDataType.String, 8),
        new JdeField("AGLF11", "AGLF11", JdeDataType.String, 8),
        new JdeField("AGLF12", "AGLF12", JdeDataType.String, 8),
        new JdeField("AGMV00", "AGMV00", JdeDataType.Numeric),
        new JdeField("AGMV01", "AGMV01", JdeDataType.Numeric),
        new JdeField("AGMV02", "AGMV02", JdeDataType.Numeric),
        new JdeField("AGMV03", "AGMV03", JdeDataType.Numeric),
        new JdeField("AGMV04", "AGMV04", JdeDataType.Numeric),
        new JdeField("AGMV05", "AGMV05", JdeDataType.Numeric),
        new JdeField("AGMV06", "AGMV06", JdeDataType.Numeric),
        new JdeField("AGMV07", "AGMV07", JdeDataType.Numeric),
        new JdeField("AGMV08", "AGMV08", JdeDataType.Numeric),
        new JdeField("AGMV09", "AGMV09", JdeDataType.Numeric),
        new JdeField("AGMV10", "AGMV10", JdeDataType.Numeric),
        new JdeField("AGMV11", "AGMV11", JdeDataType.Numeric),
        new JdeField("AGMV12", "AGMV12", JdeDataType.Numeric),
        new JdeField("AGHB00", "AGHB00", JdeDataType.String, 8),
        new JdeField("AGHB01", "AGHB01", JdeDataType.String, 8),
        new JdeField("AGHB02", "AGHB02", JdeDataType.String, 8),
        new JdeField("AGHB03", "AGHB03", JdeDataType.String, 8),
        new JdeField("AGHB04", "AGHB04", JdeDataType.String, 8),
        new JdeField("AGHB05", "AGHB05", JdeDataType.String, 8),
        new JdeField("AGHB06", "AGHB06", JdeDataType.String, 8),
        new JdeField("AGHB07", "AGHB07", JdeDataType.String, 8),
        new JdeField("AGHB08", "AGHB08", JdeDataType.String, 8),
        new JdeField("AGHB09", "AGHB09", JdeDataType.String, 8),
        new JdeField("AGHB10", "AGHB10", JdeDataType.String, 8),
        new JdeField("AGHB11", "AGHB11", JdeDataType.String, 8),
        new JdeField("AGHB12", "AGHB12", JdeDataType.String, 8),
        new JdeField("AGZP00", "AGZP00", JdeDataType.String, 24),
        new JdeField("AGZP01", "AGZP01", JdeDataType.String, 24),
        new JdeField("AGZP02", "AGZP02", JdeDataType.String, 24),
        new JdeField("AGZP03", "AGZP03", JdeDataType.String, 24),
        new JdeField("AGZP04", "AGZP04", JdeDataType.String, 24),
        new JdeField("AGZP05", "AGZP05", JdeDataType.String, 24),
        new JdeField("AGZP06", "AGZP06", JdeDataType.String, 24),
        new JdeField("AGZP07", "AGZP07", JdeDataType.String, 24),
        new JdeField("AGZP08", "AGZP08", JdeDataType.String, 24),
        new JdeField("AGZP09", "AGZP09", JdeDataType.String, 24),
        new JdeField("AGZP10", "AGZP10", JdeDataType.String, 24),
        new JdeField("AGZP11", "AGZP11", JdeDataType.String, 24),
        new JdeField("AGZP12", "AGZP12", JdeDataType.String, 24),
        new JdeField("AGSPASUSH1", "AGSPASUSH1", JdeDataType.String, 60),
        new JdeField("AGSPASUSH2", "AGSPASUSH2", JdeDataType.String, 60),
        new JdeField("AGSPASUSH3", "AGSPASUSH3", JdeDataType.String, 60),
        new JdeField("AGSPASUSH4", "AGSPASUSH4", JdeDataType.String, 60),
        new JdeField("AGSPASUSH5", "AGSPASUSH5", JdeDataType.String, 20),
        new JdeField("AGSPASUSH6", "AGSPASUSH6", JdeDataType.String, 20),
        new JdeField("AGSPASUSH7", "AGSPASUSH7", JdeDataType.String, 20),
        new JdeField("AGSPASUSH8", "AGSPASUSH8", JdeDataType.String, 20),
        new JdeField("AGSPANUSH1", "AGSPANUSH1", JdeDataType.Numeric),
        new JdeField("AGSPANUSH2", "AGSPANUSH2", JdeDataType.Numeric),
        new JdeField("AGSPANUSH3", "AGSPANUSH3", JdeDataType.Numeric),
        new JdeField("AGSPANUSH4", "AGSPANUSH4", JdeDataType.Numeric),
        new JdeField("AGSPADUSH1", "AGSPADUSH1", JdeDataType.Numeric),
        new JdeField("AGSPADUSH2", "AGSPADUSH2", JdeDataType.Numeric),
        new JdeField("AGSPADUSH3", "AGSPADUSH3", JdeDataType.Numeric),
        new JdeField("AGSPADUSH4", "AGSPADUSH4", JdeDataType.Numeric),
        new JdeField("AGSPACUSH1", "AGSPACUSH1", JdeDataType.String, 2),
        new JdeField("AGSPACUSH2", "AGSPACUSH2", JdeDataType.String, 2),
        new JdeField("AGSPACUSH3", "AGSPACUSH3", JdeDataType.String, 2),
        new JdeField("AGSPACUSH4", "AGSPACUSH4", JdeDataType.String, 2),
        new JdeField("AGBTPG", "AGBTPG", JdeDataType.String, 20),
        new JdeField("AGBTVR", "AGBTVR", JdeDataType.String, 20),
        new JdeField("AGRVST", "AGRVST", JdeDataType.String, 6),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08119_0", "Primary Key on AGACAR, AGRPYR, AGTAXX, AGAN8, AGRCK5, AGHMCO, AGPLAN, AGAOPT, AGPDBA, AGUN, AGADE", new[] { "AGACAR", "AGRPYR", "AGTAXX", "AGAN8", "AGRCK5", "AGHMCO", "AGPLAN", "AGAOPT", "AGPDBA", "AGUN", "AGADE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08119_2", "Index on AGRPYR, AGAN8", new[] { "AGRPYR", "AGAN8" }),
        new JdeIndex("F08119_3", "Index on AGUKID", new[] { "AGUKID" })
    };
}
