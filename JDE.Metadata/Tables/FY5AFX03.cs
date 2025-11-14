using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX03 - .
/// </summary>
public class FY5AFX03 : JdeTable
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
        /// DILNGP.
        /// </summary>
        public const string DILNGP = "DILNGP";

        /// <summary>
        /// DIMNTX.
        /// </summary>
        public const string DIMNTX = "DIMNTX";

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
    public override string TableName => "FY5AFX03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIMNI", "DIMNI", JdeDataType.String, 20, true, true),
        new JdeField("DISELN", "DISELN", JdeDataType.Numeric, null, true, true),
        new JdeField("DILNGP", "DILNGP", JdeDataType.String, 4, true, true),
        new JdeField("DIMNTX", "DIMNTX", JdeDataType.String, 80),
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
        new JdeIndex("FY5AFX03_0", "Primary Key on DIMNI, DISELN, DILNGP", new[] { "DIMNI", "DISELN", "DILNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX03_2", "Unique Index on DIMNI, DILNGP, DISELN", new[] { "DIMNI", "DILNGP", "DISELN" }, isUnique: true),
        new JdeIndex("FY5AFX03_3", "Index on DISY", new[] { "DISY" })
    };
}
