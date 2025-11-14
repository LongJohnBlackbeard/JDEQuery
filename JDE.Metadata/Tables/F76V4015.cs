using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4015 - .
/// </summary>
public class F76V4015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDKCO.
        /// </summary>
        public const string CDKCO = "CDKCO";

        /// <summary>
        /// CDDCT.
        /// </summary>
        public const string CDDCT = "CDDCT";

        /// <summary>
        /// CDDOC.
        /// </summary>
        public const string CDDOC = "CDDOC";

        /// <summary>
        /// CDOKCO.
        /// </summary>
        public const string CDOKCO = "CDOKCO";

        /// <summary>
        /// CDODCT.
        /// </summary>
        public const string CDODCT = "CDODCT";

        /// <summary>
        /// CDODOC.
        /// </summary>
        public const string CDODOC = "CDODOC";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

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
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDKCO", "CDKCO", JdeDataType.String, 10, true, true),
        new JdeField("CDDCT", "CDDCT", JdeDataType.String, 4, true, true),
        new JdeField("CDDOC", "CDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CDOKCO", "CDOKCO", JdeDataType.String, 10, true, true),
        new JdeField("CDODCT", "CDODCT", JdeDataType.String, 4, true, true),
        new JdeField("CDODOC", "CDODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4015_0", "Primary Key on CDKCO, CDDCT, CDDOC, CDOKCO, CDODCT, CDODOC", new[] { "CDKCO", "CDDCT", "CDDOC", "CDOKCO", "CDODCT", "CDODOC" }, isUnique: true, isPrimaryKey: true)
    };
}
