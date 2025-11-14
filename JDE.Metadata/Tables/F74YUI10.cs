using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74YUI10 - .
/// </summary>
public class F74YUI10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDJOBS.
        /// </summary>
        public const string CDJOBS = "CDJOBS";

        /// <summary>
        /// CDN001.
        /// </summary>
        public const string CDN001 = "CDN001";

        /// <summary>
        /// CDIITY.
        /// </summary>
        public const string CDIITY = "CDIITY";

        /// <summary>
        /// CDTAX.
        /// </summary>
        public const string CDTAX = "CDTAX";

        /// <summary>
        /// CDTX2.
        /// </summary>
        public const string CDTX2 = "CDTX2";

        /// <summary>
        /// CDY74C4001.
        /// </summary>
        public const string CDY74C4001 = "CDY74C4001";

        /// <summary>
        /// CDY74C4002.
        /// </summary>
        public const string CDY74C4002 = "CDY74C4002";

        /// <summary>
        /// CDY74C5001.
        /// </summary>
        public const string CDY74C5001 = "CDY74C5001";

        /// <summary>
        /// CDY74C6001.
        /// </summary>
        public const string CDY74C6001 = "CDY74C6001";

        /// <summary>
        /// CDY74C7001.
        /// </summary>
        public const string CDY74C7001 = "CDY74C7001";

        /// <summary>
        /// CDY74C8001.
        /// </summary>
        public const string CDY74C8001 = "CDY74C8001";

        /// <summary>
        /// CDY74C8002.
        /// </summary>
        public const string CDY74C8002 = "CDY74C8002";

        /// <summary>
        /// CDY74C9001.
        /// </summary>
        public const string CDY74C9001 = "CDY74C9001";

        /// <summary>
        /// CDY74C1001.
        /// </summary>
        public const string CDY74C1001 = "CDY74C1001";

        /// <summary>
        /// CDY74C1101.
        /// </summary>
        public const string CDY74C1101 = "CDY74C1101";

        /// <summary>
        /// CDMATH01.
        /// </summary>
        public const string CDMATH01 = "CDMATH01";

        /// <summary>
        /// CDMATH02.
        /// </summary>
        public const string CDMATH02 = "CDMATH02";

        /// <summary>
        /// CDGPBT.
        /// </summary>
        public const string CDGPBT = "CDGPBT";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDTDAY.
        /// </summary>
        public const string CDTDAY = "CDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F74YUI10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDJOBS", "CDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CDN001", "CDN001", JdeDataType.Numeric, null, true, true),
        new JdeField("CDIITY", "CDIITY", JdeDataType.String, 2),
        new JdeField("CDTAX", "CDTAX", JdeDataType.String, 40),
        new JdeField("CDTX2", "CDTX2", JdeDataType.String, 40),
        new JdeField("CDY74C4001", "CDY74C4001", JdeDataType.Numeric),
        new JdeField("CDY74C4002", "CDY74C4002", JdeDataType.Numeric),
        new JdeField("CDY74C5001", "CDY74C5001", JdeDataType.Numeric),
        new JdeField("CDY74C6001", "CDY74C6001", JdeDataType.Numeric),
        new JdeField("CDY74C7001", "CDY74C7001", JdeDataType.Numeric),
        new JdeField("CDY74C8001", "CDY74C8001", JdeDataType.Numeric),
        new JdeField("CDY74C8002", "CDY74C8002", JdeDataType.Numeric),
        new JdeField("CDY74C9001", "CDY74C9001", JdeDataType.Numeric),
        new JdeField("CDY74C1001", "CDY74C1001", JdeDataType.Numeric),
        new JdeField("CDY74C1101", "CDY74C1101", JdeDataType.Numeric),
        new JdeField("CDMATH01", "CDMATH01", JdeDataType.Numeric),
        new JdeField("CDMATH02", "CDMATH02", JdeDataType.Numeric),
        new JdeField("CDGPBT", "CDGPBT", JdeDataType.Numeric),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDTDAY", "CDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74YUI10_0", "Primary Key on CDJOBS, CDN001", new[] { "CDJOBS", "CDN001" }, isUnique: true, isPrimaryKey: true)
    };
}
