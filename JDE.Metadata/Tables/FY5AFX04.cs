using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX04 - .
/// </summary>
public class FY5AFX04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIMNI.
        /// </summary>
        public const string DIMNI = "DIMNI";

        /// <summary>
        /// DISELN.
        /// </summary>
        public const string DISELN = "DISELN";

        /// <summary>
        /// DIPTHT.
        /// </summary>
        public const string DIPTHT = "DIPTHT";

        /// <summary>
        /// DIPTH.
        /// </summary>
        public const string DIPTH = "DIPTH";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIMNI", "DIMNI", JdeDataType.String, 20, true, true),
        new JdeField("DISELN", "DISELN", JdeDataType.Numeric, null, true, true),
        new JdeField("DIPTHT", "DIPTHT", JdeDataType.String, 2, true, true),
        new JdeField("DIPTH", "DIPTH", JdeDataType.String, 240),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DISY", "DISY", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX04_0", "Primary Key on DIMNI, DISELN, DIPTHT", new[] { "DIMNI", "DISELN", "DIPTHT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX04_2", "Index on DIMNI, DIPTHT, DISELN", new[] { "DIMNI", "DIPTHT", "DISELN" }),
        new JdeIndex("FY5AFX04_3", "Index on DIPTHT, DIPTH, DIMNI", new[] { "DIPTHT", "DIPTH", "DIMNI" }),
        new JdeIndex("FY5AFX04_4", "Index on DISY", new[] { "DISY" })
    };
}
