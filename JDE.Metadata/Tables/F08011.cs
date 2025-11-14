using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08011 - .
/// </summary>
public class F08011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JVEMET.
        /// </summary>
        public const string JVEMET = "JVEMET";

        /// <summary>
        /// JVEVTY.
        /// </summary>
        public const string JVEVTY = "JVEVTY";

        /// <summary>
        /// JVFNO.
        /// </summary>
        public const string JVFNO = "JVFNO";

        /// <summary>
        /// JVDL01.
        /// </summary>
        public const string JVDL01 = "JVDL01";

        /// <summary>
        /// JVEPNT.
        /// </summary>
        public const string JVEPNT = "JVEPNT";

        /// <summary>
        /// JVD010.
        /// </summary>
        public const string JVD010 = "JVD010";

        /// <summary>
        /// JVD009.
        /// </summary>
        public const string JVD009 = "JVD009";

        /// <summary>
        /// JVD008.
        /// </summary>
        public const string JVD008 = "JVD008";

        /// <summary>
        /// JVD007.
        /// </summary>
        public const string JVD007 = "JVD007";

        /// <summary>
        /// JVD006.
        /// </summary>
        public const string JVD006 = "JVD006";

        /// <summary>
        /// JVD005.
        /// </summary>
        public const string JVD005 = "JVD005";

        /// <summary>
        /// JVD004.
        /// </summary>
        public const string JVD004 = "JVD004";

        /// <summary>
        /// JVD003.
        /// </summary>
        public const string JVD003 = "JVD003";

        /// <summary>
        /// JVD002.
        /// </summary>
        public const string JVD002 = "JVD002";

        /// <summary>
        /// JVD001.
        /// </summary>
        public const string JVD001 = "JVD001";
    }

    /// <inheritdoc />
    public override string TableName => "F08011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JVEMET", "JVEMET", JdeDataType.String, 8, true, true),
        new JdeField("JVEVTY", "JVEVTY", JdeDataType.String, 2),
        new JdeField("JVFNO", "JVFNO", JdeDataType.Numeric, null, true, true),
        new JdeField("JVDL01", "JVDL01", JdeDataType.String, 60),
        new JdeField("JVEPNT", "JVEPNT", JdeDataType.Numeric),
        new JdeField("JVD010", "JVD010", JdeDataType.Numeric),
        new JdeField("JVD009", "JVD009", JdeDataType.Numeric),
        new JdeField("JVD008", "JVD008", JdeDataType.Numeric),
        new JdeField("JVD007", "JVD007", JdeDataType.Numeric),
        new JdeField("JVD006", "JVD006", JdeDataType.Numeric),
        new JdeField("JVD005", "JVD005", JdeDataType.Numeric),
        new JdeField("JVD004", "JVD004", JdeDataType.Numeric),
        new JdeField("JVD003", "JVD003", JdeDataType.Numeric),
        new JdeField("JVD002", "JVD002", JdeDataType.Numeric),
        new JdeField("JVD001", "JVD001", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08011_0", "Primary Key on JVEMET, JVFNO", new[] { "JVEMET", "JVFNO" }, isUnique: true, isPrimaryKey: true)
    };
}
