using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211DT - .
/// </summary>
public class F4211DT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDOCO.
        /// </summary>
        public const string DTDOCO = "DTDOCO";

        /// <summary>
        /// DTDCTO.
        /// </summary>
        public const string DTDCTO = "DTDCTO";

        /// <summary>
        /// DTKCOO.
        /// </summary>
        public const string DTKCOO = "DTKCOO";

        /// <summary>
        /// DTLNID.
        /// </summary>
        public const string DTLNID = "DTLNID";

        /// <summary>
        /// DTLNTY.
        /// </summary>
        public const string DTLNTY = "DTLNTY";

        /// <summary>
        /// DTMCU.
        /// </summary>
        public const string DTMCU = "DTMCU";

        /// <summary>
        /// DTAN8.
        /// </summary>
        public const string DTAN8 = "DTAN8";

        /// <summary>
        /// DTSHAN.
        /// </summary>
        public const string DTSHAN = "DTSHAN";

        /// <summary>
        /// DTVR01.
        /// </summary>
        public const string DTVR01 = "DTVR01";

        /// <summary>
        /// DTCMC1.
        /// </summary>
        public const string DTCMC1 = "DTCMC1";

        /// <summary>
        /// DTCMC2.
        /// </summary>
        public const string DTCMC2 = "DTCMC2";

        /// <summary>
        /// DTITM.
        /// </summary>
        public const string DTITM = "DTITM";

        /// <summary>
        /// DTLITM.
        /// </summary>
        public const string DTLITM = "DTLITM";

        /// <summary>
        /// DTAITM.
        /// </summary>
        public const string DTAITM = "DTAITM";

        /// <summary>
        /// DTLOTN.
        /// </summary>
        public const string DTLOTN = "DTLOTN";

        /// <summary>
        /// DTUOM1.
        /// </summary>
        public const string DTUOM1 = "DTUOM1";

        /// <summary>
        /// DTTRDJ.
        /// </summary>
        public const string DTTRDJ = "DTTRDJ";

        /// <summary>
        /// DTPQOR.
        /// </summary>
        public const string DTPQOR = "DTPQOR";

        /// <summary>
        /// DTAEXP.
        /// </summary>
        public const string DTAEXP = "DTAEXP";

        /// <summary>
        /// DTDRQJ.
        /// </summary>
        public const string DTDRQJ = "DTDRQJ";

        /// <summary>
        /// DTODRJ.
        /// </summary>
        public const string DTODRJ = "DTODRJ";

        /// <summary>
        /// DTRSDJ.
        /// </summary>
        public const string DTRSDJ = "DTRSDJ";

        /// <summary>
        /// DTOPDJ.
        /// </summary>
        public const string DTOPDJ = "DTOPDJ";

        /// <summary>
        /// DTPDDJ.
        /// </summary>
        public const string DTPDDJ = "DTPDDJ";

        /// <summary>
        /// DTADDJ.
        /// </summary>
        public const string DTADDJ = "DTADDJ";

        /// <summary>
        /// DTSOQS.
        /// </summary>
        public const string DTSOQS = "DTSOQS";

        /// <summary>
        /// DTSHAE.
        /// </summary>
        public const string DTSHAE = "DTSHAE";

        /// <summary>
        /// DTCNDJ.
        /// </summary>
        public const string DTCNDJ = "DTCNDJ";

        /// <summary>
        /// DTSOCN.
        /// </summary>
        public const string DTSOCN = "DTSOCN";

        /// <summary>
        /// DTCNAE.
        /// </summary>
        public const string DTCNAE = "DTCNAE";

        /// <summary>
        /// DTIVD.
        /// </summary>
        public const string DTIVD = "DTIVD";

        /// <summary>
        /// DTIQTY.
        /// </summary>
        public const string DTIQTY = "DTIQTY";

        /// <summary>
        /// DTITOL.
        /// </summary>
        public const string DTITOL = "DTITOL";

        /// <summary>
        /// DTDLDT.
        /// </summary>
        public const string DTDLDT = "DTDLDT";

        /// <summary>
        /// DTDAQO.
        /// </summary>
        public const string DTDAQO = "DTDAQO";

        /// <summary>
        /// DTDAQE.
        /// </summary>
        public const string DTDAQE = "DTDAQE";

        /// <summary>
        /// DTDAQL.
        /// </summary>
        public const string DTDAQL = "DTDAQL";

        /// <summary>
        /// DTDAAO.
        /// </summary>
        public const string DTDAAO = "DTDAAO";

        /// <summary>
        /// DTDAAE.
        /// </summary>
        public const string DTDAAE = "DTDAAE";

        /// <summary>
        /// DTDAAL.
        /// </summary>
        public const string DTDAAL = "DTDAAL";

        /// <summary>
        /// DTRAQO.
        /// </summary>
        public const string DTRAQO = "DTRAQO";

        /// <summary>
        /// DTRAQE.
        /// </summary>
        public const string DTRAQE = "DTRAQE";

        /// <summary>
        /// DTRAQL.
        /// </summary>
        public const string DTRAQL = "DTRAQL";

        /// <summary>
        /// DTRAQC.
        /// </summary>
        public const string DTRAQC = "DTRAQC";

        /// <summary>
        /// DTPRSU.
        /// </summary>
        public const string DTPRSU = "DTPRSU";

        /// <summary>
        /// DTDAF1.
        /// </summary>
        public const string DTDAF1 = "DTDAF1";

        /// <summary>
        /// DTDAF2.
        /// </summary>
        public const string DTDAF2 = "DTDAF2";

        /// <summary>
        /// DTDAF3.
        /// </summary>
        public const string DTDAF3 = "DTDAF3";

        /// <summary>
        /// DTURCD.
        /// </summary>
        public const string DTURCD = "DTURCD";

        /// <summary>
        /// DTURDT.
        /// </summary>
        public const string DTURDT = "DTURDT";

        /// <summary>
        /// DTURAT.
        /// </summary>
        public const string DTURAT = "DTURAT";

        /// <summary>
        /// DTURAB.
        /// </summary>
        public const string DTURAB = "DTURAB";

        /// <summary>
        /// DTURRF.
        /// </summary>
        public const string DTURRF = "DTURRF";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTTDAY.
        /// </summary>
        public const string DTTDAY = "DTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4211DT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDOCO", "DTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DTDCTO", "DTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DTKCOO", "DTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTLNTY", "DTLNTY", JdeDataType.String, 4),
        new JdeField("DTMCU", "DTMCU", JdeDataType.String, 24),
        new JdeField("DTAN8", "DTAN8", JdeDataType.Numeric),
        new JdeField("DTSHAN", "DTSHAN", JdeDataType.Numeric),
        new JdeField("DTVR01", "DTVR01", JdeDataType.String, 50),
        new JdeField("DTCMC1", "DTCMC1", JdeDataType.Numeric),
        new JdeField("DTCMC2", "DTCMC2", JdeDataType.Numeric),
        new JdeField("DTITM", "DTITM", JdeDataType.Numeric),
        new JdeField("DTLITM", "DTLITM", JdeDataType.String, 50),
        new JdeField("DTAITM", "DTAITM", JdeDataType.String, 50),
        new JdeField("DTLOTN", "DTLOTN", JdeDataType.String, 60),
        new JdeField("DTUOM1", "DTUOM1", JdeDataType.String, 4),
        new JdeField("DTTRDJ", "DTTRDJ", JdeDataType.Numeric),
        new JdeField("DTPQOR", "DTPQOR", JdeDataType.Numeric),
        new JdeField("DTAEXP", "DTAEXP", JdeDataType.Numeric),
        new JdeField("DTDRQJ", "DTDRQJ", JdeDataType.Numeric),
        new JdeField("DTODRJ", "DTODRJ", JdeDataType.Numeric),
        new JdeField("DTRSDJ", "DTRSDJ", JdeDataType.Numeric),
        new JdeField("DTOPDJ", "DTOPDJ", JdeDataType.Numeric),
        new JdeField("DTPDDJ", "DTPDDJ", JdeDataType.Numeric),
        new JdeField("DTADDJ", "DTADDJ", JdeDataType.Numeric),
        new JdeField("DTSOQS", "DTSOQS", JdeDataType.Numeric),
        new JdeField("DTSHAE", "DTSHAE", JdeDataType.Numeric),
        new JdeField("DTCNDJ", "DTCNDJ", JdeDataType.Numeric),
        new JdeField("DTSOCN", "DTSOCN", JdeDataType.Numeric),
        new JdeField("DTCNAE", "DTCNAE", JdeDataType.Numeric),
        new JdeField("DTIVD", "DTIVD", JdeDataType.Numeric),
        new JdeField("DTIQTY", "DTIQTY", JdeDataType.Numeric),
        new JdeField("DTITOL", "DTITOL", JdeDataType.Numeric),
        new JdeField("DTDLDT", "DTDLDT", JdeDataType.Numeric),
        new JdeField("DTDAQO", "DTDAQO", JdeDataType.Numeric),
        new JdeField("DTDAQE", "DTDAQE", JdeDataType.Numeric),
        new JdeField("DTDAQL", "DTDAQL", JdeDataType.Numeric),
        new JdeField("DTDAAO", "DTDAAO", JdeDataType.Numeric),
        new JdeField("DTDAAE", "DTDAAE", JdeDataType.Numeric),
        new JdeField("DTDAAL", "DTDAAL", JdeDataType.Numeric),
        new JdeField("DTRAQO", "DTRAQO", JdeDataType.Numeric),
        new JdeField("DTRAQE", "DTRAQE", JdeDataType.Numeric),
        new JdeField("DTRAQL", "DTRAQL", JdeDataType.Numeric),
        new JdeField("DTRAQC", "DTRAQC", JdeDataType.Numeric),
        new JdeField("DTPRSU", "DTPRSU", JdeDataType.String, 2),
        new JdeField("DTDAF1", "DTDAF1", JdeDataType.String, 50),
        new JdeField("DTDAF2", "DTDAF2", JdeDataType.Numeric),
        new JdeField("DTDAF3", "DTDAF3", JdeDataType.Numeric),
        new JdeField("DTURCD", "DTURCD", JdeDataType.String, 4),
        new JdeField("DTURDT", "DTURDT", JdeDataType.Numeric),
        new JdeField("DTURAT", "DTURAT", JdeDataType.Numeric),
        new JdeField("DTURAB", "DTURAB", JdeDataType.Numeric),
        new JdeField("DTURRF", "DTURRF", JdeDataType.String, 30),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTTDAY", "DTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211DT_0", "Primary Key on DTDOCO, DTDCTO, DTKCOO, DTLNID", new[] { "DTDOCO", "DTDCTO", "DTKCOO", "DTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
