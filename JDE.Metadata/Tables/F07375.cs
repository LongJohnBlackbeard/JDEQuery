using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07375 - .
/// </summary>
public class F07375 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDPAYD.
        /// </summary>
        public const string JDPAYD = "JDPAYD";

        /// <summary>
        /// JDAN8.
        /// </summary>
        public const string JDAN8 = "JDAN8";

        /// <summary>
        /// JDCKCN.
        /// </summary>
        public const string JDCKCN = "JDCKCN";

        /// <summary>
        /// JDDWK.
        /// </summary>
        public const string JDDWK = "JDDWK";

        /// <summary>
        /// JDPRTR.
        /// </summary>
        public const string JDPRTR = "JDPRTR";

        /// <summary>
        /// JDPDBA.
        /// </summary>
        public const string JDPDBA = "JDPDBA";

        /// <summary>
        /// JDGH01.
        /// </summary>
        public const string JDGH01 = "JDGH01";

        /// <summary>
        /// JDGH02.
        /// </summary>
        public const string JDGH02 = "JDGH02";

        /// <summary>
        /// JDGH03.
        /// </summary>
        public const string JDGH03 = "JDGH03";

        /// <summary>
        /// JDGH04.
        /// </summary>
        public const string JDGH04 = "JDGH04";

        /// <summary>
        /// JDGH05.
        /// </summary>
        public const string JDGH05 = "JDGH05";

        /// <summary>
        /// JDP001.
        /// </summary>
        public const string JDP001 = "JDP001";

        /// <summary>
        /// JDWST.
        /// </summary>
        public const string JDWST = "JDWST";

        /// <summary>
        /// JDWCNT.
        /// </summary>
        public const string JDWCNT = "JDWCNT";

        /// <summary>
        /// JDWCTY.
        /// </summary>
        public const string JDWCTY = "JDWCTY";

        /// <summary>
        /// JDMCUG.
        /// </summary>
        public const string JDMCUG = "JDMCUG";

        /// <summary>
        /// JDPID.
        /// </summary>
        public const string JDPID = "JDPID";

        /// <summary>
        /// JDUSER.
        /// </summary>
        public const string JDUSER = "JDUSER";

        /// <summary>
        /// JDJOBN.
        /// </summary>
        public const string JDJOBN = "JDJOBN";

        /// <summary>
        /// JDUPMJ.
        /// </summary>
        public const string JDUPMJ = "JDUPMJ";

        /// <summary>
        /// JDUPMT.
        /// </summary>
        public const string JDUPMT = "JDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07375";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDPAYD", "JDPAYD", JdeDataType.String, 20, true, true),
        new JdeField("JDAN8", "JDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JDCKCN", "JDCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("JDDWK", "JDDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("JDPRTR", "JDPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("JDPDBA", "JDPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JDGH01", "JDGH01", JdeDataType.Numeric),
        new JdeField("JDGH02", "JDGH02", JdeDataType.Numeric),
        new JdeField("JDGH03", "JDGH03", JdeDataType.Numeric),
        new JdeField("JDGH04", "JDGH04", JdeDataType.Numeric),
        new JdeField("JDGH05", "JDGH05", JdeDataType.Numeric),
        new JdeField("JDP001", "JDP001", JdeDataType.String, 6),
        new JdeField("JDWST", "JDWST", JdeDataType.Numeric),
        new JdeField("JDWCNT", "JDWCNT", JdeDataType.Numeric),
        new JdeField("JDWCTY", "JDWCTY", JdeDataType.Numeric),
        new JdeField("JDMCUG", "JDMCUG", JdeDataType.String, 24),
        new JdeField("JDPID", "JDPID", JdeDataType.String, 20),
        new JdeField("JDUSER", "JDUSER", JdeDataType.String, 20),
        new JdeField("JDJOBN", "JDJOBN", JdeDataType.String, 20),
        new JdeField("JDUPMJ", "JDUPMJ", JdeDataType.Numeric),
        new JdeField("JDUPMT", "JDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07375_0", "Primary Key on JDPAYD, JDAN8, JDCKCN, JDDWK, JDPRTR, JDPDBA", new[] { "JDPAYD", "JDAN8", "JDCKCN", "JDDWK", "JDPRTR", "JDPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07375_2", "Index on JDPAYD, JDAN8, JDCKCN, JDPDBA", new[] { "JDPAYD", "JDAN8", "JDCKCN", "JDPDBA" })
    };
}
