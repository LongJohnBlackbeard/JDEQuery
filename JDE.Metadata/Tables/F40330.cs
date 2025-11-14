using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40330 - .
/// </summary>
public class F40330 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DGAN8.
        /// </summary>
        public const string DGAN8 = "DGAN8";

        /// <summary>
        /// DGCS30.
        /// </summary>
        public const string DGCS30 = "DGCS30";

        /// <summary>
        /// DGITM.
        /// </summary>
        public const string DGITM = "DGITM";

        /// <summary>
        /// DGIT80.
        /// </summary>
        public const string DGIT80 = "DGIT80";

        /// <summary>
        /// DGEFTJ.
        /// </summary>
        public const string DGEFTJ = "DGEFTJ";

        /// <summary>
        /// DGEXDJ.
        /// </summary>
        public const string DGEXDJ = "DGEXDJ";

        /// <summary>
        /// DGMNQ.
        /// </summary>
        public const string DGMNQ = "DGMNQ";

        /// <summary>
        /// DGMXQ.
        /// </summary>
        public const string DGMXQ = "DGMXQ";

        /// <summary>
        /// DGUOM.
        /// </summary>
        public const string DGUOM = "DGUOM";

        /// <summary>
        /// DGTXID.
        /// </summary>
        public const string DGTXID = "DGTXID";

        /// <summary>
        /// DGSTPR.
        /// </summary>
        public const string DGSTPR = "DGSTPR";

        /// <summary>
        /// DGOSEQ.
        /// </summary>
        public const string DGOSEQ = "DGOSEQ";

        /// <summary>
        /// DGMCU.
        /// </summary>
        public const string DGMCU = "DGMCU";

        /// <summary>
        /// DGMOT.
        /// </summary>
        public const string DGMOT = "DGMOT";

        /// <summary>
        /// DGCARS.
        /// </summary>
        public const string DGCARS = "DGCARS";

        /// <summary>
        /// DGDCTO.
        /// </summary>
        public const string DGDCTO = "DGDCTO";

        /// <summary>
        /// DGLNTY.
        /// </summary>
        public const string DGLNTY = "DGLNTY";

        /// <summary>
        /// DGLDTY.
        /// </summary>
        public const string DGLDTY = "DGLDTY";

        /// <summary>
        /// DGBPFG.
        /// </summary>
        public const string DGBPFG = "DGBPFG";

        /// <summary>
        /// DGRYIN.
        /// </summary>
        public const string DGRYIN = "DGRYIN";

        /// <summary>
        /// DGDSET.
        /// </summary>
        public const string DGDSET = "DGDSET";

        /// <summary>
        /// DGURCD.
        /// </summary>
        public const string DGURCD = "DGURCD";

        /// <summary>
        /// DGURDT.
        /// </summary>
        public const string DGURDT = "DGURDT";

        /// <summary>
        /// DGURAT.
        /// </summary>
        public const string DGURAT = "DGURAT";

        /// <summary>
        /// DGURAB.
        /// </summary>
        public const string DGURAB = "DGURAB";

        /// <summary>
        /// DGURRF.
        /// </summary>
        public const string DGURRF = "DGURRF";

        /// <summary>
        /// DGUSER.
        /// </summary>
        public const string DGUSER = "DGUSER";

        /// <summary>
        /// DGPID.
        /// </summary>
        public const string DGPID = "DGPID";

        /// <summary>
        /// DGJOBN.
        /// </summary>
        public const string DGJOBN = "DGJOBN";

        /// <summary>
        /// DGUPMJ.
        /// </summary>
        public const string DGUPMJ = "DGUPMJ";

        /// <summary>
        /// DGTDAY.
        /// </summary>
        public const string DGTDAY = "DGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40330";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DGAN8", "DGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DGCS30", "DGCS30", JdeDataType.String, 16, true, true),
        new JdeField("DGITM", "DGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DGIT80", "DGIT80", JdeDataType.String, 16, true, true),
        new JdeField("DGEFTJ", "DGEFTJ", JdeDataType.Numeric),
        new JdeField("DGEXDJ", "DGEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DGMNQ", "DGMNQ", JdeDataType.Numeric),
        new JdeField("DGMXQ", "DGMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DGUOM", "DGUOM", JdeDataType.String, 4, true, true),
        new JdeField("DGTXID", "DGTXID", JdeDataType.Numeric),
        new JdeField("DGSTPR", "DGSTPR", JdeDataType.String, 2),
        new JdeField("DGOSEQ", "DGOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DGMCU", "DGMCU", JdeDataType.String, 24),
        new JdeField("DGMOT", "DGMOT", JdeDataType.String, 6),
        new JdeField("DGCARS", "DGCARS", JdeDataType.Numeric),
        new JdeField("DGDCTO", "DGDCTO", JdeDataType.String, 4),
        new JdeField("DGLNTY", "DGLNTY", JdeDataType.String, 4),
        new JdeField("DGLDTY", "DGLDTY", JdeDataType.String, 4),
        new JdeField("DGBPFG", "DGBPFG", JdeDataType.String, 2),
        new JdeField("DGRYIN", "DGRYIN", JdeDataType.String, 2),
        new JdeField("DGDSET", "DGDSET", JdeDataType.String, 6),
        new JdeField("DGURCD", "DGURCD", JdeDataType.String, 4),
        new JdeField("DGURDT", "DGURDT", JdeDataType.Numeric),
        new JdeField("DGURAT", "DGURAT", JdeDataType.Numeric),
        new JdeField("DGURAB", "DGURAB", JdeDataType.Numeric),
        new JdeField("DGURRF", "DGURRF", JdeDataType.String, 30),
        new JdeField("DGUSER", "DGUSER", JdeDataType.String, 20),
        new JdeField("DGPID", "DGPID", JdeDataType.String, 20),
        new JdeField("DGJOBN", "DGJOBN", JdeDataType.String, 20),
        new JdeField("DGUPMJ", "DGUPMJ", JdeDataType.Numeric),
        new JdeField("DGTDAY", "DGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40330_0", "Primary Key on DGAN8, DGCS30, DGITM, DGIT80, DGEXDJ, DGUOM, DGMXQ, DGOSEQ", new[] { "DGAN8", "DGCS30", "DGITM", "DGIT80", "DGEXDJ", "DGUOM", "DGMXQ", "DGOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
