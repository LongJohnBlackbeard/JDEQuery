using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AGX01 - .
/// </summary>
public class FY5AGX01 : JdeTable
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
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";

        /// <summary>
        /// DIXMN.
        /// </summary>
        public const string DIXMN = "DIXMN";

        /// <summary>
        /// DIOCMN.
        /// </summary>
        public const string DIOCMN = "DIOCMN";

        /// <summary>
        /// DILOD.
        /// </summary>
        public const string DILOD = "DILOD";

        /// <summary>
        /// DIDSST.
        /// </summary>
        public const string DIDSST = "DIDSST";

        /// <summary>
        /// DITXIC.
        /// </summary>
        public const string DITXIC = "DITXIC";

        /// <summary>
        /// DIMNUT.
        /// </summary>
        public const string DIMNUT = "DIMNUT";

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
        /// DIMSKA.
        /// </summary>
        public const string DIMSKA = "DIMSKA";

        /// <summary>
        /// DIMSKJ.
        /// </summary>
        public const string DIMSKJ = "DIMSKJ";

        /// <summary>
        /// DIMSKK.
        /// </summary>
        public const string DIMSKK = "DIMSKK";

        /// <summary>
        /// DIMSKD.
        /// </summary>
        public const string DIMSKD = "DIMSKD";

        /// <summary>
        /// DIMSKF.
        /// </summary>
        public const string DIMSKF = "DIMSKF";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AGX01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIMNI", "DIMNI", JdeDataType.String, 20, true, true),
        new JdeField("DISY", "DISY", JdeDataType.String, 8),
        new JdeField("DIXMN", "DIXMN", JdeDataType.String, 20),
        new JdeField("DIOCMN", "DIOCMN", JdeDataType.String, 20),
        new JdeField("DILOD", "DILOD", JdeDataType.String, 2),
        new JdeField("DIDSST", "DIDSST", JdeDataType.String, 2),
        new JdeField("DITXIC", "DITXIC", JdeDataType.String, 2),
        new JdeField("DIMNUT", "DIMNUT", JdeDataType.String, 2),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIMSKA", "DIMSKA", JdeDataType.String, 2),
        new JdeField("DIMSKJ", "DIMSKJ", JdeDataType.String, 2),
        new JdeField("DIMSKK", "DIMSKK", JdeDataType.String, 2),
        new JdeField("DIMSKD", "DIMSKD", JdeDataType.String, 4),
        new JdeField("DIMSKF", "DIMSKF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AGX01_0", "Primary Key on DIMNI", new[] { "DIMNI" }, isUnique: true, isPrimaryKey: true)
    };
}
