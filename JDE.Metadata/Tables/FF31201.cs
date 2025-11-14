using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31201 - .
/// </summary>
public class FF31201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRICU.
        /// </summary>
        public const string CRICU = "CRICU";

        /// <summary>
        /// CRDOC.
        /// </summary>
        public const string CRDOC = "CRDOC";

        /// <summary>
        /// CRPRODF31.
        /// </summary>
        public const string CRPRODF31 = "CRPRODF31";

        /// <summary>
        /// CRTRSID.
        /// </summary>
        public const string CRTRSID = "CRTRSID";

        /// <summary>
        /// CRICUT.
        /// </summary>
        public const string CRICUT = "CRICUT";

        /// <summary>
        /// CRDICJ.
        /// </summary>
        public const string CRDICJ = "CRDICJ";

        /// <summary>
        /// CRDGJ.
        /// </summary>
        public const string CRDGJ = "CRDGJ";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRSUMR.
        /// </summary>
        public const string CRSUMR = "CRSUMR";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";

        /// <summary>
        /// CRMKEY.
        /// </summary>
        public const string CRMKEY = "CRMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "FF31201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRICU", "CRICU", JdeDataType.Numeric),
        new JdeField("CRDOC", "CRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CRPRODF31", "CRPRODF31", JdeDataType.Numeric, null, true, true),
        new JdeField("CRTRSID", "CRTRSID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRICUT", "CRICUT", JdeDataType.String, 4, true, true),
        new JdeField("CRDICJ", "CRDICJ", JdeDataType.Numeric),
        new JdeField("CRDGJ", "CRDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20, true, true),
        new JdeField("CRSUMR", "CRSUMR", JdeDataType.String, 2),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric),
        new JdeField("CRMKEY", "CRMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31201_0", "Primary Key on CRICUT, CRUSER, CRPRODF31, CRTRSID, CRDOC, CRDGJ", new[] { "CRICUT", "CRUSER", "CRPRODF31", "CRTRSID", "CRDOC", "CRDGJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31201_3", "Index on CRICUT, CRUSER, CRICU, CRDICJ", new[] { "CRICUT", "CRUSER", "CRICU", "CRDICJ" })
    };
}
