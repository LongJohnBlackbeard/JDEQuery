using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1505 - .
/// </summary>
public class F1505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NDMCU.
        /// </summary>
        public const string NDMCU = "NDMCU";

        /// <summary>
        /// NDDOCO.
        /// </summary>
        public const string NDDOCO = "NDDOCO";

        /// <summary>
        /// NDBCI.
        /// </summary>
        public const string NDBCI = "NDBCI";

        /// <summary>
        /// NDGLC.
        /// </summary>
        public const string NDGLC = "NDGLC";

        /// <summary>
        /// NDFETY.
        /// </summary>
        public const string NDFETY = "NDFETY";

        /// <summary>
        /// NDEFTB.
        /// </summary>
        public const string NDEFTB = "NDEFTB";

        /// <summary>
        /// NDEFTE.
        /// </summary>
        public const string NDEFTE = "NDEFTE";

        /// <summary>
        /// NDFERT.
        /// </summary>
        public const string NDFERT = "NDFERT";

        /// <summary>
        /// NDFEBS.
        /// </summary>
        public const string NDFEBS = "NDFEBS";

        /// <summary>
        /// NDGLC3.
        /// </summary>
        public const string NDGLC3 = "NDGLC3";

        /// <summary>
        /// NDCO3.
        /// </summary>
        public const string NDCO3 = "NDCO3";

        /// <summary>
        /// NDAN83.
        /// </summary>
        public const string NDAN83 = "NDAN83";

        /// <summary>
        /// NDPTC3.
        /// </summary>
        public const string NDPTC3 = "NDPTC3";

        /// <summary>
        /// NDGLC4.
        /// </summary>
        public const string NDGLC4 = "NDGLC4";

        /// <summary>
        /// NDCO4.
        /// </summary>
        public const string NDCO4 = "NDCO4";

        /// <summary>
        /// NDAN84.
        /// </summary>
        public const string NDAN84 = "NDAN84";

        /// <summary>
        /// NDPTC4.
        /// </summary>
        public const string NDPTC4 = "NDPTC4";

        /// <summary>
        /// NDMCU2.
        /// </summary>
        public const string NDMCU2 = "NDMCU2";

        /// <summary>
        /// NDUNIT.
        /// </summary>
        public const string NDUNIT = "NDUNIT";

        /// <summary>
        /// NDPINV.
        /// </summary>
        public const string NDPINV = "NDPINV";

        /// <summary>
        /// NDDEAL.
        /// </summary>
        public const string NDDEAL = "NDDEAL";

        /// <summary>
        /// NDMIND.
        /// </summary>
        public const string NDMIND = "NDMIND";

        /// <summary>
        /// NDDMAX.
        /// </summary>
        public const string NDDMAX = "NDDMAX";

        /// <summary>
        /// NDBLFC.
        /// </summary>
        public const string NDBLFC = "NDBLFC";

        /// <summary>
        /// NDBF01.
        /// </summary>
        public const string NDBF01 = "NDBF01";

        /// <summary>
        /// NDBF02.
        /// </summary>
        public const string NDBF02 = "NDBF02";

        /// <summary>
        /// NDBF03.
        /// </summary>
        public const string NDBF03 = "NDBF03";

        /// <summary>
        /// NDBF04.
        /// </summary>
        public const string NDBF04 = "NDBF04";

        /// <summary>
        /// NDBF05.
        /// </summary>
        public const string NDBF05 = "NDBF05";

        /// <summary>
        /// NDBF06.
        /// </summary>
        public const string NDBF06 = "NDBF06";

        /// <summary>
        /// NDBF07.
        /// </summary>
        public const string NDBF07 = "NDBF07";

        /// <summary>
        /// NDBF08.
        /// </summary>
        public const string NDBF08 = "NDBF08";

        /// <summary>
        /// NDBF09.
        /// </summary>
        public const string NDBF09 = "NDBF09";

        /// <summary>
        /// NDBF10.
        /// </summary>
        public const string NDBF10 = "NDBF10";

        /// <summary>
        /// NDBF11.
        /// </summary>
        public const string NDBF11 = "NDBF11";

        /// <summary>
        /// NDBF12.
        /// </summary>
        public const string NDBF12 = "NDBF12";

        /// <summary>
        /// NDBF13.
        /// </summary>
        public const string NDBF13 = "NDBF13";

        /// <summary>
        /// NDGENM.
        /// </summary>
        public const string NDGENM = "NDGENM";

        /// <summary>
        /// NDAID4.
        /// </summary>
        public const string NDAID4 = "NDAID4";

        /// <summary>
        /// NDSBL4.
        /// </summary>
        public const string NDSBL4 = "NDSBL4";

        /// <summary>
        /// NDSBT4.
        /// </summary>
        public const string NDSBT4 = "NDSBT4";

        /// <summary>
        /// NDAID3.
        /// </summary>
        public const string NDAID3 = "NDAID3";

        /// <summary>
        /// NDSBL3.
        /// </summary>
        public const string NDSBL3 = "NDSBL3";

        /// <summary>
        /// NDSBT3.
        /// </summary>
        public const string NDSBT3 = "NDSBT3";

        /// <summary>
        /// NDUSER.
        /// </summary>
        public const string NDUSER = "NDUSER";

        /// <summary>
        /// NDUPMJ.
        /// </summary>
        public const string NDUPMJ = "NDUPMJ";

        /// <summary>
        /// NDPID.
        /// </summary>
        public const string NDPID = "NDPID";

        /// <summary>
        /// NDJOBN.
        /// </summary>
        public const string NDJOBN = "NDJOBN";

        /// <summary>
        /// NDUPMT.
        /// </summary>
        public const string NDUPMT = "NDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NDMCU", "NDMCU", JdeDataType.String, 24, true, true),
        new JdeField("NDDOCO", "NDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NDBCI", "NDBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NDGLC", "NDGLC", JdeDataType.String, 8),
        new JdeField("NDFETY", "NDFETY", JdeDataType.String, 6),
        new JdeField("NDEFTB", "NDEFTB", JdeDataType.Numeric),
        new JdeField("NDEFTE", "NDEFTE", JdeDataType.Numeric),
        new JdeField("NDFERT", "NDFERT", JdeDataType.Numeric),
        new JdeField("NDFEBS", "NDFEBS", JdeDataType.String, 2),
        new JdeField("NDGLC3", "NDGLC3", JdeDataType.String, 8),
        new JdeField("NDCO3", "NDCO3", JdeDataType.String, 10),
        new JdeField("NDAN83", "NDAN83", JdeDataType.Numeric),
        new JdeField("NDPTC3", "NDPTC3", JdeDataType.String, 6),
        new JdeField("NDGLC4", "NDGLC4", JdeDataType.String, 8),
        new JdeField("NDCO4", "NDCO4", JdeDataType.String, 10),
        new JdeField("NDAN84", "NDAN84", JdeDataType.Numeric),
        new JdeField("NDPTC4", "NDPTC4", JdeDataType.String, 6),
        new JdeField("NDMCU2", "NDMCU2", JdeDataType.String, 24),
        new JdeField("NDUNIT", "NDUNIT", JdeDataType.String, 16),
        new JdeField("NDPINV", "NDPINV", JdeDataType.String, 2),
        new JdeField("NDDEAL", "NDDEAL", JdeDataType.String, 16),
        new JdeField("NDMIND", "NDMIND", JdeDataType.Numeric),
        new JdeField("NDDMAX", "NDDMAX", JdeDataType.Numeric),
        new JdeField("NDBLFC", "NDBLFC", JdeDataType.String, 2),
        new JdeField("NDBF01", "NDBF01", JdeDataType.String, 2),
        new JdeField("NDBF02", "NDBF02", JdeDataType.String, 2),
        new JdeField("NDBF03", "NDBF03", JdeDataType.String, 2),
        new JdeField("NDBF04", "NDBF04", JdeDataType.String, 2),
        new JdeField("NDBF05", "NDBF05", JdeDataType.String, 2),
        new JdeField("NDBF06", "NDBF06", JdeDataType.String, 2),
        new JdeField("NDBF07", "NDBF07", JdeDataType.String, 2),
        new JdeField("NDBF08", "NDBF08", JdeDataType.String, 2),
        new JdeField("NDBF09", "NDBF09", JdeDataType.String, 2),
        new JdeField("NDBF10", "NDBF10", JdeDataType.String, 2),
        new JdeField("NDBF11", "NDBF11", JdeDataType.String, 2),
        new JdeField("NDBF12", "NDBF12", JdeDataType.String, 2),
        new JdeField("NDBF13", "NDBF13", JdeDataType.String, 2),
        new JdeField("NDGENM", "NDGENM", JdeDataType.String, 2),
        new JdeField("NDAID4", "NDAID4", JdeDataType.String, 16),
        new JdeField("NDSBL4", "NDSBL4", JdeDataType.String, 16),
        new JdeField("NDSBT4", "NDSBT4", JdeDataType.String, 2),
        new JdeField("NDAID3", "NDAID3", JdeDataType.String, 16),
        new JdeField("NDSBL3", "NDSBL3", JdeDataType.String, 16),
        new JdeField("NDSBT3", "NDSBT3", JdeDataType.String, 2),
        new JdeField("NDUSER", "NDUSER", JdeDataType.String, 20),
        new JdeField("NDUPMJ", "NDUPMJ", JdeDataType.Numeric),
        new JdeField("NDPID", "NDPID", JdeDataType.String, 20),
        new JdeField("NDJOBN", "NDJOBN", JdeDataType.String, 20),
        new JdeField("NDUPMT", "NDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1505_0", "Primary Key on NDMCU, NDDOCO, NDBCI", new[] { "NDMCU", "NDDOCO", "NDBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
