using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4974 - .
/// </summary>
public class F4974 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWCARS.
        /// </summary>
        public const string RWCARS = "RWCARS";

        /// <summary>
        /// RWRTNM.
        /// </summary>
        public const string RWRTNM = "RWRTNM";

        /// <summary>
        /// RWRTAF.
        /// </summary>
        public const string RWRTAF = "RWRTAF";

        /// <summary>
        /// RWUSDC.
        /// </summary>
        public const string RWUSDC = "RWUSDC";

        /// <summary>
        /// RWDSAP.
        /// </summary>
        public const string RWDSAP = "RWDSAP";

        /// <summary>
        /// RWWD01.
        /// </summary>
        public const string RWWD01 = "RWWD01";

        /// <summary>
        /// RWWD02.
        /// </summary>
        public const string RWWD02 = "RWWD02";

        /// <summary>
        /// RWWD03.
        /// </summary>
        public const string RWWD03 = "RWWD03";

        /// <summary>
        /// RWWD04.
        /// </summary>
        public const string RWWD04 = "RWWD04";

        /// <summary>
        /// RWWD05.
        /// </summary>
        public const string RWWD05 = "RWWD05";

        /// <summary>
        /// RWWD06.
        /// </summary>
        public const string RWWD06 = "RWWD06";

        /// <summary>
        /// RWWD07.
        /// </summary>
        public const string RWWD07 = "RWWD07";

        /// <summary>
        /// RWWD08.
        /// </summary>
        public const string RWWD08 = "RWWD08";

        /// <summary>
        /// RWWD09.
        /// </summary>
        public const string RWWD09 = "RWWD09";

        /// <summary>
        /// RWWD10.
        /// </summary>
        public const string RWWD10 = "RWWD10";

        /// <summary>
        /// RWWD11.
        /// </summary>
        public const string RWWD11 = "RWWD11";

        /// <summary>
        /// RWMCDC.
        /// </summary>
        public const string RWMCDC = "RWMCDC";

        /// <summary>
        /// RWMCFU.
        /// </summary>
        public const string RWMCFU = "RWMCFU";

        /// <summary>
        /// RWLTLS.
        /// </summary>
        public const string RWLTLS = "RWLTLS";

        /// <summary>
        /// RWTLSE.
        /// </summary>
        public const string RWTLSE = "RWTLSE";

        /// <summary>
        /// RWSUAP.
        /// </summary>
        public const string RWSUAP = "RWSUAP";

        /// <summary>
        /// RWAFWE.
        /// </summary>
        public const string RWAFWE = "RWAFWE";

        /// <summary>
        /// RWEFTJ.
        /// </summary>
        public const string RWEFTJ = "RWEFTJ";

        /// <summary>
        /// RWEXDJ.
        /// </summary>
        public const string RWEXDJ = "RWEXDJ";

        /// <summary>
        /// RWURCD.
        /// </summary>
        public const string RWURCD = "RWURCD";

        /// <summary>
        /// RWURDT.
        /// </summary>
        public const string RWURDT = "RWURDT";

        /// <summary>
        /// RWURAT.
        /// </summary>
        public const string RWURAT = "RWURAT";

        /// <summary>
        /// RWURAB.
        /// </summary>
        public const string RWURAB = "RWURAB";

        /// <summary>
        /// RWURRF.
        /// </summary>
        public const string RWURRF = "RWURRF";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";

        /// <summary>
        /// RWJOBN.
        /// </summary>
        public const string RWJOBN = "RWJOBN";

        /// <summary>
        /// RWTDAY.
        /// </summary>
        public const string RWTDAY = "RWTDAY";

        /// <summary>
        /// RWUTIME.
        /// </summary>
        public const string RWUTIME = "RWUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4974";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWCARS", "RWCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("RWRTNM", "RWRTNM", JdeDataType.String, 20, true, true),
        new JdeField("RWRTAF", "RWRTAF", JdeDataType.Numeric),
        new JdeField("RWUSDC", "RWUSDC", JdeDataType.String, 2),
        new JdeField("RWDSAP", "RWDSAP", JdeDataType.String, 2),
        new JdeField("RWWD01", "RWWD01", JdeDataType.Numeric),
        new JdeField("RWWD02", "RWWD02", JdeDataType.Numeric),
        new JdeField("RWWD03", "RWWD03", JdeDataType.Numeric),
        new JdeField("RWWD04", "RWWD04", JdeDataType.Numeric),
        new JdeField("RWWD05", "RWWD05", JdeDataType.Numeric),
        new JdeField("RWWD06", "RWWD06", JdeDataType.Numeric),
        new JdeField("RWWD07", "RWWD07", JdeDataType.Numeric),
        new JdeField("RWWD08", "RWWD08", JdeDataType.Numeric),
        new JdeField("RWWD09", "RWWD09", JdeDataType.Numeric),
        new JdeField("RWWD10", "RWWD10", JdeDataType.Numeric),
        new JdeField("RWWD11", "RWWD11", JdeDataType.Numeric),
        new JdeField("RWMCDC", "RWMCDC", JdeDataType.Numeric),
        new JdeField("RWMCFU", "RWMCFU", JdeDataType.Numeric),
        new JdeField("RWLTLS", "RWLTLS", JdeDataType.Numeric),
        new JdeField("RWTLSE", "RWTLSE", JdeDataType.Numeric),
        new JdeField("RWSUAP", "RWSUAP", JdeDataType.String, 2),
        new JdeField("RWAFWE", "RWAFWE", JdeDataType.Numeric),
        new JdeField("RWEFTJ", "RWEFTJ", JdeDataType.Numeric),
        new JdeField("RWEXDJ", "RWEXDJ", JdeDataType.Numeric),
        new JdeField("RWURCD", "RWURCD", JdeDataType.String, 4),
        new JdeField("RWURDT", "RWURDT", JdeDataType.Numeric),
        new JdeField("RWURAT", "RWURAT", JdeDataType.Numeric),
        new JdeField("RWURAB", "RWURAB", JdeDataType.Numeric),
        new JdeField("RWURRF", "RWURRF", JdeDataType.String, 30),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20),
        new JdeField("RWJOBN", "RWJOBN", JdeDataType.String, 20),
        new JdeField("RWTDAY", "RWTDAY", JdeDataType.Numeric),
        new JdeField("RWUTIME", "RWUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4974_0", "Primary Key on RWCARS, RWRTNM", new[] { "RWCARS", "RWRTNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4974_2", "Index on RWRTNM, RWCARS", new[] { "RWRTNM", "RWCARS" })
    };
}
